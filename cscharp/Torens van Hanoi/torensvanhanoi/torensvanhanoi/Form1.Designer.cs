namespace torensvanhanoi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.forloopButton = new System.Windows.Forms.Button();
            this.mathButton = new System.Windows.Forms.Button();
            this.recursieButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Onderdelen van het product";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(12, 64);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(459, 40);
            this.inputTextBox.TabIndex = 2;
            // 
            // forloopButton
            // 
            this.forloopButton.Location = new System.Drawing.Point(12, 134);
            this.forloopButton.Name = "forloopButton";
            this.forloopButton.Size = new System.Drawing.Size(75, 23);
            this.forloopButton.TabIndex = 4;
            this.forloopButton.Text = "Forloop";
            this.forloopButton.UseVisualStyleBackColor = true;
            this.forloopButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mathButton
            // 
            this.mathButton.Location = new System.Drawing.Point(177, 134);
            this.mathButton.Name = "mathButton";
            this.mathButton.Size = new System.Drawing.Size(113, 23);
            this.mathButton.TabIndex = 5;
            this.mathButton.Text = "Machtsverheffen";
            this.mathButton.UseVisualStyleBackColor = true;
            this.mathButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // recursieButton
            // 
            this.recursieButton.Location = new System.Drawing.Point(384, 134);
            this.recursieButton.Name = "recursieButton";
            this.recursieButton.Size = new System.Drawing.Size(87, 23);
            this.recursieButton.TabIndex = 6;
            this.recursieButton.Text = "Recursie";
            this.recursieButton.UseVisualStyleBackColor = true;
            this.recursieButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AccessibleName = "";
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 241);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 19);
            this.outputLabel.TabIndex = 8;
            // 
            // answerLabel
            // 
            this.answerLabel.AccessibleName = "";
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(12, 186);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 19);
            this.answerLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 472);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.recursieButton);
            this.Controls.Add(this.mathButton);
            this.Controls.Add(this.forloopButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button forloopButton;
        private System.Windows.Forms.Button mathButton;
        private System.Windows.Forms.Button recursieButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label answerLabel;
    }
}

