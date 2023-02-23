using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieSample
{
    public partial class display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c2 = Request.Cookies["details"];
            string name = c2.Values["User_Name"];
            string pswd = c2.Values["Password"];
            Response.Output.Write($"User Name is {name} and Password is {pswd}");
        }
    }
}