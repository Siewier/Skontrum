namespace Skontrum
{
    partial class FormNoweSkontrum
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNoweSkontrum = new System.Windows.Forms.TextBox();
            this.btnZapiszNoweSkontrum = new System.Windows.Forms.Button();
            this.btnAnulujNoweSkontrum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaxNumer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj nazwę nowego skontrum:";
            // 
            // tbNoweSkontrum
            // 
            this.tbNoweSkontrum.Location = new System.Drawing.Point(16, 29);
            this.tbNoweSkontrum.Name = "tbNoweSkontrum";
            this.tbNoweSkontrum.Size = new System.Drawing.Size(167, 20);
            this.tbNoweSkontrum.TabIndex = 1;
            // 
            // btnZapiszNoweSkontrum
            // 
            this.btnZapiszNoweSkontrum.Location = new System.Drawing.Point(16, 95);
            this.btnZapiszNoweSkontrum.Name = "btnZapiszNoweSkontrum";
            this.btnZapiszNoweSkontrum.Size = new System.Drawing.Size(75, 23);
            this.btnZapiszNoweSkontrum.TabIndex = 2;
            this.btnZapiszNoweSkontrum.Text = "Zapisz";
            this.btnZapiszNoweSkontrum.UseVisualStyleBackColor = true;
            this.btnZapiszNoweSkontrum.Click += new System.EventHandler(this.btnZapiszNoweSkontrum_Click);
            // 
            // btnAnulujNoweSkontrum
            // 
            this.btnAnulujNoweSkontrum.Location = new System.Drawing.Point(108, 95);
            this.btnAnulujNoweSkontrum.Name = "btnAnulujNoweSkontrum";
            this.btnAnulujNoweSkontrum.Size = new System.Drawing.Size(75, 23);
            this.btnAnulujNoweSkontrum.TabIndex = 3;
            this.btnAnulujNoweSkontrum.Text = "Anuluj";
            this.btnAnulujNoweSkontrum.UseVisualStyleBackColor = true;
            this.btnAnulujNoweSkontrum.Click += new System.EventHandler(this.btnAnulujNoweSkontrum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Podaj ostatni numer inwentarzowy:";
            // 
            // tbMaxNumer
            // 
            this.tbMaxNumer.Location = new System.Drawing.Point(16, 69);
            this.tbMaxNumer.Name = "tbMaxNumer";
            this.tbMaxNumer.Size = new System.Drawing.Size(167, 20);
            this.tbMaxNumer.TabIndex = 5;
            // 
            // FormNoweSkontrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 130);
            this.ControlBox = false;
            this.Controls.Add(this.tbMaxNumer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnulujNoweSkontrum);
            this.Controls.Add(this.btnZapiszNoweSkontrum);
            this.Controls.Add(this.tbNoweSkontrum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormNoweSkontrum";
            this.ShowInTaskbar = false;
            this.Text = "Nowe skontrum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNoweSkontrum;
        private System.Windows.Forms.Button btnZapiszNoweSkontrum;
        private System.Windows.Forms.Button btnAnulujNoweSkontrum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaxNumer;
    }
}