namespace WindowsFormsApp1
{
    partial class Form8
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KaynakBox = new System.Windows.Forms.PictureBox();
            this.threshldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.önTanımlıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.brandlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otsuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.threshldToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1420, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // KaynakBox
            // 
            this.KaynakBox.Location = new System.Drawing.Point(21, 27);
            this.KaynakBox.Name = "KaynakBox";
            this.KaynakBox.Size = new System.Drawing.Size(687, 400);
            this.KaynakBox.TabIndex = 3;
            this.KaynakBox.TabStop = false;
            // 
            // threshldToolStripMenuItem
            // 
            this.threshldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.önTanımlıToolStripMenuItem,
            this.brandlyToolStripMenuItem,
            this.otsuToolStripMenuItem});
            this.threshldToolStripMenuItem.Name = "threshldToolStripMenuItem";
            this.threshldToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.threshldToolStripMenuItem.Text = "Threshld";
            // 
            // önTanımlıToolStripMenuItem
            // 
            this.önTanımlıToolStripMenuItem.Name = "önTanımlıToolStripMenuItem";
            this.önTanımlıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.önTanımlıToolStripMenuItem.Text = "ÖnTanımlı";
            this.önTanımlıToolStripMenuItem.Click += new System.EventHandler(this.önTanımlıToolStripMenuItem_Click);
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(724, 27);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(687, 400);
            this.islemBox.TabIndex = 4;
            this.islemBox.TabStop = false;
            // 
            // brandlyToolStripMenuItem
            // 
            this.brandlyToolStripMenuItem.Name = "brandlyToolStripMenuItem";
            this.brandlyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brandlyToolStripMenuItem.Text = "Brandly";
            this.brandlyToolStripMenuItem.Click += new System.EventHandler(this.brandlyToolStripMenuItem_Click);
            // 
            // otsuToolStripMenuItem
            // 
            this.otsuToolStripMenuItem.Name = "otsuToolStripMenuItem";
            this.otsuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otsuToolStripMenuItem.Text = "Otsu";
            this.otsuToolStripMenuItem.Click += new System.EventHandler(this.otsuToolStripMenuItem_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 577);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.KaynakBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form8";
            this.Text = "Form8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threshldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem önTanımlıToolStripMenuItem;
        private System.Windows.Forms.PictureBox KaynakBox;
        private System.Windows.Forms.PictureBox islemBox;
        private System.Windows.Forms.ToolStripMenuItem brandlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otsuToolStripMenuItem;
    }
}