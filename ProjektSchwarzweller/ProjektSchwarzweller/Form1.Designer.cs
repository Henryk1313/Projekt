namespace ProjektSchwarzweller
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDoTlum = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTlum = new System.Windows.Forms.TextBox();
            this.buttonTlum = new System.Windows.Forms.Button();
            this.rbuttPolAng = new System.Windows.Forms.RadioButton();
            this.rbuttAngPol = new System.Windows.Forms.RadioButton();
            this.chbox_podp = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txtilosc = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(575, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(213, 290);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.nowyToolStripMenuItem.Text = "&Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.zapiszToolStripMenuItem.Text = "Z&apisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.zapiszJakoToolStripMenuItem.Text = "&Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(263, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.zamknijToolStripMenuItem.Text = "Zamkni&j";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.oProgramieToolStripMenuItem.Text = "&O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Podaj slowo do tlumaczenia";
            // 
            // txtDoTlum
            // 
            this.txtDoTlum.Location = new System.Drawing.Point(26, 92);
            this.txtDoTlum.Name = "txtDoTlum";
            this.txtDoTlum.Size = new System.Drawing.Size(242, 22);
            this.txtDoTlum.TabIndex = 3;
            this.txtDoTlum.TextChanged += new System.EventHandler(this.txtDoTlum_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(91, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Tlumaczenie";
            // 
            // txtTlum
            // 
            this.txtTlum.Location = new System.Drawing.Point(26, 173);
            this.txtTlum.Name = "txtTlum";
            this.txtTlum.ReadOnly = true;
            this.txtTlum.Size = new System.Drawing.Size(242, 22);
            this.txtTlum.TabIndex = 5;
            this.txtTlum.TextChanged += new System.EventHandler(this.txtTlum_TextChanged);
            // 
            // buttonTlum
            // 
            this.buttonTlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTlum.Location = new System.Drawing.Point(318, 173);
            this.buttonTlum.Name = "buttonTlum";
            this.buttonTlum.Size = new System.Drawing.Size(146, 56);
            this.buttonTlum.TabIndex = 6;
            this.buttonTlum.Text = "TLUMACZ";
            this.buttonTlum.UseVisualStyleBackColor = true;
            this.buttonTlum.Click += new System.EventHandler(this.buttonTlum_Click);
            // 
            // rbuttPolAng
            // 
            this.rbuttPolAng.AutoSize = true;
            this.rbuttPolAng.Checked = true;
            this.rbuttPolAng.Location = new System.Drawing.Point(318, 115);
            this.rbuttPolAng.Name = "rbuttPolAng";
            this.rbuttPolAng.Size = new System.Drawing.Size(141, 20);
            this.rbuttPolAng.TabIndex = 7;
            this.rbuttPolAng.TabStop = true;
            this.rbuttPolAng.Text = "Polski na Angielski";
            this.rbuttPolAng.UseVisualStyleBackColor = true;
            this.rbuttPolAng.CheckedChanged += new System.EventHandler(this.rbuttPolAng_CheckedChanged);
            // 
            // rbuttAngPol
            // 
            this.rbuttAngPol.AutoSize = true;
            this.rbuttAngPol.Location = new System.Drawing.Point(318, 141);
            this.rbuttAngPol.Name = "rbuttAngPol";
            this.rbuttAngPol.Size = new System.Drawing.Size(141, 20);
            this.rbuttAngPol.TabIndex = 8;
            this.rbuttAngPol.TabStop = true;
            this.rbuttAngPol.Text = "Angielski na Polski";
            this.rbuttAngPol.UseVisualStyleBackColor = true;
            this.rbuttAngPol.CheckedChanged += new System.EventHandler(this.rbuttAngPol_CheckedChanged);
            // 
            // chbox_podp
            // 
            this.chbox_podp.AutoSize = true;
            this.chbox_podp.Location = new System.Drawing.Point(287, 55);
            this.chbox_podp.Name = "chbox_podp";
            this.chbox_podp.Size = new System.Drawing.Size(109, 20);
            this.chbox_podp.TabIndex = 9;
            this.chbox_podp.Text = "Podpowiadaj";
            this.chbox_podp.UseVisualStyleBackColor = true;
            this.chbox_podp.CheckedChanged += new System.EventHandler(this.chbox_podp_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(44, 291);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(131, 28);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "1 - dodaj slowo\r\n";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(44, 325);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(131, 28);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "2 - usun slowo\r\n";
            // 
            // numUD
            // 
            this.numUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUD.Location = new System.Drawing.Point(193, 302);
            this.numUD.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(61, 41);
            this.numUD.TabIndex = 12;
            this.numUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(287, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "ZMIEN BAZE DANYCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtilosc
            // 
            this.txtilosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtilosc.Location = new System.Drawing.Point(575, 50);
            this.txtilosc.Name = "txtilosc";
            this.txtilosc.ReadOnly = true;
            this.txtilosc.Size = new System.Drawing.Size(213, 34);
            this.txtilosc.TabIndex = 14;
            this.txtilosc.Text = "ILOSC SLOW: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.txtilosc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numUD);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.chbox_podp);
            this.Controls.Add(this.rbuttAngPol);
            this.Controls.Add(this.rbuttPolAng);
            this.Controls.Add(this.buttonTlum);
            this.Controls.Add(this.txtTlum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtDoTlum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TLUMACZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDoTlum;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTlum;
        private System.Windows.Forms.Button buttonTlum;
        private System.Windows.Forms.RadioButton rbuttPolAng;
        private System.Windows.Forms.RadioButton rbuttAngPol;
        private System.Windows.Forms.CheckBox chbox_podp;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.NumericUpDown numUD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtilosc;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

