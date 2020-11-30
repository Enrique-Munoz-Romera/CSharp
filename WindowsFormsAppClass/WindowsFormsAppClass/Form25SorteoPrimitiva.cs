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
    public partial class Form25SorteoPrimitiva : Form
    {
        
       
        public Form25SorteoPrimitiva()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {            
            int posX = 10;
            int posY = 10;
            for (int i = 1; i <= 20; i++)
            {
                //INSTANCIAMOS El CONTROL QUE QERAMOS PINTAR DINAMICAMENTE
                Button btn = new Button();
                btn.Text = i.ToString();                
                btn.AutoSize = true;
                btn.Location = new Point(posX,posY);
                if(i % 4 == 0)
                {
                    posX = 10;
                    posY += 50;
                }
                else
                {
                    posX += 80;
                }
                this.pnlNumeros.Controls.Add(btn);
                btn.Click += Seleccionado;
            }

        }

        private void Seleccionado(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Yellow;
            
        }
    }
}
