using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCalculator
{
    public partial class _default : System.Web.UI.Page
    {
        double result;
        String first;
        String second;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void plusButton_Click(object sender, EventArgs e)
        {
            first = firstTextBox.Text;
            second = secondTextBox.Text;

            result = double.Parse(first) + double.Parse(second);

            resultLabel.Text = result.ToString();
        }

        protected void minusButton_Click1(object sender, EventArgs e)
        {
            first = firstTextBox.Text;
            second = secondTextBox.Text;

            result = double.Parse(first) - double.Parse(second);

            resultLabel.Text = result.ToString();
        }

        protected void multiButton_Click(object sender, EventArgs e)
        {
            first = firstTextBox.Text;
            second = secondTextBox.Text;

            result = double.Parse(first) * double.Parse(second);

            resultLabel.Text = result.ToString();
        }

        protected void divButton_Click(object sender, EventArgs e)
        {
            first = firstTextBox.Text;
            second = secondTextBox.Text;

            result = double.Parse(first) / double.Parse(second);

            resultLabel.Text = result.ToString();
        }



        
    }
}