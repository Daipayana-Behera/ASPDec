using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionSample2
{
    public partial class A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            string num = txtNum.Text;
            int n = int.Parse(num);
            Session["Number"] = num;
            if(n%2==0)
            {
                Response.Redirect("B.aspx");
            }
            else
            {
                Response.Redirect("C.aspx");
            }
        }
    }
}