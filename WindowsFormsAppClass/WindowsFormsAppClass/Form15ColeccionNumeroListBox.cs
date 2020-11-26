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
    public partial class Form15ColeccionNumeroListBox : Form
    {
        public Form15ColeccionNumeroListBox()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random rand = new Random();
            for(int ctr = 0; ctr <= 10; ctr++)
            {
                int aleat = rand.Next(101);                
                this.lstNumeros.Items.Add(aleat);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumapares = 0;
            int sumaImpares = 0;

            foreach(object obj in this.lstNumeros.Items)
            {
                int num = (int)obj;
                suma += num;
                if(num % 2 == 0)
                {
                    sumapares += num;
                }
                else
                {
                    sumaImpares += num;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumapares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }
    }
}
