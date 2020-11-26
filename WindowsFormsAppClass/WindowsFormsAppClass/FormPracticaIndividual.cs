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
    public partial class FormPracticaIndividual : Form
    {
        public FormPracticaIndividual()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int longitud = 10;
            Guid miGuid = Guid.NewGuid();
            String palabras = miGuid.ToString().Replace("-", string.Empty).Substring(0,longitud);
            this.lstProductos.Items.Add(palabras);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String items = this.txtProducto.Text;
            this.lstProductos.Items.Add(items);
            this.txtProducto.SelectAll();
            this.txtProducto.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = this.lstProductos.SelectedIndex;
            String producto = this.txtProducto.Text;
            this.lstProductos.Items[index] = producto;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstProductos.SelectedIndex;
            this.lstProductos.Items.RemoveAt(index);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstProductos.Items.Clear();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
           int texto = this.lstProductos.Items.Count;
            this.txtSumar.Text = texto.ToString();
        }
    }
}
