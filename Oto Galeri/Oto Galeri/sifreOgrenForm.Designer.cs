namespace Oto_Galeri
{
    partial class sifreOgrenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifreOgrenForm));
            this.label1 = new System.Windows.Forms.Label();
            this.sifreOgren = new DevExpress.XtraEditors.SimpleButton();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEposta = new System.Windows.Forms.TextBox();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // sifreOgren
            // 
            this.sifreOgren.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.sifreOgren.Appearance.Options.UseFont = true;
            this.sifreOgren.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sifreOgren.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sifreOgren.ImageOptions.Image")));
            this.sifreOgren.Location = new System.Drawing.Point(448, 100);
            this.sifreOgren.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sifreOgren.Name = "sifreOgren";
            this.sifreOgren.Size = new System.Drawing.Size(125, 51);
            this.sifreOgren.TabIndex = 2;
            this.sifreOgren.Text = "SIFIRLA";
            this.sifreOgren.Click += new System.EventHandler(this.sifreOgren_Click);
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKullaniciAdi.ForeColor = System.Drawing.Color.Yellow;
            this.tbKullaniciAdi.Location = new System.Drawing.Point(163, 14);
            this.tbKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbKullaniciAdi.Multiline = true;
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(336, 27);
            this.tbKullaniciAdi.TabIndex = 3;
            this.tbKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "E Posta";
            // 
            // tbEposta
            // 
            this.tbEposta.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbEposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEposta.ForeColor = System.Drawing.Color.Yellow;
            this.tbEposta.Location = new System.Drawing.Point(163, 63);
            this.tbEposta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEposta.Multiline = true;
            this.tbEposta.Name = "tbEposta";
            this.tbEposta.Size = new System.Drawing.Size(336, 27);
            this.tbEposta.TabIndex = 6;
            this.tbEposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEposta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEposta_KeyDown);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Kapat.FlatAppearance.BorderSize = 0;
            this.btn_Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kapat.Image")));
            this.btn_Kapat.Location = new System.Drawing.Point(521, 2);
            this.btn_Kapat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(52, 38);
            this.btn_Kapat.TabIndex = 11;
            this.btn_Kapat.UseVisualStyleBackColor = false;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // sifreOgrenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(575, 153);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.tbEposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKullaniciAdi);
            this.Controls.Add(this.sifreOgren);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "sifreOgrenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sifreOgrenForm";
            this.Load += new System.EventHandler(this.sifreOgrenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton sifreOgren;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEposta;
        private System.Windows.Forms.Button btn_Kapat;
    }
}