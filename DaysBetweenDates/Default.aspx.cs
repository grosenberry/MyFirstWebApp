using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /** 
         * On click the ok button returns the positive difference between 2 selected
         * dates on the calendars.
         */
        protected void okButton_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate.CompareTo(Calendar2.SelectedDate) < 0)
                resultLabel.Text = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).Days.ToString();
            else
                resultLabel.Text = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate).Days.ToString() ;  
        }
    }
}