using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
   public class Class03Meses
    {
        #region CONSTRUCTOR
        public Class03Meses() { }

        public Class03Meses(String meses, int maxima, int minima)
        {
            this.Meses = meses;
            this.Maxima = maxima;
            this.Minima = minima;
        }
#endregion

        private String _Meses;
        public String Meses
        {
            get { return this._Meses; }
            set {this._Meses = value; }
        }
        public int Maxima { get; set; }
        public int Minima { get; set; }
        public double GetMedia()
        {
            return (this.Maxima + this.Minima) / 2;
        }
    }
}
