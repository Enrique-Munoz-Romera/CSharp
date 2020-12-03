using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsAppClass
{
    public partial class Form32PracticaCoches : Form
    {
        ColeccionProductos coches;
        XmlSerializer serial;

        public Form32PracticaCoches()
        {
            InitializeComponent();
            this.coches = new ColeccionProductos();
            this.serial = new XmlSerializer(typeof(Coche));
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Coche auto = new Coche();
            auto.Marca = txtMarca.Text;
            auto.Modelo = txtModelo.Text;
            this.coches.Add(auto);
            this.txtMarca.Clear();
            this.txtMarca.Focus();
            this.txtModelo.Clear();
            this.PintarCoche();
        }

        public void PintarCoche()
        {
            this.lstCoches.Items.Clear();
            foreach(Coche auto in this.coches)
            {
                this.lstCoches.Items.Add(auto.Marca);
                this.txtModelo.Text = auto.Modelo;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {

        }
    }
}
