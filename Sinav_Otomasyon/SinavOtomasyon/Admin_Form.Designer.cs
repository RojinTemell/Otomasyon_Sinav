namespace SinavOtomasyon
{
    partial class Admin_Form
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
            this.btnAdminFormOnayla = new System.Windows.Forms.Button();
            this.btnKayitGoruntule = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.txtAdminForm = new System.Windows.Forms.TextBox();
            this.btnAdminCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminFormOnayla
            // 
            this.btnAdminFormOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(114)))));
            this.btnAdminFormOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminFormOnayla.ForeColor = System.Drawing.Color.White;
            this.btnAdminFormOnayla.Location = new System.Drawing.Point(920, 615);
            this.btnAdminFormOnayla.Name = "btnAdminFormOnayla";
            this.btnAdminFormOnayla.Size = new System.Drawing.Size(168, 55);
            this.btnAdminFormOnayla.TabIndex = 2;
            this.btnAdminFormOnayla.Text = "Onayla";
            this.btnAdminFormOnayla.UseVisualStyleBackColor = false;
            this.btnAdminFormOnayla.Click += new System.EventHandler(this.btnAdminFormOnayla_Click);
            // 
            // btnKayitGoruntule
            // 
            this.btnKayitGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(114)))));
            this.btnKayitGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnKayitGoruntule.Location = new System.Drawing.Point(588, 615);
            this.btnKayitGoruntule.Name = "btnKayitGoruntule";
            this.btnKayitGoruntule.Size = new System.Drawing.Size(315, 55);
            this.btnKayitGoruntule.TabIndex = 3;
            this.btnKayitGoruntule.Text = "Kayıtları Görüntüle";
            this.btnKayitGoruntule.UseVisualStyleBackColor = false;
            this.btnKayitGoruntule.Click += new System.EventHandler(this.btnKayitGoruntule_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(12, 50);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 62;
            this.dgvAdmin.RowTemplate.Height = 28;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(558, 620);
            this.dgvAdmin.TabIndex = 5;
            this.dgvAdmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvmouseclick);
            // 
            // pbAdmin
            // 
            this.pbAdmin.Location = new System.Drawing.Point(588, 50);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(690, 328);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdmin.TabIndex = 6;
            this.pbAdmin.TabStop = false;
            // 
            // txtAdminForm
            // 
            this.txtAdminForm.Location = new System.Drawing.Point(588, 384);
            this.txtAdminForm.Multiline = true;
            this.txtAdminForm.Name = "txtAdminForm";
            this.txtAdminForm.Size = new System.Drawing.Size(690, 225);
            this.txtAdminForm.TabIndex = 7;
            // 
            // btnAdminCikis
            // 
            this.btnAdminCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(114)))));
            this.btnAdminCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminCikis.ForeColor = System.Drawing.Color.Red;
            this.btnAdminCikis.Location = new System.Drawing.Point(1110, 615);
            this.btnAdminCikis.Name = "btnAdminCikis";
            this.btnAdminCikis.Size = new System.Drawing.Size(168, 55);
            this.btnAdminCikis.TabIndex = 8;
            this.btnAdminCikis.Text = "Çıkış Yap";
            this.btnAdminCikis.UseVisualStyleBackColor = false;
            this.btnAdminCikis.Click += new System.EventHandler(this.btnAdminCikis_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(134)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1316, 702);
            this.Controls.Add(this.btnAdminCikis);
            this.Controls.Add(this.txtAdminForm);
            this.Controls.Add(this.pbAdmin);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.btnKayitGoruntule);
            this.Controls.Add(this.btnAdminFormOnayla);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdminFormOnayla;
        private System.Windows.Forms.Button btnKayitGoruntule;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.TextBox txtAdminForm;
        private System.Windows.Forms.Button btnAdminCikis;
    }
}