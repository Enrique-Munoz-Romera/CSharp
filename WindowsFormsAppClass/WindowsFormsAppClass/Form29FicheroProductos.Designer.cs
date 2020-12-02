
namespace WindowsFormsAppClass
{
    partial class Form29FicheroProductos
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lstProducto = new System.Windows.Forms.ListBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(26, 26);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(107, 29);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nombre";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(18, 58);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(176, 35);
            this.txtNom.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 141);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 29);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(12, 176);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(182, 35);
            this.txtPrecio.TabIndex = 3;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(228, 58);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(133, 45);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "Insertar";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(228, 119);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(133, 51);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Leer";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(228, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(460, 22);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(118, 29);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "Producto";
            // 
            // lstProducto
            // 
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.ItemHeight = 29;
            this.lstProducto.Location = new System.Drawing.Point(406, 58);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(369, 381);
            this.lstProducto.TabIndex = 8;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 275);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(147, 48);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Text = "Primero";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(182, 350);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(147, 47);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(16, 350);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 47);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(182, 276);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(147, 47);
            this.btnLast.TabIndex = 12;
            this.btnLast.Text = "Ultimo";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(26, 446);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(197, 29);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Producto 1 de 5";
            // 
            // Form29FicheroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 553);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lstProducto);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form29FicheroProductos";
            this.Text = "Form29FicheroProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ListBox lstProducto;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblResult;
    }
}