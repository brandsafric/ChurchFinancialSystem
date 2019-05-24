using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchFinanceManager
{
    class MembersController
    {
        public List<Member> ViewMembers()
        {
            List<Member> members = new List<Member>();
            DataTable dt = FinanceDbManager.MemberQuery(FinanceDbManager.QueryMode.SELECT_ALL);
            if (dt.Rows.Count > 0) {
                foreach (DataRow r in dt.Rows) {
                    members.Add(FinanceDbManager.DataRowToMember(r));
                }

            }
          
            return members;

        }

        public Member ViewMember(int memberId)
        {
            Member member = null;
            DataTable dt = FinanceDbManager.MemberQuery(FinanceDbManager.QueryMode.SELECT_ONE,memberId);
            if (dt.Rows.Count > 0)
            {
                    member = FinanceDbManager.DataRowToMember(dt.Rows[0]);
            }

            return member;

        }

        public void AddMember(string firstName, string middleName, string lastName, string city, DateTime birthday, bool isRegular = true)
        {
            FinanceDbManager.MemberQuery(
                FinanceDbManager.QueryMode.CREATE,Int32.MinValue,
                firstName,
                middleName,
                lastName,
                city,
                birthday,
                isRegular);

        }
        public void UpdateMember(int memberId, string firstName, string middleName, string lastName, string city, DateTime birthday, bool isRegular = true)
        {
            FinanceDbManager.MemberQuery(
                FinanceDbManager.QueryMode.UPDATE, 
                memberId,
                firstName,
                middleName,
                lastName,
                city,
                birthday,
                isRegular);

        }

        public void DeleteMember(int memberId)
        {
            FinanceDbManager.MemberQuery(FinanceDbManager.QueryMode.DELETE,memberId);
        }
    }
}
