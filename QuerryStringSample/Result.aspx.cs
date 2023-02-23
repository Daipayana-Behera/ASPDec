using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace QuerryStringSample
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Nm = Request.QueryString["Name"];
            string cl = Request.QueryString["Class"];
            string cs = Request.QueryString["C"];
            string Html = Request.QueryString["HTML"];
            string Sql = Request.QueryString["SQL"];
            string asp = Request.QueryString["Asp"];

            Response.Output.Write($"Name is {Nm} & Class is {cl}");

            int CS = int.Parse(cs);
            int HTML = int.Parse(Html);
            int SQL = int.Parse(Sql);
            int ASP = int.Parse(asp);
            int avg = (CS + HTML + SQL + ASP) / 4;
            if (avg < 50)
            {
                Response.Output.Write(" ->FAIL");
            }
            else if (avg > 50 & avg < 75)
            {
                Response.Output.Write(" ->Second Class");
            }
            else if (avg > 75 & avg < 85)
            {
                Response.Output.Write(" ->First class");
            }
            else if (avg > 85 & avg < 100)
            {
                Response.Output.Write(" ->Distinction");
            }
        }
    }
}