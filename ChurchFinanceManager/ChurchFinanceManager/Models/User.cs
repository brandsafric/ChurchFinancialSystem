using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class User : Model
    {
        public string name;
        public bool isAdmin = false;
        public string username;
        public string password;
        public Session currentSession;
        public List<Role> roles = new List<Role>();
        public User(int id)
        {
            UsersController uc = new UsersController();
            User user = uc.Show(id);
            if (user == null)
            {
                Console.WriteLine("User was not found!");
                return;
            }

            this.id = user.id;
            this.name = user.name;
            this.isAdmin = user.isAdmin;
            this.username = user.username;
            this.password = user.password;
            this.roles = isAdmin ? new RolesController().ShowAll() : new UserRolesController().ShowUsersRoles(this);


        }
        public User(DataRow r)
        {
            id = Convert.ToInt32(r["userId"]);
            name = r["name"].ToString();
            isAdmin = Convert.ToBoolean(r["isAdmin"]);
            username = r["username"].ToString();
            password = FinanceDbManager.Decrypt(r["password"].ToString());
            this.roles = isAdmin ? new RolesController().ShowAll() : new UserRolesController().ShowUsersRoles(this);
        }

        public User(string name, string username, string password)
        {
            password = FinanceDbManager.Encrypt(password);
            UsersController uc = new UsersController();
            uc.Add(
                new Param("name", name),
               new Param("username", username),
               new Param("password", password)
               );
            User u = uc.GetLastAdded();
            this.id = u.id;
            this.name = u.name;
            this.username = u.username;
            this.password = u.password;
            this.isAdmin = u.isAdmin;

            this.roles = isAdmin ? new RolesController().ShowAll() : new UserRolesController().ShowUsersRoles(this);
        }

        public void Update(string name, string username, string password)
        {
            password = FinanceDbManager.Encrypt(password);
            UsersController uc = new UsersController();
            User u = uc.Update(this.id,
                new Param("name", name),
               new Param("username", username),
               new Param("password", password)
               );
            this.id = u.id;
            this.name = u.name;
            this.username = u.username;
            this.password = u.password;
            this.isAdmin = u.isAdmin;

            this.roles = isAdmin ? new RolesController().ShowAll() : new UserRolesController().ShowUsersRoles(this);
        }

        public void Delete()
        {

            UsersController uc = new UsersController();
            uc.Delete(id);
        }

        public bool haveRole(Role reuiredRole)
        {
            if (roles == null) return false;
            if (roles.Count > 0)
                foreach (Role role in roles)
                {
                    if (reuiredRole.id == role.id)
                        return true;
                }
            return false;
        }


    }
}
