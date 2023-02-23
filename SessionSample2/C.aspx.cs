using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionSample2
{
    public partial class C : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Numb = (string)Session["Number"];
            int n1 = int.Parse(Numb);
            Response.Output.Write($"Number {Numb} is odd.\n And the odd numbers upto {Numb} are -> ");
            
            for (int i = 0; i <= n1; i++)
            {
                if (i % 2 != 0)
                {
                    
                    Response.Output.Write($"\n{i}");
                }
            }
        }
    }
}