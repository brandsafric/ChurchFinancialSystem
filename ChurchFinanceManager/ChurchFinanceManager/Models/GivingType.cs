using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class GivingType
    {
      public int givingTypeId;
      public string title;
      public bool isRegular;
      public bool isActive;

       public GivingType(int givingTypeId, string title, bool isRegular, bool isActive) {
           this.givingTypeId =  givingTypeId;
           this.title = title;
           this.isRegular = isRegular;
           this.isActive = isActive;
       }

        public GivingType(DataRow r)
        {                         
            this.givingTypeId = Convert.ToInt32(r["givingTypeId"]);
            this.title = r["title"].ToString();
            this.isRegular = Convert.ToBoolean(r["isRegular"]);
            this.isActive = Convert.ToBoolean(r["isActive"]);
        }

        public void Update(string title, bool isRegular, bool isActive)
       {
           GivingTypesController givingTypesController = new GivingTypesController();
           givingTypesController.Update(this.givingTypeId, 
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
           givingTypesController.Delete(this.givingTypeId);
       }
    }
}
