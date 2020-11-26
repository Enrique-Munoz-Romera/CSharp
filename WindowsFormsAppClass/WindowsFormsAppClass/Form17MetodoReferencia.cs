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
    public partial class Form17MetodoReferencia : Form
    {
        public Form17MetodoReferencia()
        {
            InitializeComponent();
        }

        //Metodo para comprobar valor en tipos WRAPPER
        void DobleNumero(int num)
        {
            num = num * 2;
        }

        //Metodo que recibe una clase por referencia
        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Fuchsia;
        }

        //Esto que vamos a ver no suele ser comun.
        //Metodo que recibe un wrapper o primitivo
        //y lo utiliza como referencia(como si fuera una clase).
        void DobleReferencia(ref int num)
        {
            num = num * 2;
        }

        //Si necesitamos devolver algo a la llamada
        //no es un void 
        int GetDoble(int num)
        {
            return num * 2;
        }

        private void btnLLamada_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            //Llamamos al metodo con la variable por valor 
            this.DobleNumero(numero);
            //Llamamos al metodo que recibe un obj por referencia (una clase).
            this.CambiarColor(this.btnLLamada);
            //Llamamos al metodo inusual
            //Si deseamos enviar referencia debemos incluir la palabra REF.
            //this.DobleReferencia(ref numero);
            //creamos var para llamar al metodo
            //int doble = this.GetDoble(numero);
            this.lblResultado.Text = "Doble: " + numero;

        }
    }
}
