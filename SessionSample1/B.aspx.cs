using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionSample1
{
    public partial class B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user_name = (string)Session["UserName"];

            string uname = (string)Application["User"];
            Response.Output.Write($"Name = {uname}");
        }

        
    }
}