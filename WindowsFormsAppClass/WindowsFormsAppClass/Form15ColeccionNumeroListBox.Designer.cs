
namespace WindowsFormsAppClass
{
    partial class Form15ColeccionNumeroListBox
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
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblPares = new System.Windows.Forms.Label();
            this.lblImpares = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtPares = new System.Windows.Forms.TextBox();
            this.txtImpares = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(87, 62);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(136, 32);
            this.lblNumeros.TabIndex = 0;
            this.lblNumeros.Text = "Numeros";
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 32;
            this.lstNumeros.Location = new System.Drawing.Point(12, 105);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(269, 388);
            this.lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(433, 45);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(207, 68);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(433, 140);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(209, 74);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(302, 255);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(93, 32);
            this.lblSuma.TabIndex = 4;
            this.lblSuma.Text = "Suma";
            // 
            // lblPares
            // 
            this.lblPares.AutoSize = true;
            this.lblPares.Location = new System.Drawing.Point(312, 363);
            this.lblPares.Name = "lblPares";
            this.lblPares.Size = new System.Drawing.Size(94, 32);
            this.lblPares.TabIndex = 5;
            this.lblPares.Text = "Pares";
            // 
            // lblImpares
            // 
            this.lblImpares.AutoSize = true;
            this.lblImpares.Location = new System.Drawing.Point(302, 461);
            this.lblImpares.Name = "lblImpares";
            this.lblImpares.Size = new System.Drawing.Size(123, 32);
            this.lblImpares.TabIndex = 6;
            this.lblImpares.Text = "Impares";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(433, 248);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(209, 39);
            this.txtSuma.TabIndex = 7;
            // 
            // txtPares
            // 
            this.txtPares.Location = new System.Drawing.Point(433, 356);
            this.txtPares.Name = "txtPares";
            this.txtPares.Size = new System.Drawing.Size(209, 39);
            this.txtPares.TabIndex = 8;
            // 
            // txtImpares
            // 
            this.txtImpares.Location = new System.Drawing.Point(431, 454);
            this.txtImpares.Name = "txtImpares";
            this.txtImpares.Size = new System.Drawing.Size(209, 39);
            this.txtImpares.TabIndex = 9;
            // 
            // Form15ColeccionNumeroListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 720);
            this.Controls.Add(this.txtImpares);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.lblImpares);
            this.Controls.Add(this.lblPares);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.lblNumeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form15ColeccionNumeroListBox";
            this.Text = "Form15ColeccionNumeroListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblPares;
        private System.Windows.Forms.Label lblImpares;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox txtPares;
        private System.Windows.Forms.TextBox txtImpares;
    }
}