using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm1.aspx", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm3.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm2.aspx", true);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm4.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //profe se explota para mostrar las facturas el problema es que no se cual formulario o data me sirve para que se muestren todos
            Server.Transfer("WebForm5.aspx",true);
        }
    }
}