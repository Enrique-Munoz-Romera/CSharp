
namespace WindowsFormsAppClass
{
    partial class Form25SorteoPrimitiva
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
            this.pnlNumeros = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnLucky = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlNumeros
            // 
            this.pnlNumeros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNumeros.Location = new System.Drawing.Point(41, 78);
            this.pnlNumeros.Name = "pnlNumeros";
            this.pnlNumeros.Size = new System.Drawing.Size(384, 266);
            this.pnlNumeros.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciar.Location = new System.Drawing.Point(464, 57);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(104, 36);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnLucky
            // 
            this.btnLucky.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLucky.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnLucky.Location = new System.Drawing.Point(464, 141);
            this.btnLucky.Name = "btnLucky";
            this.btnLucky.Size = new System.Drawing.Size(104, 34);
            this.btnLucky.TabIndex = 2;
            this.btnLucky.Text = "Sortear";
            this.btnLucky.UseVisualStyleBackColor = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(19, 37);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(337, 24);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Bienvenido al sorteo de la Primitiva";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(464, 195);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 149);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Los números Ganadores se representan en Verde. Los seleccionados en Amarillo. Los" +
    " fallados en Rojo";
            // 
            // Form25SorteoPrimitiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1061, 541);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnLucky);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pnlNumeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form25SorteoPrimitiva";
            this.Text = "Form25SorteoPrimitiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNumeros;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnLucky;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox textBox1;
    }
}