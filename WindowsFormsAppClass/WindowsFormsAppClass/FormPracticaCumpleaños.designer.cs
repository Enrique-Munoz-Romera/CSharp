
namespace FundamentosForms
{
    partial class FormPracticaCumpleaños
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
            this.btnCalcularDia = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblAnyo = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnyo = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularDia
            // 
            this.btnCalcularDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalcularDia.Location = new System.Drawing.Point(37, 167);
            this.btnCalcularDia.Name = "btnCalcularDia";
            this.btnCalcularDia.Size = new System.Drawing.Size(102, 43);
            this.btnCalcularDia.TabIndex = 0;
            this.btnCalcularDia.Text = "Calcular";
            this.btnCalcularDia.UseVisualStyleBackColor = false;
            this.btnCalcularDia.Click += new System.EventHandler(this.btnCalcularDia_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(60, 28);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(40, 24);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Día";
            // 
            // lblAnyo
            // 
            this.lblAnyo.AutoSize = true;
            this.lblAnyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnyo.Location = new System.Drawing.Point(60, 115);
            this.lblAnyo.Name = "lblAnyo";
            this.lblAnyo.Size = new System.Drawing.Size(48, 24);
            this.lblAnyo.TabIndex = 2;
            this.lblAnyo.Text = "Año";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(60, 74);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(49, 24);
            this.lblMes.TabIndex = 3;
            this.lblMes.Text = "Mes";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(211, 28);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 4;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(211, 74);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 5;
            // 
            // txtAnyo
            // 
            this.txtAnyo.Location = new System.Drawing.Point(211, 120);
            this.txtAnyo.Name = "txtAnyo";
            this.txtAnyo.Size = new System.Drawing.Size(100, 20);
            this.txtAnyo.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Aqua;
            this.lblResultado.Location = new System.Drawing.Point(206, 185);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(118, 25);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // FormPracticaCumpleaños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 323);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtAnyo);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblAnyo);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.btnCalcularDia);
            this.Name = "FormPracticaCumpleaños";
            this.Text = "FormPracticaCumpleaños";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblAnyo;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnyo;
        private System.Windows.Forms.Label lblResultado;
    }
}