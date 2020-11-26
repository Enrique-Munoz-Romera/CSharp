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
    public partial class Form16TiendaProductos : Form
    {
        public Form16TiendaProductos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtProducto.Text;
            this.lstTienda.Items.Add(elem);
            this.txtProducto.SelectAll();
            this.txtProducto.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstTienda.SelectedIndex;
            String elem = this.txtProducto.Text;
            this.lstTienda.Items[indice] = elem;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Borrar de uno en uno
            //int indice = this.lstTienda.SelectedIndex;
            //this.lstTienda.Items.RemoveAt(indice);

            //Borrar seleccionMultiple
            int numElem = this.lstTienda.SelectedIndices.Count - 1;
            for(int i = numElem; i >= 0; i--)
            {
                int indSeleccionado = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(indSeleccionado);
            }
            
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //ListBox items = this.lstTienda;
            //ListBox almacen = this.lstAlmacen;
            foreach(object obj in this.lstTienda.Items)
            {
                this.lstAlmacen.Items.Add(obj);
                //almacen.Items.Add(obj);
            }
        }

        private void btnSeleccionado_Click(object sender, EventArgs e)
        {
            String items = "";
            foreach (Object obj in this.lstTienda.SelectedItems)
            {
                items += obj;
            }
            this.lstAlmacen.Items.Add(items);
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            //int indice = this.lstAlmacen.SelectedIndex;
            //this.lstAlmacen.SelectedIndex = this.lstAlmacen.SelectedIndex - 1;   
            int index = this.lstAlmacen.SelectedIndex;
            Object producto = this.lstAlmacen.Items[index];
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index - 1, producto);
            this.lstAlmacen.SelectedIndex = index - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            Object product = this.lstAlmacen.Items[index];
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index + 1, product);
            this.lstAlmacen.SelectedIndex = index + 1;
        }
    }
}
