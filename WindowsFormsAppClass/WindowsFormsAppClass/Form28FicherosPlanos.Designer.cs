
namespace WindowsFormsAppClass
{
    partial class Form28FicherosPlanos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.btnLeerFile = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lstNom = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(103, 47);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(238, 29);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Introduzca un texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(85, 79);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(306, 387);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.Text = "";
            // 
            // btnLeerFile
            // 
            this.btnLeerFile.Location = new System.Drawing.Point(423, 113);
            this.btnLeerFile.Name = "btnLeerFile";
            this.btnLeerFile.Size = new System.Drawing.Size(239, 49);
            this.btnLeerFile.TabIndex = 2;
            this.btnLeerFile.Text = "Leer Fichero";
            this.btnLeerFile.UseVisualStyleBackColor = true;
            this.btnLeerFile.Click += new System.EventHandler(this.btnLeerFile_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(434, 192);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(217, 55);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Fichero";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(749, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(700, 86);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(247, 35);
            this.txtNom.TabIndex = 5;
            // 
            // lstNom
            // 
            this.lstNom.FormattingEnabled = true;
            this.lstNom.ItemHeight = 29;
            this.lstNom.Location = new System.Drawing.Point(700, 145);
            this.lstNom.Name = "lstNom";
            this.lstNom.Size = new System.Drawing.Size(247, 323);
            this.lstNom.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(961, 86);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(147, 44);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Form28FicherosPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 498);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lstNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLeerFile);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form28FicherosPlanos";
            this.Text = "Form28FicherosPlanos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.Button btnLeerFile;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ListBox lstNom;
        private System.Windows.Forms.Button btnNew;
    }
}