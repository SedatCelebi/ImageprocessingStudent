namespace WindowsFormsApp1
{
    partial class Form4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToBRGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToGBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToBRGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.KaynakBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.kontrolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem});
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
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // kontrolToolStripMenuItem
            // 
            this.kontrolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGBToBRGToolStripMenuItem,
            this.rGBToGBRToolStripMenuItem,
            this.rGBToBRGToolStripMenuItem1});
            this.kontrolToolStripMenuItem.Name = "kontrolToolStripMenuItem";
            this.kontrolToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.kontrolToolStripMenuItem.Text = "Kanal Tersle";
            // 
            // rGBToBRGToolStripMenuItem
            // 
            this.rGBToBRGToolStripMenuItem.Name = "rGBToBRGToolStripMenuItem";
            this.rGBToBRGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rGBToBRGToolStripMenuItem.Text = "RGB To RBG";
            this.rGBToBRGToolStripMenuItem.Click += new System.EventHandler(this.rGBToBRGToolStripMenuItem_Click);
            // 
            // rGBToGBRToolStripMenuItem
            // 
            this.rGBToGBRToolStripMenuItem.Name = "rGBToGBRToolStripMenuItem";
            this.rGBToGBRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rGBToGBRToolStripMenuItem.Text = "RGB To BGR";
            this.rGBToGBRToolStripMenuItem.Click += new System.EventHandler(this.rGBToGBRToolStripMenuItem_Click);
            // 
            // rGBToBRGToolStripMenuItem1
            // 
            this.rGBToBRGToolStripMenuItem1.Name = "rGBToBRGToolStripMenuItem1";
            this.rGBToBRGToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.rGBToBRGToolStripMenuItem1.Text = "RGB To GRB";
            this.rGBToBRGToolStripMenuItem1.Click += new System.EventHandler(this.rGBToBRGToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // KaynakBox
            // 
            this.KaynakBox.Location = new System.Drawing.Point(37, 46);
            this.KaynakBox.Name = "KaynakBox";
            this.KaynakBox.Size = new System.Drawing.Size(460, 480);
            this.KaynakBox.TabIndex = 3;
            this.KaynakBox.TabStop = false;
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(634, 46);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(460, 480);
            this.islemBox.TabIndex = 3;
            this.islemBox.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 600);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.KaynakBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrolToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox KaynakBox;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem rGBToBRGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToGBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToBRGToolStripMenuItem1;
        private System.Windows.Forms.PictureBox islemBox;
    }
}