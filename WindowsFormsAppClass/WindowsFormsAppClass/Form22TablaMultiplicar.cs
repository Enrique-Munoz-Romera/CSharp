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
    public partial class Form22TablaMultiplicar : Form
    {
        public Form22TablaMultiplicar()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i <= 10; i++)
            {
                int aleat = rand.Next(101);
                this.txtNum.Text = aleat.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNum.Text);
            
            for(int j = 1; j <= this.grpMultiplicar.Controls.Count; j++)
            {
                int multi = num * j ;
                this.grpMultiplicar.Controls[j-1].Text = multi.ToString();
            }
            
        }
    }
}
