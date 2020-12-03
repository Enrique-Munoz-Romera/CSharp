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
    public partial class Form31SerializarColeccion : Form
    {
        XmlSerializer serial;
        ColeccionProductos productos;

        public Form31SerializarColeccion()
        {
            InitializeComponent();
            this.serial = new XmlSerializer(typeof(ColeccionProductos));
            this.productos = new ColeccionProductos();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Nombre = this.txtNom.Text;
            prod.Precio = int.Parse(this.txtPrecio.Text);
            this.productos.Add(prod);
            this.PintarProductos();
            this.txtNom.Text = "";
            this.txtPrecio.Text = "";
            this.txtNom.Focus();
        }

        private void PintarProductos()
        {
            this.lstProducto.Items.Clear();
            foreach(Producto prod in this.productos){
                this.lstProducto.Items.Add(prod.Nombre);
            }
        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstProducto.SelectedIndex != -1)
            {
                int indice = this.lstProducto.SelectedIndex;
                Producto prod = this.productos[indice];
                this.txtNom.Text = prod.Nombre;
                this.txtPrecio.Text = prod.Precio.ToString();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("listaproductos.xml");
            this.serial.Serialize(writer, this.productos);
            await writer.FlushAsync();
            writer.Close();
            this.productos.Clear();
            this.lstProducto.Items.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listaproductos.xml");
            this.productos = (ColeccionProductos)this.serial.Deserialize(reader);
            reader.Close();
            this.PintarProductos();
        }
    }
}
