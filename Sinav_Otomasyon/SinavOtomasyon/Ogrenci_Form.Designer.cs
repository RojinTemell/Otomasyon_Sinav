namespace SinavOtomasyon
{
    partial class Ogrenci_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_Form));
            this.pbOgrenciSoru = new System.Windows.Forms.PictureBox();
            this.txtOgrA = new System.Windows.Forms.TextBox();
            this.txtOgrB = new System.Windows.Forms.TextBox();
            this.txtOgrC = new System.Windows.Forms.TextBox();
            this.txtOgrD = new System.Windows.Forms.TextBox();
            this.rbOgrA = new System.Windows.Forms.RadioButton();
            this.rbOgrC = new System.Windows.Forms.RadioButton();
            this.rbOgrB = new System.Windows.Forms.RadioButton();
            this.rbOgrD = new System.Windows.Forms.RadioButton();
            this.btnTesteBasla = new System.Windows.Forms.Button();
            this.btnTestiBitir = new System.Windows.Forms.Button();
            this.btnSonrakiSoru = new System.Windows.Forms.Button();
            this.lblsoruno = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTarih = new System.Windows.Forms.Label();
            this.lbldk = new System.Windows.Forms.Label();
            this.lblsn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenciSoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOgrenciSoru
            // 
            this.pbOgrenciSoru.Location = new System.Drawing.Point(142, 49);
            this.pbOgrenciSoru.Name = "pbOgrenciSoru";
            this.pbOgrenciSoru.Size = new System.Drawing.Size(768, 373);
            this.pbOgrenciSoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOgrenciSoru.TabIndex = 0;
            this.pbOgrenciSoru.TabStop = false;
            // 
            // txtOgrA
            // 
            this.txtOgrA.Location = new System.Drawing.Point(134, 438);
            this.txtOgrA.Multiline = true;
            this.txtOgrA.Name = "txtOgrA";
            this.txtOgrA.Size = new System.Drawing.Size(768, 34);
            this.txtOgrA.TabIndex = 1;
            // 
            // txtOgrB
            // 
            this.txtOgrB.Location = new System.Drawing.Point(134, 501);
            this.txtOgrB.Multiline = true;
            this.txtOgrB.Name = "txtOgrB";
            this.txtOgrB.Size = new System.Drawing.Size(768, 34);
            this.txtOgrB.TabIndex = 2;
            // 
            // txtOgrC
            // 
            this.txtOgrC.Location = new System.Drawing.Point(134, 565);
            this.txtOgrC.Multiline = true;
            this.txtOgrC.Name = "txtOgrC";
            this.txtOgrC.Size = new System.Drawing.Size(768, 34);
            this.txtOgrC.TabIndex = 3;
            // 
            // txtOgrD
            // 
            this.txtOgrD.Location = new System.Drawing.Point(134, 625);
            this.txtOgrD.Multiline = true;
            this.txtOgrD.Name = "txtOgrD";
            this.txtOgrD.Size = new System.Drawing.Size(768, 34);
            this.txtOgrD.TabIndex = 4;
            // 
            // rbOgrA
            // 
            this.rbOgrA.AutoSize = true;
            this.rbOgrA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbOgrA.Location = new System.Drawing.Point(76, 438);
            this.rbOgrA.Name = "rbOgrA";
            this.rbOgrA.Size = new System.Drawing.Size(52, 24);
            this.rbOgrA.TabIndex = 5;
            this.rbOgrA.TabStop = true;
            this.rbOgrA.Text = "A)";
            this.rbOgrA.UseVisualStyleBackColor = true;
            // 
            // rbOgrC
            // 
            this.rbOgrC.AutoSize = true;
            this.rbOgrC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbOgrC.Location = new System.Drawing.Point(76, 565);
            this.rbOgrC.Name = "rbOgrC";
            this.rbOgrC.Size = new System.Drawing.Size(52, 24);
            this.rbOgrC.TabIndex = 6;
            this.rbOgrC.TabStop = true;
            this.rbOgrC.Text = "C)";
            this.rbOgrC.UseVisualStyleBackColor = true;
            // 
            // rbOgrB
            // 
            this.rbOgrB.AutoSize = true;
            this.rbOgrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbOgrB.Location = new System.Drawing.Point(75, 502);
            this.rbOgrB.Name = "rbOgrB";
            this.rbOgrB.Size = new System.Drawing.Size(52, 24);
            this.rbOgrB.TabIndex = 7;
            this.rbOgrB.TabStop = true;
            this.rbOgrB.Text = "B)";
            this.rbOgrB.UseVisualStyleBackColor = true;
            // 
            // rbOgrD
            // 
            this.rbOgrD.AutoSize = true;
            this.rbOgrD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbOgrD.Location = new System.Drawing.Point(74, 625);
            this.rbOgrD.Name = "rbOgrD";
            this.rbOgrD.Size = new System.Drawing.Size(53, 24);
            this.rbOgrD.TabIndex = 8;
            this.rbOgrD.TabStop = true;
            this.rbOgrD.Text = "D)";
            this.rbOgrD.UseVisualStyleBackColor = true;
            // 
            // btnTesteBasla
            // 
            this.btnTesteBasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(134)))), ((int)(((byte)(182)))));
            this.btnTesteBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTesteBasla.ForeColor = System.Drawing.Color.White;
            this.btnTesteBasla.Location = new System.Drawing.Point(934, 203);
            this.btnTesteBasla.Name = "btnTesteBasla";
            this.btnTesteBasla.Size = new System.Drawing.Size(176, 50);
            this.btnTesteBasla.TabIndex = 9;
            this.btnTesteBasla.Text = "Teste Başla";
            this.btnTesteBasla.UseVisualStyleBackColor = false;
            this.btnTesteBasla.Click += new System.EventHandler(this.btnTesteBasla_Click);
            // 
            // btnTestiBitir
            // 
            this.btnTestiBitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(134)))), ((int)(((byte)(182)))));
            this.btnTestiBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestiBitir.ForeColor = System.Drawing.Color.White;
            this.btnTestiBitir.Location = new System.Drawing.Point(934, 297);
            this.btnTestiBitir.Name = "btnTestiBitir";
            this.btnTestiBitir.Size = new System.Drawing.Size(176, 50);
            this.btnTestiBitir.TabIndex = 10;
            this.btnTestiBitir.Text = "Testi Bitir";
            this.btnTestiBitir.UseVisualStyleBackColor = false;
            this.btnTestiBitir.Click += new System.EventHandler(this.btnTestiBitir_Click);
            // 
            // btnSonrakiSoru
            // 
            this.btnSonrakiSoru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(134)))), ((int)(((byte)(182)))));
            this.btnSonrakiSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonrakiSoru.ForeColor = System.Drawing.Color.White;
            this.btnSonrakiSoru.Location = new System.Drawing.Point(934, 601);
            this.btnSonrakiSoru.Name = "btnSonrakiSoru";
            this.btnSonrakiSoru.Size = new System.Drawing.Size(176, 48);
            this.btnSonrakiSoru.TabIndex = 13;
            this.btnSonrakiSoru.Text = "Sonraki Soru";
            this.btnSonrakiSoru.UseVisualStyleBackColor = false;
            this.btnSonrakiSoru.Click += new System.EventHandler(this.btnSonrakiSoru_Click);
            // 
            // lblsoruno
            // 
            this.lblsoruno.AutoSize = true;
            this.lblsoruno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoruno.Location = new System.Drawing.Point(31, 46);
            this.lblsoruno.Name = "lblsoruno";
            this.lblsoruno.Size = new System.Drawing.Size(96, 29);
            this.lblsoruno.TabIndex = 14;
            this.lblsoruno.Text = "1.Soru:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(982, 46);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(17, 20);
            this.lblTarih.TabIndex = 12;
            this.lblTarih.Text = "..";
            // 
            // lbldk
            // 
            this.lbldk.AutoSize = true;
            this.lbldk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldk.Location = new System.Drawing.Point(981, 114);
            this.lbldk.Name = "lbldk";
            this.lbldk.Size = new System.Drawing.Size(38, 26);
            this.lbldk.TabIndex = 15;
            this.lbldk.Text = "00";
            // 
            // lblsn
            // 
            this.lblsn.AutoSize = true;
            this.lblsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsn.Location = new System.Drawing.Point(1054, 114);
            this.lblsn.Name = "lblsn";
            this.lblsn.Size = new System.Drawing.Size(38, 26);
            this.lblsn.TabIndex = 16;
            this.lblsn.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1028, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = ":";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(916, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(913, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(913, 353);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(209, 217);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // Ogrenci_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(219)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1232, 709);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsn);
            this.Controls.Add(this.lbldk);
            this.Controls.Add(this.lblsoruno);
            this.Controls.Add(this.btnSonrakiSoru);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnTestiBitir);
            this.Controls.Add(this.btnTesteBasla);
            this.Controls.Add(this.rbOgrD);
            this.Controls.Add(this.rbOgrB);
            this.Controls.Add(this.rbOgrC);
            this.Controls.Add(this.rbOgrA);
            this.Controls.Add(this.txtOgrD);
            this.Controls.Add(this.txtOgrC);
            this.Controls.Add(this.txtOgrB);
            this.Controls.Add(this.txtOgrA);
            this.Controls.Add(this.pbOgrenciSoru);
            this.Name = "Ogrenci_Form";
            this.Text = "Ogrenci_Form";
            this.Load += new System.EventHandler(this.Ogrenci_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenciSoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOgrenciSoru;
        private System.Windows.Forms.TextBox txtOgrA;
        private System.Windows.Forms.TextBox txtOgrB;
        private System.Windows.Forms.TextBox txtOgrC;
        private System.Windows.Forms.TextBox txtOgrD;
        private System.Windows.Forms.RadioButton rbOgrA;
        private System.Windows.Forms.RadioButton rbOgrC;
        private System.Windows.Forms.RadioButton rbOgrB;
        private System.Windows.Forms.RadioButton rbOgrD;
        private System.Windows.Forms.Button btnTesteBasla;
        private System.Windows.Forms.Button btnTestiBitir;
        private System.Windows.Forms.Button btnSonrakiSoru;
        private System.Windows.Forms.Label lblsoruno;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lbldk;
        private System.Windows.Forms.Label lblsn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}