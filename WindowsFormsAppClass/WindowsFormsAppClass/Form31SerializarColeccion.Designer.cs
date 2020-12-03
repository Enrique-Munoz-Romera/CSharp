namespace WindowsFormsAppClass
{
    partial class Form31SerializarColeccion
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
            this.lstProducto = new System.Windows.Forms.ListBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProducto
            // 
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.ItemHeight = 16;
            this.lstProducto.Location = new System.Drawing.Point(399, 53);
            this.lstProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(233, 228);
            this.lstProducto.TabIndex = 23;
            this.lstProducto.SelectedIndexChanged += new System.EventHandler(this.lstProducto_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(477, 33);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(70, 16);
            this.lblProduct.TabIndex = 22;
            this.lblProduct.Text = "Producto";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(214, 101);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 33);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(296, 53);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(74, 35);
            this.btnRead.TabIndex = 20;
            this.btnRead.Text = "Leer";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(214, 53);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(74, 35);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "Insertar";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(38, 112);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(114, 22);
            this.txtPrecio.TabIndex = 18;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(35, 92);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 16);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Precio";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(38, 53);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(168, 22);
            this.txtNom.TabIndex = 16;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(35, 33);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(63, 16);
            this.lblNom.TabIndex = 15;
            this.lblNom.Text = "Nombre";
            // 
            // Form31SerializarColeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 454);
            this.Controls.Add(this.lstProducto);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form31SerializarColeccion";
            this.Text = "Form31SerializarColeccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstProducto;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
    }
}