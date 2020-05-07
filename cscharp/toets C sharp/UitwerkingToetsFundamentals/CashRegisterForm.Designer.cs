namespace UitwerkingToetsFundamentals
{
    partial class CashRegisterForm
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
            this.inventoryButton = new System.Windows.Forms.Button();
            this.sellGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.bagCheckBox = new System.Windows.Forms.CheckBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeResultLabel = new System.Windows.Forms.Label();
            this.paidAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.paidLabel = new System.Windows.Forms.Label();
            this.completeSaleButton = new System.Windows.Forms.Button();
            this.priceNoTaxResultLabel = new System.Windows.Forms.Label();
            this.priceNoTaxLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceResultLabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.receiptListBox = new System.Windows.Forms.ListBox();
            this.historyGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateTotalNumber = new System.Windows.Forms.ListBox();
            this.financesGroupBox = new System.Windows.Forms.GroupBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceResultLabel = new System.Windows.Forms.Label();
            this.buyInGroupBox = new System.Windows.Forms.GroupBox();
            this.buyInAmountTextBox = new System.Windows.Forms.TextBox();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.completeBuyInButton = new System.Windows.Forms.Button();
            this.brokenRadioButton = new System.Windows.Forms.RadioButton();
            this.damagedRadioButton = new System.Windows.Forms.RadioButton();
            this.lightDamageRadioButton = new System.Windows.Forms.RadioButton();
            this.highQualityRadioButton = new System.Windows.Forms.RadioButton();
            this.gameNameTextBox = new System.Windows.Forms.TextBox();
            this.buyInPriceLabel = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.sellGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paidAmountNumericUpDown)).BeginInit();
            this.historyGroupBox.SuspendLayout();
            this.financesGroupBox.SuspendLayout();
            this.buyInGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryButton
            // 
            this.inventoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryButton.Location = new System.Drawing.Point(6, 19);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(267, 33);
            this.inventoryButton.TabIndex = 0;
            this.inventoryButton.Text = "Spellen in magazijn";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // sellGroupBox
            // 
            this.sellGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sellGroupBox.Controls.Add(this.calculateTotalButton);
            this.sellGroupBox.Controls.Add(this.bagCheckBox);
            this.sellGroupBox.Controls.Add(this.changeLabel);
            this.sellGroupBox.Controls.Add(this.changeResultLabel);
            this.sellGroupBox.Controls.Add(this.paidAmountNumericUpDown);
            this.sellGroupBox.Controls.Add(this.paidLabel);
            this.sellGroupBox.Controls.Add(this.completeSaleButton);
            this.sellGroupBox.Controls.Add(this.priceNoTaxResultLabel);
            this.sellGroupBox.Controls.Add(this.priceNoTaxLabel);
            this.sellGroupBox.Controls.Add(this.totalPriceLabel);
            this.sellGroupBox.Controls.Add(this.totalPriceResultLabel);
            this.sellGroupBox.Controls.Add(this.receiptLabel);
            this.sellGroupBox.Controls.Add(this.receiptListBox);
            this.sellGroupBox.Controls.Add(this.inventoryButton);
            this.sellGroupBox.Location = new System.Drawing.Point(12, 12);
            this.sellGroupBox.Name = "sellGroupBox";
            this.sellGroupBox.Size = new System.Drawing.Size(279, 442);
            this.sellGroupBox.TabIndex = 1;
            this.sellGroupBox.TabStop = false;
            this.sellGroupBox.Text = "Spel verkopen aan klant";
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculateTotalButton.Location = new System.Drawing.Point(6, 248);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(267, 34);
            this.calculateTotalButton.TabIndex = 12;
            this.calculateTotalButton.Text = "Bereken totaalbedrag";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // bagCheckBox
            // 
            this.bagCheckBox.AutoSize = true;
            this.bagCheckBox.Location = new System.Drawing.Point(151, 225);
            this.bagCheckBox.Name = "bagCheckBox";
            this.bagCheckBox.Size = new System.Drawing.Size(122, 17);
            this.bagCheckBox.TabIndex = 11;
            this.bagCheckBox.Text = "Tasje erbij? (+€0,15)";
            this.bagCheckBox.UseVisualStyleBackColor = true;
            // 
            // changeLabel
            // 
            this.changeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(7, 384);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(61, 13);
            this.changeLabel.TabIndex = 7;
            this.changeLabel.Text = "Wisselgeld:";
            // 
            // changeResultLabel
            // 
            this.changeResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeResultLabel.Location = new System.Drawing.Point(129, 377);
            this.changeResultLabel.Name = "changeResultLabel";
            this.changeResultLabel.Size = new System.Drawing.Size(144, 20);
            this.changeResultLabel.TabIndex = 7;
            this.changeResultLabel.Text = "0,00";
            this.changeResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paidAmountNumericUpDown
            // 
            this.paidAmountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paidAmountNumericUpDown.DecimalPlaces = 2;
            this.paidAmountNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.paidAmountNumericUpDown.Location = new System.Drawing.Point(107, 355);
            this.paidAmountNumericUpDown.Name = "paidAmountNumericUpDown";
            this.paidAmountNumericUpDown.Size = new System.Drawing.Size(166, 20);
            this.paidAmountNumericUpDown.TabIndex = 2;
            this.paidAmountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.paidAmountNumericUpDown.ValueChanged += new System.EventHandler(this.paidAmountNumericUpDown_ValueChanged);
            // 
            // paidLabel
            // 
            this.paidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paidLabel.AutoSize = true;
            this.paidLabel.Location = new System.Drawing.Point(7, 357);
            this.paidLabel.Name = "paidLabel";
            this.paidLabel.Size = new System.Drawing.Size(94, 13);
            this.paidLabel.TabIndex = 6;
            this.paidLabel.Text = "Betaald bedrag:  €";
            // 
            // completeSaleButton
            // 
            this.completeSaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.completeSaleButton.Location = new System.Drawing.Point(6, 402);
            this.completeSaleButton.Name = "completeSaleButton";
            this.completeSaleButton.Size = new System.Drawing.Size(267, 34);
            this.completeSaleButton.TabIndex = 2;
            this.completeSaleButton.Text = "Verkoop aan klant voltooien";
            this.completeSaleButton.UseVisualStyleBackColor = true;
            this.completeSaleButton.Click += new System.EventHandler(this.completeSaleButton_Click);
            // 
            // priceNoTaxResultLabel
            // 
            this.priceNoTaxResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceNoTaxResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNoTaxResultLabel.Location = new System.Drawing.Point(129, 324);
            this.priceNoTaxResultLabel.Name = "priceNoTaxResultLabel";
            this.priceNoTaxResultLabel.Size = new System.Drawing.Size(144, 20);
            this.priceNoTaxResultLabel.TabIndex = 5;
            this.priceNoTaxResultLabel.Text = "0,00";
            this.priceNoTaxResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceNoTaxLabel
            // 
            this.priceNoTaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.priceNoTaxLabel.AutoSize = true;
            this.priceNoTaxLabel.Location = new System.Drawing.Point(7, 329);
            this.priceNoTaxLabel.Name = "priceNoTaxLabel";
            this.priceNoTaxLabel.Size = new System.Drawing.Size(109, 13);
            this.priceNoTaxLabel.TabIndex = 4;
            this.priceNoTaxLabel.Text = "Totaal (zonder BTW):";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(7, 300);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(40, 13);
            this.totalPriceLabel.TabIndex = 2;
            this.totalPriceLabel.Text = "Totaal:";
            // 
            // totalPriceResultLabel
            // 
            this.totalPriceResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceResultLabel.Location = new System.Drawing.Point(123, 292);
            this.totalPriceResultLabel.Name = "totalPriceResultLabel";
            this.totalPriceResultLabel.Size = new System.Drawing.Size(150, 31);
            this.totalPriceResultLabel.TabIndex = 3;
            this.totalPriceResultLabel.Text = "0,00";
            this.totalPriceResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(6, 62);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(46, 20);
            this.receiptLabel.TabIndex = 2;
            this.receiptLabel.Text = "Bon:";
            // 
            // receiptListBox
            // 
            this.receiptListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.receiptListBox.FormattingEnabled = true;
            this.receiptListBox.Location = new System.Drawing.Point(6, 85);
            this.receiptListBox.Name = "receiptListBox";
            this.receiptListBox.Size = new System.Drawing.Size(267, 134);
            this.receiptListBox.TabIndex = 1;
            this.receiptListBox.SelectedIndexChanged += new System.EventHandler(this.receiptListBox_SelectedIndexChanged);
            // 
            // historyGroupBox
            // 
            this.historyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyGroupBox.Controls.Add(this.calculateTotalNumber);
            this.historyGroupBox.Location = new System.Drawing.Point(611, 12);
            this.historyGroupBox.Name = "historyGroupBox";
            this.historyGroupBox.Size = new System.Drawing.Size(178, 442);
            this.historyGroupBox.TabIndex = 8;
            this.historyGroupBox.TabStop = false;
            this.historyGroupBox.Text = "Geschiedenis van bestellingen";
            // 
            // calculateTotalNumber
            // 
            this.calculateTotalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.calculateTotalNumber.FormattingEnabled = true;
            this.calculateTotalNumber.Location = new System.Drawing.Point(6, 19);
            this.calculateTotalNumber.Name = "calculateTotalNumber";
            this.calculateTotalNumber.Size = new System.Drawing.Size(166, 407);
            this.calculateTotalNumber.TabIndex = 8;
            this.calculateTotalNumber.SelectedIndexChanged += new System.EventHandler(this.calculateTotalNumber_SelectedIndexChanged);
            // 
            // financesGroupBox
            // 
            this.financesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.financesGroupBox.Controls.Add(this.balanceLabel);
            this.financesGroupBox.Controls.Add(this.balanceResultLabel);
            this.financesGroupBox.Location = new System.Drawing.Point(297, 12);
            this.financesGroupBox.Name = "financesGroupBox";
            this.financesGroupBox.Size = new System.Drawing.Size(308, 65);
            this.financesGroupBox.TabIndex = 9;
            this.financesGroupBox.TabStop = false;
            this.financesGroupBox.Text = "Financiën";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(6, 29);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(124, 13);
            this.balanceLabel.TabIndex = 8;
            this.balanceLabel.Text = "We hebben zoveel euro:";
            // 
            // balanceResultLabel
            // 
            this.balanceResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceResultLabel.Location = new System.Drawing.Point(152, 19);
            this.balanceResultLabel.Name = "balanceResultLabel";
            this.balanceResultLabel.Size = new System.Drawing.Size(150, 31);
            this.balanceResultLabel.TabIndex = 9;
            this.balanceResultLabel.Text = "0,00";
            this.balanceResultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buyInGroupBox
            // 
            this.buyInGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buyInGroupBox.Controls.Add(this.buyInAmountTextBox);
            this.buyInGroupBox.Controls.Add(this.consoleTextBox);
            this.buyInGroupBox.Controls.Add(this.consoleLabel);
            this.buyInGroupBox.Controls.Add(this.completeBuyInButton);
            this.buyInGroupBox.Controls.Add(this.brokenRadioButton);
            this.buyInGroupBox.Controls.Add(this.damagedRadioButton);
            this.buyInGroupBox.Controls.Add(this.lightDamageRadioButton);
            this.buyInGroupBox.Controls.Add(this.highQualityRadioButton);
            this.buyInGroupBox.Controls.Add(this.gameNameTextBox);
            this.buyInGroupBox.Controls.Add(this.buyInPriceLabel);
            this.buyInGroupBox.Controls.Add(this.qualityLabel);
            this.buyInGroupBox.Controls.Add(this.gameNameLabel);
            this.buyInGroupBox.Location = new System.Drawing.Point(297, 83);
            this.buyInGroupBox.Name = "buyInGroupBox";
            this.buyInGroupBox.Size = new System.Drawing.Size(308, 252);
            this.buyInGroupBox.TabIndex = 10;
            this.buyInGroupBox.TabStop = false;
            this.buyInGroupBox.Text = "Spel kopen van klant";
            // 
            // buyInAmountTextBox
            // 
            this.buyInAmountTextBox.Location = new System.Drawing.Point(82, 177);
            this.buyInAmountTextBox.Name = "buyInAmountTextBox";
            this.buyInAmountTextBox.Size = new System.Drawing.Size(220, 20);
            this.buyInAmountTextBox.TabIndex = 22;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Location = new System.Drawing.Point(72, 52);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(230, 20);
            this.consoleTextBox.TabIndex = 21;
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Location = new System.Drawing.Point(6, 55);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(48, 13);
            this.consoleLabel.TabIndex = 20;
            this.consoleLabel.Text = "Console:";
            // 
            // completeBuyInButton
            // 
            this.completeBuyInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.completeBuyInButton.Location = new System.Drawing.Point(9, 204);
            this.completeBuyInButton.Name = "completeBuyInButton";
            this.completeBuyInButton.Size = new System.Drawing.Size(293, 34);
            this.completeBuyInButton.TabIndex = 19;
            this.completeBuyInButton.Text = "Inkoop voltooien";
            this.completeBuyInButton.UseVisualStyleBackColor = true;
            this.completeBuyInButton.Click += new System.EventHandler(this.completeBuyInButton_Click);
            // 
            // brokenRadioButton
            // 
            this.brokenRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brokenRadioButton.AutoSize = true;
            this.brokenRadioButton.Location = new System.Drawing.Point(72, 147);
            this.brokenRadioButton.Name = "brokenRadioButton";
            this.brokenRadioButton.Size = new System.Drawing.Size(57, 17);
            this.brokenRadioButton.TabIndex = 17;
            this.brokenRadioButton.TabStop = true;
            this.brokenRadioButton.Text = "Defect";
            this.brokenRadioButton.UseVisualStyleBackColor = true;
            // 
            // damagedRadioButton
            // 
            this.damagedRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.damagedRadioButton.AutoSize = true;
            this.damagedRadioButton.Location = new System.Drawing.Point(72, 124);
            this.damagedRadioButton.Name = "damagedRadioButton";
            this.damagedRadioButton.Size = new System.Drawing.Size(124, 17);
            this.damagedRadioButton.TabIndex = 16;
            this.damagedRadioButton.TabStop = true;
            this.damagedRadioButton.Text = "Veel beschadigingen";
            this.damagedRadioButton.UseVisualStyleBackColor = true;
            // 
            // lightDamageRadioButton
            // 
            this.lightDamageRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lightDamageRadioButton.AutoSize = true;
            this.lightDamageRadioButton.Location = new System.Drawing.Point(72, 101);
            this.lightDamageRadioButton.Name = "lightDamageRadioButton";
            this.lightDamageRadioButton.Size = new System.Drawing.Size(89, 17);
            this.lightDamageRadioButton.TabIndex = 15;
            this.lightDamageRadioButton.TabStop = true;
            this.lightDamageRadioButton.Text = "Lichte slijtage";
            this.lightDamageRadioButton.UseVisualStyleBackColor = true;
            // 
            // highQualityRadioButton
            // 
            this.highQualityRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.highQualityRadioButton.AutoSize = true;
            this.highQualityRadioButton.Location = new System.Drawing.Point(72, 78);
            this.highQualityRadioButton.Name = "highQualityRadioButton";
            this.highQualityRadioButton.Size = new System.Drawing.Size(176, 17);
            this.highQualityRadioButton.TabIndex = 14;
            this.highQualityRadioButton.TabStop = true;
            this.highQualityRadioButton.Text = "Geen merkbare beschadigingen";
            this.highQualityRadioButton.UseVisualStyleBackColor = true;
            // 
            // gameNameTextBox
            // 
            this.gameNameTextBox.Location = new System.Drawing.Point(72, 22);
            this.gameNameTextBox.Name = "gameNameTextBox";
            this.gameNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.gameNameTextBox.TabIndex = 13;
            // 
            // buyInPriceLabel
            // 
            this.buyInPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buyInPriceLabel.AutoSize = true;
            this.buyInPriceLabel.Location = new System.Drawing.Point(6, 180);
            this.buyInPriceLabel.Name = "buyInPriceLabel";
            this.buyInPriceLabel.Size = new System.Drawing.Size(70, 13);
            this.buyInPriceLabel.TabIndex = 12;
            this.buyInPriceLabel.Text = "Inkoopprijs: €";
            // 
            // qualityLabel
            // 
            this.qualityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(6, 78);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(49, 13);
            this.qualityLabel.TabIndex = 11;
            this.qualityLabel.Text = "Kwaliteit:";
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Location = new System.Drawing.Point(6, 25);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(60, 13);
            this.gameNameLabel.TabIndex = 10;
            this.gameNameLabel.Text = "Naam spel:";
            // 
            // CashRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 466);
            this.Controls.Add(this.buyInGroupBox);
            this.Controls.Add(this.financesGroupBox);
            this.Controls.Add(this.historyGroupBox);
            this.Controls.Add(this.sellGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CashRegisterForm";
            this.Text = "Kassa Systeem";
            this.Load += new System.EventHandler(this.CashRegisterForm_Load);
            this.sellGroupBox.ResumeLayout(false);
            this.sellGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paidAmountNumericUpDown)).EndInit();
            this.historyGroupBox.ResumeLayout(false);
            this.financesGroupBox.ResumeLayout(false);
            this.financesGroupBox.PerformLayout();
            this.buyInGroupBox.ResumeLayout(false);
            this.buyInGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.GroupBox sellGroupBox;
        private System.Windows.Forms.ListBox receiptListBox;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label totalPriceResultLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label priceNoTaxLabel;
        private System.Windows.Forms.Label priceNoTaxResultLabel;
        private System.Windows.Forms.Button completeSaleButton;
        private System.Windows.Forms.Label paidLabel;
        private System.Windows.Forms.NumericUpDown paidAmountNumericUpDown;
        private System.Windows.Forms.Label changeResultLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.GroupBox historyGroupBox;
        private System.Windows.Forms.ListBox calculateTotalNumber;
        private System.Windows.Forms.GroupBox financesGroupBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label balanceResultLabel;
        private System.Windows.Forms.GroupBox buyInGroupBox;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.Label buyInPriceLabel;
        private System.Windows.Forms.TextBox gameNameTextBox;
        private System.Windows.Forms.RadioButton highQualityRadioButton;
        private System.Windows.Forms.RadioButton lightDamageRadioButton;
        private System.Windows.Forms.RadioButton damagedRadioButton;
        private System.Windows.Forms.RadioButton brokenRadioButton;
        private System.Windows.Forms.Button completeBuyInButton;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.CheckBox bagCheckBox;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.TextBox buyInAmountTextBox;
    }
}

