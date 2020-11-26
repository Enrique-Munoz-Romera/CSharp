namespace WindowsFormsAppClass
{
    partial class Form14SeleccionMultipleListBox
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
            this.lblSeleccionados = new System.Windows.Forms.Label();
            this.lblIndices = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblElemento = new System.Windows.Forms.Label();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.lblElementos = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSeleccionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccionados
            // 
            this.lblSeleccionados.AutoSize = true;
            this.lblSeleccionados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSeleccionados.Location = new System.Drawing.Point(15, 368);
            this.lblSeleccionados.Name = "lblSeleccionados";
            this.lblSeleccionados.Size = new System.Drawing.Size(186, 29);
            this.lblSeleccionados.TabIndex = 19;
            this.lblSeleccionados.Text = "Seleccionados";
            // 
            // lblIndices
            // 
            this.lblIndices.AutoSize = true;
            this.lblIndices.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndices.Location = new System.Drawing.Point(15, 308);
            this.lblIndices.Name = "lblIndices";
            this.lblIndices.Size = new System.Drawing.Size(97, 29);
            this.lblIndices.TabIndex = 18;
            this.lblIndices.Text = "Indices";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsertar.ForeColor = System.Drawing.Color.Lime;
            this.btnInsertar.Location = new System.Drawing.Point(318, 125);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(131, 33);
            this.btnInsertar.TabIndex = 14;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(318, 70);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(253, 35);
            this.txtElemento.TabIndex = 13;
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(360, 31);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(124, 29);
            this.lblElemento.TabIndex = 12;
            this.lblElemento.Text = "Elemento";
            // 
            // lstElementos
            // 
            this.lstElementos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 29;
            this.lstElementos.Location = new System.Drawing.Point(19, 70);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstElementos.Size = new System.Drawing.Size(199, 178);
            this.lstElementos.TabIndex = 11;
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(15, 31);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(137, 29);
            this.lblElementos.TabIndex = 10;
            this.lblElementos.Text = "Elementos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(318, 240);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 34);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSeleccionado
            // 
            this.btnSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeleccionado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSeleccionado.Location = new System.Drawing.Point(318, 179);
            this.btnSeleccionado.Name = "btnSeleccionado";
            this.btnSeleccionado.Size = new System.Drawing.Size(131, 37);
            this.btnSeleccionado.TabIndex = 20;
            this.btnSeleccionado.Text = "Seleccionado";
            this.btnSeleccionado.UseVisualStyleBackColor = false;
            this.btnSeleccionado.Click += new System.EventHandler(this.btnSeleccionado_Click);
            // 
            // Form14SeleccionMultipleListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 439);
            this.Controls.Add(this.btnSeleccionado);
            this.Controls.Add(this.lblSeleccionados);
            this.Controls.Add(this.lblIndices);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.lblElementos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form14SeleccionMultipleListBox";
            this.Text = "Form14SeleccionMultipleListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionados;
        private System.Windows.Forms.Label lblIndices;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSeleccionado;
    }
}