using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Response.Write("This is FirstRequest");
            }
            else
            {
                Response.Write("This is PostBack Request");
                Response.Write("Hii");
            }
        }
    }
}