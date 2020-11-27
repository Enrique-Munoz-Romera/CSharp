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
    public partial class Form21SumarBotonesColeccion : Form
    {
        List<Button> botones;
        int suma;

        public Form21SumarBotonesColeccion()
        {
            InitializeComponent();
            //Instanciamos la coleccion de buttons
            this.botones = new List<Button>();

            Random rand = new Random();
            //

            foreach(Control control in this.panel1.Controls)
            {
                //Preguntamos por su type
                if(control is Button)
                {
                    control.Text = rand.Next(1, 99).ToString();
                    this.botones.Add((Button)control);
                }
            }
            //Recorremos nuestra coleccion de botones
            foreach(Button boton in this.botones)
            {
                boton.Click += SumarNumeros;
            }
        }

        private void SumarNumeros(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.Green;
            int num = int.Parse(boton.Text);
            //int suma = int.Parse(this.txtNumeros.Text);
            this.suma += num;
            //this.txtNumeros.Text = suma.ToString();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            this.txtNumeros.Text = this.suma.ToString();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            foreach(Button boton in this.botones)
            {
                boton.BackColor = Color.FromKnownColor(KnownColor.Black);
            }
            this.suma = 0;
            this.txtNumeros.Text = "";
        }
    }
}
