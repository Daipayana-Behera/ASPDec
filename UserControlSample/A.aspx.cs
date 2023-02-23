using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlSample
{
    public partial class A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)UserControl.FindControl("txtname");
            Response.Write(t1.Text);

            TextBox t2 = (TextBox)UserControl.FindControl("txtage");
            Response.Output.Write($"<script>alert('age is ='+{t2.Text})</script>");
        }
    }
}