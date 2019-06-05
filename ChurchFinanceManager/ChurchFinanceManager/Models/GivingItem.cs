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
        public string note;
        public GivingItem(Giving giving, GivingType givingType, double amount, string note = "")
        {
            GivingItemsController gc = new GivingItemsController();
            gc.Add(
                new Param("givingId", giving.id),
                new Param("givingTypeId", givingType.id),
                new Param("amount", amount),
                new Param("note",note)
                );
            GivingItem gi = gc.GetLastAdded();
            this.id = gi.id;
            this.giving = gi.giving;
            this.givingType = gi.givingType;
            this.amount = gi.amount;
            this.note = gi.note;
        }
        public GivingItem(DataRow r)
        {
            GivingsController gc = new GivingsController();
            GivingTypesController gtc = new GivingTypesController();
            this.id = Convert.ToInt32(r["givingItemId"]);
            this.giving = gc.Show(Convert.ToInt32(r["givingId"]));
            this.givingType = gtc.Show(Convert.ToInt32(r["givingTypeId"]));
            this.amount = Convert.ToDouble(r["amount"]);
            this.note = r["note"].ToString();
        }
        public void Update(Giving giving, GivingType givingType, double amount, string note ="")
        {
            GivingItemsController gic = new GivingItemsController();
            gic.Update(this.id, 
                new Param("givingId",giving.id),
                new Param("givingTypeId",givingType.id),
                new Param("amount", amount),
                new Param("note", note));
            this.giving = giving;
            this.givingType = givingType;
            this.amount = amount;
            this.note = note;
        }
        public void Delete()
        {
            GivingItemsController gic = new GivingItemsController();
            gic.Delete(this.id);
        }
    }
}
