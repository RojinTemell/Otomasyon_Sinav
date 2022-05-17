namespace SinavOtomasyon
{
    partial class SifremiUnuttum_Formu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum_Formu));
            this.txtMailDogrulama = new System.Windows.Forms.TextBox();
            this.lblMail_SYenileme = new System.Windows.Forms.Label();
            this.btnKodGonder = new System.Windows.Forms.Button();
            this.grpbGuvenlikKod = new System.Windows.Forms.GroupBox();
            this.btnOnaylaGuvKod = new System.Windows.Forms.Button();
            this.txtGuvenlikKod = new System.Windows.Forms.TextBox();
            this.lblGuvenlikKod = new System.Windows.Forms.Label();
            this.grpbYeniSifre = new System.Windows.Forms.GroupBox();
            this.btnOnaylaYeniSifre = new System.Windows.Forms.Button();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.grpbMailDogrulama = new System.Windows.Forms.GroupBox();
            this.rbAdminSifreYenileme = new System.Windows.Forms.RadioButton();
            this.grpbKullaniciTipiSifreYeni = new System.Windows.Forms.GroupBox();
            this.rbSorumluSifreYenileme = new System.Windows.Forms.RadioButton();
            this.rbOgrenciSifreYenileme = new System.Windows.Forms.RadioButton();
            this.grpbGuvenlikKod.SuspendLayout();
            this.grpbYeniSifre.SuspendLayout();
            this.grpbMailDogrulama.SuspendLayout();
            this.grpbKullaniciTipiSifreYeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMailDogrulama
            // 
            this.txtMailDogrulama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMailDogrulama.Location = new System.Drawing.Point(132, 25);
            this.txtMailDogrulama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMailDogrulama.Name = "txtMailDogrulama";
            this.txtMailDogrulama.Size = new System.Drawing.Size(163, 26);
            this.txtMailDogrulama.TabIndex = 8;
            // 
            // lblMail_SYenileme
            // 
            this.lblMail_SYenileme.AutoSize = true;
            this.lblMail_SYenileme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail_SYenileme.Location = new System.Drawing.Point(55, 27);
            this.lblMail_SYenileme.Name = "lblMail_SYenileme";
            this.lblMail_SYenileme.Size = new System.Drawing.Size(50, 20);
            this.lblMail_SYenileme.TabIndex = 7;
            this.lblMail_SYenileme.Text = "Mail:";
            // 
            // btnKodGonder
            // 
            this.btnKodGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(197)))), ((int)(((byte)(238)))));
            this.btnKodGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKodGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.btnKodGonder.Location = new System.Drawing.Point(124, 70);
            this.btnKodGonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKodGonder.Name = "btnKodGonder";
            this.btnKodGonder.Size = new System.Drawing.Size(171, 36);
            this.btnKodGonder.TabIndex = 11;
            this.btnKodGonder.Text = "Kod Gönder";
            this.btnKodGonder.UseVisualStyleBackColor = false;
            this.btnKodGonder.Click += new System.EventHandler(this.btnKodGonder_Click);
            // 
            // grpbGuvenlikKod
            // 
            this.grpbGuvenlikKod.BackColor = System.Drawing.Color.Transparent;
            this.grpbGuvenlikKod.Controls.Add(this.btnOnaylaGuvKod);
            this.grpbGuvenlikKod.Controls.Add(this.txtGuvenlikKod);
            this.grpbGuvenlikKod.Controls.Add(this.lblGuvenlikKod);
            this.grpbGuvenlikKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbGuvenlikKod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(197)))), ((int)(((byte)(238)))));
            this.grpbGuvenlikKod.Location = new System.Drawing.Point(467, 371);
            this.grpbGuvenlikKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbGuvenlikKod.Name = "grpbGuvenlikKod";
            this.grpbGuvenlikKod.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbGuvenlikKod.Size = new System.Drawing.Size(372, 130);
            this.grpbGuvenlikKod.TabIndex = 12;
            this.grpbGuvenlikKod.TabStop = false;
            this.grpbGuvenlikKod.Text = "Güvenlik Kodu Doğrulama";
            // 
            // btnOnaylaGuvKod
            // 
            this.btnOnaylaGuvKod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(197)))), ((int)(((byte)(238)))));
            this.btnOnaylaGuvKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnaylaGuvKod.ForeColor = System.Drawing.Color.Red;
            this.btnOnaylaGuvKod.Location = new System.Drawing.Point(180, 86);
            this.btnOnaylaGuvKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnaylaGuvKod.Name = "btnOnaylaGuvKod";
            this.btnOnaylaGuvKod.Size = new System.Drawing.Size(163, 30);
            this.btnOnaylaGuvKod.TabIndex = 13;
            this.btnOnaylaGuvKod.Text = "Onayla";
            this.btnOnaylaGuvKod.UseVisualStyleBackColor = false;
            // 
            // txtGuvenlikKod
            // 
            this.txtGuvenlikKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuvenlikKod.Location = new System.Drawing.Point(180, 42);
            this.txtGuvenlikKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGuvenlikKod.Name = "txtGuvenlikKod";
            this.txtGuvenlikKod.Size = new System.Drawing.Size(163, 26);
            this.txtGuvenlikKod.TabIndex = 14;
            // 
            // lblGuvenlikKod
            // 
            this.lblGuvenlikKod.AutoSize = true;
            this.lblGuvenlikKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuvenlikKod.Location = new System.Drawing.Point(5, 46);
            this.lblGuvenlikKod.Name = "lblGuvenlikKod";
            this.lblGuvenlikKod.Size = new System.Drawing.Size(135, 20);
            this.lblGuvenlikKod.TabIndex = 13;
            this.lblGuvenlikKod.Text = "Güvenlik Kodu:";
            // 
            // grpbYeniSifre
            // 
            this.grpbYeniSifre.BackColor = System.Drawing.Color.Transparent;
            this.grpbYeniSifre.Controls.Add(this.btnOnaylaYeniSifre);
            this.grpbYeniSifre.Controls.Add(this.txtYeniSifre);
            this.grpbYeniSifre.Controls.Add(this.lblYeniSifre);
            this.grpbYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbYeniSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(197)))), ((int)(((byte)(238)))));
            this.grpbYeniSifre.Location = new System.Drawing.Point(28, 326);
            this.grpbYeniSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbYeniSifre.Name = "grpbYeniSifre";
            this.grpbYeniSifre.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbYeniSifre.Size = new System.Drawing.Size(372, 130);
            this.grpbYeniSifre.TabIndex = 15;
            this.grpbYeniSifre.TabStop = false;
            this.grpbYeniSifre.Text = "Yeni Şifre";
            // 
            // btnOnaylaYeniSifre
            // 
            this.btnOnaylaYeniSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(197)))), ((int)(((byte)(238)))));
            this.btnOnaylaYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnaylaYeniSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.btnOnaylaYeniSifre.Location = new System.Drawing.Point(180, 86);
            this.btnOnaylaYeniSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnaylaYeniSifre.Name = "btnOnaylaYeniSifre";
            this.btnOnaylaYeniSifre.Size = new System.Drawing.Size(163, 30);
            this.btnOnaylaYeniSifre.TabIndex = 13;
            this.btnOnaylaYeniSifre.Text = "Onayla";
            this.btnOnaylaYeniSifre.UseVisualStyleBackColor = false;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.Location = new System.Drawing.Point(180, 42);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(163, 26);
            this.txtYeniSifre.TabIndex = 14;
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniSifre.Location = new System.Drawing.Point(28, 45);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(97, 20);
            this.lblYeniSifre.TabIndex = 13;
            this.lblYeniSifre.Text = "Yeni Şifre:";
            // 
            // grpbMailDogrulama
            // 
            this.grpbMailDogrulama.BackColor = System.Drawing.Color.Transparent;
            this.grpbMailDogrulama.Controls.Add(this.btnKodGonder);
            this.grpbMailDogrulama.Controls.Add(this.lblMail_SYenileme);
            this.grpbMailDogrulama.Controls.Add(this.txtMailDogrulama);
            this.grpbMailDogrulama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbMailDogrulama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(197)))), ((int)(((byte)(238)))));
            this.grpbMailDogrulama.Location = new System.Drawing.Point(28, 192);
            this.grpbMailDogrulama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbMailDogrulama.Name = "grpbMailDogrulama";
            this.grpbMailDogrulama.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbMailDogrulama.Size = new System.Drawing.Size(372, 130);
            this.grpbMailDogrulama.TabIndex = 16;
            this.grpbMailDogrulama.TabStop = false;
            this.grpbMailDogrulama.Text = "Mail Doğrulama";
            // 
            // rbAdminSifreYenileme
            // 
            this.rbAdminSifreYenileme.AutoSize = true;
            this.rbAdminSifreYenileme.Location = new System.Drawing.Point(18, 32);
            this.rbAdminSifreYenileme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAdminSifreYenileme.Name = "rbAdminSifreYenileme";
            this.rbAdminSifreYenileme.Size = new System.Drawing.Size(73, 21);
            this.rbAdminSifreYenileme.TabIndex = 17;
            this.rbAdminSifreYenileme.TabStop = true;
            this.rbAdminSifreYenileme.Text = "Admin";
            this.rbAdminSifreYenileme.UseVisualStyleBackColor = true;
            // 
            // grpbKullaniciTipiSifreYeni
            // 
            this.grpbKullaniciTipiSifreYeni.BackColor = System.Drawing.Color.Transparent;
            this.grpbKullaniciTipiSifreYeni.Controls.Add(this.rbSorumluSifreYenileme);
            this.grpbKullaniciTipiSifreYeni.Controls.Add(this.rbOgrenciSifreYenileme);
            this.grpbKullaniciTipiSifreYeni.Controls.Add(this.rbAdminSifreYenileme);
            this.grpbKullaniciTipiSifreYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbKullaniciTipiSifreYeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(197)))), ((int)(((byte)(238)))));
            this.grpbKullaniciTipiSifreYeni.Location = new System.Drawing.Point(28, 13);
            this.grpbKullaniciTipiSifreYeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbKullaniciTipiSifreYeni.Name = "grpbKullaniciTipiSifreYeni";
            this.grpbKullaniciTipiSifreYeni.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbKullaniciTipiSifreYeni.Size = new System.Drawing.Size(236, 151);
            this.grpbKullaniciTipiSifreYeni.TabIndex = 15;
            this.grpbKullaniciTipiSifreYeni.TabStop = false;
            this.grpbKullaniciTipiSifreYeni.Text = "Kullanıcı Tipi Seçiniz";
            // 
            // rbSorumluSifreYenileme
            // 
            this.rbSorumluSifreYenileme.AutoSize = true;
            this.rbSorumluSifreYenileme.Location = new System.Drawing.Point(18, 106);
            this.rbSorumluSifreYenileme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSorumluSifreYenileme.Name = "rbSorumluSifreYenileme";
            this.rbSorumluSifreYenileme.Size = new System.Drawing.Size(150, 21);
            this.rbSorumluSifreYenileme.TabIndex = 19;
            this.rbSorumluSifreYenileme.TabStop = true;
            this.rbSorumluSifreYenileme.Text = "Sınav Sorumlusu";
            this.rbSorumluSifreYenileme.UseVisualStyleBackColor = true;
            // 
            // rbOgrenciSifreYenileme
            // 
            this.rbOgrenciSifreYenileme.AutoSize = true;
            this.rbOgrenciSifreYenileme.Location = new System.Drawing.Point(18, 69);
            this.rbOgrenciSifreYenileme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOgrenciSifreYenileme.Name = "rbOgrenciSifreYenileme";
            this.rbOgrenciSifreYenileme.Size = new System.Drawing.Size(86, 21);
            this.rbOgrenciSifreYenileme.TabIndex = 18;
            this.rbOgrenciSifreYenileme.TabStop = true;
            this.rbOgrenciSifreYenileme.Text = "Öğrenci";
            this.rbOgrenciSifreYenileme.UseVisualStyleBackColor = true;
            // 
            // SifremiUnuttum_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1323, 563);
            this.Controls.Add(this.grpbKullaniciTipiSifreYeni);
            this.Controls.Add(this.grpbMailDogrulama);
            this.Controls.Add(this.grpbYeniSifre);
            this.Controls.Add(this.grpbGuvenlikKod);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SifremiUnuttum_Formu";
            this.Text = "SifremiUnuttum_Formu";
            this.grpbGuvenlikKod.ResumeLayout(false);
            this.grpbGuvenlikKod.PerformLayout();
            this.grpbYeniSifre.ResumeLayout(false);
            this.grpbYeniSifre.PerformLayout();
            this.grpbMailDogrulama.ResumeLayout(false);
            this.grpbMailDogrulama.PerformLayout();
            this.grpbKullaniciTipiSifreYeni.ResumeLayout(false);
            this.grpbKullaniciTipiSifreYeni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMailDogrulama;
        private System.Windows.Forms.Label lblMail_SYenileme;
        private System.Windows.Forms.Button btnKodGonder;
        private System.Windows.Forms.GroupBox grpbGuvenlikKod;
        private System.Windows.Forms.Button btnOnaylaGuvKod;
        private System.Windows.Forms.TextBox txtGuvenlikKod;
        private System.Windows.Forms.Label lblGuvenlikKod;
        private System.Windows.Forms.GroupBox grpbYeniSifre;
        private System.Windows.Forms.Button btnOnaylaYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.GroupBox grpbMailDogrulama;
        private System.Windows.Forms.RadioButton rbAdminSifreYenileme;
        private System.Windows.Forms.GroupBox grpbKullaniciTipiSifreYeni;
        private System.Windows.Forms.RadioButton rbSorumluSifreYenileme;
        private System.Windows.Forms.RadioButton rbOgrenciSifreYenileme;
    }
}