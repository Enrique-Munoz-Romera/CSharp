using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Productos
    {
        #region CONSTRUCTOR
        //public Productos(String nombres, int precio)
        //{
        //    this.Nombre = nombres;
        //    this.Precio = precio;
        //    Debug.WriteLine("Clase Producto(name): "+Nombre);
        //    Debug.WriteLine("Clase Producto(precio): " + Precio);
        //}
        #endregion
        public String Nombre { get; set; }
        public int Precio { get; set; }
    }
}
