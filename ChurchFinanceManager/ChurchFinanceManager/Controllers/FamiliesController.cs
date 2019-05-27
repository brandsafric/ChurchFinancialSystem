using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class FamiliesController : IController<Family>
    {
        string tableName = "Families";
        string idName = "familyId";
        public void Add(params Param[] @params)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.CREATE, tableName, null, null, @params);
        }

        public void Delete(int id)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.DELETE, tableName, new Param(idName, id));
        }

        public Family GetLastAdded()
        {
            Family family = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null, new QueryBuilder().OrderBy(idName, false).Limit(1));
            if (dt.Rows.Count > 0)
                family = new Family(dt.Rows[0]);

            return family;
        }

        public Family Show(int id)
        {
            Family family = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            if (dt.Rows.Count > 0)
                family = new Family(dt.Rows[0]);

            return family;
        }

        public List<Family> ShowAll(params Param[] parameters)
        {
            List<Family> families = new List<Family>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    families.Add(new Family(r));
                }

            }

            return families;
        }

        public Family Update(int id, params Param[] @params)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.UPDATE, tableName, new Param(idName, id), null, @params);
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            Family family = null;
            if (dt.Rows.Count > 0)
                family = new Family(dt.Rows[0]);

            return family;
        }
    }
}
