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
            //Toda clase debemos instanciarla
            Class01Persona person = new Class01Persona();
            person.Nombre = "Adrian";
            person.Edad = 23;
            person.Genero = TipoGenero.Masculino;
            person.Nacionalidad = Paises.Argentina;
            person[0] = "Ojos verdes";
            person[1] = "Piel morena";
            person[2] = "Facciones Asiaticas";
            
            this.lstDatos.Items.Add("Nombre: " + person.Nombre);
            this.lstDatos.Items.Add("Edad: " + person.Edad);
            this.lstDatos.Items.Add("Genero: " + person.Genero);
            this.lstDatos.Items.Add("Pais: " + person.Nacionalidad);
            this.lstDatos.Items.Add("Descripcion: " + person[0]);
            this.lstDatos.Items.Add("Descripcion: " + person[1]);
            this.lstDatos.Items.Add("Nombre completo: " + person.GetNombreCompleto());
            person.Domicilio = new Class02Direccion();
            person.Domicilio.Calle = "Cristo de la victoria";
            this.lstDatos.Items.Add("Domicilio: " + person.Domicilio.Calle);
            person.DomicilioVacaciones = new Class02Direccion("canarias","spain",9876);
            //person.DomicilioVacaciones.Ciudad = "Cordoba";
            this.lstDatos.Items.Add("HouseHolidays: " + person.DomicilioVacaciones.Calle +" "+ person.DomicilioVacaciones.Ciudad +" "+ person.DomicilioVacaciones.CodigoPostal);
            //this.lstDatos.Items.Add("HouseHolidays: " + person.DomicilioVacaciones.Ciudad);
            //this.lstDatos.Items.Add("HouseHolidays: " + person.DomicilioVacaciones.CodigoPostal);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.lstDatos.Items.Clear();
            Class04Empleado emp = new Class04Empleado();
            emp.Nombre = "Empleado";
            emp.Apellidos = "Apellidos emp";
            this.lstDatos.Items.Add("Datos: " + emp.GetNombreCompleto());
            Class05Director dire = new Class05Director();
            this.lstDatos.Items.Add("Director: " + dire.GetSalarioMinimo());
            this.lstDatos.Items.Add("Empleado: " + emp);

        }
    }
}
