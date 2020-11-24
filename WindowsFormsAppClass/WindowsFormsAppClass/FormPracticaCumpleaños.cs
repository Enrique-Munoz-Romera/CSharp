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
    public partial class FormPracticaCumpleaños : Form
    {
        public FormPracticaCumpleaños()
        {
            InitializeComponent();
        }

        private void btnCalcularDia_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anyo = int.Parse(this.txtAnyo.Text);
            if(mes == 1)
            {
                mes = 13;
                anyo -= 1;
            }else if (mes == 2)
            {
                mes = 14;
                anyo -=  1;
            }
            int primerPaso = ((mes + 1) * 3 )/ 5;
            int segundoPaso = anyo / 4;
            int tercerPaso = anyo / 100;
            int cuartoPaso = anyo / 400;
            int quintoPaso = dia + (mes * 2) + anyo + primerPaso + segundoPaso + tercerPaso + cuartoPaso + 2;
            int sextoPaso = quintoPaso / 7;
            int septimoPaso = quintoPaso - (sextoPaso * 7);
            switch (septimoPaso)
            {
                case 0:
                    this.lblResultado.Text = "Sabado";
                    break;

                case 1:
                    this.lblResultado.Text = "Domingo";
                    break;

                case 2:
                    this.lblResultado.Text = "Lunes";
                    break;

                case 3:
                    this.lblResultado.Text = "Martes";
                    break;

                case 4:
                    this.lblResultado.Text = "Miercoles";
                    break;

                case 5:
                    this.lblResultado.Text = "Jueves";
                    break;

                case 6:
                    this.lblResultado.Text = "Viernes";
                    break;

                default:
                    this.lblResultado.Text = "Error";
                    break;
            }
        }
    }
}
