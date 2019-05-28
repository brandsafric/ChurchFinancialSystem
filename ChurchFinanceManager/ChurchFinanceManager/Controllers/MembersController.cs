using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchFinanceManager
{
    class MembersController : Controller<Member>
    {

        public MembersController()
        {
            tableName = "Members";
            idName = "memberId";
        }

        public List<Member> ShowAllMembersNotInFamily()
        {
            MembersFamiliesController mfc = new MembersFamiliesController();
            List<Member> members = new List<Member>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL,
                tableName, null, new QueryBuilder().
                Where(idName).NotIn(new QueryBuilder().
                Select(mfc.tableName,idName)
                ));
            if(dt.Rows.Count > 0)
                foreach(DataRow r in dt.Rows)
                {
                    members.Add(new Member(r));
                }
            return members;
        }
    }
}
