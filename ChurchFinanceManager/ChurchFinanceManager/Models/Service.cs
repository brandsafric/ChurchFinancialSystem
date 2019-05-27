using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchFinanceManager
{
    public class Service : Model
    {
        public string name;
        public int day;

        public Service(string name, int day)
        {
            ServicesController sc = new ServicesController();
            sc.Add(
                new Param("name", name),
                new Param("day", day)
                );
            Service s = sc.GetLastAdded();

            this.id = s.id;
            this.name = s.name;
            this.day = s.day;
        }
        public Service(DataRow r)
        {
            this.id = Convert.ToInt32(r["serviceId"]);
            this.name = r["name"].ToString();
            this.day = Convert.ToInt32(r["day"]);
        }

        public string DayFullName()
        {
            string dName = "";
            switch (day)
            {
                case 0: dName = "Sunday"; break;
                case 1: dName = "Monday"; break;
                case 2: dName = "Tuesday"; break;
                case 3: dName = "Wednesday"; break;
                case 4: dName = "Thursday"; break;
                case 5: dName = "Friday"; break;
                case 6: dName = "Saturday"; break;
            }
            return dName;
        }
        public string DayShortName()
        {
            string dName = "";
            switch (day)
            {
                case 0: dName = "Sun"; break;
                case 1: dName = "Mon"; break;
                case 2: dName = "Tue"; break;
                case 4: dName = "Thu"; break;
                case 5: dName = "Fri"; break;
                case 6: dName = "Sat"; break;
            }
            return dName;
        }

        public void Update(string name, int day)
        {
            ServicesController sc = new ServicesController();

            Service service = sc.Update(this.id,
                new Param("name", name),
                new Param("day", day)
                );
            this.name = service.name;
            this.day = service.day;
        }

        public void Delete()
        {
            ServicesController sc = new ServicesController();
            sc.Delete(this.id);
        }

        public DateTime GetLastServiceDate()
        {
            DateTime dt =DateTime.Today;
            while (day != (int)dt.DayOfWeek)
                dt = dt.AddDays(-1);
            return dt;
        }



    }
}
