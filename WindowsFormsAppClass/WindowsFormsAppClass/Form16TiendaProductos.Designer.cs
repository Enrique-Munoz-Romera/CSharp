
namespace WindowsFormsAppClass
{
    partial class Form16TiendaProductos
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTienda = new System.Windows.Forms.Label();
            this.lstTienda = new System.Windows.Forms.ListBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnSeleccionado = new System.Windows.Forms.Button();
            this.lstAlmacen = new System.Windows.Forms.ListBox();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(31, 27);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(137, 32);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(37, 73);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(230, 39);
            this.txtProducto.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Lime;
            this.btnInsertar.Location = new System.Drawing.Point(37, 130);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(153, 51);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(37, 272);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(153, 47);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.Location = new System.Drawing.Point(37, 201);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(153, 55);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(37, 338);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(153, 52);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Location = new System.Drawing.Point(315, 27);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(109, 32);
            this.lblTienda.TabIndex = 6;
            this.lblTienda.Text = "Tienda";
            // 
            // lstTienda
            // 
            this.lstTienda.FormattingEnabled = true;
            this.lstTienda.ItemHeight = 32;
            this.lstTienda.Location = new System.Drawing.Point(321, 73);
            this.lstTienda.Name = "lstTienda";
            this.lstTienda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTienda.Size = new System.Drawing.Size(255, 324);
            this.lstTienda.TabIndex = 7;
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTodos.Location = new System.Drawing.Point(614, 272);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(167, 47);
            this.btnTodos.TabIndex = 8;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnSeleccionado
            // 
            this.btnSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeleccionado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionado.Location = new System.Drawing.Point(614, 188);
            this.btnSeleccionado.Name = "btnSeleccionado";
            this.btnSeleccionado.Size = new System.Drawing.Size(167, 46);
            this.btnSeleccionado.TabIndex = 9;
            this.btnSeleccionado.Text = "Seleccion";
            this.btnSeleccionado.UseVisualStyleBackColor = false;
            this.btnSeleccionado.Click += new System.EventHandler(this.btnSeleccionado_Click);
            // 
            // lstAlmacen
            // 
            this.lstAlmacen.FormattingEnabled = true;
            this.lstAlmacen.ItemHeight = 32;
            this.lstAlmacen.Location = new System.Drawing.Point(819, 73);
            this.lstAlmacen.Name = "lstAlmacen";
            this.lstAlmacen.Size = new System.Drawing.Size(262, 324);
            this.lstAlmacen.TabIndex = 10;
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.AutoSize = true;
            this.lblAlmacen.Location = new System.Drawing.Point(813, 27);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(133, 32);
            this.lblAlmacen.TabIndex = 11;
            this.lblAlmacen.Text = "Almacen";
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(1121, 144);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(168, 47);
            this.btnSubir.TabIndex = 12;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(1121, 272);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(168, 47);
            this.btnBajar.TabIndex = 13;
            this.btnBajar.Text = "Bajar";
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // Form16TiendaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1511, 720);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.lblAlmacen);
            this.Controls.Add(this.lstAlmacen);
            this.Controls.Add(this.btnSeleccionado);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.lstTienda);
            this.Controls.Add(this.lblTienda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblProducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form16TiendaProductos";
            this.Text = "Form16TiendaProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.ListBox lstTienda;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnSeleccionado;
        private System.Windows.Forms.ListBox lstAlmacen;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnBajar;
    }
}