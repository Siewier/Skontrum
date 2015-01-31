namespace Skontrum
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnNoweSkontrum = new System.Windows.Forms.Button();
            this.btnWczytajSkontrum = new System.Windows.Forms.Button();
            this.gbStart = new System.Windows.Forms.GroupBox();
            this.gbDodaj = new System.Windows.Forms.GroupBox();
            this.btnUbytki = new System.Windows.Forms.Button();
            this.btnWypozyczone = new System.Windows.Forms.Button();
            this.btnZPolki = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.btnTabela = new System.Windows.Forms.Button();
            this.btnPodsumowanie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEksportuj = new System.Windows.Forms.Button();
            this.btnDrukuj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnInfo = new System.Windows.Forms.Button();
            this.gbStart.SuspendLayout();
            this.gbDodaj.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNoweSkontrum
            // 
            this.btnNoweSkontrum.Location = new System.Drawing.Point(8, 23);
            this.btnNoweSkontrum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNoweSkontrum.Name = "btnNoweSkontrum";
            this.btnNoweSkontrum.Size = new System.Drawing.Size(147, 28);
            this.btnNoweSkontrum.TabIndex = 0;
            this.btnNoweSkontrum.Text = "Nowe skontrum";
            this.btnNoweSkontrum.UseVisualStyleBackColor = true;
            this.btnNoweSkontrum.Click += new System.EventHandler(this.btnNoweSkontrum_Click);
            // 
            // btnWczytajSkontrum
            // 
            this.btnWczytajSkontrum.Location = new System.Drawing.Point(192, 23);
            this.btnWczytajSkontrum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWczytajSkontrum.Name = "btnWczytajSkontrum";
            this.btnWczytajSkontrum.Size = new System.Drawing.Size(147, 28);
            this.btnWczytajSkontrum.TabIndex = 1;
            this.btnWczytajSkontrum.Text = "Wczytaj skontrum";
            this.btnWczytajSkontrum.UseVisualStyleBackColor = true;
            this.btnWczytajSkontrum.Click += new System.EventHandler(this.btnWczytajSkontrum_Click);
            // 
            // gbStart
            // 
            this.gbStart.Controls.Add(this.btnNoweSkontrum);
            this.gbStart.Controls.Add(this.btnWczytajSkontrum);
            this.gbStart.Location = new System.Drawing.Point(16, 15);
            this.gbStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStart.Name = "gbStart";
            this.gbStart.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStart.Size = new System.Drawing.Size(347, 68);
            this.gbStart.TabIndex = 2;
            this.gbStart.TabStop = false;
            this.gbStart.Text = "Start";
            // 
            // gbDodaj
            // 
            this.gbDodaj.Controls.Add(this.btnUbytki);
            this.gbDodaj.Controls.Add(this.btnWypozyczone);
            this.gbDodaj.Controls.Add(this.btnZPolki);
            this.gbDodaj.Location = new System.Drawing.Point(16, 91);
            this.gbDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDodaj.Name = "gbDodaj";
            this.gbDodaj.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDodaj.Size = new System.Drawing.Size(347, 105);
            this.gbDodaj.TabIndex = 3;
            this.gbDodaj.TabStop = false;
            this.gbDodaj.Text = "Dodawanie";
            // 
            // btnUbytki
            // 
            this.btnUbytki.Enabled = false;
            this.btnUbytki.Location = new System.Drawing.Point(101, 60);
            this.btnUbytki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUbytki.Name = "btnUbytki";
            this.btnUbytki.Size = new System.Drawing.Size(145, 28);
            this.btnUbytki.TabIndex = 2;
            this.btnUbytki.Text = "Ubytki";
            this.btnUbytki.UseVisualStyleBackColor = true;
            this.btnUbytki.Click += new System.EventHandler(this.btnUbytki_Click);
            // 
            // btnWypozyczone
            // 
            this.btnWypozyczone.Enabled = false;
            this.btnWypozyczone.Location = new System.Drawing.Point(192, 25);
            this.btnWypozyczone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWypozyczone.Name = "btnWypozyczone";
            this.btnWypozyczone.Size = new System.Drawing.Size(147, 28);
            this.btnWypozyczone.TabIndex = 1;
            this.btnWypozyczone.Text = "Wypożyczone";
            this.btnWypozyczone.UseVisualStyleBackColor = true;
            this.btnWypozyczone.Click += new System.EventHandler(this.btnWypozyczone_Click);
            // 
            // btnZPolki
            // 
            this.btnZPolki.Enabled = false;
            this.btnZPolki.Location = new System.Drawing.Point(9, 25);
            this.btnZPolki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZPolki.Name = "btnZPolki";
            this.btnZPolki.Size = new System.Drawing.Size(145, 28);
            this.btnZPolki.TabIndex = 0;
            this.btnZPolki.Text = "Z półki";
            this.btnZPolki.UseVisualStyleBackColor = true;
            this.btnZPolki.Click += new System.EventHandler(this.btnZPolki_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.btnTabela);
            this.gbStatus.Controls.Add(this.btnPodsumowanie);
            this.gbStatus.Location = new System.Drawing.Point(16, 204);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStatus.Size = new System.Drawing.Size(347, 68);
            this.gbStatus.TabIndex = 4;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // btnTabela
            // 
            this.btnTabela.Enabled = false;
            this.btnTabela.Location = new System.Drawing.Point(192, 25);
            this.btnTabela.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(147, 28);
            this.btnTabela.TabIndex = 1;
            this.btnTabela.Text = "Tabela";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // btnPodsumowanie
            // 
            this.btnPodsumowanie.Enabled = false;
            this.btnPodsumowanie.Location = new System.Drawing.Point(8, 25);
            this.btnPodsumowanie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPodsumowanie.Name = "btnPodsumowanie";
            this.btnPodsumowanie.Size = new System.Drawing.Size(147, 28);
            this.btnPodsumowanie.TabIndex = 0;
            this.btnPodsumowanie.Text = "Podsumowanie";
            this.btnPodsumowanie.UseVisualStyleBackColor = true;
            this.btnPodsumowanie.Click += new System.EventHandler(this.btnPodsumowanie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEksportuj);
            this.groupBox1.Controls.Add(this.btnDrukuj);
            this.groupBox1.Controls.Add(this.btnZapisz);
            this.groupBox1.Location = new System.Drawing.Point(16, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(347, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zapisywanie";
            // 
            // btnEksportuj
            // 
            this.btnEksportuj.Enabled = false;
            this.btnEksportuj.Location = new System.Drawing.Point(8, 62);
            this.btnEksportuj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEksportuj.Name = "btnEksportuj";
            this.btnEksportuj.Size = new System.Drawing.Size(331, 28);
            this.btnEksportuj.TabIndex = 2;
            this.btnEksportuj.Text = "Eksportuj do MS Excel";
            this.btnEksportuj.UseVisualStyleBackColor = true;
            this.btnEksportuj.Click += new System.EventHandler(this.btnEksportuj_Click);
            // 
            // btnDrukuj
            // 
            this.btnDrukuj.Enabled = false;
            this.btnDrukuj.Location = new System.Drawing.Point(192, 25);
            this.btnDrukuj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDrukuj.Name = "btnDrukuj";
            this.btnDrukuj.Size = new System.Drawing.Size(147, 28);
            this.btnDrukuj.TabIndex = 1;
            this.btnDrukuj.Text = "Drukuj";
            this.btnDrukuj.UseVisualStyleBackColor = true;
            this.btnDrukuj.Click += new System.EventHandler(this.btnDrukuj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Enabled = false;
            this.btnZapisz.Location = new System.Drawing.Point(8, 25);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(147, 28);
            this.btnZapisz.TabIndex = 0;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"Pliki XML|*.xml|Wszystkie|*.*\"";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(25, 388);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(329, 28);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "O programie";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 426);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbDodaj);
            this.Controls.Add(this.gbStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Skontrum 1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbStart.ResumeLayout(false);
            this.gbDodaj.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoweSkontrum;
        private System.Windows.Forms.Button btnWczytajSkontrum;
        private System.Windows.Forms.GroupBox gbStart;
        private System.Windows.Forms.GroupBox gbDodaj;
        private System.Windows.Forms.Button btnUbytki;
        private System.Windows.Forms.Button btnWypozyczone;
        private System.Windows.Forms.Button btnZPolki;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Button btnTabela;
        private System.Windows.Forms.Button btnPodsumowanie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEksportuj;
        private System.Windows.Forms.Button btnDrukuj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnInfo;
    }
}

