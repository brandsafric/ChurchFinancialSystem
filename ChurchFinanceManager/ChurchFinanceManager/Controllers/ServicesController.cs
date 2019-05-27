using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class ServicesController : Controller<Service>
    {
        public ServicesController()
        {
            tableName = "Services";
            idName = "serviceId";
        }

    }
}
