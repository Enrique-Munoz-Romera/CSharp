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
    public partial class Form10SumarNumerosString : Form
    {
        public Form10SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //Sumar Numeros Sting
           String textonumeros = this.txtNumeros.Text;
            int suma = 0;
            //Recorremos todos los caracteres del STRING
            for(int i = 0; i < textonumeros.Length; i++)
            {
                //Recuperamos cada caracter
                char character = textonumeros[i];
                //convertimos el caracter a numeros

                //esta conversion recupera el codigo ASCI
                //nosotros necesitamos el LITERAL

                //esta conversion no nos sirve
                //int num = character;
                int num = int.Parse(character.ToString());
                suma += num;
            }
            this.lblResultado.Text = suma.ToString();
        }
    }
}
