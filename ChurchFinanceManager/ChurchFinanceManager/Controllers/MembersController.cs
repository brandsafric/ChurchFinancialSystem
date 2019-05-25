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
        
        public List<Member> ShowAll(params Param[] @params)
        {
            List<Member> members = new List<Member>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    members.Add(new Member(r));
                }

            }

            return members;
        }

        public Member Show(int id)
        {
            Member member = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE,tableName,new Param(idName,id));
            if (dt.Rows.Count > 0)
                member = new Member(dt.Rows[0]);
          
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
                member = new Member(dt.Rows[0]);

            return member;
        }

        public void Delete(int id)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.DELETE, tableName, new Param(idName, id));

        }


    }
}
