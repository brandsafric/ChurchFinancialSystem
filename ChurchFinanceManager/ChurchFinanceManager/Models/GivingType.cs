using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class GivingType : Model
    {
      public string title;
      public bool isRegular;
      public bool isActive;

       public GivingType(string title, bool isRegular, bool isActive) {
            GivingTypesController gtc = new GivingTypesController();
            gtc.Add(
                new Param("title", title),
                new Param("isRegular", isRegular),
                new Param("isActive", isActive));
            GivingType gt = gtc.GetLastAdded();
            this.id =  gt.id;
           this.title = gt.title;
           this.isRegular = gt.isRegular;
           this.isActive = gt.isActive;
       }

        public GivingType(DataRow r)
        {                         
            this.id = Convert.ToInt32(r["givingTypeId"]);
            this.title = r["title"].ToString();
            this.isRegular = Convert.ToBoolean(r["isRegular"]);
            this.isActive = Convert.ToBoolean(r["isActive"]);
        }

        public void Update(string title, bool isRegular, bool isActive)
       {
           GivingTypesController givingTypesController = new GivingTypesController();
           givingTypesController.Update(this.id, 
               new Param("title",title),
               new Param("isRegular", isRegular),
               new Param("isActive", isActive));
           this.title = title;
           this.isRegular = isRegular;
           this.isActive = isActive;
       }

       public void Delete()
       {
           GivingTypesController givingTypesController = new GivingTypesController();
           givingTypesController.Delete(this.id);
       }
    }
}
