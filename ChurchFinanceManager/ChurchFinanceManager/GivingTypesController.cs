using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class GivingTypesController
    {
        public List<GivingType> ViewGivingTypes()
        {
            List<GivingType> givingTypes = new List<GivingType>();
            DataTable dt = FinanceDbManager.GivingTypeQuery(FinanceDbManager.QueryMode.SELECT_ALL);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    givingTypes.Add(FinanceDbManager.DataRowToGivingType(r));
                }

            }

            return givingTypes;

        }

        public GivingType ViewGivingType(int givingTypeId)
        {
            GivingType givingType = null;
            DataTable dt = FinanceDbManager.GivingTypeQuery(FinanceDbManager.QueryMode.SELECT_ONE, givingTypeId);
            if (dt.Rows.Count > 0)
            {
                givingType = FinanceDbManager.DataRowToGivingType(dt.Rows[0]);
            }

            return givingType;

        }

        public void AddGivingType(string title, bool isRegular, bool isActive)
        {
            FinanceDbManager.GivingTypeQuery(
                FinanceDbManager.QueryMode.CREATE, Int32.MinValue,
                title,
                isRegular,
                isActive);

        }
        public void UpdateGivingType(int givingTypeId, string title, bool isRegular, bool isActive)
        {
            FinanceDbManager.GivingTypeQuery(
                FinanceDbManager.QueryMode.UPDATE,
                givingTypeId,
                title,
                isRegular,
                isActive);

        }

        public void DeleteGivingType(int givingTypeId)
        {
            FinanceDbManager.GivingTypeQuery(FinanceDbManager.QueryMode.DELETE, givingTypeId);
        }
    }
}
