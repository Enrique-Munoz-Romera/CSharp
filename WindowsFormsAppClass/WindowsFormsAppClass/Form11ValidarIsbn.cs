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
    public partial class Form11ValidarIsbn : Form
    {
        public Form11ValidarIsbn()
        {
            InitializeComponent();
        }

        private void btnValidarISBN_Click(object sender, EventArgs e)
        {
            String isbn = this.txtISBN.Text;
            int suma = 0;
            if(isbn.Length == 10)
            {
                for(int i = 0; i < isbn.Length; i++)
                {
                    char caracter = isbn[i];
                    int num = int.Parse(caracter.ToString());
                    int multi = num * (i + 1);
                    suma += multi;
                }
                if(suma % 11 == 0)
                {
                    this.lblResultado.Text = "Correcto";
                }
                else
                {
                    this.lblResultado.Text = "incorrecto";
                }
            }
            else
            {
                MessageBox.Show("El numero ISBN debe contener 10 digitos");
            }
        }
    }
}
