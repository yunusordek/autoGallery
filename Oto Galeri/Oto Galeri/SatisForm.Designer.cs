namespace Oto_Galeri
{
    partial class SatisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlaka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtSatisTarih = new System.Windows.Forms.DateTimePicker();
            this.cbTC = new System.Windows.Forms.ComboBox();
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.cbOdemeTip = new System.Windows.Forms.ComboBox();
            this.cbTaksitSayisi = new System.Windows.Forms.ComboBox();
            this.lblTaksit = new System.Windows.Forms.Label();
            this.btnSAT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAylikTaksitTutari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(869, 130);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "FİYAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(538, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SATIŞ TARİHİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PLAKA";
            // 
            // tbPlaka
            // 
            this.tbPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPlaka.Location = new System.Drawing.Point(139, 8);
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.ReadOnly = true;
            this.tbPlaka.Size = new System.Drawing.Size(235, 20);
            this.tbPlaka.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ÖDEME TİPİ";
            // 
            // dtSatisTarih
            // 
            this.dtSatisTarih.Location = new System.Drawing.Point(636, 8);
            this.dtSatisTarih.Name = "dtSatisTarih";
            this.dtSatisTarih.Size = new System.Drawing.Size(233, 20);
            this.dtSatisTarih.TabIndex = 13;
            // 
            // cbTC
            // 
            this.cbTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTC.FormattingEnabled = true;
            this.cbTC.Location = new System.Drawing.Point(139, 53);
            this.cbTC.Name = "cbTC";
            this.cbTC.Size = new System.Drawing.Size(235, 21);
            this.cbTC.TabIndex = 2;
            this.cbTC.SelectedIndexChanged += new System.EventHandler(this.cbTC_SelectedIndexChanged);
            // 
            // tbFiyat
            // 
            this.tbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFiyat.Location = new System.Drawing.Point(139, 95);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(235, 20);
            this.tbFiyat.TabIndex = 3;
            // 
            // cbOdemeTip
            // 
            this.cbOdemeTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOdemeTip.FormattingEnabled = true;
            this.cbOdemeTip.Items.AddRange(new object[] {
            "Nakit",
            "Taksit"});
            this.cbOdemeTip.Location = new System.Drawing.Point(139, 133);
            this.cbOdemeTip.Name = "cbOdemeTip";
            this.cbOdemeTip.Size = new System.Drawing.Size(235, 21);
            this.cbOdemeTip.TabIndex = 4;
            this.cbOdemeTip.SelectedIndexChanged += new System.EventHandler(this.cbOdemeTip_SelectedIndexChanged);
            // 
            // cbTaksitSayisi
            // 
            this.cbTaksitSayisi.BackColor = System.Drawing.SystemColors.Window;
            this.cbTaksitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTaksitSayisi.FormattingEnabled = true;
            this.cbTaksitSayisi.Items.AddRange(new object[] {
            "2",
            "6",
            "8",
            "12",
            "15",
            "18",
            "24"});
            this.cbTaksitSayisi.Location = new System.Drawing.Point(541, 134);
            this.cbTaksitSayisi.Name = "cbTaksitSayisi";
            this.cbTaksitSayisi.Size = new System.Drawing.Size(58, 21);
            this.cbTaksitSayisi.TabIndex = 5;
            this.cbTaksitSayisi.Visible = false;
            this.cbTaksitSayisi.SelectedIndexChanged += new System.EventHandler(this.cbTaksitSayisi_SelectedIndexChanged);
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksit.Location = new System.Drawing.Point(402, 139);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(95, 13);
            this.lblTaksit.TabIndex = 18;
            this.lblTaksit.Text = "TAKSİT SAYISI";
            this.lblTaksit.Visible = false;
            // 
            // btnSAT
            // 
            this.btnSAT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSAT.BackgroundImage")));
            this.btnSAT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSAT.FlatAppearance.BorderSize = 0;
            this.btnSAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAT.Location = new System.Drawing.Point(810, 164);
            this.btnSAT.Name = "btnSAT";
            this.btnSAT.Size = new System.Drawing.Size(51, 43);
            this.btnSAT.TabIndex = 6;
            this.btnSAT.UseVisualStyleBackColor = true;
            this.btnSAT.Click += new System.EventHandler(this.btnSAT_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 21);
            this.button2.TabIndex = 20;
            this.button2.Text = "Müşteri Bilgisi Görüntüle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(96, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Satışını Yapmak İstediğiniz Aracı Aşağıdaki Liste İçerisinden Seçiniz !";
            // 
            // lblAylikTaksitTutari
            // 
            this.lblAylikTaksitTutari.AutoSize = true;
            this.lblAylikTaksitTutari.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAylikTaksitTutari.Location = new System.Drawing.Point(623, 137);
            this.lblAylikTaksitTutari.Name = "lblAylikTaksitTutari";
            this.lblAylikTaksitTutari.Size = new System.Drawing.Size(17, 17);
            this.lblAylikTaksitTutari.TabIndex = 22;
            this.lblAylikTaksitTutari.Text = "0";
            this.lblAylikTaksitTutari.Visible = false;
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(869, 344);
            this.Controls.Add(this.lblAylikTaksitTutari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSAT);
            this.Controls.Add(this.lblTaksit);
            this.Controls.Add(this.cbTaksitSayisi);
            this.Controls.Add(this.cbOdemeTip);
            this.Controls.Add(this.tbFiyat);
            this.Controls.Add(this.cbTC);
            this.Controls.Add(this.dtSatisTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPlaka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SatisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Formu";
            this.Load += new System.EventHandler(this.SatisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlaka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtSatisTarih;
        private System.Windows.Forms.ComboBox cbTC;
        private System.Windows.Forms.TextBox tbFiyat;
        private System.Windows.Forms.ComboBox cbOdemeTip;
        private System.Windows.Forms.ComboBox cbTaksitSayisi;
        private System.Windows.Forms.Label lblTaksit;
        private System.Windows.Forms.Button btnSAT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAylikTaksitTutari;
    }
}