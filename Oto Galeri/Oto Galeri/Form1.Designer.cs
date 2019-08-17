namespace Oto_Galeri
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifreUnuttumLabel = new System.Windows.Forms.LinkLabel();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Appearance.Options.UseForeColor = true;
            this.btnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.ImageOptions.Image")));
            this.btnGiris.Location = new System.Drawing.Point(462, 38);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(101, 71);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.BackColor = System.Drawing.Color.Black;
            this.tbKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKullaniciAdi.ForeColor = System.Drawing.Color.Yellow;
            this.tbKullaniciAdi.Location = new System.Drawing.Point(149, 48);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(294, 23);
            this.tbKullaniciAdi.TabIndex = 2;
            this.tbKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPassword.ForeColor = System.Drawing.Color.Yellow;
            this.tbPassword.Location = new System.Drawing.Point(149, 74);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(294, 23);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // sifreUnuttumLabel
            // 
            this.sifreUnuttumLabel.ActiveLinkColor = System.Drawing.Color.Red;
            this.sifreUnuttumLabel.AutoSize = true;
            this.sifreUnuttumLabel.BackColor = System.Drawing.Color.Transparent;
            this.sifreUnuttumLabel.LinkColor = System.Drawing.Color.Navy;
            this.sifreUnuttumLabel.Location = new System.Drawing.Point(461, 128);
            this.sifreUnuttumLabel.Name = "sifreUnuttumLabel";
            this.sifreUnuttumLabel.Size = new System.Drawing.Size(96, 13);
            this.sifreUnuttumLabel.TabIndex = 6;
            this.sifreUnuttumLabel.TabStop = true;
            this.sifreUnuttumLabel.Text = "Şifremi Unuttum";
            this.sifreUnuttumLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sifreUnuttumLabel_LinkClicked);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Kapat.FlatAppearance.BorderSize = 0;
            this.btn_Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kapat.Image")));
            this.btn_Kapat.Location = new System.Drawing.Point(528, -2);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(45, 33);
            this.btn_Kapat.TabIndex = 10;
            this.btn_Kapat.UseVisualStyleBackColor = false;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(569, 150);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.sifreUnuttumLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbKullaniciAdi);
            this.Controls.Add(this.btnGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel sifreUnuttumLabel;
        public System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btn_Kapat;
    }
}

