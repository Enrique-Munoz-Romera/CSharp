using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosForms
{
    public partial class Form08Char : Form
    {
        public Form08Char()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                //Queremos convertir cada int a Char
                char caracter = (char) i;
                if(char.IsLetter(caracter) == true)
                {
                    this.txtLetras.Text += caracter;
                }else if (char.IsNumber(caracter) == true)
                {
                    this.txtNumeros.Text += caracter;
                }else if (char.IsSymbol(caracter) == true)
                {
                    this.txtSimbolos.Text += caracter;
                }else if (char.IsPunctuation(caracter) == true)
                {

                    this.txtPuntuacion.Text += caracter;
                }
            }
        }
    }
}
