using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuerryStringSample
{
    public partial class Marks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string cls = txtclass.Text;
            string C = txtC.Text;
            string html = txthtml.Text;
            string sql = txtsql.Text;
            string asp = txtasp.Text;
            Response.Redirect($"Result.aspx?Name={name}&Class={cls}&C={C}&HTML={html}&SQL={sql}&Asp={asp}");
            
        }
    }
}