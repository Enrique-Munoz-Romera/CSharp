using System;
using System.Collections;
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
    public partial class Form19ColeccionesNoGraficas : Form
    {
        public Form19ColeccionesNoGraficas()
        {
            InitializeComponent();
            //ArraysList
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.btn1);
            coleccion.Add(this.btn2);
            coleccion.Add(this.btn3);
            //vamos a cambiar el color de fondo
            //((Button)coleccion[0]).BackColor = Color.Yellow;
            //un bucle each permite la conversion de obj a la clase definida
            //es decir hace una conversion implicita
            //foreach(Button boton in coleccion)
            //{
            //    boton.BackColor = Color.Green;
            //}

            //Las colecciones genericas son mas eficientes
            //Tienen tipado y mas facil detectar errores en compilacion
            List<Control> botones = new List<Control>();
            botones.Add(btn1);
            botones.Add(btn2);
            botones.Add(btn3);
            botones.Add(textBox1);
            //EL compilador detecta errores de programacion 
            //botones.Add(this.textBox1);esto es el ejmplo de error.
            //otra ventaja que ofroce es que los elementos vienen tipados, en su forma definida
            botones[0].BackColor = Color.Gold;
            foreach(Control control in botones)
            {
                control.BackColor = Color.Fuchsia;
                //y si deseamos realizar algo soo en la clase TEXTBOX?¿
                //Para preguntar si un obj es de una clase determenunada se utiliza el operdar IS
                if( control is TextBox)
                {
                    control.BackColor = Color.LavenderBlush;
                    //La clase TEXTBOX  tiene un metodo que es .Paste();
                    //Pega del portapapeles en la caja 
                    ((TextBox)control).Paste();
                    //Control.Paste();
                }
            }
        }

        
    }
}
