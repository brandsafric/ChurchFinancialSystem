using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    abstract class Controller : IController<Model>
    {
        private protected string tableName;
        private protected string idName;
        public void Add(params Param[] @params)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.CREATE, tableName, null, null, @params);
        }

        public void Delete(int id)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.DELETE, tableName, new Param(idName, id));
        }

        public Model GetLastAdded()
        {
            Model model = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null, new QueryBuilder().OrderBy(idName, false).Limit(1));
            if (dt.Rows.Count > 0)
                model = new Model(dt.Rows[0]);

            return model;
        }

        public Model Show(int id)
        {

            Model model = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            if (dt.Rows.Count > 0)
                model = new Model(dt.Rows[0]);

            return model;
        }

        public List<Model> ShowAll(params Param[] parameters)
        {
            List<Model> models = new List<Model>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    models.Add(new Model(r));
                }

            }

            return models;
        }

        public Model Update(int id, params Param[] @params)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.UPDATE, tableName, new Param(idName, id), null, @params);
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            Model model = null;
            if (dt.Rows.Count > 0)
                model = new Model(dt.Rows[0]);

            return model;
        }
    }
}
