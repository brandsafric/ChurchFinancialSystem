using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChurchFinanceManager
{
    public partial class GivingStatsFrm : Form
    {
        List<DateTime> dateRanges = new List<DateTime>();
        public GivingStatsFrm()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadTimeRanges();
        }

        private void GivingStatsFrm_Load(object sender, EventArgs e)
        {

            LoadControls();
        }

        void LoadControls()
        {
            //Load offering type
            List<GivingType> givingTypes = new List<GivingType>();
            GivingTypesController gtc = new GivingTypesController();
            givingTypes = gtc.ShowAll();
            if (givingTypes.Count > 0)
            {
                Dictionary<int, string> givingTypesLibrary = new Dictionary<int, string>();
                givingTypesLibrary.Add(0, "<All>");
                foreach (GivingType givingType in givingTypes)
                {
                    givingTypesLibrary.Add(givingType.id, givingType.title);
                }
                givingTypesCmbBx.DataSource = new BindingSource(givingTypesLibrary, null);
                givingTypesCmbBx.DisplayMember = "Value";
                givingTypesCmbBx.ValueMember = "Key";

                givingTypesCmbBx.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No offering types available! no registered offering type found.", "Offering Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            //initialize Controls
            periodCmbBx.SelectedIndex = 0;

        }

        void LoadTimeRanges()
        {
            dateRangeCmbBx.DataSource = null;
            dateRangeCmbBx.Items.Clear();

            if (periodCmbBx.SelectedIndex == 0)
            {
                LoadYears();
            }
            else
            {
                LoadMonths();
            }


        }

        void LoadMonths()
        {
            dateRanges = new GivingItemsController().GetAllMonths();
            if (dateRanges.Count == 0) { MessageBox.Show("No offering records found!"); this.Close(); return; }
            Dictionary<DateTime, string> datesLibrary = new Dictionary<DateTime, string>();
            foreach (DateTime date in dateRanges)
            {
                datesLibrary.Add(date, date.ToString("MMM yyyy"));
            }

            dateRangeCmbBx.DataSource = new BindingSource(datesLibrary, null);
            dateRangeCmbBx.DisplayMember = "Value";
            dateRangeCmbBx.ValueMember = "Key";

            dateRangeCmbBx.SelectedIndex = 0;
        }

        void LoadYears()
        {
            dateRanges = new GivingItemsController().GetAllYears();
            if (dateRanges.Count == 0) { MessageBox.Show("No offering records found!"); this.Close(); return; }
            Dictionary<DateTime, string> datesLibrary = new Dictionary<DateTime, string>();
            foreach (DateTime date in dateRanges)
            {
                datesLibrary.Add(date, date.ToString("yyyy"));
            }

            dateRangeCmbBx.DataSource = new BindingSource(datesLibrary, null);
            dateRangeCmbBx.DisplayMember = "Value";
            dateRangeCmbBx.ValueMember = "Key";

            dateRangeCmbBx.SelectedIndex = 0;
        }

        private void DateRangeCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGraph();
        }

        private void GivingTypesCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGraph();
        }

        void LoadGraph()
        {
            if (dateRangeCmbBx.SelectedValue == null) return;
            if (dateRangeCmbBx.Items.Count == 0) return;

            DateTime selectedDate;
            if (!DateTime.TryParse(dateRangeCmbBx.SelectedValue.ToString(), out selectedDate))
            {
                selectedDate = ((KeyValuePair<DateTime, string>)dateRangeCmbBx.SelectedValue).Key;
            }
            int selectedGivingType = givingTypesCmbBx.SelectedIndex == 0 ? 0 : (int)givingTypesCmbBx.SelectedValue;
            int selectedYear = selectedDate.Year;
            int selectedMonth = periodCmbBx.SelectedIndex == 0 ? 0 : selectedDate.Month;


            DataTable dt = new GivingItemsController().ShowAll(selectedYear, selectedMonth, selectedGivingType);
            double total = 0;
            //loading the graph
            displayChart.Series.Clear();
            displayChart.Series.Add((selectedGivingType == 0 ? "All Offering" : new GivingTypesController().Show(selectedGivingType).title));
            displayChart.Series[0].ChartType = SeriesChartType.Area;
            foreach (DataRow r in dt.Rows)
            {
               
                total += Convert.ToDouble(r["total"]);
                string displayStr = (periodCmbBx.SelectedIndex == 0 ?
                    CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(Convert.ToInt32(r["month"])) + " " + r["year"].ToString()
                    : Convert.ToDateTime(r["start"]).ToString("MMM dd, yyyy") + " - " + Convert.ToDateTime(r["end"]).ToString("MMM dd, yyyy"));
                displayChart.Series[0].Points.AddXY(displayStr, r["total"]);
            }
            totalTxt.Text = total.ToString();
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
