using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class Member : Model
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public DateTime birthday;
        public string city;
        public bool isRegular;

        public Member(string firstName, string middleName, string lastName, DateTime birthday, string city, bool isRegular)
        {
            MembersController mc = new MembersController();
            mc.Add(
                new Param("firstName", firstName),
               new Param("middleName", middleName),
               new Param("lastName", lastName),
               new Param("city", city),
               new Param("birthday", birthday),
               new Param("isRegular", isRegular)
               );
            Member m = mc.GetLastAdded();
            this.id = m.id;
           this.firstName = m.firstName;
           this.middleName = m.middleName;
           this.lastName = m.lastName;
           this.birthday = m.birthday;
           this.city = m.city;
           this.isRegular = m.isRegular;
        }
        public Member(DataRow r)
        {
            this.id = Convert.ToInt32(r["memberId"]);
            this.firstName = r["firstName"].ToString();
            this.middleName = r["middleName"].ToString();
            this.lastName = r["lastName"].ToString();
            this.birthday = Convert.ToDateTime(r["birthday"]).Date;
            this.city = r["city"].ToString();
            this.isRegular = Convert.ToBoolean(r["isRegular"]);

        }

        public Member(int memberId, string firstName, string middleName, string lastName, DateTime birthday, string city, bool isRegular)
        {
            this.id = memberId;
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

        public void Update(string firstName, string middleName, string lastName,  DateTime birthday, string city, bool isRegular)
        {
            MembersController mc = new MembersController();
            
            Member member = mc.Update(this.id,
               new Param("firstName", firstName),
              new Param("middleName", middleName),
              new Param("lastName", lastName),
              new Param("city", city),
              new Param("birthday", birthday),
              new Param("isRegular", isRegular)
              );
            this.firstName = member.firstName;
            this.lastName = member.lastName;
            this.middleName = member.middleName;
            this.city = member.city;
            this.birthday = member.birthday;
            this.isRegular = member.isRegular;
        }

        public void Delete()
        {
            MembersController memberController = new MembersController();
            memberController.Delete(id);
        }

        public string FullName() {
            string fName = "";
            fName += firstName + " ";
            if (!String.IsNullOrEmpty(middleName))
                fName += middleName[0] + ". ";
            fName += lastName;
            return fName;
        }

        public Family Family()
        {
            MembersFamiliesController mfc = new MembersFamiliesController();
            return mfc.ShowMembersFamily(this);
        }
    }
}
