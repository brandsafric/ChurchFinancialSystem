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
    }
}
