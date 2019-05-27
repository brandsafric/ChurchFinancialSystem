using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class Model
    {
        int id;
        public Model(DataRow r)
        {
            DatarowToModel(r);
        }
        public virtual void DatarowToModel(DataRow r)
        {

        }
    }
}
