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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //Cuando Pulsemos el boton sucedera todo este código
            //Estas propiedades son de tipo primitivo
            txtCaja.Text = "Soy el primer Texto en C#";
            //La palabra clave THIS indica la clase sobre la que estamos trabajando
            //si no se pone; por defecto recupera el nombre de variable por cercanía
            this.txtCaja.Width = 400;
            //Propiedades de objectos
            //si queremos cambiar el tamaño del boton la propiedad es SIZE
            //Debemos crear el objeto con new clase ().
            this.btnPulsar.Size = new Size(100, 90);
            //Propiedades de objetos:
            //Tenemos algunas clases que no se crean, si no que se utilizan directamente
            //un ejemplo seria la clase color.
            this.BackColor = Color.Gold;
            //ENUMERACIONES. en AMARILLO
            //una ENUMERACION es una serie de posibilidades para una propiedad.
            //En realidad son tipos INT pero los muestra como STRING
            this.txtCaja.TextAlign = HorizontalAlignment.Right;
        }

        private void txtCaja_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
