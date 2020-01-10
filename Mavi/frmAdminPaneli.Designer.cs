namespace Mavi
{
    partial class frmAdminPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPaneli));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işYeriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işYeriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işYeriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işYeriAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işYeriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıRandevuListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işYeriRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCik = new System.Windows.Forms.Button();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1162, 596);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(100, 100);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1162, 621);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Enabled = false;
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(1162, 589);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.LeftToolStripPanelVisible = false;
            this.toolStripContainer2.Location = new System.Drawing.Point(100, 100);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.RightToolStripPanelVisible = false;
            this.toolStripContainer2.Size = new System.Drawing.Size(1162, 621);
            this.toolStripContainer2.TabIndex = 7;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Ivory;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işYeriİşlemleriToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 32);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işYeriİşlemleriToolStripMenuItem
            // 
            this.işYeriİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.işYeriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işYeriEkleToolStripMenuItem,
            this.işYeriSilToolStripMenuItem,
            this.işYeriAraToolStripMenuItem,
            this.işYeriGüncelleToolStripMenuItem});
            this.işYeriİşlemleriToolStripMenuItem.Name = "işYeriİşlemleriToolStripMenuItem";
            this.işYeriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(144, 28);
            this.işYeriİşlemleriToolStripMenuItem.Text = "İşyeri İşlemleri";
            // 
            // işYeriEkleToolStripMenuItem
            // 
            this.işYeriEkleToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.işYeriEkleToolStripMenuItem.Name = "işYeriEkleToolStripMenuItem";
            this.işYeriEkleToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.işYeriEkleToolStripMenuItem.Text = "İşyeri Ekle";
            this.işYeriEkleToolStripMenuItem.Click += new System.EventHandler(this.işYeriEkleToolStripMenuItem_Click);
            // 
            // işYeriSilToolStripMenuItem
            // 
            this.işYeriSilToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.işYeriSilToolStripMenuItem.Name = "işYeriSilToolStripMenuItem";
            this.işYeriSilToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.işYeriSilToolStripMenuItem.Text = "İşyeri Sil";
            this.işYeriSilToolStripMenuItem.Click += new System.EventHandler(this.işYeriSilToolStripMenuItem_Click);
            // 
            // işYeriAraToolStripMenuItem
            // 
            this.işYeriAraToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.işYeriAraToolStripMenuItem.Name = "işYeriAraToolStripMenuItem";
            this.işYeriAraToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.işYeriAraToolStripMenuItem.Text = "İşyeri Ara";
            this.işYeriAraToolStripMenuItem.Click += new System.EventHandler(this.işYeriAraToolStripMenuItem_Click);
            // 
            // işYeriGüncelleToolStripMenuItem
            // 
            this.işYeriGüncelleToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.işYeriGüncelleToolStripMenuItem.Name = "işYeriGüncelleToolStripMenuItem";
            this.işYeriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.işYeriGüncelleToolStripMenuItem.Text = "İşyeri Güncelle";
            this.işYeriGüncelleToolStripMenuItem.Click += new System.EventHandler(this.işYeriGüncelleToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıRaporlarıToolStripMenuItem,
            this.işYeriRaporlarıToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(96, 28);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // kullanıcıRaporlarıToolStripMenuItem
            // 
            this.kullanıcıRaporlarıToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.kullanıcıRaporlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıListelemeToolStripMenuItem,
            this.kullanıcıRandevuListelemeToolStripMenuItem});
            this.kullanıcıRaporlarıToolStripMenuItem.Name = "kullanıcıRaporlarıToolStripMenuItem";
            this.kullanıcıRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(246, 28);
            this.kullanıcıRaporlarıToolStripMenuItem.Text = "Kullanıcı Raporları";
            // 
            // kullanıcıListelemeToolStripMenuItem
            // 
            this.kullanıcıListelemeToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.kullanıcıListelemeToolStripMenuItem.Name = "kullanıcıListelemeToolStripMenuItem";
            this.kullanıcıListelemeToolStripMenuItem.Size = new System.Drawing.Size(369, 28);
            this.kullanıcıListelemeToolStripMenuItem.Text = "Kullanıcı Listeleme";
            this.kullanıcıListelemeToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıListelemeToolStripMenuItem_Click);
            // 
            // kullanıcıRandevuListelemeToolStripMenuItem
            // 
            this.kullanıcıRandevuListelemeToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.kullanıcıRandevuListelemeToolStripMenuItem.Name = "kullanıcıRandevuListelemeToolStripMenuItem";
            this.kullanıcıRandevuListelemeToolStripMenuItem.Size = new System.Drawing.Size(369, 28);
            this.kullanıcıRandevuListelemeToolStripMenuItem.Text = "Randevu Sayısına Göre Listeleme";
            this.kullanıcıRandevuListelemeToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıRandevuListelemeToolStripMenuItem_Click);
            // 
            // işYeriRaporlarıToolStripMenuItem
            // 
            this.işYeriRaporlarıToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.işYeriRaporlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işyeriListeleToolStripMenuItem});
            this.işYeriRaporlarıToolStripMenuItem.Name = "işYeriRaporlarıToolStripMenuItem";
            this.işYeriRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(246, 28);
            this.işYeriRaporlarıToolStripMenuItem.Text = "İşyeri Raporları";
            // 
            // işyeriListeleToolStripMenuItem
            // 
            this.işyeriListeleToolStripMenuItem.Name = "işyeriListeleToolStripMenuItem";
            this.işyeriListeleToolStripMenuItem.Size = new System.Drawing.Size(207, 28);
            this.işyeriListeleToolStripMenuItem.Text = "İşyeri Listeme";
            this.işyeriListeleToolStripMenuItem.Click += new System.EventHandler(this.işyeriListeleToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.BackColor = System.Drawing.Color.Ivory;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(101, 28);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 621);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnCik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnCik
            // 
            this.btnCik.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCik.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCik.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCik.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCik.Location = new System.Drawing.Point(1162, 0);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(100, 100);
            this.btnCik.TabIndex = 8;
            this.btnCik.Text = "Cıkış Yap";
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // frmAdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdminPaneli";
            this.Text = "İş Yeri Admin Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işYeriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işYeriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işYeriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işYeriAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işYeriGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işYeriRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.ToolStripMenuItem işyeriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıRandevuListelemeToolStripMenuItem;
    }
}

