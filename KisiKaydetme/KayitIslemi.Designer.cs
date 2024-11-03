namespace KisiKaydetme
{
    partial class KayitIslemi
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
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_soyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_cinsiyet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtb_telefon = new System.Windows.Forms.MaskedTextBox();
            this.mtb_tcno = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtb_dtarihi = new System.Windows.Forms.MaskedTextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_kayitliKisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(113, 50);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(202, 22);
            this.tb_isim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // tb_soyisim
            // 
            this.tb_soyisim.Location = new System.Drawing.Point(113, 84);
            this.tb_soyisim.Name = "tb_soyisim";
            this.tb_soyisim.Size = new System.Drawing.Size(202, 22);
            this.tb_soyisim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC Kimlik No";
            // 
            // mtb_cinsiyet
            // 
            this.mtb_cinsiyet.Location = new System.Drawing.Point(113, 178);
            this.mtb_cinsiyet.Name = "mtb_cinsiyet";
            this.mtb_cinsiyet.Size = new System.Drawing.Size(202, 22);
            this.mtb_cinsiyet.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cinsiyet";
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(113, 247);
            this.tb_adres.Multiline = true;
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.Size = new System.Drawing.Size(202, 108);
            this.tb_adres.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Telefon";
            // 
            // mtb_telefon
            // 
            this.mtb_telefon.Location = new System.Drawing.Point(113, 212);
            this.mtb_telefon.Mask = "(999) 000-0000";
            this.mtb_telefon.Name = "mtb_telefon";
            this.mtb_telefon.Size = new System.Drawing.Size(202, 22);
            this.mtb_telefon.TabIndex = 6;
            // 
            // mtb_tcno
            // 
            this.mtb_tcno.Location = new System.Drawing.Point(112, 145);
            this.mtb_tcno.Mask = "00000000000";
            this.mtb_tcno.Name = "mtb_tcno";
            this.mtb_tcno.Size = new System.Drawing.Size(203, 22);
            this.mtb_tcno.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dogum Tarihi";
            // 
            // mtb_dtarihi
            // 
            this.mtb_dtarihi.Location = new System.Drawing.Point(113, 112);
            this.mtb_dtarihi.Mask = "00/00/0000";
            this.mtb_dtarihi.Name = "mtb_dtarihi";
            this.mtb_dtarihi.Size = new System.Drawing.Size(202, 22);
            this.mtb_dtarihi.TabIndex = 3;
            this.mtb_dtarihi.ValidatingType = typeof(System.DateTime);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(113, 378);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(202, 36);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_kayitliKisi
            // 
            this.lbl_kayitliKisi.AutoSize = true;
            this.lbl_kayitliKisi.Location = new System.Drawing.Point(444, 50);
            this.lbl_kayitliKisi.Name = "lbl_kayitliKisi";
            this.lbl_kayitliKisi.Size = new System.Drawing.Size(45, 16);
            this.lbl_kayitliKisi.TabIndex = 9;
            this.lbl_kayitliKisi.Text = "KAYIT";
            // 
            // KayitIslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_kayitliKisi);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.mtb_dtarihi);
            this.Controls.Add(this.mtb_tcno);
            this.Controls.Add(this.mtb_telefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_adres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtb_cinsiyet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_soyisim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_isim);
            this.Name = "KayitIslemi";
            this.Text = "KayitIslemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_soyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mtb_cinsiyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtb_telefon;
        private System.Windows.Forms.MaskedTextBox mtb_tcno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtb_dtarihi;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_kayitliKisi;
    }
}