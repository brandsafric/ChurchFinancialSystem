using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class Role : Model
    {
        public string title;
        public string  description;
        public string  tag;
        public bool isFullAccess;
        public Role(DataRow r)
        {
            this.title = r["title"].ToString();
            this.description = r["description"].ToString();
            this.tag = r["tag"].ToString();
            this.isFullAccess = Convert.ToBoolean(r["isFullAccess"]);

        }

        public Role(int roleId)
        {
            RolesController rc = new RolesController();
            Role role = rc.Show(roleId);
            this.title = role.title;
            this.description = role.description;
            this.tag = role.tag;
            this.isFullAccess = role.isFullAccess;
        }





    }
}
