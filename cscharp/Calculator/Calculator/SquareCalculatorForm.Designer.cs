namespace Calculator
{
    partial class SquareCalculatorForm
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
            this.components = new System.ComponentModel.Container();
            this.squareAreaButton = new System.Windows.Forms.Button();
            this.squareOutlineTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.squareAreaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.squareOutlineButton = new System.Windows.Forms.Button();
            this.squareOutlineLabel = new System.Windows.Forms.Label();
            this.squareAreaLabel = new System.Windows.Forms.Label();
            this.rectanglePageButton = new System.Windows.Forms.Button();
            this.circlePageButton = new System.Windows.Forms.Button();
            this.trianglePageButton = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // squareAreaButton
            // 
            this.squareAreaButton.BackColor = System.Drawing.Color.Aqua;
            this.squareAreaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareAreaButton.Location = new System.Drawing.Point(502, 194);
            this.squareAreaButton.Name = "squareAreaButton";
            this.squareAreaButton.Size = new System.Drawing.Size(315, 34);
            this.squareAreaButton.TabIndex = 0;
            this.squareAreaButton.Text = "Vierkant oppervlakte";
            this.squareAreaButton.UseVisualStyleBackColor = false;
            this.squareAreaButton.Click += new System.EventHandler(this.squareAreaButton_Click);
            // 
            // squareOutlineTextBox
            // 
            this.squareOutlineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareOutlineTextBox.Location = new System.Drawing.Point(13, 80);
            this.squareOutlineTextBox.Name = "squareOutlineTextBox";
            this.squareOutlineTextBox.Size = new System.Drawing.Size(466, 26);
            this.squareOutlineTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "De oppervlakte van een vierkant";
            // 
            // squareAreaTextBox
            // 
            this.squareAreaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareAreaTextBox.Location = new System.Drawing.Point(12, 199);
            this.squareAreaTextBox.Name = "squareAreaTextBox";
            this.squareAreaTextBox.Size = new System.Drawing.Size(467, 26);
            this.squareAreaTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "De omtrek van een vierkant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vierkant uitrekenen";
            // 
            // squareOutlineButton
            // 
            this.squareOutlineButton.BackColor = System.Drawing.Color.Aqua;
            this.squareOutlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareOutlineButton.Location = new System.Drawing.Point(502, 75);
            this.squareOutlineButton.Name = "squareOutlineButton";
            this.squareOutlineButton.Size = new System.Drawing.Size(315, 34);
            this.squareOutlineButton.TabIndex = 6;
            this.squareOutlineButton.Text = "Vierkant omtrek";
            this.squareOutlineButton.UseVisualStyleBackColor = false;
            this.squareOutlineButton.Click += new System.EventHandler(this.squareOutlineButton_Click);
            // 
            // squareOutlineLabel
            // 
            this.squareOutlineLabel.AutoSize = true;
            this.squareOutlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareOutlineLabel.Location = new System.Drawing.Point(12, 103);
            this.squareOutlineLabel.Name = "squareOutlineLabel";
            this.squareOutlineLabel.Size = new System.Drawing.Size(0, 20);
            this.squareOutlineLabel.TabIndex = 28;
            // 
            // squareAreaLabel
            // 
            this.squareAreaLabel.AutoSize = true;
            this.squareAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareAreaLabel.Location = new System.Drawing.Point(12, 222);
            this.squareAreaLabel.Name = "squareAreaLabel";
            this.squareAreaLabel.Size = new System.Drawing.Size(0, 20);
            this.squareAreaLabel.TabIndex = 36;
            // 
            // rectanglePageButton
            // 
            this.rectanglePageButton.BackColor = System.Drawing.Color.Aqua;
            this.rectanglePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectanglePageButton.Location = new System.Drawing.Point(16, 281);
            this.rectanglePageButton.Name = "rectanglePageButton";
            this.rectanglePageButton.Size = new System.Drawing.Size(214, 66);
            this.rectanglePageButton.TabIndex = 54;
            this.rectanglePageButton.Text = "Rechthoek uitrekenen";
            this.rectanglePageButton.UseVisualStyleBackColor = false;
            // 
            // circlePageButton
            // 
            this.circlePageButton.BackColor = System.Drawing.Color.Aqua;
            this.circlePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circlePageButton.Location = new System.Drawing.Point(265, 281);
            this.circlePageButton.Name = "circlePageButton";
            this.circlePageButton.Size = new System.Drawing.Size(214, 66);
            this.circlePageButton.TabIndex = 56;
            this.circlePageButton.Text = "Cirkel uitrekenen";
            this.circlePageButton.UseVisualStyleBackColor = false;
            // 
            // trianglePageButton
            // 
            this.trianglePageButton.BackColor = System.Drawing.Color.Aqua;
            this.trianglePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trianglePageButton.Location = new System.Drawing.Point(502, 281);
            this.trianglePageButton.Name = "trianglePageButton";
            this.trianglePageButton.Size = new System.Drawing.Size(315, 66);
            this.trianglePageButton.TabIndex = 57;
            this.trianglePageButton.Text = "Rechthoekige driehoek uitrekenen";
            this.trianglePageButton.UseVisualStyleBackColor = false;
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // SquareCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(851, 378);
            this.Controls.Add(this.trianglePageButton);
            this.Controls.Add(this.circlePageButton);
            this.Controls.Add(this.rectanglePageButton);
            this.Controls.Add(this.squareAreaLabel);
            this.Controls.Add(this.squareOutlineLabel);
            this.Controls.Add(this.squareOutlineButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.squareAreaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.squareOutlineTextBox);
            this.Controls.Add(this.squareAreaButton);
            this.Name = "SquareCalculatorForm";
            this.Text = "SquareCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button squareAreaButton;
        private System.Windows.Forms.TextBox squareOutlineTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox squareAreaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button squareOutlineButton;
        private System.Windows.Forms.Label squareOutlineLabel;
        private System.Windows.Forms.Label squareAreaLabel;
        private System.Windows.Forms.Button rectanglePageButton;
        private System.Windows.Forms.Button circlePageButton;
        private System.Windows.Forms.Button trianglePageButton;
        private System.Windows.Forms.Timer animationTimer;
    }
}

