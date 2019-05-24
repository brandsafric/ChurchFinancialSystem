using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class GivingItem
    {
        public int givingItemId;
        public Giving giving;
        public GivingType givingType;
        public double amount;
        public GivingItem(int givingItemId, Giving giving, GivingType givingType, double amount)
        {
            this.givingItemId = givingItemId;
            this.giving = giving;
            this.givingType = givingType;
            this.amount = amount;
        }
        public void Update(Giving giving, GivingType givingType, double amount)
        {
            GivingItemsController gic = new GivingItemsController();
            gic.UpdateGivingItem(this.givingItemId, giving, givingType, amount);
            this.giving = giving;
            this.givingType = givingType;
            this.amount = amount;
        }
        public void Delete()
        {
            GivingItemsController gic = new GivingItemsController();
            gic.DeleteGivingItem(this.givingItemId);
        }
    }
}
