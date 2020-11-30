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
        Button[] botones;
       
       
        public Form25SorteoPrimitiva()
        {
            InitializeComponent();
            this.botones = new Button[6] ;
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
            if (btn.BackColor == Color.Yellow )
            {
                botones = botones.Where(val => val != btn).ToArray();
                btn.BackColor = Color.FromKnownColor(KnownColor.HotTrack);
            }
            else
            {
                btn.BackColor = Color.Yellow;
                for(int i = 0; i<= (botones.Length-1); i++)
                {
                    if(botones[i] == null)
                    {
                        botones[i] = btn;
                        break;
                    }
                }
            }

            //if(btn.BackColor != Color.Yellow){
            //    btn.BackColor = Color.Yellow;
            //}
            //else
            //{
            //    btn.BackColor = Color.FromKnownColor(KnownColor.HotTrack);
            //}


        }
    }
}
