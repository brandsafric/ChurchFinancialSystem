using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class UsersController : Controller<User>
    {
        public UsersController()
        {
            tableName = "Users";
            idName = "userId";
        }
        public bool UsernameExist(string username)
        {

            DataTable dt = FinanceDbManager.CustomQuery(new QueryBuilder().
                SelectAll(tableName).Where("username").EqualsTo("@username"),
                new Param("username", username));
            return (dt.Rows.Count > 0);
        }
        public bool IsDuplicateUsername(string desiredUsername, User currenUser)
        {
            DataTable dt = FinanceDbManager.CustomQuery(new QueryBuilder().
               SelectAll(tableName).Where("username").EqualsTo("@username")
               .And("userId").NotEqualsTo("@userId"),
               new Param("username", desiredUsername),
               new Param("userId", currenUser.id)
               );
            return (dt.Rows.Count > 0);
        }
        public User Show(string username)
        {
            DataTable dt = FinanceDbManager.CustomQuery(new QueryBuilder().
                SelectAll(tableName).Where("username").EqualsTo("@username"),
                new Param("username", username));
            if (dt.Rows.Count == 0) return null;

            return new User(dt.Rows[0]);
        }

        public override void Delete(int id)
        {
            User user = new User(id);
            if (user.isAdmin) return;
            base.Delete(id);
            
        }

        public bool IsCorrectCredentials(string username, string password)
        {
            User user = Show(username);
            if (user == null) return false;

            if(!user.password.Equals(password)) return false;

            return true;
        }
    }
}
