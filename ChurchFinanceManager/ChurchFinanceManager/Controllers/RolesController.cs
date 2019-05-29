using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class RolesController : Controller<Role>
    {
        public RolesController()
        {
            tableName = "Roles";
            idName = "roleId";
        }
        //get role by tag
        public Role GetRoleByTag(string tag)
        {
            DataTable dt = FinanceDbManager.CustomQuery(new QueryBuilder()
                .SelectAll(tableName).Where("tag").EqualsTo("@tag"),
                new Param("tag", tag));
            if (dt.Rows.Count == 0) return null;
            return new Role(dt.Rows[0]);
        }
    }
}
