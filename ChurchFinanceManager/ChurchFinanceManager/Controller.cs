using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    abstract class Controller<T>: IController<T> where T:Model
    {
        private protected string tableName;
        private protected string idName;

        public virtual void Add(params Param[] @params)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.CREATE, tableName, null, null, @params);
        }

        public virtual void Delete(int id)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.DELETE, tableName, new Param(idName, id));
        }

        public virtual T GetLastAdded()
        {
            T obj = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null, new QueryBuilder().OrderBy(idName, false).Limit(1));
            if (dt.Rows.Count > 0)
                obj = (T)Activator.CreateInstance(typeof(T), dt.Rows[0]);

            return obj;
        }

        public virtual T Show(int id)
        {
            T obj = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            if (dt.Rows.Count > 0)
                obj = (T)Activator.CreateInstance(typeof(T), dt.Rows[0]);

            return obj;

        }

        public virtual List<T> ShowAll(params Param[] parameters)
        {
            List<T> objects = new List<T>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    objects.Add((T)Activator.CreateInstance(typeof(T),r));
                }

            }

            return objects;

        }

        public virtual T Update(int id, params Param[] @params)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.UPDATE, tableName, new Param(idName, id), null, @params);
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            T obj = null;
            if (dt.Rows.Count > 0)
                obj = (T)Activator.CreateInstance(typeof(T), dt.Rows[0]);

            return obj;
        }

        
    }
}
