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
            this.gbStart.SuspendLayout();
            this.gbDodaj.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNoweSkontrum
            // 
            this.btnNoweSkontrum.Location = new System.Drawing.Point(6, 19);
            this.btnNoweSkontrum.Name = "btnNoweSkontrum";
            this.btnNoweSkontrum.Size = new System.Drawing.Size(110, 23);
            this.btnNoweSkontrum.TabIndex = 0;
            this.btnNoweSkontrum.Text = "Nowe skontrum";
            this.btnNoweSkontrum.UseVisualStyleBackColor = true;
            this.btnNoweSkontrum.Click += new System.EventHandler(this.btnNoweSkontrum_Click);
            // 
            // btnWczytajSkontrum
            // 
            this.btnWczytajSkontrum.Location = new System.Drawing.Point(144, 19);
            this.btnWczytajSkontrum.Name = "btnWczytajSkontrum";
            this.btnWczytajSkontrum.Size = new System.Drawing.Size(110, 23);
            this.btnWczytajSkontrum.TabIndex = 1;
            this.btnWczytajSkontrum.Text = "Wczytaj skontrum";
            this.btnWczytajSkontrum.UseVisualStyleBackColor = true;
            // 
            // gbStart
            // 
            this.gbStart.Controls.Add(this.btnNoweSkontrum);
            this.gbStart.Controls.Add(this.btnWczytajSkontrum);
            this.gbStart.Location = new System.Drawing.Point(12, 12);
            this.gbStart.Name = "gbStart";
            this.gbStart.Size = new System.Drawing.Size(260, 55);
            this.gbStart.TabIndex = 2;
            this.gbStart.TabStop = false;
            this.gbStart.Text = "Start";
            // 
            // gbDodaj
            // 
            this.gbDodaj.Controls.Add(this.btnUbytki);
            this.gbDodaj.Controls.Add(this.btnWypozyczone);
            this.gbDodaj.Controls.Add(this.btnZPolki);
            this.gbDodaj.Location = new System.Drawing.Point(12, 74);
            this.gbDodaj.Name = "gbDodaj";
            this.gbDodaj.Size = new System.Drawing.Size(260, 85);
            this.gbDodaj.TabIndex = 3;
            this.gbDodaj.TabStop = false;
            this.gbDodaj.Text = "Dodawanie";
            // 
            // btnUbytki
            // 
            this.btnUbytki.Location = new System.Drawing.Point(76, 49);
            this.btnUbytki.Name = "btnUbytki";
            this.btnUbytki.Size = new System.Drawing.Size(109, 23);
            this.btnUbytki.TabIndex = 2;
            this.btnUbytki.Text = "Ubytki";
            this.btnUbytki.UseVisualStyleBackColor = true;
            this.btnUbytki.Click += new System.EventHandler(this.btnUbytki_Click);
            // 
            // btnWypozyczone
            // 
            this.btnWypozyczone.Location = new System.Drawing.Point(144, 20);
            this.btnWypozyczone.Name = "btnWypozyczone";
            this.btnWypozyczone.Size = new System.Drawing.Size(110, 23);
            this.btnWypozyczone.TabIndex = 1;
            this.btnWypozyczone.Text = "Wypożyczone";
            this.btnWypozyczone.UseVisualStyleBackColor = true;
            this.btnWypozyczone.Click += new System.EventHandler(this.btnWypozyczone_Click);
            // 
            // btnZPolki
            // 
            this.btnZPolki.Location = new System.Drawing.Point(7, 20);
            this.btnZPolki.Name = "btnZPolki";
            this.btnZPolki.Size = new System.Drawing.Size(109, 23);
            this.btnZPolki.TabIndex = 0;
            this.btnZPolki.Text = "Z półki";
            this.btnZPolki.UseVisualStyleBackColor = true;
            this.btnZPolki.Click += new System.EventHandler(this.btnZPolki_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.btnTabela);
            this.gbStatus.Controls.Add(this.btnPodsumowanie);
            this.gbStatus.Location = new System.Drawing.Point(12, 166);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(260, 55);
            this.gbStatus.TabIndex = 4;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // btnTabela
            // 
            this.btnTabela.Location = new System.Drawing.Point(144, 20);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(110, 23);
            this.btnTabela.TabIndex = 1;
            this.btnTabela.Text = "Tabela";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // btnPodsumowanie
            // 
            this.btnPodsumowanie.Location = new System.Drawing.Point(6, 20);
            this.btnPodsumowanie.Name = "btnPodsumowanie";
            this.btnPodsumowanie.Size = new System.Drawing.Size(110, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 80);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zapisywanie";
            // 
            // btnEksportuj
            // 
            this.btnEksportuj.Location = new System.Drawing.Point(6, 50);
            this.btnEksportuj.Name = "btnEksportuj";
            this.btnEksportuj.Size = new System.Drawing.Size(248, 23);
            this.btnEksportuj.TabIndex = 2;
            this.btnEksportuj.Text = "Eksportuj do MS Excel";
            this.btnEksportuj.UseVisualStyleBackColor = true;
            // 
            // btnDrukuj
            // 
            this.btnDrukuj.Location = new System.Drawing.Point(144, 20);
            this.btnDrukuj.Name = "btnDrukuj";
            this.btnDrukuj.Size = new System.Drawing.Size(110, 23);
            this.btnDrukuj.TabIndex = 1;
            this.btnDrukuj.Text = "Drukuj";
            this.btnDrukuj.UseVisualStyleBackColor = true;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(6, 20);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(110, 23);
            this.btnZapisz.TabIndex = 0;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbDodaj);
            this.Controls.Add(this.gbStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Skontrum";
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
    }
}

