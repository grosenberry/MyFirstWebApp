using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButtonChallenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultImage.ImageUrl = "Assets\\pencil.png";
            }
            else if (penRadioButton.Checked)
            {
                resultImage.ImageUrl = "Assets\\pen.png";
            }
            else  if (phoneRadioButton.Checked)
            {
                resultImage.ImageUrl = "Assets\\phone.png";
            }
            else if (tabletRadioButton.Checked)
            {
                resultImage.ImageUrl = "Assets\\tablet.png";
            }
            else
            {
                resultLabel.Text = "Please choose an option above";
            }
        }
    }
}