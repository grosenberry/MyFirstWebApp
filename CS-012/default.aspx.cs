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
            //resultLabel.Text = (isTextBox.Text == equalToTextBox.Text) ? "Yes they are equal!" : "Nope, not equal at all";

            resultLabel.Text = (oldCheckBox.Checked) ? "Yep you are old" : "Nope youre young!";
        }

        protected void oldCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}