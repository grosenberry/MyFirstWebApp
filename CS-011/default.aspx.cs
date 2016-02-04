using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_011
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            
            if (coolCheckBox.Checked)
            {
                resultLabel.Text = "You are cool!";
            }
            else
                resultLabel.Text = "You are not cool";

            
            if (isTextBox.Text.Equals(equalToTextBox.Text))
            {
                resultLabel.Text = "They are equal!";
            }
            else
            {
                resultLabel.Text = "They are not equal!";
            }

            if (pizzaRadioButton.Checked)
            {
                resultLabel.Text = "Pizza is ok I guess";
            }
            else if (saladRadioButton.Checked)
            {
                resultLabel.Text = "At least its healthy";
            }
            else if (pbjRadioButton.Checked)
            {
                resultLabel.Text = "Yum, PB & J";
            }
            else
            {
                resultLabel.Text = "Please select one of the options";
            }

        }
    }
}