using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsAppClass
{
    public partial class Form30SerializarClase : Form
    {
        XmlSerializer serial;

        public Form30SerializarClase()
        {
            InitializeComponent();
            //en el momento de instanciar el objeto 
            //debemos indicar la cls que almacenaremos
            //TypeOf--> nos devuelve un obj de la clase Type
            this.serial = new XmlSerializer(typeof(Productos));
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.Nombre = this.txtProducto.Text;
            producto.Precio = int.Parse(this.txtPrecio.Text);
            //Para serializar se utiliza S.IO
            //clase Stream(Reader,Writer)
            StreamWriter writer = new StreamWriter("producto.xml");
            //con el producto serialize almacenamos un obj
            // de la clase y genera un fichero xml con el proyecto 
            //el writer es el vehiculo para escribir el fichero
            this.serial.Serialize(writer, producto);
            await writer.FlushAsync();
            writer.Close();
            this.txtProducto.Text = "";
            this.txtPrecio.Text = "";
            this.lblInfo.Text = "Datos guardados";
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("producto.xml");
            //La deserializacion es automatica
            //Nosotros enviamos el reader y nos decuelve
            //el obj ya instanciado
            //Utilizamos el metodo DESERIALIZE
            Productos producto = (Productos)this.serial.Deserialize(reader);
            reader.Close();
            this.txtProducto.Text = producto.Nombre;
            this.txtPrecio.Text = producto.Precio.ToString();
            this.lblInfo.Text = "producto leído";
        }
    }
}
