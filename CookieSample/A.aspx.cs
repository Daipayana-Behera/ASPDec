using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieSample
{
    public partial class A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            HttpCookie c1 = new HttpCookie("data");
            c1.Values["Name"] = name;
            c1.Expires = DateTime.Now.AddYears(2);
            Response.Cookies.Add(c1);
            Response.Redirect("B.aspx");
        }
    }
}