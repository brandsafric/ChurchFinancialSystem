using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class GivingItemsController
    {
        public List<GivingItem> ViewGivingItems(Giving giving)
        {
            List<GivingItem> givingItems = new List<GivingItem>();
            DataTable dt = FinanceDbManager.GivingItemQuery(FinanceDbManager.QueryMode.SELECT_ALL,0, giving.givingId);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    givingItems.Add(FinanceDbManager.DataRowToGivingItem(r));
                }

            }

            return givingItems;
        }

        public GivingItem ViewGivingItem(int givingItemId)
        {
            GivingItem givingItem = null;
            DataTable dt = FinanceDbManager.GivingItemQuery(FinanceDbManager.QueryMode.SELECT_ONE, givingItemId);
            if (dt.Rows.Count > 0)
            {
                givingItem = FinanceDbManager.DataRowToGivingItem(dt.Rows[0]);
            }

            return givingItem;
        }

        public void AddGivingItem(Giving giving,GivingType givingType, double amount)
        {
            if (giving == null || givingType == null)
            {
                MessageBox.Show("Offering or Offering Type not found!", "Offering Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FinanceDbManager.GivingItemQuery(
                FinanceDbManager.QueryMode.CREATE, Int32.MinValue,
                giving.givingId,
                givingType.givingTypeId,
                amount
                );

        }

        public void UpdateGivingItem(int givingItemId, Giving giving, GivingType givingType, double amount)
        {
            if (giving == null || givingType == null)
            {
                MessageBox.Show("Offering or Offering Type not found!", "Offering Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FinanceDbManager.GivingItemQuery(
                    FinanceDbManager.QueryMode.UPDATE,
                    givingItemId,
                    giving.givingId,
                    givingType.givingTypeId,
                    amount);
        }

        public void DeleteGivingItem(int givingItemId)
        {
            FinanceDbManager.GivingItemQuery(FinanceDbManager.QueryMode.DELETE, givingItemId);
        }
    }
}
