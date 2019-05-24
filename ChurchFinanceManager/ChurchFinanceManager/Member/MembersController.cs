using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchFinanceManager
{
    class MembersController : IController<Member>
    {
        private protected string tableName = "Members";
        private protected string idName = "memberId";
        public List<Member> ViewMembers()
        {
            List<Member> members = new List<Member>();
            DataTable dt = FinanceDbManager.MemberQuery(FinanceDbManager.QueryMode.SELECT_ALL);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    members.Add(FinanceDbManager.DataRowToMember(r));
                }

            }

            return members;

        }

        public Member ViewMember(int memberId)
        {
            Member member = null;
            DataTable dt = FinanceDbManager.MemberQuery(FinanceDbManager.QueryMode.SELECT_ONE, memberId);
            if (dt.Rows.Count > 0)
            {
                member = FinanceDbManager.DataRowToMember(dt.Rows[0]);
            }

            return member;

        }

        public void AddMember(string firstName, string middleName, string lastName, string city, DateTime birthday, bool isRegular = true)
        {
            FinanceDbManager.MemberQuery(
                FinanceDbManager.QueryMode.CREATE, Int32.MinValue,
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
            FinanceDbManager.MemberQuery(FinanceDbManager.QueryMode.DELETE, memberId);
        }

        public List<Member> ShowAll()
        {
            List<Member> members = new List<Member>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    members.Add(FinanceDbManager.DataRowToMember(r));
                }

            }

            return members;
        }

        public Member Show(int id)
        {
            Member member = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE,tableName,new Param(idName,id));
            if (dt.Rows.Count > 0)
                member = FinanceDbManager.DataRowToMember(dt.Rows[0]);
          
            return member;
        }

        public void Add(params Param[] @params)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.CREATE, tableName, null, null, @params);
        }

        public Member Update(int id, params Param[] @params)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.UPDATE, tableName, new Param(idName,id), null, @params);
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            Member member = null;
            if (dt.Rows.Count > 0)
                member = FinanceDbManager.DataRowToMember(dt.Rows[0]);

            return member;
        }

        public void Delete(int id)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.DELETE, tableName, new Param(idName, id));

        }


    }
}
