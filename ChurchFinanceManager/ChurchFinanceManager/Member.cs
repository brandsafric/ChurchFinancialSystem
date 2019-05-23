using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class Member
    {
        public int memberId;
        public string firstName;
        public string middleName;
        public string lastName;
        public DateTime birthday;
        public string city;
        public bool isRegular;

        public Member(int memberId, string firstName, string middleName, string lastName, DateTime birthday, string city, bool isRegular)
        {
           this.memberId = memberId;
           this.firstName = firstName;
           this.middleName = middleName;
           this.lastName = lastName;
           this.birthday = birthday;
           this.city = city;
           this.isRegular = isRegular;
        }

        public int GetAge() {
            int age = DateTime.Today.Year - birthday.Year;
            if (birthday.Date > DateTime.Today.AddYears(-age)) age--;
            return age;
        }

        public void Update(string firstName, string middleName, string lastName, string city, DateTime birthday, bool isRegular)
        {
            MembersController memberController = new MembersController();
            memberController.UpdateMember(memberId, firstName, middleName, lastName, city, birthday, isRegular);
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.city = city;
            this.isRegular = isRegular;
        }

        public void Delete()
        {
            MembersController memberController = new MembersController();
            memberController.DeleteMember(memberId);
        }
    }
}
