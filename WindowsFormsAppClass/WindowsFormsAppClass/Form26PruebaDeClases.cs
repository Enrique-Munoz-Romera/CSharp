using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace WindowsFormsAppClass
{
    public partial class Form26PruebaDeClases : Form
    {
        public Form26PruebaDeClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Class01Persona person = new Class01Persona();
            person.Nombre = "Adrian";
            person.Edad = -23;
            this.lstDatos.Items.Add("Nombre: " + person.Nombre);
            this.lstDatos.Items.Add("Edad: " + person.Edad);

        }
    }
}
