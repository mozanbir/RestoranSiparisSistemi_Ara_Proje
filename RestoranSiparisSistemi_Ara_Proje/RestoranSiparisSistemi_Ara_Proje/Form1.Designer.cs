﻿namespace RestoranSiparisSistemi_Ara_Proje
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstMenuler = new System.Windows.Forms.ListBox();
            this.btnYemekEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.rtxSiparisOzet = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "  MENÜ(Yemek Seçimi)";
            // 
            // lstMenuler
            // 
            this.lstMenuler.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstMenuler.FormattingEnabled = true;
            this.lstMenuler.Location = new System.Drawing.Point(25, 143);
            this.lstMenuler.Name = "lstMenuler";
            this.lstMenuler.Size = new System.Drawing.Size(223, 147);
            this.lstMenuler.TabIndex = 1;
            // 
            // btnYemekEkle
            // 
            this.btnYemekEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYemekEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemekEkle.Location = new System.Drawing.Point(25, 324);
            this.btnYemekEkle.Name = "btnYemekEkle";
            this.btnYemekEkle.Size = new System.Drawing.Size(223, 70);
            this.btnYemekEkle.TabIndex = 2;
            this.btnYemekEkle.Text = "Sepete Ekle";
            this.btnYemekEkle.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(293, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Tutar";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.BackColor = System.Drawing.Color.RosyBrown;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(291, 114);
            this.lblToplamTutar.MaximumSize = new System.Drawing.Size(200, 200);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(184, 50);
            this.lblToplamTutar.TabIndex = 4;
            this.lblToplamTutar.Text = "0.00 TL";
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiparisTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisTamamla.Location = new System.Drawing.Point(288, 186);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(187, 58);
            this.btnSiparisTamamla.TabIndex = 5;
            this.btnSiparisTamamla.Text = "Sipariş Oluştur";
            this.btnSiparisTamamla.UseVisualStyleBackColor = false;
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnDurumGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumGuncelle.Location = new System.Drawing.Point(288, 270);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(187, 136);
            this.btnDurumGuncelle.TabIndex = 6;
            this.btnDurumGuncelle.Text = "Durumu \'Yolda\'";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            // 
            // rtxSiparisOzet
            // 
            this.rtxSiparisOzet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtxSiparisOzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxSiparisOzet.Location = new System.Drawing.Point(513, 37);
            this.rtxSiparisOzet.Name = "rtxSiparisOzet";
            this.rtxSiparisOzet.Size = new System.Drawing.Size(257, 369);
            this.rtxSiparisOzet.TabIndex = 7;
            this.rtxSiparisOzet.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 473);
            this.Controls.Add(this.rtxSiparisOzet);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnYemekEkle);
            this.Controls.Add(this.lstMenuler);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Restoran Sipariş Sistemi Ara Proje";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMenuler;
        private System.Windows.Forms.Button btnYemekEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.RichTextBox rtxSiparisOzet;
    }
}

