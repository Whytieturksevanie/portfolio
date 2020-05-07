namespace banksimulatie
{
    partial class NewTransactiesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.ofNameTextBox = new System.Windows.Forms.TextBox();
            this.forWhomTextBox = new System.Windows.Forms.TextBox();
            this.balansStatusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.balansStatusNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Van:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voor:";
            // 
            // ofNameTextBox
            // 
            this.ofNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ofNameTextBox.Location = new System.Drawing.Point(65, 9);
            this.ofNameTextBox.Name = "ofNameTextBox";
            this.ofNameTextBox.Size = new System.Drawing.Size(434, 26);
            this.ofNameTextBox.TabIndex = 2;
            // 
            // forWhomTextBox
            // 
            this.forWhomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forWhomTextBox.Location = new System.Drawing.Point(65, 45);
            this.forWhomTextBox.Name = "forWhomTextBox";
            this.forWhomTextBox.Size = new System.Drawing.Size(434, 26);
            this.forWhomTextBox.TabIndex = 3;
            // 
            // balansStatusNumericUpDown
            // 
            this.balansStatusNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balansStatusNumericUpDown.Location = new System.Drawing.Point(93, 95);
            this.balansStatusNumericUpDown.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.balansStatusNumericUpDown.Name = "balansStatusNumericUpDown";
            this.balansStatusNumericUpDown.Size = new System.Drawing.Size(406, 26);
            this.balansStatusNumericUpDown.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Balans: €";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aanmaken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewTransactiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balansStatusNumericUpDown);
            this.Controls.Add(this.forWhomTextBox);
            this.Controls.Add(this.ofNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewTransactiesForm";
            this.Text = "newtransacties";
            this.Load += new System.EventHandler(this.newTransactiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balansStatusNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ofNameTextBox;
        private System.Windows.Forms.TextBox forWhomTextBox;
        private System.Windows.Forms.NumericUpDown balansStatusNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}