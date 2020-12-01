using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    #region ENUMERACIONES
    public enum TipoGenero
    {
        Masculino = 0, Femenino = 1
    }

    public enum Paises
    {
        España = 0, Inglaterra = 1, Francia = 2, Argentina = 3
    }
    #endregion
    public class Class01Persona
    {

        #region CONSTRUCTORES
        public Class01Persona()
        {
            Debug.WriteLine("Constructor de Persona Vacio");
        }
        #endregion

        public Class01Persona(String nombre, String apellidos)
        {
            Debug.WriteLine("Constructor de Persona con parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        public Class01Persona(int edad, String nombre, String apellidos)
        {
            Debug.WriteLine("Constructor de Persona con 3 parametros");
        }

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
        //Si nosotros lo deseamos asignamos el campo, sino no lo hago 
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

        private String _Apellidos;
        public String Apellidos
        {
            get
            {
                return this._Apellidos;
            }
            set
            {
                this._Apellidos = value;
            }
        }

        private TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set {
                //Debemos controlar siemre los valores
                //de las enumeraciones para ver si coincides con nuestras ops
                if(value != TipoGenero.Femenino &&
                    value != TipoGenero.Masculino)
                {
                    throw new Exception("Rango de genero no soportado");
                }
                this._Genero = value; 
            }
        }

        private Paises _Nacionalidad;
        public Paises Nacionalidad
        {
            get { return this._Nacionalidad; }
            set { this._Nacionalidad = value; }
        }

        //una propiedad indizada contienen multiples elements
        //Necesitamos un campo para manejar la propiedad
        //Yo quiero crear una propiedad que contenga por ejemplo
        //espacio para 5 descripciones de la persona
        private String[] _Descripciones = new String[5];
        //Un campo indizado (propiedad indizada) no tiene NAME
        //SE UTILIZA LA PABRA THIS para crearla
        public String this[int indice]
        {
            get { return this._Descripciones[indice];}
            set { this._Descripciones[indice] = value; }
        }

        //Propiedad extendida cn la dir de casa
        private Class02Direccion _Domicilio;
        public Class02Direccion Domicilio
        {
            get { return this._Domicilio; }
            set { this._Domicilio = value; }
        }

        //Hacemos una propiedad autoimplementada
        public Class02Direccion DomicilioVacaciones { get; set; }
        #endregion

        #region METODOS  de la clase persona
        //Tenemos metodos VOID y RETURN
        //Podemos tener metodos con parametros opcionales
        public void MetodoParametrosOpcionales(int numero,
            int parametroopocional = 99 )
        {

        }
        //Sobrecarga de un metodo
        //Un metodo tiene diferentes formas,
        //tienen diferentes codigos
        //El metodo debe llamarse igual y tener distintos parametros y tipos
        public String GetNombreCompleto()
        {
            return this.Nombre + "," + this.Apellidos;
        }

        public String GetNombreCompleto(bool ordenacion)
        {
            if (ordenacion == true)
            {
                return this.Apellidos + "," + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }

        public void GetNombreCompleto(int numero)
        {

        }

        public String GetNombreCompleto(int valor, int otro) 
        {
            return this.GetNombreCompleto().ToUpper();
        }
        #endregion

    }

}
