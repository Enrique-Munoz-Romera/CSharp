namespace WindowsFormsAppClass
{
    partial class Form20MetodosEventoColecciones
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.chkAsociarMetodos = new System.Windows.Forms.CheckBox();
            this.lblNumeroEventos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(121, 51);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 33);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "btn1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(121, 101);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 31);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "btn2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(121, 151);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 35);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "btn3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // chkAsociarMetodos
            // 
            this.chkAsociarMetodos.AutoSize = true;
            this.chkAsociarMetodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAsociarMetodos.Location = new System.Drawing.Point(111, 12);
            this.chkAsociarMetodos.Name = "chkAsociarMetodos";
            this.chkAsociarMetodos.Size = new System.Drawing.Size(162, 24);
            this.chkAsociarMetodos.TabIndex = 3;
            this.chkAsociarMetodos.Text = "Asociar Metodos";
            this.chkAsociarMetodos.UseVisualStyleBackColor = true;
            this.chkAsociarMetodos.CheckedChanged += new System.EventHandler(this.chkAsociarMetodos_CheckedChanged);
            // 
            // lblNumeroEventos
            // 
            this.lblNumeroEventos.AutoSize = true;
            this.lblNumeroEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEventos.Location = new System.Drawing.Point(250, 60);
            this.lblNumeroEventos.Name = "lblNumeroEventos";
            this.lblNumeroEventos.Size = new System.Drawing.Size(102, 24);
            this.lblNumeroEventos.TabIndex = 4;
            this.lblNumeroEventos.Text = "Nº Events";
            // 
            // Form20MetodosEventoColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(515, 329);
            this.Controls.Add(this.lblNumeroEventos);
            this.Controls.Add(this.chkAsociarMetodos);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form20MetodosEventoColecciones";
            this.Text = "Form20MetodosEventoColecciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.CheckBox chkAsociarMetodos;
        private System.Windows.Forms.Label lblNumeroEventos;
    }
}