using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class GivingItemsController : Controller<GivingItem>
    {
        public GivingItemsController()
        {
            tableName = "GivingItems";
            idName = "givingItemId";
        }
        
        public override List<GivingItem> ShowAll(params Param[] @params)
        {

            List<GivingItem> givingItems = new List<GivingItem>();
            if (@params.Length != 1) return givingItems;

            QueryBuilder qb = new QueryBuilder().Where(@params[0].name).EqualsTo(@params[0].value);

            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null, qb);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    givingItems.Add(new GivingItem(r));
                }

            }

            return givingItems;
        }

     
        public override void Add(params Param[] @params)
        {
            if (@params.Length != 3) return;
            GivingsController gc = new GivingsController();
            GivingTypesController gtc = new GivingTypesController();
            if (gc.Show((int)@params[0].value) == null || gtc.Show((int)@params[1].value) == null)
            {
                MessageBox.Show("Offering or Offering Type not found!", "Offering Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.Add(@params);
        }

        public override GivingItem Update(int id, params Param[] @params)
        {
            if (@params.Length != 3) return null;
            GivingsController gc = new GivingsController();
            GivingTypesController gtc = new GivingTypesController();
            if (gc.Show((int)@params[0].value) == null || gtc.Show((int)@params[1].value) == null)
            {
                MessageBox.Show("Offering or Offering Type not found!", "Offering Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
         
            return base.Update(id,@params);
        }


    }
}
