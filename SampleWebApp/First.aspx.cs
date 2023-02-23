using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class First : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string Age = txtAge.Text;
            //int Age = Convert.ToInt32(txtAge.Text);
            string email = txtEmail.Text;
           // string male = rdMale.Text;
            //string female = rdFemale.Text;
           // string course = ddlCourse.Text;
           // string city = ddlCity.Text;

            Response.Output.Write($"Name is{name}, Age is {Age} and Email is {email}");
           
        }
    }
}