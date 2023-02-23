using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuerryStringSample
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtbtn_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPswd.Text;
            Response.Redirect($"Display.aspx?User_Name={username}&User_Pswd={password}");
        }
    }
}