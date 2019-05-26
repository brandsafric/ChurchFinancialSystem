using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class GivingItemsController : IController<GivingItem>
    {

        private protected string tableName = "GivingItems";
        private protected string idName = "givingItemId";

        public List<GivingItem> ShowAll(params Param[] @params)
        {

            List<GivingItem> givingItems = new List<GivingItem>();
            if (@params.Length != 1) return givingItems;

            QueryBuilder qb = new QueryBuilder().Where(@params[0].name).EqualsTo(@params[0].value);
            
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL,tableName,null,qb);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    givingItems.Add(new GivingItem(r));
                }

            }

            return givingItems;
        }

        public GivingItem Show(int id)
        {
            GivingItem givingItem = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE,tableName,new Param(idName,id));
            if (dt.Rows.Count > 0)
            {
                givingItem = new GivingItem(dt.Rows[0]);
            }

            return givingItem;
        }

        public void Add(params Param[] @params)
        {
            if (@params.Length != 3) return;
            GivingsController gc = new GivingsController();
            GivingTypesController gtc = new GivingTypesController();
            if (gc.Show((int)@params[0].value) == null || gtc.Show((int)@params[1].value) == null)
            {
                MessageBox.Show("Offering or Offering Type not found!", "Offering Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.CREATE,tableName,null,null,@params);
        }

        public GivingItem Update(int id, params Param[] @params)
        {
            if (@params.Length != 3) return null;
            GivingsController gc = new GivingsController();
            GivingTypesController gtc = new GivingTypesController();
            if (gc.Show((int)@params[0].value) == null || gtc.Show((int)@params[1].value) == null)
            {
                MessageBox.Show("Offering or Offering Type not found!", "Offering Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.UPDATE, tableName, new Param(idName, id), null, @params);
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            GivingItem givingItem = null;
            if (dt.Rows.Count > 0)
                givingItem = new GivingItem(dt.Rows[0]);

            return givingItem;
        }

        public void Delete(int id)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.DELETE, tableName, new Param(idName, id));
        }

        public GivingItem GetLastAdded()
        {
            GivingItem givingItem = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null, new QueryBuilder().OrderBy(idName, false).Limit(1));
            if (dt.Rows.Count > 0)
                givingItem = new GivingItem(dt.Rows[0]);

            return givingItem;
        }
    }
}
