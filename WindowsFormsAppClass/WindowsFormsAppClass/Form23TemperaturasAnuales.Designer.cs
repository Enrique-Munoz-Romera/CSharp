
namespace WindowsFormsAppClass
{
    partial class Form23TemperaturasAnuales
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
            this.lblMonths = new System.Windows.Forms.Label();
            this.lstMonth = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.lblTemperaturaMax = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTemperaturaMin = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTemperaturaInt = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMonths.Location = new System.Drawing.Point(57, 20);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(81, 25);
            this.lblMonths.TabIndex = 0;
            this.lblMonths.Text = "Meses";
            // 
            // lstMonth
            // 
            this.lstMonth.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lstMonth.FormattingEnabled = true;
            this.lstMonth.ItemHeight = 20;
            this.lstMonth.Location = new System.Drawing.Point(32, 50);
            this.lstMonth.Name = "lstMonth";
            this.lstMonth.Size = new System.Drawing.Size(215, 304);
            this.lstMonth.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Teal;
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(266, 50);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 37);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDetails.Location = new System.Drawing.Point(266, 98);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(110, 34);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Detalles";
            this.btnDetails.UseVisualStyleBackColor = false;
            // 
            // lblTemperaturaMax
            // 
            this.lblTemperaturaMax.AutoSize = true;
            this.lblTemperaturaMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperaturaMax.ForeColor = System.Drawing.Color.Red;
            this.lblTemperaturaMax.Location = new System.Drawing.Point(262, 150);
            this.lblTemperaturaMax.Name = "lblTemperaturaMax";
            this.lblTemperaturaMax.Size = new System.Drawing.Size(82, 24);
            this.lblTemperaturaMax.TabIndex = 4;
            this.lblTemperaturaMax.Text = "Máxima";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 26);
            this.textBox1.TabIndex = 5;
            // 
            // lblTemperaturaMin
            // 
            this.lblTemperaturaMin.AutoSize = true;
            this.lblTemperaturaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperaturaMin.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblTemperaturaMin.Location = new System.Drawing.Point(262, 227);
            this.lblTemperaturaMin.Name = "lblTemperaturaMin";
            this.lblTemperaturaMin.Size = new System.Drawing.Size(77, 24);
            this.lblTemperaturaMin.TabIndex = 6;
            this.lblTemperaturaMin.Text = "Mínima";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(266, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 26);
            this.textBox2.TabIndex = 7;
            // 
            // lblTemperaturaInt
            // 
            this.lblTemperaturaInt.AutoSize = true;
            this.lblTemperaturaInt.ForeColor = System.Drawing.Color.Blue;
            this.lblTemperaturaInt.Location = new System.Drawing.Point(262, 298);
            this.lblTemperaturaInt.Name = "lblTemperaturaInt";
            this.lblTemperaturaInt.Size = new System.Drawing.Size(95, 20);
            this.lblTemperaturaInt.TabIndex = 8;
            this.lblTemperaturaInt.Text = "Intermedia";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(266, 328);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 26);
            this.textBox3.TabIndex = 9;
            // 
            // Form23TemperaturasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 448);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblTemperaturaInt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblTemperaturaMin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTemperaturaMax);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lstMonth);
            this.Controls.Add(this.lblMonths);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form23TemperaturasAnuales";
            this.Text = "Form23TemperaturasAnuales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.ListBox lstMonth;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label lblTemperaturaMax;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTemperaturaMin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTemperaturaInt;
        private System.Windows.Forms.TextBox textBox3;
    }
}