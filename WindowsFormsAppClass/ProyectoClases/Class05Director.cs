using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Class05Director:Class04Empleado
    {
        #region CONSTRUCTOR
        public Class05Director()
        {
            this.SalarioMinimo += 200;
        }
        #endregion

        #region OVERRIDE METHOD
        //Con la palabra new se observa que se esta sobrescribiendo el metodo
        //public new int GetVacaciones()
        //{
        //    int vacas = base.GetVacaciones();
        //    Debug.WriteLine("getVacaciones() dir");
        //    return +3;
        //}

        //Otra manera de sobrescribir un metodo es preparandolo en la clase base VIRTUAL
        //y aqui en la clase que hereda se recoge con OVERRIDE
        public override int GetVacaciones()
        {
            int vacas = base.GetVacaciones();
        Debug.WriteLine("getVacaciones() dir");
            return vacas + 3;
        }

    //OVERLOAD
    public int GetVacaciones(int diasextras)
        {
            return this.GetVacaciones() + diasextras;
        }
        #endregion
    }
}
