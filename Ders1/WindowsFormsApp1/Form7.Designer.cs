namespace WindowsFormsApp1
{
    partial class Form7
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
            this.KaynakBox = new System.Windows.Forms.PictureBox();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.KaynakBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goruntuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goruntuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ikiliİslemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesisşimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bileşimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KaynakBox
            // 
            this.KaynakBox.Location = new System.Drawing.Point(12, 50);
            this.KaynakBox.Name = "KaynakBox";
            this.KaynakBox.Size = new System.Drawing.Size(687, 400);
            this.KaynakBox.TabIndex = 0;
            this.KaynakBox.TabStop = false;
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(402, 456);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(687, 400);
            this.islemBox.TabIndex = 1;
            this.islemBox.TabStop = false;
            // 
            // KaynakBox2
            // 
            this.KaynakBox2.Location = new System.Drawing.Point(705, 50);
            this.KaynakBox2.Name = "KaynakBox2";
            this.KaynakBox2.Size = new System.Drawing.Size(687, 400);
            this.KaynakBox2.TabIndex = 2;
            this.KaynakBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ikiliİslemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1489, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goruntuToolStripMenuItem,
            this.goruntuToolStripMenuItem1});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // goruntuToolStripMenuItem
            // 
            this.goruntuToolStripMenuItem.Name = "goruntuToolStripMenuItem";
            this.goruntuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goruntuToolStripMenuItem.Text = "1.goruntu";
            this.goruntuToolStripMenuItem.Click += new System.EventHandler(this.goruntuToolStripMenuItem_Click);
            // 
            // goruntuToolStripMenuItem1
            // 
            this.goruntuToolStripMenuItem1.Name = "goruntuToolStripMenuItem1";
            this.goruntuToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.goruntuToolStripMenuItem1.Text = "2.goruntu";
            this.goruntuToolStripMenuItem1.Click += new System.EventHandler(this.goruntuToolStripMenuItem1_Click);
            // 
            // ikiliİslemToolStripMenuItem
            // 
            this.ikiliİslemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplamaToolStripMenuItem,
            this.çıkarmaToolStripMenuItem,
            this.kesisşimToolStripMenuItem,
            this.bileşimToolStripMenuItem});
            this.ikiliİslemToolStripMenuItem.Name = "ikiliİslemToolStripMenuItem";
            this.ikiliİslemToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ikiliİslemToolStripMenuItem.Text = "ikili islem";
            // 
            // toplamaToolStripMenuItem
            // 
            this.toplamaToolStripMenuItem.Name = "toplamaToolStripMenuItem";
            this.toplamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toplamaToolStripMenuItem.Text = "Toplama";
            this.toplamaToolStripMenuItem.Click += new System.EventHandler(this.toplamaToolStripMenuItem_Click);
            // 
            // çıkarmaToolStripMenuItem
            // 
            this.çıkarmaToolStripMenuItem.Name = "çıkarmaToolStripMenuItem";
            this.çıkarmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkarmaToolStripMenuItem.Text = "Çıkarma";
            // 
            // kesisşimToolStripMenuItem
            // 
            this.kesisşimToolStripMenuItem.Name = "kesisşimToolStripMenuItem";
            this.kesisşimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kesisşimToolStripMenuItem.Text = "Kesisşim";
            // 
            // bileşimToolStripMenuItem
            // 
            this.bileşimToolStripMenuItem.Name = "bileşimToolStripMenuItem";
            this.bileşimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bileşimToolStripMenuItem.Text = "Bileşim";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 880);
            this.Controls.Add(this.KaynakBox2);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.KaynakBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox KaynakBox;
        private System.Windows.Forms.PictureBox islemBox;
        private System.Windows.Forms.PictureBox KaynakBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goruntuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goruntuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ikiliİslemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkarmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesisşimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bileşimToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}