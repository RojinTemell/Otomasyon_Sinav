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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminFormOnayla
            // 
            this.btnAdminFormOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminFormOnayla.Location = new System.Drawing.Point(1147, 615);
            this.btnAdminFormOnayla.Name = "btnAdminFormOnayla";
            this.btnAdminFormOnayla.Size = new System.Drawing.Size(168, 55);
            this.btnAdminFormOnayla.TabIndex = 2;
            this.btnAdminFormOnayla.Text = "Onayla";
            this.btnAdminFormOnayla.UseVisualStyleBackColor = true;
            this.btnAdminFormOnayla.Click += new System.EventHandler(this.btnAdminFormOnayla_Click);
            // 
            // btnKayitGoruntule
            // 
            this.btnKayitGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitGoruntule.Location = new System.Drawing.Point(753, 615);
            this.btnKayitGoruntule.Name = "btnKayitGoruntule";
            this.btnKayitGoruntule.Size = new System.Drawing.Size(315, 55);
            this.btnKayitGoruntule.TabIndex = 3;
            this.btnKayitGoruntule.Text = "Kayıtları Görüntüle";
            this.btnKayitGoruntule.UseVisualStyleBackColor = true;
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
            this.dgvAdmin.Size = new System.Drawing.Size(694, 631);
            this.dgvAdmin.TabIndex = 5;
            this.dgvAdmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvmouseclick);
            // 
            // pbAdmin
            // 
            this.pbAdmin.Location = new System.Drawing.Point(728, 50);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(690, 328);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdmin.TabIndex = 6;
            this.pbAdmin.TabStop = false;
            // 
            // txtAdminForm
            // 
            this.txtAdminForm.Location = new System.Drawing.Point(728, 384);
            this.txtAdminForm.Multiline = true;
            this.txtAdminForm.Name = "txtAdminForm";
            this.txtAdminForm.Size = new System.Drawing.Size(690, 225);
            this.txtAdminForm.TabIndex = 7;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 702);
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
    }
}