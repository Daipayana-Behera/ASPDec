using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieSample
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string pswd = txtPswd.Text;
            HttpCookie c1 = new HttpCookie("details"); // inside cookie we can store a data. Cookie will create inside server and then it will pass to a browser. sometimes cookie will store inside browser RAM memory or client. cookie will travel between server to browser or server to client. 
            c1.Values["User_Name"] = username;
            c1.Values["Password"] = pswd;
            c1.Expires=DateTime.Now.AddMonths(2);//to make permanent cookie, without this line it will be temporary cookie.
            Response.Cookies.Add(c1);
            Response.Redirect("display.aspx");
        }
    }
}