namespace WindowsFormsAppClass
{
    partial class Form32PracticaCoches
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
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblCoches = new System.Windows.Forms.Label();
            this.lstCoches = new System.Windows.Forms.ListBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // pct1
            // 
            this.pct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct1.Location = new System.Drawing.Point(25, 165);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(208, 237);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pct1.TabIndex = 0;
            this.pct1.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(22, 20);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 18);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(25, 41);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(208, 24);
            this.txtMarca.TabIndex = 2;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(22, 88);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(64, 18);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(25, 109);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(208, 24);
            this.txtModelo.TabIndex = 4;
            // 
            // lblCoches
            // 
            this.lblCoches.AutoSize = true;
            this.lblCoches.Location = new System.Drawing.Point(329, 24);
            this.lblCoches.Name = "lblCoches";
            this.lblCoches.Size = new System.Drawing.Size(66, 18);
            this.lblCoches.TabIndex = 5;
            this.lblCoches.Text = "Coches";
            // 
            // lstCoches
            // 
            this.lstCoches.FormattingEnabled = true;
            this.lstCoches.ItemHeight = 18;
            this.lstCoches.Location = new System.Drawing.Point(278, 45);
            this.lstCoches.Name = "lstCoches";
            this.lstCoches.Size = new System.Drawing.Size(235, 220);
            this.lstCoches.TabIndex = 6;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(278, 302);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(81, 26);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "Insertar";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(380, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 26);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(380, 346);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(98, 29);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "Load File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(278, 346);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(81, 29);
            this.btnImage.TabIndex = 10;
            this.btnImage.Text = "Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // Form32PracticaCoches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 439);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lstCoches);
            this.Controls.Add(this.lblCoches);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.pct1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form32PracticaCoches";
            this.Text = "Form32PracticaCoches";
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblCoches;
        private System.Windows.Forms.ListBox lstCoches;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnImage;
    }
}