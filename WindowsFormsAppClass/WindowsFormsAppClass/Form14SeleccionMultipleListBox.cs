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
    public partial class Form14SeleccionMultipleListBox : Form
    {
        public Form14SeleccionMultipleListBox()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            //La coleccion donde vamos a insertar es .ITEMS
            //DEBEMOS AVERIGUAR EL TIPO DE  ITEMS
            this.lstElementos.Items.Add(elem);
            this.txtElemento.SelectAll();
            this.txtElemento.Focus();
        }

        private void btnSeleccionado_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            //.SelectedIndices
            //Es un tipo INT
            foreach(int num in this.lstElementos.SelectedIndices)
            {
                indices += num +  ",";
            }
            //.SelectedItems
            //this.lstElementos.SelectedItems[]//object
            foreach (object obj in this.lstElementos.SelectedItems)
            {
                items += obj + ",";
            }
            this.lblIndices.Text = indices.Trim(',');
            this.lblSeleccionados.Text = items.Trim(',');
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //vamos a recorrer todos los indices seleccionados
            //Recorremos .SelectedIndices
            //Todos los elementos estan en la coleccion .Items
            //eliminaremos de la coleccion .Items
            //foreach(int indice in this.lstElementos.SelectedIndices)
            //{
            //    this.lstElementos.Items.RemoveAt(indice);
            //}
            //Siempre que eliminemos varios elementos de una coleecion 
            //

            int numelementos = this.lstElementos.SelectedIndices.Count - 1;
            for (int i = numelementos; i >= 0; i--)
            {
                int indseleccionado = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(indseleccionado);
            }
        }
    }
}
