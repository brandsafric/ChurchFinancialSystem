using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
   public class Family : Model
    {
        public string familyName;
        public Family(string familyName)
        {
            FamiliesController fc = new FamiliesController();
            fc.Add(new Param("familyName", familyName));
            Family f = fc.GetLastAdded();
            this.id = f.id;
            this.familyName = f.familyName;
        }
        public Family(DataRow r)
        {
            this.id = Convert.ToInt32(r["familyId"]);
            this.familyName = r["familyName"].ToString();

        }

        public void Update(string familyName)
        {
            Family family = new FamiliesController().Update(this.id,
               new Param("familyName", familyName)
              );
            this.familyName = family.familyName;
        }

        public void Delete()
        {
             new MembersController().Delete(id);
        }

    }
}
