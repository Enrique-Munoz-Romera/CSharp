using ProyectoClases;
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
    public partial class Form27PracticaMesesConClase : Form
    {
        List<Class03Meses> meses;
        public Form27PracticaMesesConClase()
        {
            InitializeComponent();
            this.meses = new List<Class03Meses>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.meses.Clear();
            this.lstMonths.Items.Clear();
            DateTime fecha = DateTime.Parse("01/01/2020");
            Random rnd = new Random();
            for (int i = 1; i <= 12; i++)
            {
                int max = rnd.Next(10, 40);
                int min = rnd.Next(-20, 15);
                Class03Meses meses = new Class03Meses() ;
                meses.Meses = fecha.ToString("MMMM");
                fecha = fecha.AddMonths(1);
                this.lstMonths.Items.Add(meses.Meses);
                this.meses.Add(meses);
                
            }
            
        }

        private void lstMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstMonths.SelectedIndex;
            Class03Meses mes = this.meses[indice - 1];
            this.textBox1.Text = mes.Meses;
            this.textBox2.Text = mes.Maxima.ToString();
            this.textBox3.Text = mes.Minima.ToString();
            this.textBox4.Text = mes.GetMedia().ToString();
        }
    }
}
