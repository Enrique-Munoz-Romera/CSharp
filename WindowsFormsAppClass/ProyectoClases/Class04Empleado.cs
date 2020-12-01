using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
   public class Class04Empleado: Class01Persona
    {
        #region CONSTRUCTOR
        public Class04Empleado()
        {
            Debug.WriteLine("Constructor vacio emp");
            this.salariominimo = 800;
        }

        public Class04Empleado(String nombre, String apellidos)
        {
            Debug.WriteLine("Constructor con 2 parametros emp");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        #endregion
        internal int salariominimo { get; set; }
    }
}
