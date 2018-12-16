namespace WindowsFormsApp1
{
    partial class Form9
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KaynakBox = new System.Windows.Forms.PictureBox();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.filtrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceEdgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homonietyEdgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.filtrelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1406, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.KaynakBox.Location = new System.Drawing.Point(12, 36);
            this.KaynakBox.Name = "KaynakBox";
            this.KaynakBox.Size = new System.Drawing.Size(687, 400);
            this.KaynakBox.TabIndex = 4;
            this.KaynakBox.TabStop = false;
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(705, 36);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(687, 400);
            this.islemBox.TabIndex = 5;
            this.islemBox.TabStop = false;
            // 
            // filtrelerToolStripMenuItem
            // 
            this.filtrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.meanToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.laplacienToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.differenceEdgeToolStripMenuItem,
            this.homonietyEdgeToolStripMenuItem});
            this.filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            this.filtrelerToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.filtrelerToolStripMenuItem.Text = "Low-High Pass Filtreler";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blurToolStripMenuItem.Text = "blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // meanToolStripMenuItem
            // 
            this.meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            this.meanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meanToolStripMenuItem.Text = "mean";
            this.meanToolStripMenuItem.Click += new System.EventHandler(this.meanToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medianToolStripMenuItem.Text = "median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sharpenToolStripMenuItem.Text = "sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // laplacienToolStripMenuItem
            // 
            this.laplacienToolStripMenuItem.Name = "laplacienToolStripMenuItem";
            this.laplacienToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.laplacienToolStripMenuItem.Text = "laplacien";
            this.laplacienToolStripMenuItem.Click += new System.EventHandler(this.laplacienToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobelToolStripMenuItem.Text = "sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // differenceEdgeToolStripMenuItem
            // 
            this.differenceEdgeToolStripMenuItem.Name = "differenceEdgeToolStripMenuItem";
            this.differenceEdgeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.differenceEdgeToolStripMenuItem.Text = "difference edge";
            this.differenceEdgeToolStripMenuItem.Click += new System.EventHandler(this.differenceEdgeToolStripMenuItem_Click);
            // 
            // homonietyEdgeToolStripMenuItem
            // 
            this.homonietyEdgeToolStripMenuItem.Name = "homonietyEdgeToolStripMenuItem";
            this.homonietyEdgeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homonietyEdgeToolStripMenuItem.Text = "Homoniety Edge";
            this.homonietyEdgeToolStripMenuItem.Click += new System.EventHandler(this.homonietyEdgeToolStripMenuItem_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 762);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.KaynakBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form9";
            this.Text = "Form9";
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
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox KaynakBox;
        private System.Windows.Forms.PictureBox islemBox;
        private System.Windows.Forms.ToolStripMenuItem filtrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differenceEdgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homonietyEdgeToolStripMenuItem;
    }
}