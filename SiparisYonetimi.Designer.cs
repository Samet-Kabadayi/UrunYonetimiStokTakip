namespace UrunYonetimiStokTakip
{
    partial class SiparisYonetimi
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
            this.dgwSiparisler = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dtpSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbMusteriler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbUrunler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiparis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.katagoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müsteriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSiparisler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwSiparisler
            // 
            this.dgwSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSiparisler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SiparisNo,
            this.MusteriId,
            this.UrunId,
            this.SiparisTarihi});
            this.dgwSiparisler.Location = new System.Drawing.Point(1, 28);
            this.dgwSiparisler.Margin = new System.Windows.Forms.Padding(0);
            this.dgwSiparisler.Name = "dgwSiparisler";
            this.dgwSiparisler.RowHeadersVisible = false;
            this.dgwSiparisler.RowHeadersWidth = 51;
            this.dgwSiparisler.RowTemplate.Height = 24;
            this.dgwSiparisler.Size = new System.Drawing.Size(585, 491);
            this.dgwSiparisler.TabIndex = 0;
            this.dgwSiparisler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSiparisler_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "No";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // SiparisNo
            // 
            this.SiparisNo.DataPropertyName = "SiparisNo";
            this.SiparisNo.HeaderText = "Sipariş Numarası";
            this.SiparisNo.MinimumWidth = 6;
            this.SiparisNo.Name = "SiparisNo";
            // 
            // MusteriId
            // 
            this.MusteriId.DataPropertyName = "MusteriId";
            this.MusteriId.HeaderText = "Müşteri";
            this.MusteriId.MinimumWidth = 6;
            this.MusteriId.Name = "MusteriId";
            // 
            // UrunId
            // 
            this.UrunId.DataPropertyName = "UrunId";
            this.UrunId.HeaderText = "Ürün";
            this.UrunId.MinimumWidth = 6;
            this.UrunId.Name = "UrunId";
            // 
            // SiparisTarihi
            // 
            this.SiparisTarihi.DataPropertyName = "SiparisTarihi";
            this.SiparisTarihi.HeaderText = "Sipariş Tarihi";
            this.SiparisTarihi.MinimumWidth = 6;
            this.SiparisTarihi.Name = "SiparisTarihi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.dtpSiparisTarihi);
            this.groupBox1.Controls.Add(this.cbMusteriler);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbUrunler);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSiparis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(589, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(6, 33);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(23, 25);
            this.lblid.TabIndex = 13;
            this.lblid.Text = "0";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(132, 204);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 45);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(246, 204);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 45);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(18, 204);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(108, 45);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dtpSiparisTarihi
            // 
            this.dtpSiparisTarihi.Location = new System.Drawing.Point(162, 129);
            this.dtpSiparisTarihi.Name = "dtpSiparisTarihi";
            this.dtpSiparisTarihi.Size = new System.Drawing.Size(178, 30);
            this.dtpSiparisTarihi.TabIndex = 9;
            // 
            // cbMusteriler
            // 
            this.cbMusteriler.DisplayMember = "UrunAd";
            this.cbMusteriler.FormattingEnabled = true;
            this.cbMusteriler.Location = new System.Drawing.Point(161, 61);
            this.cbMusteriler.Name = "cbMusteriler";
            this.cbMusteriler.Size = new System.Drawing.Size(179, 33);
            this.cbMusteriler.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sipariş No:";
            // 
            // cbUrunler
            // 
            this.cbUrunler.FormattingEnabled = true;
            this.cbUrunler.Location = new System.Drawing.Point(161, 95);
            this.cbUrunler.Name = "cbUrunler";
            this.cbUrunler.Size = new System.Drawing.Size(179, 33);
            this.cbUrunler.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün:";
            // 
            // txtSiparis
            // 
            this.txtSiparis.Location = new System.Drawing.Point(161, 25);
            this.txtSiparis.Name = "txtSiparis";
            this.txtSiparis.Size = new System.Drawing.Size(179, 30);
            this.txtSiparis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş Tarihi:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.katagoriYönetimiToolStripMenuItem,
            this.markaYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem,
            this.kullanıcıYönetimiToolStripMenuItem,
            this.müsteriYönetimiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // katagoriYönetimiToolStripMenuItem
            // 
            this.katagoriYönetimiToolStripMenuItem.Name = "katagoriYönetimiToolStripMenuItem";
            this.katagoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.katagoriYönetimiToolStripMenuItem.Text = "Katagori Yönetimi";
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
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            this.kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            this.kullanıcıYönetimiToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            // 
            // müsteriYönetimiToolStripMenuItem
            // 
            this.müsteriYönetimiToolStripMenuItem.Name = "müsteriYönetimiToolStripMenuItem";
            this.müsteriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.müsteriYönetimiToolStripMenuItem.Text = "Müsteri Yönetimi";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // SiparisYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(975, 520);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwSiparisler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SiparisYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Yönetimi";
            this.Load += new System.EventHandler(this.SiparisYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSiparisler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpSiparisTarihi;
        private System.Windows.Forms.ComboBox cbMusteriler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbUrunler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSiparis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem katagoriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müsteriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisTarihi;
    }
}