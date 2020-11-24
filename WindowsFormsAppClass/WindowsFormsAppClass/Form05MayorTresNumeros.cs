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
    public partial class Form05MayorTresNumeros : Form
    {
        public Form05MayorTresNumeros()
        {
            InitializeComponent();
        }

        private void Form05MayorTresNumeros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //capturamos los numeros de los textBox
            int num1 = int.Parse(this.txtNum1.Text);
            int num2 = int.Parse(this.txtNum2.Text);
            int num3 = int.Parse(this.txtNum3.Text);
            int mayor, menor, intermedio;
            //Evaluamos el numero mayor
            if(num1 >= num2 && num1 >= num3)
            {
                mayor = num1;
            }else if (num2 >= num1 && num2 >= num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = 3;
            }
            //Evaluamos el menor
            if(num1 <= num2 && num1 <= num3)
            {
                menor = num1;
            }else if (num2 <= num1 && num2 <= num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }
            //regla matematica para sacar el intermedio
            int suma = num3 + num2 + num1;
            intermedio = suma - mayor - menor;
            //ahora vamos a pintar en un lbl
            this.lblResultado.Text = "Mayor: " + mayor + "\nMenor: " + menor + "\nIntermedio: " + intermedio;
            
        }
    }
}
