using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class UserRolesController : Controller<Role>
    {
        public UserRolesController()
        {
            tableName = "UserRoles";
        }

        public List<Role> ShowUsersRoles(User user)
        {
            List<Role> roles = new List<Role>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null,
                new QueryBuilder().Where("userId").EqualsTo("@userId"), new Param("userId", user.id));
            if (dt.Rows.Count == 0) return null;
            foreach(DataRow r in dt.Rows)
            {
                Role role = new Role(Convert.ToInt32(r["roleId"]));
                if (role == null) continue;

                roles.Add(role);

            }
            return roles;
        }

        public bool UserHaveRole(User user, Role role)
        {
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null,
                new QueryBuilder().Where("userId").EqualsTo("@userId").And("roleId").EqualsTo("@roleId"), 
                new Param("userId", user.id),
                new Param("roleId", role.id));
            if (dt.Rows.Count == 0) return false;
            return true;
        }

        public void DeleteRoleFromUser(Role role, User user)
        {
            FinanceDbManager.CustomQuery(new QueryBuilder().
                Delete(tableName).Where("roleId").EqualsTo("@roleId").
                And("userId").EqualsTo("@userId"),
                new Param("roleId",role.id),
                 new Param("userId", user.id)
                );
        }

        public void AddRoleRoleToUser(Role role, User user)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.CREATE, tableName, null, null,
                new Param("roleId", role.id),
            new Param("userId", user.id));
                
        }
    }
}
