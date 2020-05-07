namespace straattaal_Woordenboek
{
    partial class dictionaryForm
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
            this.translateListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // translateListBox
            // 
            this.translateListBox.FormattingEnabled = true;
            this.translateListBox.Location = new System.Drawing.Point(12, 5);
            this.translateListBox.Name = "translateListBox";
            this.translateListBox.Size = new System.Drawing.Size(776, 433);
            this.translateListBox.TabIndex = 0;
            this.translateListBox.SelectedIndexChanged += new System.EventHandler(this.translateListBox_SelectedIndexChanged);
            // 
            // dictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.translateListBox);
            this.Name = "dictionaryForm";
            this.Text = "Woordenboek straattaal";
            this.Load += new System.EventHandler(this.dictionary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox translateListBox;
    }
}