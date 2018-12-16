namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griYontemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkSıralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresHoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hücreSaymaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duzenToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // duzenToolStripMenuItem
            // 
            this.duzenToolStripMenuItem.Name = "duzenToolStripMenuItem";
            this.duzenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duzenToolStripMenuItem.Text = "Kapat";
            this.duzenToolStripMenuItem.Click += new System.EventHandler(this.duzenToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkAlToolStripMenuItem,
            this.griYontemleriToolStripMenuItem,
            this.renkSıralamaToolStripMenuItem,
            this.histogramAlToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.toplamaToolStripMenuItem,
            this.thresHoldToolStripMenuItem,
            this.filtrelerToolStripMenuItem,
            this.hücreSaymaToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // renkAlToolStripMenuItem
            // 
            this.renkAlToolStripMenuItem.Name = "renkAlToolStripMenuItem";
            this.renkAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renkAlToolStripMenuItem.Text = "Renk Al";
            this.renkAlToolStripMenuItem.Click += new System.EventHandler(this.renkAlToolStripMenuItem_Click);
            // 
            // griYontemleriToolStripMenuItem
            // 
            this.griYontemleriToolStripMenuItem.Name = "griYontemleriToolStripMenuItem";
            this.griYontemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.griYontemleriToolStripMenuItem.Text = "Gri Yontemleri";
            this.griYontemleriToolStripMenuItem.Click += new System.EventHandler(this.griYontemleriToolStripMenuItem_Click);
            // 
            // renkSıralamaToolStripMenuItem
            // 
            this.renkSıralamaToolStripMenuItem.Name = "renkSıralamaToolStripMenuItem";
            this.renkSıralamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renkSıralamaToolStripMenuItem.Text = "Renk Sıralama";
            this.renkSıralamaToolStripMenuItem.Click += new System.EventHandler(this.renkSıralamaToolStripMenuItem_Click);
            // 
            // histogramAlToolStripMenuItem
            // 
            this.histogramAlToolStripMenuItem.Name = "histogramAlToolStripMenuItem";
            this.histogramAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.histogramAlToolStripMenuItem.Text = "Histogram Al";
            this.histogramAlToolStripMenuItem.Click += new System.EventHandler(this.histogramAlToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.invertToolStripMenuItem.Text = "İnvert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // toplamaToolStripMenuItem
            // 
            this.toplamaToolStripMenuItem.Name = "toplamaToolStripMenuItem";
            this.toplamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toplamaToolStripMenuItem.Text = "Toplama";
            this.toplamaToolStripMenuItem.Click += new System.EventHandler(this.toplamaToolStripMenuItem_Click);
            // 
            // thresHoldToolStripMenuItem
            // 
            this.thresHoldToolStripMenuItem.Name = "thresHoldToolStripMenuItem";
            this.thresHoldToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thresHoldToolStripMenuItem.Text = "ThresHold";
            this.thresHoldToolStripMenuItem.Click += new System.EventHandler(this.thresHoldToolStripMenuItem_Click);
            // 
            // filtrelerToolStripMenuItem
            // 
            this.filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            this.filtrelerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filtrelerToolStripMenuItem.Text = "Filtreler";
            this.filtrelerToolStripMenuItem.Click += new System.EventHandler(this.filtrelerToolStripMenuItem_Click);
            // 
            // hücreSaymaToolStripMenuItem
            // 
            this.hücreSaymaToolStripMenuItem.Name = "hücreSaymaToolStripMenuItem";
            this.hücreSaymaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hücreSaymaToolStripMenuItem.Text = "Hücre sayma";
            this.hücreSaymaToolStripMenuItem.Click += new System.EventHandler(this.hücreSaymaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 512);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griYontemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkSıralamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresHoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hücreSaymaToolStripMenuItem;
    }
}

