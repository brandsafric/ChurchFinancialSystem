using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class Giving
    {
      public int givingId;
      public Member member;
      public DateTime givingDate;
      public DateTime entryDate;

      public Giving(int givingId, int memberId, DateTime givingDate, DateTime entryDate)
      {
          MembersController mc = new MembersController();
          this.givingId = givingId;
          this.member = mc.Show(memberId);
          this.givingDate = givingDate;
          this.entryDate = entryDate;
       }

      public Giving(int givingId, Member member, DateTime givingDate, DateTime entryDate)
      {
          MembersController mc = new MembersController();
          this.givingId = givingId;
          this.member = member;
          this.givingDate = givingDate;
          this.entryDate = entryDate;
      }
        public void Update(Member member, DateTime givingDate)
        {
            GivingsController gc = new GivingsController();
            gc.UpdateGiving(givingId, member, givingDate);
            this.member = member;
            this.givingDate = givingDate;
        }
        public void Delete()
        {
            GivingsController gc = new GivingsController();
            gc.DeleteGiving(givingId);
        }
        public List<GivingItem> givingItems()
        {
            List<GivingItem> gi = new List<GivingItem>();
           GivingItemsController gic = new GivingItemsController();
            gi= gic.ViewGivingItems(this);
            return gi;

        }

        public double totalAmount()
        {
            List<GivingItem> gi = givingItems();
            double total = 0;
            foreach(GivingItem g in gi)
            {
                total += g.amount;
            }
            return total;
        }


    }
}
