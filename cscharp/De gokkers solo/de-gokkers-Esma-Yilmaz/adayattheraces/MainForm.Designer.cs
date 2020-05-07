namespace adayattheraces
{
    partial class mainForm
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
            this.dogOne = new System.Windows.Forms.PictureBox();
            this.racePictureBox = new System.Windows.Forms.PictureBox();
            this.dogTwo = new System.Windows.Forms.PictureBox();
            this.minimumLabel = new System.Windows.Forms.Label();
            this.guyOne = new System.Windows.Forms.RadioButton();
            this.guyTwo = new System.Windows.Forms.RadioButton();
            this.guyThree = new System.Windows.Forms.RadioButton();
            this.guyLabel = new System.Windows.Forms.Label();
            this.betsButton = new System.Windows.Forms.Button();
            this.betsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dogNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.raceButton = new System.Windows.Forms.Button();
            this.JoeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AlLabel = new System.Windows.Forms.Label();
            this.BobLabel = new System.Windows.Forms.Label();
            this.dogThree = new System.Windows.Forms.PictureBox();
            this.dogFour = new System.Windows.Forms.PictureBox();
            this.speedTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dogOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogFour)).BeginInit();
            this.SuspendLayout();
            // 
            // dogOne
            // 
            this.dogOne.Image = global::adayattheraces.Properties.Resources.afbeelding_hond;
            this.dogOne.Location = new System.Drawing.Point(27, 21);
            this.dogOne.Name = "dogOne";
            this.dogOne.Size = new System.Drawing.Size(76, 20);
            this.dogOne.TabIndex = 1;
            this.dogOne.TabStop = false;
            // 
            // racePictureBox
            // 
            this.racePictureBox.Image = global::adayattheraces.Properties.Resources.afbeelding_racebaan;
            this.racePictureBox.Location = new System.Drawing.Point(12, 12);
            this.racePictureBox.Name = "racePictureBox";
            this.racePictureBox.Size = new System.Drawing.Size(613, 204);
            this.racePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.racePictureBox.TabIndex = 0;
            this.racePictureBox.TabStop = false;
            // 
            // dogTwo
            // 
            this.dogTwo.Image = global::adayattheraces.Properties.Resources.afbeelding_hond;
            this.dogTwo.Location = new System.Drawing.Point(25, 70);
            this.dogTwo.Name = "dogTwo";
            this.dogTwo.Size = new System.Drawing.Size(78, 20);
            this.dogTwo.TabIndex = 2;
            this.dogTwo.TabStop = false;
            // 
            // minimumLabel
            // 
            this.minimumLabel.AutoSize = true;
            this.minimumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumLabel.Location = new System.Drawing.Point(9, 30);
            this.minimumLabel.Name = "minimumLabel";
            this.minimumLabel.Size = new System.Drawing.Size(195, 20);
            this.minimumLabel.TabIndex = 5;
            this.minimumLabel.Text = "Minimumlimiet: 5 dollar ";
            // 
            // guyOne
            // 
            this.guyOne.AutoSize = true;
            this.guyOne.Location = new System.Drawing.Point(10, 62);
            this.guyOne.Name = "guyOne";
            this.guyOne.Size = new System.Drawing.Size(42, 17);
            this.guyOne.TabIndex = 6;
            this.guyOne.TabStop = true;
            this.guyOne.Text = "Joe";
            this.guyOne.UseVisualStyleBackColor = true;
            this.guyOne.CheckedChanged += new System.EventHandler(this.oneRadioButton_CheckedChanged);
            // 
            // guyTwo
            // 
            this.guyTwo.AutoSize = true;
            this.guyTwo.Location = new System.Drawing.Point(10, 94);
            this.guyTwo.Name = "guyTwo";
            this.guyTwo.Size = new System.Drawing.Size(44, 17);
            this.guyTwo.TabIndex = 7;
            this.guyTwo.TabStop = true;
            this.guyTwo.Text = "Bob";
            this.guyTwo.UseVisualStyleBackColor = true;
            this.guyTwo.CheckedChanged += new System.EventHandler(this.twoRadioButton_CheckedChanged);
            // 
            // guyThree
            // 
            this.guyThree.AutoSize = true;
            this.guyThree.Location = new System.Drawing.Point(10, 126);
            this.guyThree.Name = "guyThree";
            this.guyThree.Size = new System.Drawing.Size(34, 17);
            this.guyThree.TabIndex = 8;
            this.guyThree.TabStop = true;
            this.guyThree.Text = "Al";
            this.guyThree.UseVisualStyleBackColor = true;
            this.guyThree.CheckedChanged += new System.EventHandler(this.threeRadioButton_CheckedChanged);
            // 
            // guyLabel
            // 
            this.guyLabel.AutoSize = true;
            this.guyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guyLabel.Location = new System.Drawing.Point(7, 196);
            this.guyLabel.Name = "guyLabel";
            this.guyLabel.Size = new System.Drawing.Size(0, 20);
            this.guyLabel.TabIndex = 9;
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(47, 196);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(110, 23);
            this.betsButton.TabIndex = 10;
            this.betsButton.Text = "weddenschappen";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // betsNumericUpDown
            // 
            this.betsNumericUpDown.Location = new System.Drawing.Point(163, 199);
            this.betsNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betsNumericUpDown.Name = "betsNumericUpDown";
            this.betsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.betsNumericUpDown.TabIndex = 22;
            this.betsNumericUpDown.ValueChanged += new System.EventHandler(this.betsNumericUpDown_ValueChanged);
            // 
            // betsLabel
            // 
            this.betsLabel.AutoSize = true;
            this.betsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betsLabel.Location = new System.Drawing.Point(312, 30);
            this.betsLabel.Name = "betsLabel";
            this.betsLabel.Size = new System.Drawing.Size(153, 20);
            this.betsLabel.TabIndex = 12;
            this.betsLabel.Text = "Weddenschappen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "dollar op het hondennummer";
            // 
            // dogNumericUpDown
            // 
            this.dogNumericUpDown.Location = new System.Drawing.Point(436, 201);
            this.dogNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumericUpDown.Name = "dogNumericUpDown";
            this.dogNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.dogNumericUpDown.TabIndex = 14;
            this.dogNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumericUpDown.ValueChanged += new System.EventHandler(this.dogNumericUpDown_ValueChanged);
            // 
            // raceButton
            // 
            this.raceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceButton.Location = new System.Drawing.Point(505, 193);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(101, 30);
            this.raceButton.TabIndex = 15;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // JoeLabel
            // 
            this.JoeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoeLabel.Location = new System.Drawing.Point(316, 63);
            this.JoeLabel.Name = "JoeLabel";
            this.JoeLabel.Size = new System.Drawing.Size(290, 17);
            this.JoeLabel.TabIndex = 19;
            this.JoeLabel.Text = "Joe\'s inzet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AlLabel);
            this.groupBox1.Controls.Add(this.BobLabel);
            this.groupBox1.Controls.Add(this.JoeLabel);
            this.groupBox1.Controls.Add(this.raceButton);
            this.groupBox1.Controls.Add(this.dogNumericUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.betsLabel);
            this.groupBox1.Controls.Add(this.betsNumericUpDown);
            this.groupBox1.Controls.Add(this.betsButton);
            this.groupBox1.Controls.Add(this.guyLabel);
            this.groupBox1.Controls.Add(this.guyThree);
            this.groupBox1.Controls.Add(this.guyTwo);
            this.groupBox1.Controls.Add(this.guyOne);
            this.groupBox1.Controls.Add(this.minimumLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 225);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wedden Atelier";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // AlLabel
            // 
            this.AlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlLabel.Location = new System.Drawing.Point(316, 136);
            this.AlLabel.Name = "AlLabel";
            this.AlLabel.Size = new System.Drawing.Size(290, 16);
            this.AlLabel.TabIndex = 21;
            this.AlLabel.Text = "Al\'s inzet";
            // 
            // BobLabel
            // 
            this.BobLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BobLabel.Location = new System.Drawing.Point(316, 95);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(290, 20);
            this.BobLabel.TabIndex = 20;
            this.BobLabel.Text = "Bob\'s inzet";
            // 
            // dogThree
            // 
            this.dogThree.Image = global::adayattheraces.Properties.Resources.afbeelding_hond;
            this.dogThree.Location = new System.Drawing.Point(25, 128);
            this.dogThree.Name = "dogThree";
            this.dogThree.Size = new System.Drawing.Size(78, 20);
            this.dogThree.TabIndex = 7;
            this.dogThree.TabStop = false;
            // 
            // dogFour
            // 
            this.dogFour.Image = global::adayattheraces.Properties.Resources.afbeelding_hond;
            this.dogFour.Location = new System.Drawing.Point(25, 176);
            this.dogFour.Name = "dogFour";
            this.dogFour.Size = new System.Drawing.Size(78, 20);
            this.dogFour.TabIndex = 8;
            this.dogFour.TabStop = false;
            // 
            // speedTimer
            // 
            this.speedTimer.Interval = 1000;
            this.speedTimer.Tick += new System.EventHandler(this.speedTimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.dogFour);
            this.Controls.Add(this.dogThree);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dogTwo);
            this.Controls.Add(this.dogOne);
            this.Controls.Add(this.racePictureBox);
            this.Name = "mainForm";
            this.Text = "Een dag op de races";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dogOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogFour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racePictureBox;
        private System.Windows.Forms.PictureBox dogOne;
        private System.Windows.Forms.PictureBox dogTwo;
        private System.Windows.Forms.Label minimumLabel;
        private System.Windows.Forms.RadioButton guyOne;
        private System.Windows.Forms.RadioButton guyTwo;
        private System.Windows.Forms.RadioButton guyThree;
        private System.Windows.Forms.Label guyLabel;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.NumericUpDown betsNumericUpDown;
        private System.Windows.Forms.Label betsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dogNumericUpDown;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Label JoeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AlLabel;
        private System.Windows.Forms.Label BobLabel;
        private System.Windows.Forms.PictureBox dogThree;
        private System.Windows.Forms.PictureBox dogFour;
        private System.Windows.Forms.Timer speedTimer;
    }
}

