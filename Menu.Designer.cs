namespace UrunYonetimiStokTakip
{
    partial class Menu
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
            this.btnkatagori = new System.Windows.Forms.Button();
            this.btnkullanici = new System.Windows.Forms.Button();
            this.btnmarkayonetimi = new System.Windows.Forms.Button();
            this.btnMusteriYonetimi = new System.Windows.Forms.Button();
            this.btnSiparisYonetimi = new System.Windows.Forms.Button();
            this.btnUrunYonetimi = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkatagori
            // 
            this.btnkatagori.BackColor = System.Drawing.SystemColors.Info;
            this.btnkatagori.Location = new System.Drawing.Point(60, 60);
            this.btnkatagori.Name = "btnkatagori";
            this.btnkatagori.Size = new System.Drawing.Size(142, 101);
            this.btnkatagori.TabIndex = 0;
            this.btnkatagori.Text = "Katagori Yönetimi";
            this.btnkatagori.UseVisualStyleBackColor = false;
            this.btnkatagori.Click += new System.EventHandler(this.btnkatagori_Click);
            // 
            // btnkullanici
            // 
            this.btnkullanici.BackColor = System.Drawing.SystemColors.Info;
            this.btnkullanici.Location = new System.Drawing.Point(208, 60);
            this.btnkullanici.Name = "btnkullanici";
            this.btnkullanici.Size = new System.Drawing.Size(142, 101);
            this.btnkullanici.TabIndex = 1;
            this.btnkullanici.Text = "Kullanıcı Yönetimi";
            this.btnkullanici.UseVisualStyleBackColor = false;
            this.btnkullanici.Click += new System.EventHandler(this.btnkullanici_Click);
            // 
            // btnmarkayonetimi
            // 
            this.btnmarkayonetimi.BackColor = System.Drawing.SystemColors.Info;
            this.btnmarkayonetimi.Location = new System.Drawing.Point(356, 60);
            this.btnmarkayonetimi.Name = "btnmarkayonetimi";
            this.btnmarkayonetimi.Size = new System.Drawing.Size(142, 101);
            this.btnmarkayonetimi.TabIndex = 2;
            this.btnmarkayonetimi.Text = "Marka Yönetimi";
            this.btnmarkayonetimi.UseVisualStyleBackColor = false;
            this.btnmarkayonetimi.Click += new System.EventHandler(this.btnmarkayonetimi_Click);
            // 
            // btnMusteriYonetimi
            // 
            this.btnMusteriYonetimi.BackColor = System.Drawing.SystemColors.Info;
            this.btnMusteriYonetimi.Location = new System.Drawing.Point(60, 167);
            this.btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            this.btnMusteriYonetimi.Size = new System.Drawing.Size(142, 101);
            this.btnMusteriYonetimi.TabIndex = 3;
            this.btnMusteriYonetimi.Text = "Müşteri Yönetimi";
            this.btnMusteriYonetimi.UseVisualStyleBackColor = false;
            this.btnMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // btnSiparisYonetimi
            // 
            this.btnSiparisYonetimi.BackColor = System.Drawing.SystemColors.Info;
            this.btnSiparisYonetimi.Location = new System.Drawing.Point(208, 167);
            this.btnSiparisYonetimi.Name = "btnSiparisYonetimi";
            this.btnSiparisYonetimi.Size = new System.Drawing.Size(142, 101);
            this.btnSiparisYonetimi.TabIndex = 4;
            this.btnSiparisYonetimi.Text = "Sipariş Yönetimi";
            this.btnSiparisYonetimi.UseVisualStyleBackColor = false;
            this.btnSiparisYonetimi.Click += new System.EventHandler(this.btnSiparisYonetimi_Click);
            // 
            // btnUrunYonetimi
            // 
            this.btnUrunYonetimi.BackColor = System.Drawing.SystemColors.Info;
            this.btnUrunYonetimi.Location = new System.Drawing.Point(356, 167);
            this.btnUrunYonetimi.Name = "btnUrunYonetimi";
            this.btnUrunYonetimi.Size = new System.Drawing.Size(142, 101);
            this.btnUrunYonetimi.TabIndex = 5;
            this.btnUrunYonetimi.Text = "Ürün Yönetimi";
            this.btnUrunYonetimi.UseVisualStyleBackColor = false;
            this.btnUrunYonetimi.Click += new System.EventHandler(this.btnUrunYonetimi_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(60, 274);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(438, 41);
            this.btncikis.TabIndex = 6;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(606, 412);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnUrunYonetimi);
            this.Controls.Add(this.btnSiparisYonetimi);
            this.Controls.Add(this.btnMusteriYonetimi);
            this.Controls.Add(this.btnmarkayonetimi);
            this.Controls.Add(this.btnkullanici);
            this.Controls.Add(this.btnkatagori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkatagori;
        private System.Windows.Forms.Button btnkullanici;
        private System.Windows.Forms.Button btnmarkayonetimi;
        private System.Windows.Forms.Button btnMusteriYonetimi;
        private System.Windows.Forms.Button btnSiparisYonetimi;
        private System.Windows.Forms.Button btnUrunYonetimi;
        private System.Windows.Forms.Button btncikis;
    }
}