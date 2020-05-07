namespace CarCollector
{
    partial class MainForm
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
            this.modelListBox = new System.Windows.Forms.ListBox();
            this.brandListBox = new System.Windows.Forms.ListBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.carGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabelTwo = new System.Windows.Forms.Label();
            this.carMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verzamelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carGroupBox.SuspendLayout();
            this.carMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelListBox
            // 
            this.modelListBox.FormattingEnabled = true;
            this.modelListBox.Location = new System.Drawing.Point(12, 366);
            this.modelListBox.Name = "modelListBox";
            this.modelListBox.Size = new System.Drawing.Size(149, 186);
            this.modelListBox.TabIndex = 0;
            this.modelListBox.SelectedIndexChanged += new System.EventHandler(this.modelListBox_SelectedIndexChanged);
            // 
            // brandListBox
            // 
            this.brandListBox.FormattingEnabled = true;
            this.brandListBox.Location = new System.Drawing.Point(12, 125);
            this.brandListBox.Name = "brandListBox";
            this.brandListBox.Size = new System.Drawing.Size(149, 186);
            this.brandListBox.TabIndex = 1;
            this.brandListBox.SelectedIndexChanged += new System.EventHandler(this.brandListBox_SelectedIndexChanged);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(12, 343);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(62, 20);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model:";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(8, 102);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(53, 20);
            this.brandLabel.TabIndex = 3;
            this.brandLabel.Text = "Merk:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(12, 48);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(1361, 20);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Selecteer een merk in de onderstaande lijst. Selecteer vervolgens het gewenste mo" +
    "del. U zult informatie over het voertuig en de aangepaste informatie over het vo" +
    "ertuig in mijn verzameling zien.";
            // 
            // carGroupBox
            // 
            this.carGroupBox.Controls.Add(this.descriptionLabelTwo);
            this.carGroupBox.Location = new System.Drawing.Point(180, 125);
            this.carGroupBox.Name = "carGroupBox";
            this.carGroupBox.Size = new System.Drawing.Size(1188, 426);
            this.carGroupBox.TabIndex = 5;
            this.carGroupBox.TabStop = false;
            this.carGroupBox.Text = "Tim\'s auto";
            // 
            // descriptionLabelTwo
            // 
            this.descriptionLabelTwo.AutoSize = true;
            this.descriptionLabelTwo.Location = new System.Drawing.Point(6, 29);
            this.descriptionLabelTwo.Name = "descriptionLabelTwo";
            this.descriptionLabelTwo.Size = new System.Drawing.Size(0, 13);
            this.descriptionLabelTwo.TabIndex = 0;
            // 
            // carMenuStrip
            // 
            this.carMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.verzamelingToolStripMenuItem});
            this.carMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.carMenuStrip.Name = "carMenuStrip";
            this.carMenuStrip.Size = new System.Drawing.Size(1380, 24);
            this.carMenuStrip.TabIndex = 6;
            this.carMenuStrip.Text = "carMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Bestand";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Afsluiten";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // verzamelingToolStripMenuItem
            // 
            this.verzamelingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem});
            this.verzamelingToolStripMenuItem.Name = "verzamelingToolStripMenuItem";
            this.verzamelingToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.verzamelingToolStripMenuItem.Text = "Verzameling";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addCarToolStripMenuItem.Text = "Een auto toevoegen ";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 563);
            this.Controls.Add(this.carGroupBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.brandListBox);
            this.Controls.Add(this.modelListBox);
            this.Controls.Add(this.carMenuStrip);
            this.MainMenuStrip = this.carMenuStrip;
            this.Name = "MainForm";
            this.Text = "Auto verzamelaar";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.carGroupBox.ResumeLayout(false);
            this.carGroupBox.PerformLayout();
            this.carMenuStrip.ResumeLayout(false);
            this.carMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox modelListBox;
        private System.Windows.Forms.ListBox brandListBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.GroupBox carGroupBox;
        private System.Windows.Forms.MenuStrip carMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verzamelingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.Label descriptionLabelTwo;
    }
}

