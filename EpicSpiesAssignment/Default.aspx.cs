using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 * Programmer:  Gary Rosenberry
 * Program: EpicSpiesAssignment
 * Date Created: 3/19/16
 * Date Modified: 3/30/16
 * 
 * This Program will allow a user to enter a spy name, project name, and
 * select project dates within the guidelines of certain business rules.
 * 
 * The program will calculate total project cost based on rates and OT rates
 * using the selected dates in the calendar.
 */



namespace EpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        public readonly double rate = 500.00; //Current Rate
        public readonly double overtime = 1000.00; //Current OT Rate

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DateTime today = DateTime.Today;

                endDateCalendar.SelectedDate = today;
                endDateCalendar.VisibleDate = endDateCalendar.SelectedDate;
                startDateCalendar.SelectedDate = today.AddDays(14);
                startDateCalendar.VisibleDate = startDateCalendar.SelectedDate;
                projEndDateCalendar.SelectedDate = today.AddDays(21);
                projEndDateCalendar.VisibleDate = projEndDateCalendar.SelectedDate;
                
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            double salary = 0.0; //Total Salary
            double daysBetweenAssignments = startDateCalendar.SelectedDate.Subtract(endDateCalendar.SelectedDate).TotalDays; //Days between assignments

            //If 2 weeks are not selected in between assignments, show an error and show a new start date of a correct 
            if (daysBetweenAssignments < 14)
            {
                resultLabel.Text = "Error.  Must allow at least two weeks between previous assignment and new assignment";
                startDateCalendar.SelectedDate = endDateCalendar.SelectedDate.AddDays(14);
                startDateCalendar.VisibleDate = startDateCalendar.SelectedDate;
            }
            //If assignment meets 2 week requirement, calculate salary and assign.
            else
            {
                //Check to see if OT is necessary.
                if (projEndDateCalendar.SelectedDate.Subtract(startDateCalendar.SelectedDate).TotalDays > 21)
                {
                    //Add OT to the salary.
                    salary += overtime;
                }

                //Calculate how many days the project will take and multipy it times the rate.
                salary += projEndDateCalendar.SelectedDate.Subtract(startDateCalendar.SelectedDate).TotalDays * rate;

                resultLabel.Text = String.Format("Assignment of {0} to assignment Project: {1} is authorized. Budget total is: {2:C}.", 
                    spyNameBox.Text, 
                    assignNameBox.Text, 
                    salary);

                //Reset the fields for the next assignment
                endDateCalendar.SelectedDate = projEndDateCalendar.SelectedDate;
                endDateCalendar.VisibleDate = endDateCalendar.SelectedDate;
                startDateCalendar.SelectedDate = endDateCalendar.SelectedDate.AddDays(14);
                startDateCalendar.VisibleDate = startDateCalendar.SelectedDate;
                projEndDateCalendar.SelectedDate = endDateCalendar.SelectedDate.AddDays(21);
                projEndDateCalendar.VisibleDate = projEndDateCalendar.SelectedDate;

                spyNameBox.Text = "";
                assignNameBox.Text = "";
            }
        }
    }
}