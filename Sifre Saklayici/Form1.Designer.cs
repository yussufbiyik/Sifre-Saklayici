namespace Sifre_Saklayici
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.siteGirdisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.epostaGirdisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreGirdisi = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ekleButon = new System.Windows.Forms.Button();
            this.kaldirButon = new System.Windows.Forms.Button();
            this.aramaGirdisi = new System.Windows.Forms.TextBox();
            this.araButon = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sifreSayaci = new System.Windows.Forms.ToolStripStatusLabel();
            this.sifreListesi = new System.Windows.Forms.ListBox();
            this.gizleButon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontrol Paneli";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.siteGirdisi);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.epostaGirdisi);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.sifreGirdisi);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(9, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(185, 370);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site:";
            // 
            // siteGirdisi
            // 
            this.siteGirdisi.Location = new System.Drawing.Point(3, 17);
            this.siteGirdisi.Name = "siteGirdisi";
            this.siteGirdisi.Size = new System.Drawing.Size(179, 20);
            this.siteGirdisi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı/E-Posta:";
            // 
            // epostaGirdisi
            // 
            this.epostaGirdisi.Location = new System.Drawing.Point(3, 57);
            this.epostaGirdisi.Name = "epostaGirdisi";
            this.epostaGirdisi.Size = new System.Drawing.Size(179, 20);
            this.epostaGirdisi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre:";
            // 
            // sifreGirdisi
            // 
            this.sifreGirdisi.Location = new System.Drawing.Point(3, 97);
            this.sifreGirdisi.Name = "sifreGirdisi";
            this.sifreGirdisi.PasswordChar = '*';
            this.sifreGirdisi.Size = new System.Drawing.Size(179, 20);
            this.sifreGirdisi.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ekleButon);
            this.flowLayoutPanel1.Controls.Add(this.kaldirButon);
            this.flowLayoutPanel1.Controls.Add(this.gizleButon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 395);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 64);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ekleButon
            // 
            this.ekleButon.BackColor = System.Drawing.Color.DarkGreen;
            this.ekleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleButon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleButon.ForeColor = System.Drawing.Color.White;
            this.ekleButon.Location = new System.Drawing.Point(3, 3);
            this.ekleButon.Name = "ekleButon";
            this.ekleButon.Size = new System.Drawing.Size(88, 25);
            this.ekleButon.TabIndex = 0;
            this.ekleButon.Text = "Ekle";
            this.ekleButon.UseVisualStyleBackColor = false;
            this.ekleButon.Click += new System.EventHandler(this.ekleButon_Click);
            // 
            // kaldirButon
            // 
            this.kaldirButon.BackColor = System.Drawing.Color.Maroon;
            this.kaldirButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaldirButon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaldirButon.ForeColor = System.Drawing.Color.White;
            this.kaldirButon.Location = new System.Drawing.Point(97, 3);
            this.kaldirButon.Name = "kaldirButon";
            this.kaldirButon.Size = new System.Drawing.Size(88, 25);
            this.kaldirButon.TabIndex = 1;
            this.kaldirButon.Text = "Kaldır";
            this.kaldirButon.UseVisualStyleBackColor = false;
            this.kaldirButon.Click += new System.EventHandler(this.kaldirButon_Click);
            // 
            // aramaGirdisi
            // 
            this.aramaGirdisi.Location = new System.Drawing.Point(218, 13);
            this.aramaGirdisi.Multiline = true;
            this.aramaGirdisi.Name = "aramaGirdisi";
            this.aramaGirdisi.Size = new System.Drawing.Size(488, 27);
            this.aramaGirdisi.TabIndex = 2;
            // 
            // araButon
            // 
            this.araButon.BackColor = System.Drawing.SystemColors.Highlight;
            this.araButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.araButon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButon.ForeColor = System.Drawing.Color.White;
            this.araButon.Location = new System.Drawing.Point(712, 13);
            this.araButon.Name = "araButon";
            this.araButon.Size = new System.Drawing.Size(76, 27);
            this.araButon.TabIndex = 3;
            this.araButon.Text = "Ara";
            this.araButon.UseVisualStyleBackColor = false;
            this.araButon.Click += new System.EventHandler(this.araButon_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sifreSayaci});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sifreSayaci
            // 
            this.sifreSayaci.Name = "sifreSayaci";
            this.sifreSayaci.Size = new System.Drawing.Size(139, 17);
            this.sifreSayaci.Text = "Toplam 0 Şifre Kaydedildi";
            // 
            // sifreListesi
            // 
            this.sifreListesi.FormattingEnabled = true;
            this.sifreListesi.ItemHeight = 14;
            this.sifreListesi.Location = new System.Drawing.Point(219, 47);
            this.sifreListesi.Name = "sifreListesi";
            this.sifreListesi.Size = new System.Drawing.Size(569, 424);
            this.sifreListesi.TabIndex = 5;
            // 
            // gizleButon
            // 
            this.gizleButon.BackColor = System.Drawing.Color.Chocolate;
            this.gizleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gizleButon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gizleButon.ForeColor = System.Drawing.Color.White;
            this.gizleButon.Location = new System.Drawing.Point(3, 34);
            this.gizleButon.Name = "gizleButon";
            this.gizleButon.Size = new System.Drawing.Size(182, 25);
            this.gizleButon.TabIndex = 2;
            this.gizleButon.Text = "Şifreleri Gizle";
            this.gizleButon.UseVisualStyleBackColor = false;
            this.gizleButon.Click += new System.EventHandler(this.gizleButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.sifreListesi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.araButon);
            this.Controls.Add(this.aramaGirdisi);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Şifre Saklayıcı";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ekleButon;
        private System.Windows.Forms.Button kaldirButon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox siteGirdisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox epostaGirdisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreGirdisi;
        private System.Windows.Forms.TextBox aramaGirdisi;
        private System.Windows.Forms.Button araButon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sifreSayaci;
        private System.Windows.Forms.ListBox sifreListesi;
        private System.Windows.Forms.Button gizleButon;
    }
}

