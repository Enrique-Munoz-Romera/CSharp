using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
   public class Class01Persona
    {
        #region PROPIEDADES
        //Todo lo que pongamos aqui se podra colapsar y desplegar

        //Empezamos con campos de la clase
        //Suele ser privado y es una herramienta para la clase (ES UNA VARIABLE)
        //vamos a ver 2 modificadores de acceso, tiene que ver con la ENCAPSULACION [PUBLIC / PRIVATE]

        //public String Nombre;
        //public int Edad;

        //En visual studio no se crean campos accesibles siempre se crean propiedades
        //una propiedad es un campo, exactamente igual, 
        // donde nos permite controlar elementos de codigos(como los getter, setter de java)
        //si quieres dejar el acceso debe ser public.
        //Sintaxis de propiedad.

        //public TipoDato NombrePropiedad
        //{
        //    get
        //    {
        //Devolvemos un valor
        //        return valor;
        //    }
        //    set
        //    {
        //          Establecemos un valor
        //        //tenemos value para recuperar el dato
        //    }
        //}

        //Las propiedades siempre tendran un campo de control
        //el campo sera privado para la clase y sera el encargado 
        //de manejar la propiedad
        //Si nosotros lo deseamos asigno el campo, sino no lo hago 
        //Los campos de propiedad se reperesentan con _Propiedad
        private String _Nombre;
        //Asi la propiedad devueve el campo y evitaremos formar un bucle infinito (StackerOverFlow..)
        public String Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set 
            { 
                //Tenemos codigo para controlar los valores asignados a la propiedad
                if(value < 0)
                {
                    //Damos un valor por defecto ("Error silencioso")
                    //this._Edad = 0;

                    //Para lanzar una excepcion se utiliza
                    // throw new TipoException
                    //Clase base es Excepction
                    throw new Exception("Edad negativa: " + value);
                }
                else
                {
                    this._Edad = value; 
                }
            }
        }
        #endregion

    }
}
