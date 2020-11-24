namespace WindowsFormsAppClass
{
    partial class Form04CambiarForm
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtPosx = new System.Windows.Forms.TextBox();
            this.txtPosy = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(34, 35);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(87, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Posicion X:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(34, 137);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(87, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Posicion Y:";
            // 
            // txtPosx
            // 
            this.txtPosx.Location = new System.Drawing.Point(192, 35);
            this.txtPosx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPosx.Name = "txtPosx";
            this.txtPosx.Size = new System.Drawing.Size(148, 26);
            this.txtPosx.TabIndex = 2;
            // 
            // txtPosy
            // 
            this.txtPosy.Location = new System.Drawing.Point(192, 140);
            this.txtPosy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPosy.Name = "txtPosy";
            this.txtPosy.Size = new System.Drawing.Size(148, 26);
            this.txtPosy.TabIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(438, 35);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(42, 20);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Rojo";
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(517, 35);
            this.txtRojo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(148, 26);
            this.txtRojo.TabIndex = 5;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(438, 137);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(52, 20);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Verde";
            // 
            // txtVerde
            // 
            this.txtVerde.Location = new System.Drawing.Point(517, 131);
            this.txtVerde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(148, 26);
            this.txtVerde.TabIndex = 7;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(438, 238);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(40, 20);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "Azul";
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(517, 232);
            this.txtAzul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(148, 26);
            this.txtAzul.TabIndex = 9;
            // 
            // btnPosicion
            // 
            this.btnPosicion.BackColor = System.Drawing.Color.Yellow;
            this.btnPosicion.Location = new System.Drawing.Point(192, 261);
            this.btnPosicion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(150, 54);
            this.btnPosicion.TabIndex = 10;
            this.btnPosicion.Text = "Posicion";
            this.btnPosicion.UseVisualStyleBackColor = false;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Lime;
            this.btnColor.Location = new System.Drawing.Point(517, 309);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(150, 46);
            this.btnColor.TabIndex = 11;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form04CambiarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 570);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtVerde);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtRojo);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtPosy);
            this.Controls.Add(this.txtPosx);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form04CambiarForm";
            this.Text = "Form04CambiarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtPosx;
        private System.Windows.Forms.TextBox txtPosy;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtVerde;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtAzul;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnColor;
    }
}