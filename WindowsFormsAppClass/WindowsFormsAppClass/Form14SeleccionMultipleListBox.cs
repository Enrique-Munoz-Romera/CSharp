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
                indices += indices;
            }
            //.SelectedItems
            //this.lstElementos.SelectedItems[]
        }
    }
}
