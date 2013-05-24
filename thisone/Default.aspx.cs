using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace thisone
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            input1.Text = "Hello appt164"; 
        }

        protected void doBtn_Click(object sender, EventArgs e)
        {

            string key = ConfigurationManager.AppSettings["key"];
            input1.Text = "Clicked" + " " + key;
        }
    }
}