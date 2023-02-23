using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuerryStringSample
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string username = Request.QueryString["User_Name"];
           string pswd = Request.QueryString["User_Pswd"];
            Response.Output.Write($"User Name is {username} and Password is {pswd}");
        }
    }
}