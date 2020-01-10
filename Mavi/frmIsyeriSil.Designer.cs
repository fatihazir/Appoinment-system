namespace Mavi
{
    partial class frmIsyeriSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsyeriSil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIsyeriListesi = new System.Windows.Forms.DataGridView();
            this.btnIsyeriSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSilinecekIsyeriId = new System.Windows.Forms.TextBox();
            this.Zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.btnSorulariSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 668);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAnasayfa.Location = new System.Drawing.Point(1107, 707);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(161, 49);
            this.btnAnasayfa.TabIndex = 3;
            this.btnAnasayfa.Text = "< Anasayfaya Dön";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(175, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mevcut İşyerleri";
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
            this.dgvIsyeriListesi.TabIndex = 26;
            // 
            // btnIsyeriSil
            // 
            this.btnIsyeriSil.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIsyeriSil.Location = new System.Drawing.Point(617, 654);
            this.btnIsyeriSil.Name = "btnIsyeriSil";
            this.btnIsyeriSil.Size = new System.Drawing.Size(216, 30);
            this.btnIsyeriSil.TabIndex = 2;
            this.btnIsyeriSil.Text = "İşyerini Sil";
            this.btnIsyeriSil.UseVisualStyleBackColor = false;
            this.btnIsyeriSil.Click += new System.EventHandler(this.btnIsyeriSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(175, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Silinecek İşyerinin İdsini Giriniz:";
            // 
            // txtSilinecekIsyeriId
            // 
            this.txtSilinecekIsyeriId.Location = new System.Drawing.Point(453, 594);
            this.txtSilinecekIsyeriId.Name = "txtSilinecekIsyeriId";
            this.txtSilinecekIsyeriId.Size = new System.Drawing.Size(100, 22);
            this.txtSilinecekIsyeriId.TabIndex = 1;
            // 
            // Zamanlayici
            // 
            this.Zamanlayici.Tick += new System.EventHandler(this.Zamanlayici_Tick);
            // 
            // btnSorulariSil
            // 
            this.btnSorulariSil.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSorulariSil.Location = new System.Drawing.Point(617, 594);
            this.btnSorulariSil.Name = "btnSorulariSil";
            this.btnSorulariSil.Size = new System.Drawing.Size(216, 30);
            this.btnSorulariSil.TabIndex = 29;
            this.btnSorulariSil.Text = "Soruları Sil";
            this.btnSorulariSil.UseVisualStyleBackColor = false;
            this.btnSorulariSil.Click += new System.EventHandler(this.btnSorulariSil_Click);
            // 
            // frmIsyeriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.btnSorulariSil);
            this.Controls.Add(this.txtSilinecekIsyeriId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIsyeriSil);
            this.Controls.Add(this.dgvIsyeriListesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIsyeriSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIsyeriSil";
            this.Load += new System.EventHandler(this.frmIsyeriSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIsyeriListesi;
        private System.Windows.Forms.Button btnIsyeriSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSilinecekIsyeriId;
        private System.Windows.Forms.Timer Zamanlayici;
        private System.Windows.Forms.Button btnSorulariSil;
    }
}