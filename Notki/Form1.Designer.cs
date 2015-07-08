namespace Notki
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zapiszZmianyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaNotkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDModyfikacji = new System.Windows.Forms.RadioButton();
            this.radioButtonDUtworzenia = new System.Windows.Forms.RadioButton();
            this.radioButtonWaznosc = new System.Windows.Forms.RadioButton();
            this.radioButtonTytul = new System.Windows.Forms.RadioButton();
            this.buttonSortuj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonZapiszZmiany = new System.Windows.Forms.Button();
            this.buttonUsunNotatke = new System.Windows.Forms.Button();
            this.buttonKoniec = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszZmianyToolStripMenuItem,
            this.nowaNotkaToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zapiszZmianyToolStripMenuItem
            // 
            this.zapiszZmianyToolStripMenuItem.Name = "zapiszZmianyToolStripMenuItem";
            this.zapiszZmianyToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.zapiszZmianyToolStripMenuItem.Text = "Zapisz zmiany";
            // 
            // nowaNotkaToolStripMenuItem
            // 
            this.nowaNotkaToolStripMenuItem.Name = "nowaNotkaToolStripMenuItem";
            this.nowaNotkaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.nowaNotkaToolStripMenuItem.Text = "Nowa notka";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(455, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel1.Text = "Notatek: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDModyfikacji);
            this.groupBox1.Controls.Add(this.radioButtonDUtworzenia);
            this.groupBox1.Controls.Add(this.radioButtonWaznosc);
            this.groupBox1.Controls.Add(this.radioButtonTytul);
            this.groupBox1.Controls.Add(this.buttonSortuj);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 417);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista notatek:";
            // 
            // radioButtonDModyfikacji
            // 
            this.radioButtonDModyfikacji.AutoSize = true;
            this.radioButtonDModyfikacji.Location = new System.Drawing.Point(6, 394);
            this.radioButtonDModyfikacji.Name = "radioButtonDModyfikacji";
            this.radioButtonDModyfikacji.Size = new System.Drawing.Size(100, 17);
            this.radioButtonDModyfikacji.TabIndex = 5;
            this.radioButtonDModyfikacji.TabStop = true;
            this.radioButtonDModyfikacji.Text = "daty modyfikacji";
            this.radioButtonDModyfikacji.UseVisualStyleBackColor = true;
            // 
            // radioButtonDUtworzenia
            // 
            this.radioButtonDUtworzenia.AutoSize = true;
            this.radioButtonDUtworzenia.Location = new System.Drawing.Point(6, 375);
            this.radioButtonDUtworzenia.Name = "radioButtonDUtworzenia";
            this.radioButtonDUtworzenia.Size = new System.Drawing.Size(99, 17);
            this.radioButtonDUtworzenia.TabIndex = 4;
            this.radioButtonDUtworzenia.TabStop = true;
            this.radioButtonDUtworzenia.Text = "daty utworzenia";
            this.radioButtonDUtworzenia.UseVisualStyleBackColor = true;
            // 
            // radioButtonWaznosc
            // 
            this.radioButtonWaznosc.AutoSize = true;
            this.radioButtonWaznosc.Location = new System.Drawing.Point(111, 394);
            this.radioButtonWaznosc.Name = "radioButtonWaznosc";
            this.radioButtonWaznosc.Size = new System.Drawing.Size(69, 17);
            this.radioButtonWaznosc.TabIndex = 3;
            this.radioButtonWaznosc.TabStop = true;
            this.radioButtonWaznosc.Text = "ważności";
            this.radioButtonWaznosc.UseVisualStyleBackColor = true;
            // 
            // radioButtonTytul
            // 
            this.radioButtonTytul.AutoSize = true;
            this.radioButtonTytul.Location = new System.Drawing.Point(111, 375);
            this.radioButtonTytul.Name = "radioButtonTytul";
            this.radioButtonTytul.Size = new System.Drawing.Size(52, 17);
            this.radioButtonTytul.TabIndex = 2;
            this.radioButtonTytul.TabStop = true;
            this.radioButtonTytul.Text = "tytułu";
            this.radioButtonTytul.UseVisualStyleBackColor = true;
            // 
            // buttonSortuj
            // 
            this.buttonSortuj.Location = new System.Drawing.Point(6, 341);
            this.buttonSortuj.Name = "buttonSortuj";
            this.buttonSortuj.Size = new System.Drawing.Size(187, 23);
            this.buttonSortuj.TabIndex = 1;
            this.buttonSortuj.Text = "Sortuj wg:";
            this.buttonSortuj.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 316);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(218, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 207);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Treść notatki:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 182);
            this.textBox1.TabIndex = 0;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(219, 241);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(224, 40);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "Nowa notatka";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonZapiszZmiany
            // 
            this.buttonZapiszZmiany.Location = new System.Drawing.Point(218, 287);
            this.buttonZapiszZmiany.Name = "buttonZapiszZmiany";
            this.buttonZapiszZmiany.Size = new System.Drawing.Size(224, 40);
            this.buttonZapiszZmiany.TabIndex = 7;
            this.buttonZapiszZmiany.Text = "Zapisz zmiany";
            this.buttonZapiszZmiany.UseVisualStyleBackColor = true;
            // 
            // buttonUsunNotatke
            // 
            this.buttonUsunNotatke.Location = new System.Drawing.Point(219, 333);
            this.buttonUsunNotatke.Name = "buttonUsunNotatke";
            this.buttonUsunNotatke.Size = new System.Drawing.Size(224, 40);
            this.buttonUsunNotatke.TabIndex = 8;
            this.buttonUsunNotatke.Text = "Usuń notatkę";
            this.buttonUsunNotatke.UseVisualStyleBackColor = true;
            // 
            // buttonKoniec
            // 
            this.buttonKoniec.Location = new System.Drawing.Point(217, 404);
            this.buttonKoniec.Name = "buttonKoniec";
            this.buttonKoniec.Size = new System.Drawing.Size(224, 40);
            this.buttonKoniec.TabIndex = 9;
            this.buttonKoniec.Text = "Zamknij";
            this.buttonKoniec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 470);
            this.Controls.Add(this.buttonKoniec);
            this.Controls.Add(this.buttonUsunNotatke);
            this.Controls.Add(this.buttonZapiszZmiany);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(471, 509);
            this.MinimumSize = new System.Drawing.Size(471, 509);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nowaNotkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem zapiszZmianyToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonZapiszZmiany;
        private System.Windows.Forms.Button buttonUsunNotatke;
        private System.Windows.Forms.Button buttonKoniec;
        private System.Windows.Forms.RadioButton radioButtonDModyfikacji;
        private System.Windows.Forms.RadioButton radioButtonDUtworzenia;
        private System.Windows.Forms.RadioButton radioButtonWaznosc;
        private System.Windows.Forms.RadioButton radioButtonTytul;
        private System.Windows.Forms.Button buttonSortuj;
    }
}

