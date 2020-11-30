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
    public partial class Form23TemperaturasAnuales : Form
    {
        //Cremaos una coleccion 
        List<int> temperaturas;

        public Form23TemperaturasAnuales()
        {
            InitializeComponent();
            //instanciamos la coleccion
            this.temperaturas = new List<int>();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //String[] months = new String[]{"Enero","Febrero","Marzo","Abril","Mayo",
            //    "Junio","Julio","Agosto","Septiembre","Octubre","Novimebre","Diciembre"};
            //Random rnd = new Random();

            //if(this.lstMonth.Items.Count == 0)
            //{
            //    for (int ctr = 1; ctr <= 12; ctr++)
            //    {
            //        int aleat = rnd.Next(-20,45);
            //        this.lstMonth.Items.Add(months[ctr - 1] + " " + aleat);
            //    }
            //}

            //Vamos a realizar el ejercico utilizando clases especificas 
            DateTime fecha = DateTime.Parse("01/01/2020");
            Random rnd = new Random();
            this.lstMonth.Items.Clear();
            this.temperaturas.Clear();
            for (int i = 1; i <= 12; i++)
            {
                String mes = fecha.ToString("MMMM");
                int aleat = rnd.Next(-20, 45);
                this.lstMonth.Items.Add(mes + "  " + aleat);
                this.temperaturas.Add(aleat);
                fecha = fecha.AddMonths(1);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            int maxima, minima, intermedia, suma;
            minima = this.temperaturas[0];
            maxima = this.temperaturas[0];
            suma = 0;
            foreach(int temp in temperaturas)
            {
                suma += temp;
                if(temp > maxima)
                {
                    maxima = temp;
                }
                minima = Math.Min(temp,minima);
            }
            intermedia = suma / this.temperaturas.Count;
            this.textBox1.Text = maxima.ToString();
            this.textBox2.Text = minima.ToString();
            this.textBox3.Text = intermedia.ToString();
        }
    }
}
