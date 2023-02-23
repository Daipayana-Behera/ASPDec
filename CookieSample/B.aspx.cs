using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieSample
{
    public partial class B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c2 = Request.Cookies["data"];
            string name = c2.Values["Name"];
            Response.Output.Write($"Name: {name} |");
            int vowels = 0;
            int consonant = 0;
            int Space = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u' || name[i] == 'A'
                    || name[i] == 'E' || name[i] == 'I' || name[i] == 'O' || name[i] == 'U')
                {
                    vowels = vowels + 1;
                }
                else if (name[i]==' ')
                {
                    Space = Space + 1;
                }
                else
                {
                    consonant = consonant + 1;
                }
            }

            Response.Output.Write($"\n Vowels count: {vowels} \n, Consonant count: {consonant}");
        }
    }
}