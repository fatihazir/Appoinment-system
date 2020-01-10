namespace Mavi
{
    partial class frmIsyeriAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsyeriAra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvIsyeriListesi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsyeriAdindanAramaMetni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsyeriYoneticiAdindanAramaMetni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Zamanlayici = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListesi)).BeginInit();
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
            this.panel1.TabIndex = 24;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAnasayfa.Location = new System.Drawing.Point(1089, 660);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(161, 49);
            this.btnAnasayfa.TabIndex = 2;
            this.btnAnasayfa.Text = "< Anasayfaya Dön";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 721);
            this.panel2.TabIndex = 25;
            // 
            // dgvIsyeriListesi
            // 
            this.dgvIsyeriListesi.AllowUserToAddRows = false;
            this.dgvIsyeriListesi.AllowUserToDeleteRows = false;
            this.dgvIsyeriListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIsyeriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsyeriListesi.Location = new System.Drawing.Point(180, 189);
            this.dgvIsyeriListesi.Name = "dgvIsyeriListesi";
            this.dgvIsyeriListesi.ReadOnly = true;
            this.dgvIsyeriListesi.RowHeadersWidth = 51;
            this.dgvIsyeriListesi.RowTemplate.Height = 24;
            this.dgvIsyeriListesi.Size = new System.Drawing.Size(1003, 360);
            this.dgvIsyeriListesi.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(175, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mevcut İşyerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 39;
            // 
            // txtIsyeriAdindanAramaMetni
            // 
            this.txtIsyeriAdindanAramaMetni.Location = new System.Drawing.Point(398, 588);
            this.txtIsyeriAdindanAramaMetni.Name = "txtIsyeriAdindanAramaMetni";
            this.txtIsyeriAdindanAramaMetni.Size = new System.Drawing.Size(219, 22);
            this.txtIsyeriAdindanAramaMetni.TabIndex = 1;
            this.txtIsyeriAdindanAramaMetni.TextChanged += new System.EventHandler(this.txtAramaMetni_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(176, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "İşyeri adını giriniz:";
            // 
            // txtIsyeriYoneticiAdindanAramaMetni
            // 
            this.txtIsyeriYoneticiAdindanAramaMetni.Location = new System.Drawing.Point(460, 624);
            this.txtIsyeriYoneticiAdindanAramaMetni.Name = "txtIsyeriYoneticiAdindanAramaMetni";
            this.txtIsyeriYoneticiAdindanAramaMetni.Size = new System.Drawing.Size(219, 22);
            this.txtIsyeriYoneticiAdindanAramaMetni.TabIndex = 43;
            this.txtIsyeriYoneticiAdindanAramaMetni.TextChanged += new System.EventHandler(this.txtIsyeriYoneticiAdindanAramaMetni_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(176, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "İşyeri yönetici adını giriniz:";
            // 
            // Zamanlayici
            // 
            this.Zamanlayici.Tick += new System.EventHandler(this.Zamanlayici_Tick);
            // 
            // frmIsyeriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.txtIsyeriYoneticiAdindanAramaMetni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIsyeriAdindanAramaMetni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvIsyeriListesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIsyeriAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIsyeriAra";
            this.Load += new System.EventHandler(this.frmIsyeriAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvIsyeriListesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsyeriAdindanAramaMetni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsyeriYoneticiAdindanAramaMetni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Zamanlayici;
    }
}