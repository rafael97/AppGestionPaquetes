using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Datos;

namespace App.Web
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                BillsRepositories bill = new BillsRepositories();
                PersonRepositories perso = new PersonRepositories();
                long codigo = long.Parse(TextBox1.Text);
               
                if (perso.consultar(codigo))
                {
                    bill.facturar();

                    Label18.Text = bill.ToString();
                    //Label18.Text = "factura realizada " + "cliente: " + TextBox1.Text;
                    Label18.Visible = true;

                }
                else
                {
                   
                    Label18.Text = "cliente desconosido porfavor ingrese uno valido o registrese";
                    Label18.Visible = true;
                }
           
            }
            catch (Exception)
            {
                
                
            } 
            
           
        }
    }
}