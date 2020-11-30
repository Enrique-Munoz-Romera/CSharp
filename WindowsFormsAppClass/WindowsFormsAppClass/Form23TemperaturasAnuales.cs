using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppClass
{
    public partial class Form23TemperaturasAnuales : Form
    {
        public Form23TemperaturasAnuales()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            String[] months = new String[]{"Enero","Febrero","Marzo","Abril","Mayo",
                "Junio","Julio","Agosto","Septiembre","Octubre","Novimebre","Diciembre"};
            Random rnd = new Random();
           
            if(this.lstMonth.Items.Count == 0)
            {
                for (int ctr = 1; ctr <= 12; ctr++)
                {
                    int aleat = rnd.Next(-20,45);
                    this.lstMonth.Items.Add(months[ctr - 1] + " " + aleat);
                }
            }
        }
    }
}
