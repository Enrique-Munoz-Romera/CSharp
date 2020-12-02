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

namespace WindowsFormsAppClass
{
    public partial class Form29FicheroProductos : Form
    {
        List<Productos> products;
        int indice;
        public Form29FicheroProductos()
        {
            InitializeComponent();
            this.products = new List<Productos>();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String nombres = this.txtNom.Text;
            int precio = int.Parse(this.txtPrecio.Text);
            //this.lstProducto.Items.Add(nombres);
            //this.lstProducto.Items.Add(precio);
            Productos product = new Productos();
            product.Nombre = nombres;
            product.Precio = precio;
            this.txtNom.Clear();
            this.txtNom.Focus();
            this.txtPrecio.Clear();
            //this.txtPrecio.Focus();
            this.products.Add(product);
            this.CargarProductos();
        }

        private void CargarProductos()
        {
            this.lstProducto.Items.Clear();            
            foreach (Productos prod in this.products)
            {
                this.lstProducto.Items.Add(prod.Nombre);
                //this.lstProducto.Items.Add(prod.Precio);
            }
            this.lblResult.Text = "Producto 1 de " + this.products.Count;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            DialogResult resultado = save.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                String path = save.FileName;
                FileInfo file = new FileInfo(path);
                using (TextWriter writer = file.CreateText())
                {
                    await writer.WriteAsync(this.GetProductosString());
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstProducto.Items.Clear();
                
            }
        }

       public String GetProductosString()
        {
            //Serielizacion Propia(inventada)
            //nombre%precio@nombre%precio
            String datos = "";
            foreach(Productos prod in this.products)
            {
                //nombre%precio --> es lo que queremos obtener
                String stprod = prod.Nombre + "%" + prod.Precio;
                datos += stprod + "@";
            }
            datos = datos.Trim('@');
            return datos;
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult respuesta = open.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                String path = open.FileName;
                FileInfo file = new FileInfo(path);
                using (TextReader reader = file.OpenText())
                {
                    String contenido = await reader.ReadToEndAsync();
                    reader.Close();
                    this.CreateProductoString(contenido);
                }
                this.CargarProductos();
            }
        }

        public void CreateProductoString(String contenido)
        {
            this.products.Clear();
            //nombre%precio@nombre%precio
            String[] datosproductos = contenido.Split('@');
            foreach(String dato in datosproductos)
            {
                //nombre%producto
                String[] propiedades = dato.Split('%');
                Productos producto = new Productos();
                producto.Nombre = propiedades[0];
                producto.Precio = int.Parse(propiedades[1]);
                this.products.Add(producto);
            }
        }

        //Vamos a crear un metodo para utilizar el index y jugar con ello
        private void PintarProducto()
        {
            Productos prod = this.products[indice];
            this.txtNom.Text = prod.Nombre;
            this.txtPrecio.Text = prod.Precio.ToString();
            this.lblResult.Text = "Producto " + (this.indice + 1)
                + " de " + this.products.Count;
            this.lstProducto.SelectedIndex = this.indice;
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.indice = 0;
            this.PintarProducto();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.indice += 1;
            if(indice >= this.products.Count)
            {
                this.indice = this.products.Count - 1;
            }
            this.PintarProducto();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.indice--;
            if(indice < 0)
            {
                this.indice = 0;
            }
            this.PintarProducto();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.indice = this.products.Count - 1;
            this.PintarProducto();
        }
      
    }
}
