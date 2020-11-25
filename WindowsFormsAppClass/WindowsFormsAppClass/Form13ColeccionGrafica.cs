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
    public partial class Form13ColeccionGrafica : Form
    {
        public Form13ColeccionGrafica()
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

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblPosicion.Text = "Posicion: " + this.lstElementos.SelectedIndex;
            this.lblSeleccionado.Text = "Seleccionado: " + this.lstElementos.SelectedItem;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Utilizamos el metodo clear y limpiamos toda la coleccion
            this.lstElementos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Para eliminar elemento individuales tenemos dos metodos diferentes
            // .Remove(OBJ) || .RemoveAt(index).
            int indice = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(indice);
            //this.lstElementos.Items.RemoveAt(3);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstElementos.SelectedIndex;
            String elem = this.txtElemento.Text;
            this.lstElementos.Items[indice] = elem;
        }
       
    }
}
