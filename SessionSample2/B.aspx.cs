using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionSample2
{
    public partial class B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Num = (string)Session["Number"];
            int n2 = int.Parse(Num);
            bool isprime = true;
            Response.Output.WriteLine($"Number {Num} is even.\n And Prime Numbers Upto {Num} are -> ");
            

            for (int i = 2; i <= n2; i++)
            {
                for (int j = 2; j <= n2; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Response.Output.WriteLine("\n"+i);
                    
                }
                isprime = true;
            }
            
        }
    }
}