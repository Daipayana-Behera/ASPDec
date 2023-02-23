using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedirectionPage
{
    public partial class A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
           // Response.Redirect("B.aspx",true); It will not execute source page fully. true is default . without true same . execution stop source page execution not completely.
           // Response.Redirect("B.aspx",false); It will execute source page fully first & then it will redirect to destination page.
           // Response.Redirect("B.aspx");// Same as ("B.aspx",true)
            Response.Write("Hi");

            //Server.Transfer("B.aspx");

            Server.Execute("B.aspx");
            Response.Write("Hello");
        }
    }
}