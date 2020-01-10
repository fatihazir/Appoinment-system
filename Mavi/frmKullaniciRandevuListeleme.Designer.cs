namespace Mavi
{
    partial class frmKullaniciRandevuListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciRandevuListeleme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvRandevuyaGoreKullanicilar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.Zamanlayici = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuyaGoreKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-9, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 100);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 768);
            this.panel2.TabIndex = 48;
            // 
            // dgvRandevuyaGoreKullanicilar
            // 
            this.dgvRandevuyaGoreKullanicilar.AllowUserToAddRows = false;
            this.dgvRandevuyaGoreKullanicilar.AllowUserToDeleteRows = false;
            this.dgvRandevuyaGoreKullanicilar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRandevuyaGoreKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevuyaGoreKullanicilar.Location = new System.Drawing.Point(180, 189);
            this.dgvRandevuyaGoreKullanicilar.Name = "dgvRandevuyaGoreKullanicilar";
            this.dgvRandevuyaGoreKullanicilar.ReadOnly = true;
            this.dgvRandevuyaGoreKullanicilar.RowHeadersWidth = 51;
            this.dgvRandevuyaGoreKullanicilar.RowTemplate.Height = 24;
            this.dgvRandevuyaGoreKullanicilar.Size = new System.Drawing.Size(885, 454);
            this.dgvRandevuyaGoreKullanicilar.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(175, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "Randevu Sayısına Göre Kullanıcılar";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAnasayfa.Location = new System.Drawing.Point(1107, 707);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(161, 49);
            this.btnAnasayfa.TabIndex = 52;
            this.btnAnasayfa.Text = "< Anasayfaya Dön";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // Zamanlayici
            // 
            this.Zamanlayici.Tick += new System.EventHandler(this.Zamanlayici_Tick);
            // 
            // frmKullaniciRandevuListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.dgvRandevuyaGoreKullanicilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullaniciRandevuListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKullaniciRandevuListeleme";
            this.Load += new System.EventHandler(this.frmKullaniciRandevuListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuyaGoreKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvRandevuyaGoreKullanicilar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Timer Zamanlayici;
    }
}