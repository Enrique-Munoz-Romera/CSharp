
namespace WindowsFormsAppClass
{
    partial class Form26PruebaDeClases
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
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearPersona = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDatos
            // 
            this.lstDatos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 20;
            this.lstDatos.Location = new System.Drawing.Point(45, 55);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(475, 364);
            this.lstDatos.TabIndex = 0;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(201, 27);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(62, 24);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Datos";
            // 
            // btnCrearPersona
            // 
            this.btnCrearPersona.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrearPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPersona.ForeColor = System.Drawing.Color.Coral;
            this.btnCrearPersona.Location = new System.Drawing.Point(545, 111);
            this.btnCrearPersona.Name = "btnCrearPersona";
            this.btnCrearPersona.Size = new System.Drawing.Size(110, 54);
            this.btnCrearPersona.TabIndex = 2;
            this.btnCrearPersona.Text = "Crear Persona";
            this.btnCrearPersona.UseVisualStyleBackColor = false;
            this.btnCrearPersona.Click += new System.EventHandler(this.btnCrearPersona_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(545, 193);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(110, 32);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Empleado";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // Form26PruebaDeClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnCrearPersona);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lstDatos);
            this.Name = "Form26PruebaDeClases";
            this.Text = "Form26PruebaDeClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearPersona;
        private System.Windows.Forms.Button btnEmployee;
    }
}