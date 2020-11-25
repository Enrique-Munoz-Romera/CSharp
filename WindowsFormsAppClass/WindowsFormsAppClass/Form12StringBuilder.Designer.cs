namespace WindowsFormsAppClass
{
    partial class Form12StringBuilder
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
            this.richTexto = new System.Windows.Forms.RichTextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnReverseString = new System.Windows.Forms.Button();
            this.btnReverseStringBuilder = new System.Windows.Forms.Button();
            this.lblColeccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTexto
            // 
            this.richTexto.Location = new System.Drawing.Point(54, 47);
            this.richTexto.Name = "richTexto";
            this.richTexto.Size = new System.Drawing.Size(391, 279);
            this.richTexto.TabIndex = 0;
            this.richTexto.Text = "";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(116, 19);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(71, 25);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Texto";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Red;
            this.lblTiempo.Location = new System.Drawing.Point(116, 329);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(114, 25);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "lblTiempo";
            // 
            // btnReverseString
            // 
            this.btnReverseString.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReverseString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverseString.Location = new System.Drawing.Point(473, 102);
            this.btnReverseString.Name = "btnReverseString";
            this.btnReverseString.Size = new System.Drawing.Size(153, 58);
            this.btnReverseString.TabIndex = 3;
            this.btnReverseString.Text = "Reverse String";
            this.btnReverseString.UseVisualStyleBackColor = false;
            this.btnReverseString.Click += new System.EventHandler(this.btnReverseString_Click);
            // 
            // btnReverseStringBuilder
            // 
            this.btnReverseStringBuilder.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReverseStringBuilder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverseStringBuilder.Location = new System.Drawing.Point(473, 211);
            this.btnReverseStringBuilder.Name = "btnReverseStringBuilder";
            this.btnReverseStringBuilder.Size = new System.Drawing.Size(153, 55);
            this.btnReverseStringBuilder.TabIndex = 4;
            this.btnReverseStringBuilder.Text = "Reverse String Builder";
            this.btnReverseStringBuilder.UseVisualStyleBackColor = false;
            this.btnReverseStringBuilder.Click += new System.EventHandler(this.btnReverseStringBuilder_Click);
            // 
            // lblColeccion
            // 
            this.lblColeccion.AutoSize = true;
            this.lblColeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccion.Location = new System.Drawing.Point(121, 393);
            this.lblColeccion.Name = "lblColeccion";
            this.lblColeccion.Size = new System.Drawing.Size(170, 24);
            this.lblColeccion.TabIndex = 5;
            this.lblColeccion.Text = "Teoria Coleccion";
            // 
            // Form12StringBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblColeccion);
            this.Controls.Add(this.btnReverseStringBuilder);
            this.Controls.Add(this.btnReverseString);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.richTexto);
            this.Name = "Form12StringBuilder";
            this.Text = "Form12StringBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnReverseString;
        private System.Windows.Forms.Button btnReverseStringBuilder;
        private System.Windows.Forms.Label lblColeccion;
    }
}