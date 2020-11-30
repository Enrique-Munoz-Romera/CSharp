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
    public partial class Form24ControlesEnEjecucion : Form
    {
        public Form24ControlesEnEjecucion()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int posX = 0;
            for(int i = 1; i <= 5; i++)
            {
                 //Instanciamos control chk
                CheckBox chk = new CheckBox();
                chk.Text = rnd.Next(1, 50).ToString();
                chk.AutoSize = true;
                chk.Location = new Point(posX, 10);
                posX += 70;
                this.panel1.Controls.Add(chk);
                chk.CheckedChanged += RealizarOperacion;

            }
        }

        private void RealizarOperacion(object sender, EventArgs e)
        {
            int valor = int.Parse(this.txtValor.Text);
            CheckBox chk = (CheckBox)sender;
            int num = int.Parse(chk.Text);
            if(chk.Checked == true)
            {
                valor += num;
            }
            else
            {
                valor -= num;
            }
            this.txtValor.Text = valor.ToString();
        }
    }
}
