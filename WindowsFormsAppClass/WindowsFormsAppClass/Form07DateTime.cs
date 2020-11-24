using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosForms
{
    public partial class Form07DateTime : Form
    {
        public Form07DateTime()
        {
            InitializeComponent();
            this.txtFechaActual.Text = DateTime.Now.ToString();
        }

        private void chkCambiarFormato_CheckedChanged(object sender, EventArgs e)
        {
            //Recuperamos la fecha de la caja
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            //ahora preguntamos 
            if(this.chkCambiarFormato.Checked == true){
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
        }

        private void btnMostrarFecha_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if(rdbDias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }else if (this.rdbMeses.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else
            {
                fecha = fecha.AddYears(incremento);
            }          
            this.txtNuevaFecha.Text = fecha.ToString();
            this.lblDatos.Text = "Bisiesto: "
            + DateTime.IsLeapYear(fecha.Year) + "\nDía semana: " + fecha.DayOfWeek
            + "\nDía ano: " + fecha.DayOfYear;
        }
    }
}
