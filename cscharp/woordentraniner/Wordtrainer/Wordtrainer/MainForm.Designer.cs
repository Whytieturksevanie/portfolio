namespace Wordtrainer
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
            this.GermanLabel = new System.Windows.Forms.Label();
            this.GermanTextBox = new System.Windows.Forms.TextBox();
            this.DutchLabel = new System.Windows.Forms.Label();
            this.DutchTextBox = new System.Windows.Forms.TextBox();
            this.translateListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.exerciseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GermanLabel
            // 
            this.GermanLabel.AutoSize = true;
            this.GermanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GermanLabel.Location = new System.Drawing.Point(12, 9);
            this.GermanLabel.Name = "GermanLabel";
            this.GermanLabel.Size = new System.Drawing.Size(51, 24);
            this.GermanLabel.TabIndex = 0;
            this.GermanLabel.Text = "Duits";
            this.GermanLabel.Click += new System.EventHandler(this.GermanLabel_Click);
            // 
            // GermanTextBox
            // 
            this.GermanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GermanTextBox.Location = new System.Drawing.Point(12, 36);
            this.GermanTextBox.Name = "GermanTextBox";
            this.GermanTextBox.Size = new System.Drawing.Size(186, 26);
            this.GermanTextBox.TabIndex = 1;
            // 
            // DutchLabel
            // 
            this.DutchLabel.AutoSize = true;
            this.DutchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DutchLabel.Location = new System.Drawing.Point(12, 82);
            this.DutchLabel.Name = "DutchLabel";
            this.DutchLabel.Size = new System.Drawing.Size(108, 24);
            this.DutchLabel.TabIndex = 2;
            this.DutchLabel.Text = "Nederlands";
            this.DutchLabel.Click += new System.EventHandler(this.DutchLabel_Click);
            // 
            // DutchTextBox
            // 
            this.DutchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DutchTextBox.Location = new System.Drawing.Point(12, 109);
            this.DutchTextBox.Name = "DutchTextBox";
            this.DutchTextBox.Size = new System.Drawing.Size(186, 26);
            this.DutchTextBox.TabIndex = 3;
            // 
            // translateListBox
            // 
            this.translateListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateListBox.FormattingEnabled = true;
            this.translateListBox.ItemHeight = 20;
            this.translateListBox.Location = new System.Drawing.Point(223, 27);
            this.translateListBox.Name = "translateListBox";
            this.translateListBox.Size = new System.Drawing.Size(273, 404);
            this.translateListBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(110, 158);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 35);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Toevoegen";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exerciseButton
            // 
            this.exerciseButton.Location = new System.Drawing.Point(12, 397);
            this.exerciseButton.Name = "exerciseButton";
            this.exerciseButton.Size = new System.Drawing.Size(201, 37);
            this.exerciseButton.TabIndex = 6;
            this.exerciseButton.Text = "Oefenen";
            this.exerciseButton.UseVisualStyleBackColor = true;
            this.exerciseButton.Click += new System.EventHandler(this.exerciseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.exerciseButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.translateListBox);
            this.Controls.Add(this.DutchTextBox);
            this.Controls.Add(this.DutchLabel);
            this.Controls.Add(this.GermanTextBox);
            this.Controls.Add(this.GermanLabel);
            this.Name = "MainForm";
            this.Text = "Woordtraniner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GermanLabel;
        public System.Windows.Forms.TextBox GermanTextBox;
        private System.Windows.Forms.Label DutchLabel;
        public System.Windows.Forms.TextBox DutchTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exerciseButton;
        public System.Windows.Forms.ListBox translateListBox;
    }
}

