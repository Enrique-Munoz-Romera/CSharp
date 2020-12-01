using System;
using System.Collections.Generic;
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
            this.salariominimo = 1000;
        }
        #endregion

        public int GetSalarioMinimo()
        {
            return this.salariominimo;
        }
    }
}
