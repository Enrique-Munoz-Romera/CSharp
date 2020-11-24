
namespace FundamentosForms
{
    partial class Form08Char
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.txtSimbolos = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(87, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(66, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Letras";
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(16, 62);
            this.txtLetras.Multiline = true;
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(257, 135);
            this.txtLetras.TabIndex = 1;
            // 
            // txtSimbolos
            // 
            this.txtSimbolos.Location = new System.Drawing.Point(336, 62);
            this.txtSimbolos.Multiline = true;
            this.txtSimbolos.Name = "txtSimbolos";
            this.txtSimbolos.Size = new System.Drawing.Size(277, 135);
            this.txtSimbolos.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(427, 29);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(96, 24);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Simbolos";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(16, 260);
            this.txtNumeros.Multiline = true;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(277, 135);
            this.txtNumeros.TabIndex = 5;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(87, 227);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(95, 24);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Números";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(355, 260);
            this.txtPuntuacion.Multiline = true;
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(277, 135);
            this.txtPuntuacion.TabIndex = 7;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(427, 227);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(115, 24);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Puntuación";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(639, 171);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(146, 62);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "Recorrer Ascis";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form08Char
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 432);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtSimbolos);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form08Char";
            this.Text = "Form08Char";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtLetras;
        private System.Windows.Forms.TextBox txtSimbolos;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btn1;
    }
}