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
    public partial class FormSumar : Form
    {
        public FormSumar()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //Necesitamos los valores de las cajas
            //son tipo String y necesitamos int
            //por lo que debemos convertir String a Int
            //PARSEAR
            int num1, num2;
            num1 = int.Parse(this.txtNum1.Text);
            num2 = int.Parse(this.txtNum2.Text);
            int suma = num1 + num2;
            //Debemos convertir INT A STRING -->.ToString()
            this.lblResultado.Text = suma.ToString();
        }
    }
}
