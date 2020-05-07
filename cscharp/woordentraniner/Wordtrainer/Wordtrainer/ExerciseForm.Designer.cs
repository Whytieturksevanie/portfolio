namespace Wordtrainer
{
    partial class ExerciseForm
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
            this.exerciseLabel = new System.Windows.Forms.Label();
            this.exerciseTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exerciseLabel
            // 
            this.exerciseLabel.AutoSize = true;
            this.exerciseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseLabel.Location = new System.Drawing.Point(214, 25);
            this.exerciseLabel.Name = "exerciseLabel";
            this.exerciseLabel.Size = new System.Drawing.Size(142, 24);
            this.exerciseLabel.TabIndex = 0;
            this.exerciseLabel.Text = "Woord oefenen";
            this.exerciseLabel.Click += new System.EventHandler(this.exerciseLabel_Click);
            // 
            // exerciseTextBox
            // 
            this.exerciseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseTextBox.Location = new System.Drawing.Point(12, 82);
            this.exerciseTextBox.Name = "exerciseTextBox";
            this.exerciseTextBox.Size = new System.Drawing.Size(546, 31);
            this.exerciseTextBox.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(12, 137);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(546, 51);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Volgende";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 217);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.exerciseTextBox);
            this.Controls.Add(this.exerciseLabel);
            this.Name = "ExerciseForm";
            this.Text = "Oefenen";
            this.Load += new System.EventHandler(this.ExerciseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exerciseLabel;
        private System.Windows.Forms.TextBox exerciseTextBox;
        private System.Windows.Forms.Button nextButton;
    }
}