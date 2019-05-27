using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class Giving : Model
    {
        public Member member;
        public DateTime givingDate;
        public DateTime entryDate;
        public Service service;

        public Giving(Member member, DateTime givingDate, Service service)
        {
            GivingsController gc = new GivingsController();
            gc.Add(new Param("memberId", member.id),
                new Param("givingDate", givingDate),
                new Param("entryDate", DateTime.Now),
                new Param("serviceId",service.id));
            Giving g = gc.GetLastAdded();
            MembersController mc = new MembersController();
            this.member = g.member;
            this.givingDate = g.givingDate;
            this.entryDate = g.entryDate;
            this.service = g.service;
        }

        public Giving(int givingId, Member member, DateTime givingDate, DateTime entryDate,Service service)
        {
            MembersController mc = new MembersController();
            this.id = givingId;
            this.member = member;
            this.givingDate = givingDate;
            this.entryDate = entryDate;
            this.service = service;
        }

        public Giving(DataRow r)
        {
            try
            {

                MembersController mc = new MembersController();
                ServicesController sc = new ServicesController();
                this.id = Convert.ToInt32(r["givingId"]);
                this.member = mc.Show(Convert.ToInt32(r["memberId"]));
                this.givingDate = Convert.ToDateTime(r["givingDate"]);
                this.entryDate = Convert.ToDateTime(r["entryDate"]);
                this.service = sc.Show(Convert.ToInt32(r["serviceId"]));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Update(Member member, DateTime givingDate, Service service)
        {
            GivingsController gc = new GivingsController();
            gc.Update(id, 
                new Param("memberId",member.id), 
                new Param("givingDate", givingDate),
                new Param("serviceId", service.id)
                );
            this.member = member;
            this.givingDate = givingDate;
        }
        public void Delete()
        {
            GivingsController gc = new GivingsController();
            gc.Delete(id);
        }
        public List<GivingItem> givingItems()
        {
            List<GivingItem> gi = new List<GivingItem>();
            GivingItemsController gic = new GivingItemsController();
            gi = gic.ShowAll(new Param("givingId",id));
            return gi;

        }

        public double totalAmount()
        {
            List<GivingItem> gi = givingItems();
            double total = 0;
            foreach (GivingItem g in gi)
            {
                total += g.amount;
            }
            return total;
        }


    }
}
