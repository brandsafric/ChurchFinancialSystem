using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class GivingItem : Model
    {
        public Giving giving;
        public GivingType givingType;
        public double amount;
        public GivingItem(Giving giving, GivingType givingType, double amount)
        {
            GivingItemsController gc = new GivingItemsController();
            gc.Add(
                new Param("givingId", giving.id),
                new Param("givingTypeId", givingType.id),
                new Param("amount", amount)
                );
            GivingItem gi = gc.GetLastAdded();
            this.id = gi.id;
            this.giving = gi.giving;
            this.givingType = gi.givingType;
            this.amount = gi.amount;
        }
        public GivingItem(DataRow r)
        {
            GivingsController gc = new GivingsController();
            GivingTypesController gtc = new GivingTypesController();
            this.id = Convert.ToInt32(r["givingItemId"]);
            this.giving = gc.Show(Convert.ToInt32(r["givingId"]));
            this.givingType = gtc.Show(Convert.ToInt32(r["givingTypeId"]));
            this.amount = Convert.ToDouble(r["amount"]);
        }
        public void Update(Giving giving, GivingType givingType, double amount)
        {
            GivingItemsController gic = new GivingItemsController();
            gic.Update(this.id, 
                new Param("givingId",giving.id),
                new Param("givingTypeId",givingType.id),
                new Param("amount", amount));
            this.giving = giving;
            this.givingType = givingType;
            this.amount = amount;
        }
        public void Delete()
        {
            GivingItemsController gic = new GivingItemsController();
            gic.Delete(this.id);
        }
    }
}
