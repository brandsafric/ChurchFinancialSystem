using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class FamiliesController : Controller<Family>
    {
        public FamiliesController()
        {
            tableName = "Families";
            idName = "familyId";
        }

    }
}
