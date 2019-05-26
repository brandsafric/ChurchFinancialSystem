using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class ServicesController : IController<Service>
    {
        private protected string tableName = "Services";
        private protected string idName = "serviceId";

        public void Add(params Param[] @params)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.CREATE, tableName, null, null, @params);
        }

        public void Delete(int id)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.DELETE, tableName, new Param(idName, id));
        }

        public Service GetLastAdded()
        {
            Service service = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null, new QueryBuilder().OrderBy(idName, false).Limit(1));
            if (dt.Rows.Count > 0)
                service = new Service(dt.Rows[0]);

            return service;
        }

        public Service Show(int id)
        {
            Service service = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            if (dt.Rows.Count > 0)
                service = new Service(dt.Rows[0]);

            return service;
        }

        public List<Service> ShowAll(params Param[] parameters)
        {
            List<Service> service = new List<Service>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    service.Add(new Service(r));
                }

            }

            return service;
        }

        public Service Update(int id, params Param[] @params)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.UPDATE, tableName, new Param(idName, id), null, @params);
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            Service service = null;
            if (dt.Rows.Count > 0)
                service = new Service(dt.Rows[0]);

            return service;
        }
    }
}
