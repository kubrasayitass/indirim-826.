namespace indirim_826
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
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblİndirimlifiyat = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb25 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(26, 62);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(35, 13);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.Text = "Tutar:";
            // 
            // lblİndirimlifiyat
            // 
            this.lblİndirimlifiyat.AutoSize = true;
            this.lblİndirimlifiyat.Location = new System.Drawing.Point(26, 95);
            this.lblİndirimlifiyat.Name = "lblİndirimlifiyat";
            this.lblİndirimlifiyat.Size = new System.Drawing.Size(69, 13);
            this.lblİndirimlifiyat.TabIndex = 1;
            this.lblİndirimlifiyat.Text = "İndirimli Fiyat:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(18, 217);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(216, 36);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(90, 59);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 3;
            this.txtTutar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(18, 125);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(71, 17);
            this.rb5.TabIndex = 4;
            this.rb5.TabStop = true;
            this.rb5.Text = "%5 indirim";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(18, 148);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(77, 17);
            this.rb10.TabIndex = 5;
            this.rb10.TabStop = true;
            this.rb10.Text = "%10 indirim";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Location = new System.Drawing.Point(18, 171);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(77, 17);
            this.rb15.TabIndex = 6;
            this.rb15.TabStop = true;
            this.rb15.Text = "%15 indirim";
            this.rb15.UseVisualStyleBackColor = true;
            // 
            // rb25
            // 
            this.rb25.AutoSize = true;
            this.rb25.Location = new System.Drawing.Point(18, 194);
            this.rb25.Name = "rb25";
            this.rb25.Size = new System.Drawing.Size(77, 17);
            this.rb25.TabIndex = 7;
            this.rb25.TabStop = true;
            this.rb25.Text = "%25 indirim";
            this.rb25.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "_____________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(259, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb25);
            this.Controls.Add(this.rb15);
            this.Controls.Add(this.rb10);
            this.Controls.Add(this.rb5);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblİndirimlifiyat);
            this.Controls.Add(this.lblTutar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblİndirimlifiyat;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.RadioButton rb25;
        private System.Windows.Forms.Label label3;
    }
}

