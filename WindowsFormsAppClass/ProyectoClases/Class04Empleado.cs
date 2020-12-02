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
        public Class04Empleado() : base()
        {
            Debug.WriteLine("Constructor vacio emp");
            this.SalarioMinimo = 1000;
        }

        public Class04Empleado(String nombre, String apellidos):base(nombre,apellidos)
        {
            Debug.WriteLine("Constructor con 2 parametros emp");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        #endregion

        #region PROPIEDADES
        //public int SalarioMinimo { get; set; }
        //internal int SalarioMinimo { get; set; }
        protected int SalarioMinimo { get; set; }
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        #endregion

        #region METODOS DE CLASE EMPLEADO
        //Con la palabra VIRTUAL indicamos que ese metodo está preparado para ser sobrescrito
        public virtual int GetVacaciones()
        {
            Debug.WriteLine("Get Vacaciones() emp");
            return 22;
        }
        #endregion
    }
}
