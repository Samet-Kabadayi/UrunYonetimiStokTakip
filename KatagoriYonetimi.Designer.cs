namespace UrunYonetimiStokTakip
{
    partial class KatagoriYonetimi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.markaYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwKatagoriler = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.cbKatagoriDurum = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.txtKatagoriAd = new System.Windows.Forms.TextBox();
            this.txtKatagoriAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEklenmeTarihi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKatagoriler)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem,
            this.kullanıcıYönetimiToolStripMenuItem,
            this.müşteriYönetimiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // markaYönetimiToolStripMenuItem
            // 
            this.markaYönetimiToolStripMenuItem.Name = "markaYönetimiToolStripMenuItem";
            this.markaYönetimiToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.markaYönetimiToolStripMenuItem.Text = "Marka Yönetimi";
            this.markaYönetimiToolStripMenuItem.Click += new System.EventHandler(this.markaYönetimiToolStripMenuItem_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            this.ürünYönetimiToolStripMenuItem.Click += new System.EventHandler(this.ürünYönetimiToolStripMenuItem_Click);
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            this.kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            this.kullanıcıYönetimiToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            this.kullanıcıYönetimiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıYönetimiToolStripMenuItem_Click);
            // 
            // müşteriYönetimiToolStripMenuItem
            // 
            this.müşteriYönetimiToolStripMenuItem.Name = "müşteriYönetimiToolStripMenuItem";
            this.müşteriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.müşteriYönetimiToolStripMenuItem.Text = "Müşteri Yönetimi";
            this.müşteriYönetimiToolStripMenuItem.Click += new System.EventHandler(this.müşteriYönetimiToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwKatagoriler);
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 493);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dgwKatagoriler
            // 
            this.dgwKatagoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKatagoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKatagoriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwKatagoriler.Location = new System.Drawing.Point(3, 26);
            this.dgwKatagoriler.Name = "dgwKatagoriler";
            this.dgwKatagoriler.RowHeadersVisible = false;
            this.dgwKatagoriler.RowHeadersWidth = 51;
            this.dgwKatagoriler.RowTemplate.Height = 24;
            this.dgwKatagoriler.Size = new System.Drawing.Size(439, 464);
            this.dgwKatagoriler.TabIndex = 0;
            this.dgwKatagoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKatagoriler_CellClick);
            this.dgwKatagoriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKatagoriler_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTarih);
            this.groupBox2.Controls.Add(this.lblid);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.cbKatagoriDurum);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.txtKatagoriAd);
            this.groupBox2.Controls.Add(this.txtKatagoriAciklama);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtEklenmeTarihi);
            this.groupBox2.Location = new System.Drawing.Point(452, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 242);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Katagori Bilgileri";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(164, 136);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(19, 25);
            this.lblTarih.TabIndex = 11;
            this.lblTarih.Text = "-";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(29, 108);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 25);
            this.lblid.TabIndex = 10;
            this.lblid.Text = "-";
            this.lblid.Visible = false;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(284, 171);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(133, 42);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // cbKatagoriDurum
            // 
            this.cbKatagoriDurum.AutoSize = true;
            this.cbKatagoriDurum.Location = new System.Drawing.Point(168, 104);
            this.cbKatagoriDurum.Name = "cbKatagoriDurum";
            this.cbKatagoriDurum.Size = new System.Drawing.Size(92, 29);
            this.cbKatagoriDurum.TabIndex = 9;
            this.cbKatagoriDurum.Text = "Durum";
            this.cbKatagoriDurum.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 171);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(133, 42);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(145, 171);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(133, 42);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // txtKatagoriAd
            // 
            this.txtKatagoriAd.Location = new System.Drawing.Point(133, 29);
            this.txtKatagoriAd.Name = "txtKatagoriAd";
            this.txtKatagoriAd.Size = new System.Drawing.Size(179, 30);
            this.txtKatagoriAd.TabIndex = 8;
            // 
            // txtKatagoriAciklama
            // 
            this.txtKatagoriAciklama.Location = new System.Drawing.Point(133, 64);
            this.txtKatagoriAciklama.Multiline = true;
            this.txtKatagoriAciklama.Name = "txtKatagoriAciklama";
            this.txtKatagoriAciklama.Size = new System.Drawing.Size(179, 29);
            this.txtKatagoriAciklama.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Katagori Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Açıklama:";
            // 
            // TxtEklenmeTarihi
            // 
            this.TxtEklenmeTarihi.AutoSize = true;
            this.TxtEklenmeTarihi.Location = new System.Drawing.Point(20, 136);
            this.TxtEklenmeTarihi.Name = "TxtEklenmeTarihi";
            this.TxtEklenmeTarihi.Size = new System.Drawing.Size(148, 25);
            this.TxtEklenmeTarihi.TabIndex = 6;
            this.TxtEklenmeTarihi.Text = "Eklenme Tarihi:";
            this.TxtEklenmeTarihi.Click += new System.EventHandler(this.TxtEklenmeTarihi_Click);
            // 
            // KatagoriYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(885, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KatagoriYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katagori Yönetimi";
            this.Load += new System.EventHandler(this.KatagoriYonetimi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKatagoriler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem markaYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwKatagoriler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKatagoriAd;
        private System.Windows.Forms.TextBox txtKatagoriAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtEklenmeTarihi;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.CheckBox cbKatagoriDurum;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ToolStripMenuItem müşteriYönetimiToolStripMenuItem;
    }
}