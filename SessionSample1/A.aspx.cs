using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionSample1
{
    public partial class A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            Session["UserName"] = name;//session 
            Application["User"] = name;//application state server side SMT
            Response.Redirect("B.aspx");
        }
    }
}