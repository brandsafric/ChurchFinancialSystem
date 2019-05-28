using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager { 
    class MembersFamiliesController : Controller<Member>
    {
        public MembersFamiliesController()
        {
            tableName = "MembersFamilies";
            idName = "membersFamiliesId";
        }

        public bool MemberFamilyExists(Member member,Family family)
        {
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null,
                new QueryBuilder().Where("memberId").EqualsTo(member.id).And("familyId").EqualsTo(family.id));
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public List<Member> ShowFamilyMembers(Family family)
        {
            MembersController mc = new MembersController();
            List<Member> members = new List<Member>();
            if (family == null) return members;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null,
                new QueryBuilder().Where("familyId").EqualsTo(family.id)
                );
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    members.Add(mc.Show((Convert.ToInt32(r["memberId"]))));
                }

            }

            return members;
        }
        public Family ShowMembersFamily(Member member)
        {
            FamiliesController fc = new FamiliesController();
            Family family = null;
            if (member == null) return null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null,
                new QueryBuilder().Where("memberId").EqualsTo(member.id)
                );
            if (dt.Rows.Count > 0)
            {
                family = fc.Show((int)dt.Rows[0]["familyId"]);
            }

            return family;
        }

        public void Delete(Member member, Family family)
        {
            Console.WriteLine(new QueryBuilder().
                Delete(tableName).Where("memberId").EqualsTo(member.id).And("familyId").EqualsTo(family.id).ToString());



            FinanceDbManager.CustomQuery(new QueryBuilder().
                Delete(tableName).Where("memberId").EqualsTo(member.id).And("familyId").EqualsTo(family.id)

                );
        }
    }
}

