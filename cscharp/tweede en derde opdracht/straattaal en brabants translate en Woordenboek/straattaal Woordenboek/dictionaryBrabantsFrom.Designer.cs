namespace straattaal_Woordenboek
{
    partial class dictionaryBrabantsFrom
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
            this.translateBrabantsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // translateBrabantsListBox
            // 
            this.translateBrabantsListBox.FormattingEnabled = true;
            this.translateBrabantsListBox.Location = new System.Drawing.Point(12, 9);
            this.translateBrabantsListBox.Name = "translateBrabantsListBox";
            this.translateBrabantsListBox.Size = new System.Drawing.Size(776, 433);
            this.translateBrabantsListBox.TabIndex = 1;
            // 
            // dictionaryBrabantsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.translateBrabantsListBox);
            this.Name = "dictionaryBrabantsFrom";
            this.Text = "dictionaryBrabantsFrom";
            this.Load += new System.EventHandler(this.dictionaryBrabantsFrom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox translateBrabantsListBox;
    }
}