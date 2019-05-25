using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class GivingTypesController : IController<GivingType>
    {

        private protected string tableName = "GivingTypes";
        private protected string idName = "givingTypeId";
        public List<GivingType> ShowAll(params Param[] @params)
        {
            List<GivingType> givingTypes = new List<GivingType>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL,tableName);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    givingTypes.Add(new GivingType(r));
                }

            }

            return givingTypes;
        }

        public GivingType Show(int id)
        {
            GivingType givingType = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName,id));
            if (dt.Rows.Count > 0)
            {
                givingType = FinanceDbManager.DataRowToGivingType(dt.Rows[0]);
            }

            return givingType;
        }

        public void Add(params Param[] @params)
        {
            FinanceDbManager.BasicQuery(
                FinanceDbManager.QueryMode.CREATE,tableName,null,null,
                @params);
        }

        public GivingType Update(int id, params Param[] @params)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.UPDATE, tableName, new Param(idName, id), null, @params);
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            GivingType givingType = null;
            if (dt.Rows.Count > 0)
                givingType = new GivingType(dt.Rows[0]);

            return givingType;
        }

        public void Delete(int id)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.DELETE, tableName, new Param(idName, id));
        }
    }
}
