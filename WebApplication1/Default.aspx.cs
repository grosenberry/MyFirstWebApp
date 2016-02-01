using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String age = ageTextBox.Text;

            String money = moneyTextBox.Text;

            String result = "At " + age + " years old, I would have expected you to have more than " + money + " in your pocket.";

            resultLabel.Text = result;
        }
    }
}