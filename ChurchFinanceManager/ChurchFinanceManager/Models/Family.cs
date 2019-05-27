using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class Family 
    {
        public int familyId;
        public string familyName;
        public Family(string familyName)
        {
            MembersController mc = new MembersController();
            //mc.Add(
            //    new Param("firstName", firstName),
            //   new Param("middleName", middleName),
            //   new Param("lastName", lastName),
            //   new Param("city", city),
            //   new Param("birthday", birthday),
            //   new Param("isRegular", isRegular)
            //   );
            //Member m = mc.GetLastAdded();
            //this.memberId = m.memberId;
            //this.firstName = m.firstName;
            //this.middleName = m.middleName;
            //this.lastName = m.lastName;
            //this.birthday = m.birthday;
            //this.city = m.city;
            //this.isRegular = m.isRegular;
        }
        public Family(DataRow r)
        {
            //this.memberId = Convert.ToInt32(r["memberId"]);
            //this.firstName = r["firstName"].ToString();
            //this.middleName = r["middleName"].ToString();
            //this.lastName = r["lastName"].ToString();
            //this.birthday = Convert.ToDateTime(r["birthday"]).Date;
            //this.city = r["city"].ToString();
            //this.isRegular = Convert.ToBoolean(r["isRegular"]);

        }

        public void Update(string familyName)
        {
            //MembersController mc = new MembersController();

            //Member member = mc.Update(this.memberId,
            //   new Param("firstName", firstName),
            //  new Param("middleName", middleName),
            //  new Param("lastName", lastName),
            //  new Param("city", city),
            //  new Param("birthday", birthday),
            //  new Param("isRegular", isRegular)
            //  );
            //this.firstName = member.firstName;
            //this.lastName = member.lastName;
            //this.middleName = member.middleName;
            //this.city = member.city;
            //this.birthday = member.birthday;
            //this.isRegular = member.isRegular;
        }

        public void Delete()
        {
            //MembersController memberController = new MembersController();
            //memberController.Delete(memberId);
        }

    }
}
