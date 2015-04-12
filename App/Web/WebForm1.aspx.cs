using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Modelo;
using App.Datos;

namespace App.Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                long id = long.Parse(TextBox1.Text);
                long box = long.Parse(TextBox5.Text);

                Person p = new Person(id, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox6.Text, box);

                PersonRepositories per = new PersonRepositories();
                per.AddPerson(p);


                Label6.Text = p.ToString();
            }
            catch (Exception)
            {
                
                
            }
           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text="";
            TextBox2.Text="";
            TextBox3.Text="";
            TextBox4.Text="";
            TextBox5.Text="";
            TextBox6.Text = "";
            Label6.Text="";


        }

      
        protected void Button3_Click1(object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx", true);
        }
    }
}