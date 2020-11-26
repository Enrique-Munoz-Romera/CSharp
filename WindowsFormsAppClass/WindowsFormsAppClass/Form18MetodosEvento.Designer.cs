
namespace WindowsFormsAppClass
{
    partial class Form18MetodosEvento
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
            this.lblNum = new System.Windows.Forms.Label();
            this.lblLetras = new System.Windows.Forms.Label();
            this.lblRaton = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(49, 62);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(180, 29);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Solo Numeros";
            // 
            // lblLetras
            // 
            this.lblLetras.AutoSize = true;
            this.lblLetras.Location = new System.Drawing.Point(49, 139);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(146, 29);
            this.lblLetras.TabIndex = 1;
            this.lblLetras.Text = "Solo Letras";
            // 
            // lblRaton
            // 
            this.lblRaton.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblRaton.Location = new System.Drawing.Point(148, 235);
            this.lblRaton.Name = "lblRaton";
            this.lblRaton.Size = new System.Drawing.Size(410, 268);
            this.lblRaton.TabIndex = 2;
            this.lblRaton.Text = "label2";
            this.lblRaton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 35);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 35);
            this.textBox2.TabIndex = 4;
            // 
            // Form18MetodosEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 653);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRaton);
            this.Controls.Add(this.lblLetras);
            this.Controls.Add(this.lblNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form18MetodosEvento";
            this.Text = "Form18MetodosEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblLetras;
        private System.Windows.Forms.Label lblRaton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}