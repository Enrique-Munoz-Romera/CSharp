
namespace FundamentosForms
{
    partial class Form07DateTime
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
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.chkCambiarFormato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarFecha = new System.Windows.Forms.Button();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.lblIncremento = new System.Windows.Forms.Label();
            this.rdbAnyo = new System.Windows.Forms.RadioButton();
            this.rdbMeses = new System.Windows.Forms.RadioButton();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.lblNuevaFecha = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(12, 9);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(150, 25);
            this.lblFechaActual.TabIndex = 0;
            this.lblFechaActual.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(12, 37);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(483, 31);
            this.txtFechaActual.TabIndex = 1;
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(8, 359);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(483, 31);
            this.txtNuevaFecha.TabIndex = 2;
            // 
            // chkCambiarFormato
            // 
            this.chkCambiarFormato.AutoSize = true;
            this.chkCambiarFormato.Location = new System.Drawing.Point(12, 83);
            this.chkCambiarFormato.Name = "chkCambiarFormato";
            this.chkCambiarFormato.Size = new System.Drawing.Size(211, 29);
            this.chkCambiarFormato.TabIndex = 3;
            this.chkCambiarFormato.Text = "Cambiar Formato";
            this.chkCambiarFormato.UseVisualStyleBackColor = true;
            this.chkCambiarFormato.CheckedChanged += new System.EventHandler(this.chkCambiarFormato_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnMostrarFecha);
            this.groupBox1.Controls.Add(this.txtIncremento);
            this.groupBox1.Controls.Add(this.lblIncremento);
            this.groupBox1.Controls.Add(this.rdbAnyo);
            this.groupBox1.Controls.Add(this.rdbMeses);
            this.groupBox1.Controls.Add(this.rdbDias);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones Fecha";
            // 
            // btnMostrarFecha
            // 
            this.btnMostrarFecha.Location = new System.Drawing.Point(167, 121);
            this.btnMostrarFecha.Name = "btnMostrarFecha";
            this.btnMostrarFecha.Size = new System.Drawing.Size(194, 38);
            this.btnMostrarFecha.TabIndex = 9;
            this.btnMostrarFecha.Text = "Mostrar fecha";
            this.btnMostrarFecha.UseVisualStyleBackColor = true;
            this.btnMostrarFecha.Click += new System.EventHandler(this.btnMostrarFecha_Click);
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(248, 74);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(100, 31);
            this.txtIncremento.TabIndex = 8;
            // 
            // lblIncremento
            // 
            this.lblIncremento.AutoSize = true;
            this.lblIncremento.Location = new System.Drawing.Point(220, 27);
            this.lblIncremento.Name = "lblIncremento";
            this.lblIncremento.Size = new System.Drawing.Size(128, 25);
            this.lblIncremento.TabIndex = 7;
            this.lblIncremento.Text = "Incremento";
            // 
            // rdbAnyo
            // 
            this.rdbAnyo.AutoSize = true;
            this.rdbAnyo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbAnyo.Location = new System.Drawing.Point(6, 126);
            this.rdbAnyo.Name = "rdbAnyo";
            this.rdbAnyo.Size = new System.Drawing.Size(83, 29);
            this.rdbAnyo.TabIndex = 6;
            this.rdbAnyo.TabStop = true;
            this.rdbAnyo.Text = "Años";
            this.rdbAnyo.UseVisualStyleBackColor = false;
            // 
            // rdbMeses
            // 
            this.rdbMeses.AutoSize = true;
            this.rdbMeses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbMeses.Location = new System.Drawing.Point(6, 91);
            this.rdbMeses.Name = "rdbMeses";
            this.rdbMeses.Size = new System.Drawing.Size(99, 29);
            this.rdbMeses.TabIndex = 5;
            this.rdbMeses.TabStop = true;
            this.rdbMeses.Text = "Meses";
            this.rdbMeses.UseVisualStyleBackColor = false;
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbDias.Location = new System.Drawing.Point(6, 43);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(77, 29);
            this.rdbDias.TabIndex = 0;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Dias";
            this.rdbDias.UseVisualStyleBackColor = false;
            // 
            // lblNuevaFecha
            // 
            this.lblNuevaFecha.AutoSize = true;
            this.lblNuevaFecha.Location = new System.Drawing.Point(12, 320);
            this.lblNuevaFecha.Name = "lblNuevaFecha";
            this.lblNuevaFecha.Size = new System.Drawing.Size(151, 25);
            this.lblNuevaFecha.TabIndex = 5;
            this.lblNuevaFecha.Text = "Nueva Fecha";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(3, 410);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(98, 25);
            this.lblDatos.TabIndex = 6;
            this.lblDatos.Text = "lblDatos";
            // 
            // Form07DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 459);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblNuevaFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkCambiarFormato);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.lblFechaActual);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form07DateTime";
            this.Text = "Form07DateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.TextBox txtFechaActual;
        private System.Windows.Forms.TextBox txtNuevaFecha;
        private System.Windows.Forms.CheckBox chkCambiarFormato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarFecha;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Label lblIncremento;
        private System.Windows.Forms.RadioButton rdbAnyo;
        private System.Windows.Forms.RadioButton rdbMeses;
        private System.Windows.Forms.RadioButton rdbDias;
        private System.Windows.Forms.Label lblNuevaFecha;
        private System.Windows.Forms.Label lblDatos;
    }
}