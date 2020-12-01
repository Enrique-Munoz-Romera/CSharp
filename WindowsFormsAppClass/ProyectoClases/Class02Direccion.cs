using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
   public class Class02Direccion
    {
        # region COSTRUCTOR DE DIRECCION
        public Class02Direccion()
        {
            Debug.WriteLine("Constructor direccion simple");
        }

        //Podemos tener multiples constructores con el concepto de POLIMORFISMO
        public Class02Direccion(String calle, String ciudad)
        {
            //iniciamos las propiedades
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor direccion con 2 parametros");

        }

        public Class02Direccion(String calle, String ciudad,int cp):this(calle,ciudad)
        {
            //this.Calle = calle;
            //this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor direccion con 3 parametros");
        }
        #endregion
        //Cuando no deseamos comprobar valores de una propiedad
        // se utilizan propiedades que no tenemos que escribir el campo
        //esta dentro de la declaracion
        public String Calle { get; set; }
        public String Ciudad { get; set; }
        public int CodigoPostal { get; set; }
       
    }
}
