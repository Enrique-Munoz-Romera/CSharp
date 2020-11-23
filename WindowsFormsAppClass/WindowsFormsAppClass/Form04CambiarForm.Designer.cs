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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtNum5 = new System.Windows.Forms.TextBox();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(63, 37);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Posicion X:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(63, 96);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(60, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Posicion Y:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(192, 29);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(192, 89);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(442, 29);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(29, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Rojo";
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(555, 29);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(100, 20);
            this.txtNum3.TabIndex = 5;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(441, 95);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(35, 13);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Verde";
            // 
            // txtNum4
            // 
            this.txtNum4.Location = new System.Drawing.Point(555, 95);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(100, 20);
            this.txtNum4.TabIndex = 7;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(444, 161);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(27, 13);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "Azul";
            // 
            // txtNum5
            // 
            this.txtNum5.Location = new System.Drawing.Point(555, 153);
            this.txtNum5.Name = "txtNum5";
            this.txtNum5.Size = new System.Drawing.Size(100, 20);
            this.txtNum5.TabIndex = 9;
            // 
            // btnPosicion
            // 
            this.btnPosicion.BackColor = System.Drawing.Color.Yellow;
            this.btnPosicion.Location = new System.Drawing.Point(192, 188);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(100, 35);
            this.btnPosicion.TabIndex = 10;
            this.btnPosicion.Text = "Posicion";
            this.btnPosicion.UseVisualStyleBackColor = false;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Lime;
            this.btnColor.Location = new System.Drawing.Point(555, 231);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 30);
            this.btnColor.TabIndex = 11;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // Form04CambiarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.txtNum5);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form04CambiarForm";
            this.Text = "Form04CambiarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnColor;
    }
}