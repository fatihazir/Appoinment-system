namespace Mavi
{
    partial class frmIsyeriGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsyeriGuncelle));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnIsyeriGuncelle = new System.Windows.Forms.Button();
            this.dgvIsyeriListesi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxKategori = new System.Windows.Forms.ComboBox();
            this.txtIsyeriAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtIsyeriAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIsyeriTel = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIsyeriId = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListesi)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 100);
            this.panel1.TabIndex = 22;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAnasayfa.Location = new System.Drawing.Point(1089, 660);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(161, 49);
            this.btnAnasayfa.TabIndex = 8;
            this.btnAnasayfa.Text = "< Anasayfaya Dön";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnIsyeriGuncelle
            // 
            this.btnIsyeriGuncelle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIsyeriGuncelle.Location = new System.Drawing.Point(607, 571);
            this.btnIsyeriGuncelle.Name = "btnIsyeriGuncelle";
            this.btnIsyeriGuncelle.Size = new System.Drawing.Size(211, 49);
            this.btnIsyeriGuncelle.TabIndex = 7;
            this.btnIsyeriGuncelle.Text = "Seçilen İşyerini Güncelle";
            this.btnIsyeriGuncelle.UseVisualStyleBackColor = false;
            this.btnIsyeriGuncelle.Click += new System.EventHandler(this.btnIsyeriGuncelle_Click);
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
            this.dgvIsyeriListesi.Size = new System.Drawing.Size(640, 360);
            this.dgvIsyeriListesi.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(175, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mevcut İşyerleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(851, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 56;
            this.label2.Text = "Kategori";
            // 
            // cmbBoxKategori
            // 
            this.cmbBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxKategori.FormattingEnabled = true;
            this.cmbBoxKategori.Items.AddRange(new object[] {
            "Adalet",
            "Hukuk",
            "Maliye",
            "Mühendislik",
            "Diş"});
            this.cmbBoxKategori.Location = new System.Drawing.Point(854, 557);
            this.cmbBoxKategori.Name = "cmbBoxKategori";
            this.cmbBoxKategori.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxKategori.TabIndex = 6;
            // 
            // txtIsyeriAdres
            // 
            this.txtIsyeriAdres.BackColor = System.Drawing.SystemColors.Control;
            this.txtIsyeriAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsyeriAdres.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsyeriAdres.Location = new System.Drawing.Point(850, 448);
            this.txtIsyeriAdres.Name = "txtIsyeriAdres";
            this.txtIsyeriAdres.Size = new System.Drawing.Size(215, 22);
            this.txtIsyeriAdres.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(846, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "İş Yeri Adresi";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(849, 476);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 1);
            this.panel6.TabIndex = 53;
            // 
            // txtIsyeriAdi
            // 
            this.txtIsyeriAdi.BackColor = System.Drawing.SystemColors.Control;
            this.txtIsyeriAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsyeriAdi.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsyeriAdi.Location = new System.Drawing.Point(849, 283);
            this.txtIsyeriAdi.Name = "txtIsyeriAdi";
            this.txtIsyeriAdi.Size = new System.Drawing.Size(215, 22);
            this.txtIsyeriAdi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(845, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Telefon Numarası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(845, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 46;
            this.label7.Text = "İş Yeri Adı";
            // 
            // txtIsyeriTel
            // 
            this.txtIsyeriTel.BackColor = System.Drawing.SystemColors.Control;
            this.txtIsyeriTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsyeriTel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsyeriTel.Location = new System.Drawing.Point(848, 369);
            this.txtIsyeriTel.Name = "txtIsyeriTel";
            this.txtIsyeriTel.Size = new System.Drawing.Size(215, 22);
            this.txtIsyeriTel.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(848, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 48;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(848, 311);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 1);
            this.panel4.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(844, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 62;
            this.label8.Text = "İşyeri Id";
            // 
            // txtIsyeriId
            // 
            this.txtIsyeriId.BackColor = System.Drawing.SystemColors.Control;
            this.txtIsyeriId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsyeriId.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsyeriId.Location = new System.Drawing.Point(848, 213);
            this.txtIsyeriId.Name = "txtIsyeriId";
            this.txtIsyeriId.Size = new System.Drawing.Size(215, 22);
            this.txtIsyeriId.TabIndex = 1;
            this.txtIsyeriId.Text = "Güncellenecek İşyeri";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(848, 241);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(215, 1);
            this.panel7.TabIndex = 60;
            // 
            // Zamanlayici
            // 
            this.Zamanlayici.Tick += new System.EventHandler(this.Zamanlayici_Tick);
            // 
            // frmIsyeriGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIsyeriId);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoxKategori);
            this.Controls.Add(this.txtIsyeriAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtIsyeriAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIsyeriTel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnIsyeriGuncelle);
            this.Controls.Add(this.dgvIsyeriListesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIsyeriGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIsyeriGuncelle";
            this.Load += new System.EventHandler(this.frmIsyeriGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnIsyeriGuncelle;
        private System.Windows.Forms.DataGridView dgvIsyeriListesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxKategori;
        private System.Windows.Forms.TextBox txtIsyeriAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIsyeriAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIsyeriTel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIsyeriId;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Timer Zamanlayici;
        private System.Windows.Forms.Timer timer1;
    }
}