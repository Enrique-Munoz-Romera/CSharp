using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppClass
{
    public partial class Form12StringBuilder : Form
    {
        public Form12StringBuilder()
        {
            InitializeComponent();
            int[] numeros = new int[3] { 14, 838, 33 };
            //sumamos todos los numeros del array
            int suma = 0;
            foreach(int num in numeros)
            {
                suma += num;
            }
            this.lblColeccion.Text = suma.ToString();
            foreach(Control control in this.Controls)
            {
                control.BackColor = Color.DarkGoldenrod;
            }
        }

        private void btnReverseString_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            krono.Start();
            String texto = this.richTexto.Text;
            if (texto.Length > 0)
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    //Recuperamos la utlima letra
                    char letra = texto[texto.Length - 1];
                    //Eliminamos la ultima letra
                    texto = texto.Remove(texto.Length - 1);
                    //insertamos la letra en la posicion indice
                    texto = texto.Insert(i, letra.ToString());
                }
                this.richTexto.Text = texto;
                krono.Stop();
                TimeSpan interval = krono.Elapsed;
                this.lblTiempo.Text = "Segundos: " + interval.TotalSeconds
                    + "\nMilisiegundos: " + interval.TotalMilliseconds;
            }
            else
            {
                MessageBox.Show("Introduce un texto porfavor");
            }
        }

        private void btnReverseStringBuilder_Click(object sender, EventArgs e)
        {
            //2º)Ahora queremos medir el tiempo de ejecucion en el proceso
            //Para e
            Stopwatch krono = new Stopwatch();
            krono.Start();
            StringBuilder texto = new StringBuilder();
            texto.Append(this.richTexto.Text);
            for (int i = 0; i < texto.Length; i++)
            {
                char letra = texto[texto.Length - 1];
                texto = texto.Remove(texto.Length - 1, 1);
                texto = texto.Insert(i, letra);
            }
            this.richTexto.Text = texto.ToString();
            krono.Stop();
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + "\nMilisegundos: " + krono.Elapsed.TotalMilliseconds;

        }
    }
}
