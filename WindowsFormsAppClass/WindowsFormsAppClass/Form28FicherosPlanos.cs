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

namespace WindowsFormsAppClass
{
    public partial class Form28FicherosPlanos : Form
    {
        public Form28FicherosPlanos()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            //Todos ellos nos va a devolver DIALOGRESULT y nos lo dara ShowDialog();
            DialogResult respuesta = save.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                String path = save.FileName;
                //La clase fileInfo sirve para manejar cualquier tipo de archivo
                //Ofrece informacion del fichero 
                FileInfo file = new FileInfo(path);
                //a parit del FileInfo podemos ccrear objs para leer en bytes o planos.
                //Vamos a utilizar using para crear el obj,utilizarlo y destruirlo a la vez.
                //Para leerlo como texto plano tenemosTextWriter/  CreateText()nos devuelve y nos crea el obj
                using (TextWriter writer = file.CreateText())
                {
                    //escribir
                    //writer.Write(this.txtTexto.Text);
                    await writer.WriteAsync(this.GetStringNombres());
                    //Independiente a texto plano o bytes,
                    //al escribir debemos liberar el flujo de memoria .Flush() y cerrar .Close()el fichero 
                    //si no hago esto puede que no se ejecute correctamente.
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstNom.Items.Clear();
                this.txtTexto.Text = "";
            }
        }

        private async void btnLeerFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult respuesta = open.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                String path = open.FileName;
                FileInfo file = new FileInfo(path);
                using (TextReader reader = file.OpenText())
                {
                    String contenido = await reader.ReadToEndAsync();
                    reader.Close();
                    this.txtTexto.Text = contenido;
                    this.SetStringNombres(contenido);
                }
                
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            String nombre = this.txtNom.Text;
            this.lstNom.Items.Add(nombre);
            this.txtNom.Text = "";
            this.txtNom.Focus();
        }

        public String GetStringNombres()
        {
            String datos = "";
            foreach(String nombre in this.lstNom.Items)
            {
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;

        }

        public void SetStringNombres(String data)
        {
            String[] nombres = data.Split(',');
            this.lstNom.Items.Clear();
            foreach(String nombre in nombres)
            {
                this.lstNom.Items.Add(nombre);
            }            
        }
    }
}
