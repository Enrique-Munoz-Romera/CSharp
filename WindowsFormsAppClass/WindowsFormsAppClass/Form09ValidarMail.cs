using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppClass
{
    public partial class Form09ValidarMail : Form
    {
        public Form09ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            String email = this.txtEmail.Text;
            if (email.Contains("@") == false)
            {
                this.lblResultado.Text = "No hay @";
            }else if (email.StartsWith("@") || email.EndsWith("@"))
            {
                this.lblResultado.Text = "@ al principio o al fial";
            }else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                this.lblResultado.Text = "Existe mas de un @";
            }else if (email.Contains(".") == false)
            {
                this.lblResultado.Text = "No existe punto";
            }else if(email.LastIndexOf(".") < email.IndexOf("@"))
            {
                this.lblResultado.Text = "Punto despues de la @";
            }
            else
            {
                int ultimopunto = email.LastIndexOf(".");
                string dominio = email.Substring(ultimopunto + 1);
                if(dominio.Length >= 2 && dominio.Length <= 4)
                {
                    this.lblResultado.Text = "Mail Correcto";
                }else
                {
                    this.lblResultado.Text = "Dominio incorrecto";
                }
            }
        }
    }
}
