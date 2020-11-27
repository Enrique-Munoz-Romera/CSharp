namespace WindowsFormsAppClass
{
    partial class Form22TablaMultiplicar
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
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.grpMultiplicar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGrpMul1 = new System.Windows.Forms.TextBox();
            this.txtGrpMul2 = new System.Windows.Forms.TextBox();
            this.txtGrpMul3 = new System.Windows.Forms.TextBox();
            this.txtGrpMul4 = new System.Windows.Forms.TextBox();
            this.txtGrpMul5 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.grpMultiplicar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(89, 36);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(85, 24);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Número";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(93, 63);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(128, 20);
            this.txtNum.TabIndex = 1;
            // 
            // grpMultiplicar
            // 
            this.grpMultiplicar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpMultiplicar.Controls.Add(this.txtGrpMul5);
            this.grpMultiplicar.Controls.Add(this.txtGrpMul4);
            this.grpMultiplicar.Controls.Add(this.txtGrpMul3);
            this.grpMultiplicar.Controls.Add(this.txtGrpMul2);
            this.grpMultiplicar.Controls.Add(this.txtGrpMul1);
            this.grpMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMultiplicar.Location = new System.Drawing.Point(267, 36);
            this.grpMultiplicar.Name = "grpMultiplicar";
            this.grpMultiplicar.Size = new System.Drawing.Size(261, 384);
            this.grpMultiplicar.TabIndex = 2;
            this.grpMultiplicar.TabStop = false;
            this.grpMultiplicar.Text = "Tabla de Multiplicar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(79, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tabla Multiplicar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtGrpMul1
            // 
            this.txtGrpMul1.Location = new System.Drawing.Point(21, 50);
            this.txtGrpMul1.Name = "txtGrpMul1";
            this.txtGrpMul1.Size = new System.Drawing.Size(100, 29);
            this.txtGrpMul1.TabIndex = 0;
            // 
            // txtGrpMul2
            // 
            this.txtGrpMul2.Location = new System.Drawing.Point(21, 103);
            this.txtGrpMul2.Name = "txtGrpMul2";
            this.txtGrpMul2.Size = new System.Drawing.Size(100, 29);
            this.txtGrpMul2.TabIndex = 1;
            // 
            // txtGrpMul3
            // 
            this.txtGrpMul3.Location = new System.Drawing.Point(21, 158);
            this.txtGrpMul3.Name = "txtGrpMul3";
            this.txtGrpMul3.Size = new System.Drawing.Size(100, 29);
            this.txtGrpMul3.TabIndex = 2;
            // 
            // txtGrpMul4
            // 
            this.txtGrpMul4.Location = new System.Drawing.Point(21, 215);
            this.txtGrpMul4.Name = "txtGrpMul4";
            this.txtGrpMul4.Size = new System.Drawing.Size(100, 29);
            this.txtGrpMul4.TabIndex = 3;
            // 
            // txtGrpMul5
            // 
            this.txtGrpMul5.Location = new System.Drawing.Point(21, 275);
            this.txtGrpMul5.Name = "txtGrpMul5";
            this.txtGrpMul5.Size = new System.Drawing.Size(100, 29);
            this.txtGrpMul5.TabIndex = 4;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Teal;
            this.btn2.Location = new System.Drawing.Point(93, 89);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(115, 27);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Generar";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form22TablaMultiplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(661, 485);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpMultiplicar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Name = "Form22TablaMultiplicar";
            this.Text = "Form22TablaMultiplicar";
            this.grpMultiplicar.ResumeLayout(false);
            this.grpMultiplicar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.GroupBox grpMultiplicar;
        private System.Windows.Forms.TextBox txtGrpMul5;
        private System.Windows.Forms.TextBox txtGrpMul4;
        private System.Windows.Forms.TextBox txtGrpMul3;
        private System.Windows.Forms.TextBox txtGrpMul2;
        private System.Windows.Forms.TextBox txtGrpMul1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn2;
    }
}