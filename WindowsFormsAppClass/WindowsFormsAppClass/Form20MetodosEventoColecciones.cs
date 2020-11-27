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
    public partial class Form20MetodosEventoColecciones : Form
    {
        int contador = 0;
        List<Button> botones;
        public Form20MetodosEventoColecciones()
        {
            InitializeComponent();
            //Los objetos siempre se instancian en un constructos
            this.botones = new List<Button>();
            //this.botones.Add(btn1);
            //this.botones.Add(btn2);
            //this.botones.Add(btn3);
            //Cuando hablamos de colecciones en forms
            //tenemos una coleccion que es controls.
            //Si queremos guardar todos los botones del form
            // this.controls y almacenar solo los botones en la coleccion
            foreach(Control control in this.Controls)
            {
                this.botones.Add((Button)control);
            }
        }

        //No tiene nada que ver un mtodo de evento (cundo)
        //Con un metodo propio de la clase
        void AddEvents (bool activar)
        {
            foreach(Button boton in this.botones)
            {
                if(activar == true)
                {
                    boton.Click += MostrarMensaje;
                }
                else
                {
                    boton.Click -= MostrarMensaje;
                }
            }
        }

        private void chkAsociarMetodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAsociarMetodos.Checked == true)
            {
                contador += 1;
                this.AddEvents(true);
                //this.btn1.Click += MostrarMensaje;
                //foreach(Button boton in botones)
                //{
                //    boton.Click += MostrarMensaje;
                //}
            }
            else
            {
                contador--;
                this.AddEvents(false);
                //this.btn1.Click -= MostrarMensaje;
                //foreach(Button boton in botones)
                //{
                //    boton.Click -= MostrarMensaje;
                //}
            }
            this.lblNumeroEventos.Text = "Eventos: " + this.contador;
        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            MessageBox.Show("Hoy es viernes 27 !! ");
            //Vienen varios objetos
        }
    }
}
