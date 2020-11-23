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
    public partial class FormConversion : Form
    {
        public FormConversion()
        {
            InitializeComponent();
        }

        private void FormConversion_Load(object sender, EventArgs e)
        {
            double mayor = 50;
            int menor = 50;
            //Si igualamos mayor capacidad a menor capacidad
            //conversión automática
            mayor = menor;
            //Error de compilacón 
            //menor = mayor;
            //Casting entre primitivos
            //Los primitivos estan todos en minusculas
            //(TIPO A CONVENTIR )objeto
            short mini = 44;//menor
            int numero = 55;//mayo
            mini = (short)numero;

            //conversion de STRING a tipo primitivo
            //UN TIPO string ES UNA CLASE
            //TIENE LA PRIMERA LETRa en mayuscula
            //Para poder convertirlo a string
            //a primitivo se utilizal metodos de las clases
            //primitivas. se llama Parsear
            //tipoPrimitivo.Parse(STRING)
            String texto = "34567";
            double doble = double.Parse(texto);
            //ESTO YA NOS REALIZARIA LA CONVERSIÓN

            //Convertir Primitivos a STRING
            //La clase System.Object contiene un metodo para convertir a String
            //.ToString()
            //Cualquier obj.tiene el metodo .ToString()
            int valor = 999;
            String dato = valor.ToString();
            dato = this.ToString();
            dato = this.BackColor.ToString();

            //Los metodos pueden tener sobrecarga
            MessageBox.Show("Texto", "Titulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }
    }
}
