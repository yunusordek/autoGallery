namespace Oto_Galeri
{
    partial class KiralamaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiralamaForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlaka = new System.Windows.Forms.TextBox();
            this.dtKiralamaTarih = new System.Windows.Forms.DateTimePicker();
            this.dtTeslimTarih = new System.Windows.Forms.DateTimePicker();
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.btnKirala = new System.Windows.Forms.Button();
            this.cbTC = new System.Windows.Forms.ComboBox();
            this.btnMusteriBilgisi = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridKiralik = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKiralik)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLAKA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "KİRALAMA TARİHİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TESLİM ETME TARİHİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "FİYAT";
            // 
            // tbPlaka
            // 
            this.tbPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPlaka.Location = new System.Drawing.Point(271, 3);
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.Size = new System.Drawing.Size(396, 20);
            this.tbPlaka.TabIndex = 1;
            // 
            // dtKiralamaTarih
            // 
            this.dtKiralamaTarih.Location = new System.Drawing.Point(271, 65);
            this.dtKiralamaTarih.Name = "dtKiralamaTarih";
            this.dtKiralamaTarih.Size = new System.Drawing.Size(396, 20);
            this.dtKiralamaTarih.TabIndex = 8;
            // 
            // dtTeslimTarih
            // 
            this.dtTeslimTarih.Location = new System.Drawing.Point(271, 100);
            this.dtTeslimTarih.Name = "dtTeslimTarih";
            this.dtTeslimTarih.Size = new System.Drawing.Size(396, 20);
            this.dtTeslimTarih.TabIndex = 9;
            this.dtTeslimTarih.ValueChanged += new System.EventHandler(this.dtTeslimTarih_ValueChanged);
            // 
            // tbFiyat
            // 
            this.tbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFiyat.Location = new System.Drawing.Point(271, 136);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(396, 20);
            this.tbFiyat.TabIndex = 3;
            // 
            // btnKirala
            // 
            this.btnKirala.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKirala.BackgroundImage")));
            this.btnKirala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKirala.FlatAppearance.BorderSize = 0;
            this.btnKirala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKirala.Location = new System.Drawing.Point(713, 136);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(59, 40);
            this.btnKirala.TabIndex = 11;
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // cbTC
            // 
            this.cbTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTC.FormattingEnabled = true;
            this.cbTC.Location = new System.Drawing.Point(271, 36);
            this.cbTC.Name = "cbTC";
            this.cbTC.Size = new System.Drawing.Size(396, 21);
            this.cbTC.TabIndex = 2;
            this.cbTC.SelectedIndexChanged += new System.EventHandler(this.cbTC_SelectedIndexChanged);
            // 
            // btnMusteriBilgisi
            // 
            this.btnMusteriBilgisi.Location = new System.Drawing.Point(688, 36);
            this.btnMusteriBilgisi.Name = "btnMusteriBilgisi";
            this.btnMusteriBilgisi.Size = new System.Drawing.Size(156, 27);
            this.btnMusteriBilgisi.TabIndex = 13;
            this.btnMusteriBilgisi.Text = "Müşteri Bilgisi Görüntüle";
            this.btnMusteriBilgisi.UseVisualStyleBackColor = true;
            this.btnMusteriBilgisi.Visible = false;
            this.btnMusteriBilgisi.Click += new System.EventHandler(this.btnMusteriBilgisi_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(779, 139);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(48, 34);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dataGridKiralik
            // 
            this.dataGridKiralik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKiralik.Location = new System.Drawing.Point(0, 193);
            this.dataGridKiralik.Name = "dataGridKiralik";
            this.dataGridKiralik.Size = new System.Drawing.Size(853, 174);
            this.dataGridKiralik.TabIndex = 15;
            this.dataGridKiralik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridKiralik_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(255, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Lütfen Öncelikle Aracı Aşağıdaki Listeden Seçiniz !";
            // 
            // KiralamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(855, 367);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridKiralik);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnMusteriBilgisi);
            this.Controls.Add(this.cbTC);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.tbFiyat);
            this.Controls.Add(this.dtTeslimTarih);
            this.Controls.Add(this.dtKiralamaTarih);
            this.Controls.Add(this.tbPlaka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KiralamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiralama Formu";
            this.Load += new System.EventHandler(this.KiralamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKiralik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlaka;
        private System.Windows.Forms.DateTimePicker dtKiralamaTarih;
        private System.Windows.Forms.DateTimePicker dtTeslimTarih;
        private System.Windows.Forms.TextBox tbFiyat;
        private System.Windows.Forms.ComboBox cbTC;
        private System.Windows.Forms.Button btnMusteriBilgisi;
        public System.Windows.Forms.DataGridView dataGridKiralik;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.Label label6;
    }
}