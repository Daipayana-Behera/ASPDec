using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoadingData
{
    public partial class B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //step1: Create an object for List generic class
                List<string> states = new List<string>();

                //step2: Add all the otions to list generic object
                
                states.Add("Select");
                states.Add("KA");
                states.Add("MP");
                states.Add("AP");
                

                //step3:
                ddlStates.DataSource = states;

                //step4:
                ddlStates.DataBind();
            }
        }

        protected void ddlStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            string statename = ddlStates.SelectedValue;
            List<string> lstCity = new List<string>();
            if (statename == "KA")
            {
                lstCity.Add("Bangalore");
                lstCity.Add("Mysore");
            }
            else if (statename == "AP")
            {
                lstCity.Add("Vijaywada");
                lstCity.Add("Chittoor");
            }
            else if (statename == "MP")
            {
                lstCity.Add("Bhopal");
                lstCity.Add("Indore");
            }
            ddlCity.DataSource = lstCity;
            ddlCity.DataBind();
        }
    }
}