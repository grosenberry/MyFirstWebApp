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
            comparisonTypeLabel.Text = "equal to";
            //comparisonTypeLabel.Text = "not equal to";
            //comparisonTypeLabel.Text = "greater than";
            //comparisonTypeLabel.Text = "greater than";
            //comparisonTypeLabel.Text = "greater than or equal to";
            //comparisonTypeLabel.Text = "less than";
            //comparisonTypeLabel.Text = "less than or equal to";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //resultLabel.Text = (isTextBox.Text == equalToTextBox.Text) ? "Yes" : "No";
            //resultLabel.Text = (isTextBox.Text != equalToTextBox.Text) ? "Yes" : "No";

            //int first = int.Parse(isTextBox.Text);
            //int second = int.Parse(equalToTextBox.Text);

            //resultLabel.Text = (first > second) ? "Yes" : "No";
            //resultLabel.Text = (first >= second) ? "Yes" : "No";
            //resultLabel.Text = (first < second) ? "Yes" : "No";
            //resultLabel.Text = (first <= second) ? "Yes" : "No";
            //resultLabel.Text = (first <= second) ? "Yes" : "No";
            //resultLabel.Text = (first <= second) ? "Yes" : "No";

            /*
            if (oldCheckBox.Checked && isTextBox.Text == "Gary" && equalToTextBox.Text == "Rosenberry")
            {
                resultLabel.Text = "Perfect Tri-fecta";
            }
            else
            {
                resultLabel.Text = "Not quite there";
            }*/

            /*
            if (oldCheckBox.Checked || isTextBox.Text == "Gary" || equalToTextBox.Text == "Rosenberry")
            {
                resultLabel.Text = "One out of three aint bad";
            }
            else
            {
                resultLabel.Text = "Not quite there";
            }
             * */



        }

        protected void oldCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}