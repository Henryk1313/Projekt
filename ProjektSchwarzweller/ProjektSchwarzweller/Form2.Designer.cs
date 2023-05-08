namespace ProjektSchwarzweller
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPOL = new System.Windows.Forms.TextBox();
            this.txtANG = new System.Windows.Forms.TextBox();
            this.btnDod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(27, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(311, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "WPISZ SLOWO PO POLSKU";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(27, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(409, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "WPISZ TO SLOWO PO ANGIELSKU";
            // 
            // txtPOL
            // 
            this.txtPOL.Location = new System.Drawing.Point(27, 98);
            this.txtPOL.Name = "txtPOL";
            this.txtPOL.Size = new System.Drawing.Size(507, 22);
            this.txtPOL.TabIndex = 2;
            // 
            // txtANG
            // 
            this.txtANG.Location = new System.Drawing.Point(27, 233);
            this.txtANG.Name = "txtANG";
            this.txtANG.Size = new System.Drawing.Size(507, 22);
            this.txtANG.TabIndex = 3;
            // 
            // btnDod
            // 
            this.btnDod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDod.Location = new System.Drawing.Point(183, 309);
            this.btnDod.Name = "btnDod";
            this.btnDod.Size = new System.Drawing.Size(132, 56);
            this.btnDod.TabIndex = 4;
            this.btnDod.Text = "DODAJ SLOWO";
            this.btnDod.UseVisualStyleBackColor = true;
            this.btnDod.Click += new System.EventHandler(this.btnDod_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btnDod);
            this.Controls.Add(this.txtANG);
            this.Controls.Add(this.txtPOL);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "DODAJ SLOWO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtPOL;
        private System.Windows.Forms.TextBox txtANG;
        private System.Windows.Forms.Button btnDod;
    }
}