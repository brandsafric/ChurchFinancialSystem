using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class GivingItemsController : Controller<GivingItem>
    {
        public GivingItemsController()
        {
            tableName = "GivingItems";
            idName = "givingItemId";
        }
        
        public override List<GivingItem> ShowAll(params Param[] @params)
        {

            List<GivingItem> givingItems = new List<GivingItem>();
            if (@params.Length != 1) return givingItems;

            QueryBuilder qb = new QueryBuilder().Where(@params[0].name).EqualsTo(@params[0].value);

            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL, tableName, null, qb);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    givingItems.Add(new GivingItem(r));
                }

            }

            return givingItems;
        }

     
        public override void Add(params Param[] @params)
        {
            if (@params.Length != 4) return;
            GivingsController gc = new GivingsController();
            GivingTypesController gtc = new GivingTypesController();
            if (gc.Show((int)@params[0].value) == null || gtc.Show((int)@params[1].value) == null)
            {
                MessageBox.Show("Offering or Offering Type not found!", "Offering Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.Add(@params);
        }

        public override GivingItem Update(int id, params Param[] @params)
        {
            if (@params.Length != 4) return null;
            GivingsController gc = new GivingsController();
            GivingTypesController gtc = new GivingTypesController();
            if (gc.Show((int)@params[0].value) == null || gtc.Show((int)@params[1].value) == null)
            {
                MessageBox.Show("Offering or Offering Type not found!", "Offering Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
         
            return base.Update(id,@params);
        }

        public List<DateTime> GetAllMonths()
        {


            QueryBuilder qb = new QueryBuilder().Custom("SELECT DISTINCT strftime('%m',g.givingDate) as month, strftime('%Y',g.givingDate) as year FROM GivingItems gi JOIN  Givings g ON gi.givingId = g.givingId");
            List <DateTime> monthYearList = new List<DateTime>();
            DataTable dt = FinanceDbManager.CustomQuery(qb);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    monthYearList.Add(new DateTime(
                        Convert.ToInt32(r["year"]),
                        Convert.ToInt32(r["month"]),
                        1//default value which will not be used
                        ));
                }

            }

            return monthYearList;
        }

        public List<DateTime> GetAllYears()
        {


            QueryBuilder qb = new QueryBuilder().Custom("SELECT DISTINCT strftime('%Y',g.givingDate) as year FROM GivingItems gi JOIN  Givings g ON gi.givingId = g.givingId");
            List<DateTime> YearList = new List<DateTime>();
            DataTable dt = FinanceDbManager.CustomQuery(qb);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    YearList.Add(new DateTime(
                        Convert.ToInt32(r["year"]),
                        1,//default value which will not be used
                        1//default value which will not be used
                        ));
                }

            }

            return YearList;
        }

        public DataTable ShowAll(int year, int month = 0, int givingTypeId = 0)
        {
            List<GivingItem> gi = new List<GivingItem>();
            string condition;
            if (month == 0)
                return GetTotalOfYear(year, givingTypeId);
            else
                return GetTotalOfMonth(month, year, givingTypeId);
        }

        DataTable GetTotalOfYear(int year, int givingTypeId = 0)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("total");
            dt.Columns.Add("month");
            dt.Columns.Add("year");
            for (int month = 1; month <= 12; month++)
            {
               string condition = new QueryBuilder().Where("strftime('%Y', g.givingDate)").EqualsTo($"'{year.ToString()}'")
                    .And("strftime('%m', g.givingDate)").EqualsTo($"'{ month.ToString("D2")}'").ToString();
                if(givingTypeId != 0)
                    condition += new QueryBuilder().And("gi.givingTypeId").EqualsTo(givingTypeId).ToString();
                DataTable Tempdt = FinanceDbManager.CustomQuery(new QueryBuilder().Custom("SELECT " +
                    "SUM(gi.amount) AS total, " +
                    "Strftime('%m', g.givingDate) AS 'month', " +
                    "Strftime('%Y', g.givingDate) AS 'year' " +
                    "FROM Givings g JOIN GivingItems gi ON gi.givingId = g.givingId ").Custom(condition));
                if (Tempdt.Rows[0]["total"] != DBNull.Value) { dt.Rows.Add(Tempdt.Rows[0]["total"] , Tempdt.Rows[0]["month"], Tempdt.Rows[0]["year"]);continue; }


                dt.Rows.Add(0, month, year);
            }
            return dt;
        }

        DataTable GetTotalOfMonth(int month, int year, int givingTypeId = 0)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("total");
            dt.Columns.Add("start");
            dt.Columns.Add("end");

            // Get the weeks in a month
            DateTime date = new DateTime(year,month,1);
            // first generate all dates in the month of 'date'
            var dates = Enumerable.Range(1, DateTime.DaysInMonth(date.Year, date.Month)).Select(n => new DateTime(date.Year, date.Month, n));
            // then filter the only the start of weeks
            var weekStarts = from d in dates
                           where d.DayOfWeek == DayOfWeek.Sunday
                           select d;

            foreach(DateTime start in weekStarts)
            {
                string condition = new QueryBuilder().Where("date(g.givingDate)")
                    .BETWEEN(
                    $"'{ start.ToString("yyyy-MM-dd")}'",
                    $"'{start.AddDays(7).ToString("yyyy-MM-dd")}'"
                    ).ToString();
                if (givingTypeId != 0)
                    condition += new QueryBuilder().And("gi.givingTypeId").EqualsTo(givingTypeId).ToString();
                DataTable Tempdt = FinanceDbManager.CustomQuery(new QueryBuilder().Custom("SELECT " +
                    "SUM(gi.amount) AS total, " +
                    $"date('{start.ToString("yyyy-MM-dd")}') AS 'start', " +
                    $"date('{start.AddDays(7).ToString("yyyy-MM-dd")}') AS 'end' " +
                    "FROM Givings g JOIN GivingItems gi ON gi.givingId = g.givingId ").Custom(condition));
                Console.WriteLine("Controller Total:" + Tempdt.Rows[0]["total"].ToString());
                dt.Rows.Add((Tempdt.Rows[0]["total"]==DBNull.Value? 0 : Tempdt.Rows[0]["total"]), Tempdt.Rows[0]["start"],Tempdt.Rows[0]["end"]); 
                
            }



         
            return dt;
        }


    }
}
