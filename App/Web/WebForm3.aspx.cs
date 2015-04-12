using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Datos;
using App.Modelo;

namespace App.Web
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            long idRemitente = long.Parse(TextBox7.Text);
            long boxRemitente = long.Parse(TextBox12.Text);
            long idReceptor = long.Parse(TextBox13.Text);
            long boxReceptor = long.Parse(TextBox18.Text);
            double precio=Convert.ToDouble(TextBox6.Text);
            double peso = Convert.ToDouble(TextBox4.Text);
            Person remitente = new Person(idRemitente, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, boxRemitente);
            Person receptor = new Person(idReceptor, TextBox14.Text, TextBox15.Text, TextBox16.Text, TextBox17.Text, boxReceptor);
            if (CheckBox1.Checked == true)
            {
              //  Package pg1 = new Package(TextBox1.Text, remitente, receptor, peso, precio);
                Package pg1 = new OvernightPackage(TextBox1.Text, remitente, receptor, peso, precio, 500);

                BillsRepositories bill = new BillsRepositories();

                bill.AddPaquete(pg1);
                Label6.Text = "paquete  night guardado";
            }
            if (CheckBox2.Checked == true)
            {
                Package pg1 = new TwoDayPackage(TextBox1.Text, remitente, receptor, peso, precio,500);

                BillsRepositories bill = new BillsRepositories();

                bill.AddPaquete(pg1);
                Label6.Text = "paquete two days guardado";
            }
                if (CheckBox3.Checked==true)
	{
		 Package pg1 = new Package(TextBox1.Text, remitente, receptor, peso, precio);

         BillsRepositories bill = new BillsRepositories();

         bill.AddPaquete(pg1);
         Label6.Text = "paquete normal guardado ";
	}
            

           

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked==true)
            {
                CheckBox2.Checked = false;
                CheckBox3.Checked = false;
            }
            
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                CheckBox1.Checked = false;
                CheckBox3.Checked = false;
            }
            
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                CheckBox2.Checked = false;
                CheckBox1.Checked = false;
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox15.Text = "";
            TextBox16.Text = "";
            TextBox17.Text = "";
            TextBox18.Text = "";
            TextBox1.Text = "";
            TextBox4.Text = "";
            TextBox7.Text = "";
            TextBox6.Text = "";
            TextBox9.Text = "";
            TextBox8.Text = "";
        }
    }
}