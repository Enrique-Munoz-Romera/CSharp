namespace WindowsFormsAppClass
{
    partial class Form27PracticaMesesConClase
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.lstMonths = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblMinima = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblIntermedio = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(157, 28);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(71, 24);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Meses";
            // 
            // lstMonths
            // 
            this.lstMonths.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstMonths.ForeColor = System.Drawing.Color.Yellow;
            this.lstMonths.FormattingEnabled = true;
            this.lstMonths.ItemHeight = 24;
            this.lstMonths.Location = new System.Drawing.Point(57, 55);
            this.lstMonths.Name = "lstMonths";
            this.lstMonths.Size = new System.Drawing.Size(296, 364);
            this.lstMonths.TabIndex = 1;
            this.lstMonths.SelectedIndexChanged += new System.EventHandler(this.lstMonths_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(370, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 29);
            this.textBox1.TabIndex = 3;
            // 
            // lblMaxima
            // 
            this.lblMaxima.AutoSize = true;
            this.lblMaxima.ForeColor = System.Drawing.Color.Red;
            this.lblMaxima.Location = new System.Drawing.Point(374, 126);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(110, 24);
            this.lblMaxima.TabIndex = 4;
            this.lblMaxima.Text = "ºC Maxima";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(374, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 29);
            this.textBox2.TabIndex = 5;
            // 
            // lblMinima
            // 
            this.lblMinima.AutoSize = true;
            this.lblMinima.ForeColor = System.Drawing.Color.Purple;
            this.lblMinima.Location = new System.Drawing.Point(374, 208);
            this.lblMinima.Name = "lblMinima";
            this.lblMinima.Size = new System.Drawing.Size(105, 24);
            this.lblMinima.TabIndex = 6;
            this.lblMinima.Text = "ºC Minima";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(374, 235);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 29);
            this.textBox3.TabIndex = 7;
            // 
            // lblIntermedio
            // 
            this.lblIntermedio.AutoSize = true;
            this.lblIntermedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblIntermedio.Location = new System.Drawing.Point(374, 283);
            this.lblIntermedio.Name = "lblIntermedio";
            this.lblIntermedio.Size = new System.Drawing.Size(95, 24);
            this.lblIntermedio.TabIndex = 8;
            this.lblIntermedio.Text = "ºC Media";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(374, 310);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 29);
            this.textBox4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(374, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form27PracticaMesesConClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(608, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblIntermedio);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblMinima);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblMaxima);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstMonths);
            this.Controls.Add(this.lblMonth);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form27PracticaMesesConClase";
            this.Text = "Form27PracticaMesesConClase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ListBox lstMonths;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMaxima;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblMinima;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblIntermedio;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
    }
}