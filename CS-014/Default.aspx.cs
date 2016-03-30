using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.Now;
            
            //resultLabel.Text = dt.ToLongDateString();
            //resultLabel.Text = dt.ToLongTimeString();
            //resultLabel.Text = dt.ToShortDateString();
            //resultLabel.Text = dt.ToShortTimeString();

            //resultLabel.Text = dt.AddMonths(-2).ToString();
            //resultLabel.Text = dt.Month.ToString();

            //resultLabel.Text = dt.IsDaylightSavingTime().ToString();
            //resultLabel.Text = dt.DayOfWeek.ToString();
            //resultLabel.Text = dt.DayOfYear.ToString();

            //DateTime dt = DateTime.Parse("12/7/1969");
            //resultLabel.Text = dt.ToLongDateString().ToString();

            DateTime dt = new DateTime(1969, 12, 7, 6, 30, 0);
            resultLabel.Text = dt.ToLongDateString().ToString();
        }
    }
}