using System;
using System.Collections.Generic;
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

       public void Update(string title, bool isRegular, bool isActive)
       {
           GivingTypesController givingTypesController = new GivingTypesController();
           givingTypesController.UpdateGivingType(this.givingTypeId, title, isRegular, isActive);
           this.title = title;
           this.isRegular = isRegular;
           this.isActive = isActive;
       }

       public void Delete()
       {
           GivingTypesController givingTypesController = new GivingTypesController();
           givingTypesController.DeleteGivingType(this.givingTypeId);
       }
    }
}
