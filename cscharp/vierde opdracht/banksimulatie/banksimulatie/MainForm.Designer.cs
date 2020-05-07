namespace banksimulatie
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
            this.label2 = new System.Windows.Forms.Label();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newTransatieButton = new System.Windows.Forms.Button();
            this.transactionButton = new System.Windows.Forms.Button();
            this.totalTransactiesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hier een overzicht van al onze klanten";
            // 
            // customersListBox
            // 
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.Location = new System.Drawing.Point(6, 31);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(217, 368);
            this.customersListBox.TabIndex = 2;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.customersListBox_SelectedIndexChanged);
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(6, 405);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(217, 24);
            this.newAccountButton.TabIndex = 3;
            this.newAccountButton.Text = "Nieuwe account aanmaken";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newAccountButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customersListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 435);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounts";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newTransatieButton);
            this.groupBox2.Controls.Add(this.transactionButton);
            this.groupBox2.Controls.Add(this.totalTransactiesListBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(249, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 426);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transacties";
            // 
            // newTransatieButton
            // 
            this.newTransatieButton.Location = new System.Drawing.Point(339, 396);
            this.newTransatieButton.Name = "newTransatieButton";
            this.newTransatieButton.Size = new System.Drawing.Size(253, 23);
            this.newTransatieButton.TabIndex = 3;
            this.newTransatieButton.Text = "Nieuwe transactie";
            this.newTransatieButton.UseVisualStyleBackColor = true;
            this.newTransatieButton.Click += new System.EventHandler(this.newTransatieButton_Click);
            // 
            // transactionButton
            // 
            this.transactionButton.Location = new System.Drawing.Point(6, 396);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(133, 23);
            this.transactionButton.TabIndex = 2;
            this.transactionButton.Text = "Transaction herroepen";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // totalTransactiesListBox
            // 
            this.totalTransactiesListBox.FormattingEnabled = true;
            this.totalTransactiesListBox.Location = new System.Drawing.Point(9, 38);
            this.totalTransactiesListBox.Name = "totalTransactiesListBox";
            this.totalTransactiesListBox.Size = new System.Drawing.Size(583, 355);
            this.totalTransactiesListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hieronder ziet u enkel alle transacties van onze klachten. Transacties van en naa" +
    "r andere banken worden niet weergeven.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button newTransatieButton;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.ListBox totalTransactiesListBox;
        private System.Windows.Forms.Label label1;
    }
}

