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
    public partial class Form04CambiarForm : Form
    {
        public Form04CambiarForm()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int posx = int.Parse(this.txtPosx.Text);
            int posy = int.Parse(this.txtPosy.Text);
            this.btnPosicion.Location = new Point(posx, posy);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int azul = int.Parse(this.txtAzul.Text);
            int verde = int.Parse(this.txtVerde.Text);
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
