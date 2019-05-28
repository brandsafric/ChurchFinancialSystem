using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class FamiliesController : Controller<Family>
    {
        MembersFamiliesController mfc = new MembersFamiliesController();
        public FamiliesController()
        {
            tableName = "Families";
            idName = "familyId";
        }

       

    }
}
