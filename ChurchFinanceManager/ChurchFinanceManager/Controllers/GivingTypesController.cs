using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class GivingTypesController : Controller<GivingType>
    {
        public GivingTypesController()
        {
            tableName = "GivingTypes";
            idName = "givingTypeId";
        }
      
        public List<GivingType> ShowUnused(Giving giving)
        {
            List<GivingType> givingTypes = new List<GivingType>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL,
                tableName, null,
                new QueryBuilder().Where(idName).NotIn(
                    new QueryBuilder().Select("GivingItems", idName).Where("givingId").EqualsTo(giving.id)
                    ).And("isActive").EqualsTo(true)
                );
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    givingTypes.Add(new GivingType(r));
                }

            }

            return givingTypes;
        }
        public List<GivingType> ShowUnusedExcept(Giving giving,GivingType givingType)
        {
            List<GivingType> givingTypes = new List<GivingType>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL,
                tableName, null,
                new QueryBuilder().Where(idName).NotIn(
                    new QueryBuilder().Select("GivingItems", idName).Where("givingId").EqualsTo(giving.id)
                    .And("givingTypeId").NotEqualsTo(givingType.id)
                    ).And("isActive").EqualsTo(true)
                ) ;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    givingTypes.Add(new GivingType(r));
                }

            }

            return givingTypes;
        }

    }
}
