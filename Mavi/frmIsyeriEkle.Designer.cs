namespace Mavi
{
    partial class frmIsyeriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsyeriEkle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIsyeriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsyeriTel = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIsyeriAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnIsyeriEkle = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxKategori = new System.Windows.Forms.ComboBox();
            this.Zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.dgvBasvurular = new System.Windows.Forms.DataGridView();
            this.txtKullanıcıId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvYoneticisizIsyerleri = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnYetkiAta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasvurular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYoneticisizIsyerleri)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 100);
            this.panel1.TabIndex = 3;
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
            this.panel2.TabIndex = 4;
            // 
            // txtIsyeriAdi
            // 
            this.txtIsyeriAdi.BackColor = System.Drawing.SystemColors.Control;
            this.txtIsyeriAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsyeriAdi.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsyeriAdi.Location = new System.Drawing.Point(151, 503);
            this.txtIsyeriAdi.Name = "txtIsyeriAdi";
            this.txtIsyeriAdi.Size = new System.Drawing.Size(215, 22);
            this.txtIsyeriAdi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(426, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefon Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(147, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "İş Yeri Adı";
            // 
            // txtIsyeriTel
            // 
            this.txtIsyeriTel.BackColor = System.Drawing.SystemColors.Control;
            this.txtIsyeriTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsyeriTel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsyeriTel.Location = new System.Drawing.Point(429, 501);
            this.txtIsyeriTel.Name = "txtIsyeriTel";
            this.txtIsyeriTel.Size = new System.Drawing.Size(215, 22);
            this.txtIsyeriTel.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(429, 529);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(150, 531);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 1);
            this.panel4.TabIndex = 7;
            // 
            // txtIsyeriAdres
            // 
            this.txtIsyeriAdres.BackColor = System.Drawing.SystemColors.Control;
            this.txtIsyeriAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsyeriAdres.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsyeriAdres.Location = new System.Drawing.Point(150, 583);
            this.txtIsyeriAdres.Name = "txtIsyeriAdres";
            this.txtIsyeriAdres.Size = new System.Drawing.Size(215, 22);
            this.txtIsyeriAdres.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(146, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "İş Yeri Adresi";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(149, 611);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 1);
            this.panel6.TabIndex = 13;
            // 
            // btnIsyeriEkle
            // 
            this.btnIsyeriEkle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIsyeriEkle.Location = new System.Drawing.Point(427, 679);
            this.btnIsyeriEkle.Name = "btnIsyeriEkle";
            this.btnIsyeriEkle.Size = new System.Drawing.Size(216, 30);
            this.btnIsyeriEkle.TabIndex = 22;
            this.btnIsyeriEkle.Text = "İşyeri Bilgilerini Kaydet";
            this.btnIsyeriEkle.UseVisualStyleBackColor = false;
            this.btnIsyeriEkle.Click += new System.EventHandler(this.btnIsyeriEkle_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAnasayfa.Location = new System.Drawing.Point(1089, 660);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(161, 49);
            this.btnAnasayfa.TabIndex = 23;
            this.btnAnasayfa.Text = "< Anasayfaya Dön";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(145, 637);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kategori";
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
            this.cmbBoxKategori.Location = new System.Drawing.Point(149, 685);
            this.cmbBoxKategori.Name = "cmbBoxKategori";
            this.cmbBoxKategori.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxKategori.TabIndex = 18;
            // 
            // Zamanlayici
            // 
            this.Zamanlayici.Tick += new System.EventHandler(this.Zamanlayici_Tick);
            // 
            // dgvBasvurular
            // 
            this.dgvBasvurular.AllowUserToAddRows = false;
            this.dgvBasvurular.AllowUserToDeleteRows = false;
            this.dgvBasvurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasvurular.Location = new System.Drawing.Point(116, 168);
            this.dgvBasvurular.Name = "dgvBasvurular";
            this.dgvBasvurular.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBasvurular.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBasvurular.RowHeadersWidth = 51;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBasvurular.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBasvurular.RowTemplate.Height = 24;
            this.dgvBasvurular.Size = new System.Drawing.Size(545, 260);
            this.dgvBasvurular.TabIndex = 68;
            // 
            // txtKullanıcıId
            // 
            this.txtKullanıcıId.BackColor = System.Drawing.SystemColors.Control;
            this.txtKullanıcıId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullanıcıId.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıId.Location = new System.Drawing.Point(429, 583);
            this.txtKullanıcıId.Name = "txtKullanıcıId";
            this.txtKullanıcıId.Size = new System.Drawing.Size(215, 22);
            this.txtKullanıcıId.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(425, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 69;
            this.label1.Text = "Kullanıcı ID";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(428, 611);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 1);
            this.panel5.TabIndex = 70;
            // 
            // dgvYoneticisizIsyerleri
            // 
            this.dgvYoneticisizIsyerleri.AllowUserToAddRows = false;
            this.dgvYoneticisizIsyerleri.AllowUserToDeleteRows = false;
            this.dgvYoneticisizIsyerleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYoneticisizIsyerleri.Location = new System.Drawing.Point(705, 168);
            this.dgvYoneticisizIsyerleri.Name = "dgvYoneticisizIsyerleri";
            this.dgvYoneticisizIsyerleri.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYoneticisizIsyerleri.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvYoneticisizIsyerleri.RowHeadersWidth = 51;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYoneticisizIsyerleri.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvYoneticisizIsyerleri.RowTemplate.Height = 24;
            this.dgvYoneticisizIsyerleri.Size = new System.Drawing.Size(545, 260);
            this.dgvYoneticisizIsyerleri.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(111, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 29);
            this.label6.TabIndex = 73;
            this.label6.Text = "Başvuru Tablosu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(700, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 29);
            this.label7.TabIndex = 74;
            this.label7.Text = "Yöneticisiz İşyerleri";
            // 
            // btnYetkiAta
            // 
            this.btnYetkiAta.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnYetkiAta.Location = new System.Drawing.Point(718, 679);
            this.btnYetkiAta.Name = "btnYetkiAta";
            this.btnYetkiAta.Size = new System.Drawing.Size(216, 30);
            this.btnYetkiAta.TabIndex = 75;
            this.btnYetkiAta.Text = "Yönetici Erişimini Tanımla";
            this.btnYetkiAta.UseVisualStyleBackColor = false;
            this.btnYetkiAta.Click += new System.EventHandler(this.btnYetkiAta_Click);
            // 
            // frmIsyeriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.btnYetkiAta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvYoneticisizIsyerleri);
            this.Controls.Add(this.txtKullanıcıId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgvBasvurular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnIsyeriEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBoxKategori);
            this.Controls.Add(this.txtIsyeriAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtIsyeriAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIsyeriTel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIsyeriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Yeri Ekle";
            this.Load += new System.EventHandler(this.frmIsyeriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasvurular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYoneticisizIsyerleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIsyeriAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsyeriTel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIsyeriAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnIsyeriEkle;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxKategori;
        private System.Windows.Forms.Timer Zamanlayici;
        private System.Windows.Forms.DataGridView dgvBasvurular;
        private System.Windows.Forms.TextBox txtKullanıcıId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvYoneticisizIsyerleri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnYetkiAta;
    }
}