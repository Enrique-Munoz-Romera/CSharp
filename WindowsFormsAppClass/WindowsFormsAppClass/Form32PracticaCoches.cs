using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsAppClass
{
    public partial class Form32PracticaCoches : Form
    {
        ColeccionCoches coches;
        XmlSerializer serial;
        int indice;
        string path;

        public Form32PracticaCoches()
        {
            InitializeComponent();
            this.coches = new ColeccionCoches();
            this.serial = new XmlSerializer(typeof(ColeccionCoches));
            this.indice = 0;
            this.path = "../../Images/simpson.jpg";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Coche auto = new Coche();
            auto.Marca = txtMarca.Text;
            auto.Modelo = txtModelo.Text;
            Image imagen = Image.FromFile(path);
            using (var ms = new MemoryStream())
            {
                imagen.Save(ms, imagen.RawFormat);
                auto.Imagen = ms.ToArray();
            }
            this.coches.Add(auto);
            this.txtMarca.Clear();
            this.txtMarca.Focus();
            this.txtModelo.Clear();
            this.PintarCoche();
        }

        public void PintarCoche()
        {
            this.lstCoches.Items.Clear();
            foreach(Coche auto in this.coches)
            {
                this.lstCoches.Items.Add(auto.Marca + " --> " + auto.Modelo);
                //this.lstCoches.Items.Add(auto.Modelo);
                this.pct1.Image = Image.FromFile(path);
            }
            this.lstCoches.SelectedIndex = this.indice;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("listaCoches2.xml");
            this.serial.Serialize(writer,coches);
            await writer.FlushAsync();
            writer.Close();
            this.coches.Clear();
            this.lstCoches.Items.Clear();            
            MessageBox.Show("Save successfuly");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listaCoches2.xml");
            //Realizamos el casting para la desserializacion
            this.coches = (ColeccionCoches)this.serial.Deserialize(reader);
            reader.Close();
            this.PintarCoche();

        }       

        private void btnImage_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listaCoches2.xml");
            this.coches = (ColeccionCoches)this.serial.Deserialize(reader);
            reader.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.indice += 1;  
            if(this.indice >= this.coches.Count)
            {
                this.indice = 0;
            }
            this.PintarCoche();
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            this.indice -= 1;
            if(this.indice < 0)
            {
                this.indice = this.coches.Count - 1 ;
            }
            this.PintarCoche();
        }
    }
}
