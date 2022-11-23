namespace Program_1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.underlaymentPrice = new System.Windows.Forms.Label();
            this.firstroomLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hardwoodcostLabel = new System.Windows.Forms.Label();
            this.underlaycostLabel = new System.Windows.Forms.Label();
            this.laborcostLabel = new System.Windows.Forms.Label();
            this.totalcostLabel = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.underlaymentBox = new System.Windows.Forms.TextBox();
            this.firstroomBox = new System.Windows.Forms.TextBox();
            this.sqyardsOutput = new System.Windows.Forms.Label();
            this.hardwoodcostOutput = new System.Windows.Forms.Label();
            this.underlaycostOutput = new System.Windows.Forms.Label();
            this.laborcostOutput = new System.Windows.Forms.Label();
            this.totalcostOutput = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(168, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(224, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "E-Z Hardwood Floor Estimator";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(102, 100);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(176, 20);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Max Width of Room (ft):";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(93, 153);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(185, 20);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Max Length of Room (ft):";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(98, 207);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(180, 20);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Hardwood Price (sq. yd):";
            // 
            // underlaymentPrice
            // 
            this.underlaymentPrice.AutoSize = true;
            this.underlaymentPrice.Location = new System.Drawing.Point(123, 252);
            this.underlaymentPrice.Name = "underlaymentPrice";
            this.underlaymentPrice.Size = new System.Drawing.Size(155, 40);
            this.underlaymentPrice.TabIndex = 4;
            this.underlaymentPrice.Text = "        Underlayment:\r\n(0 for NO, 1 for YES)";
            // 
            // firstroomLabel
            // 
            this.firstroomLabel.AutoSize = true;
            this.firstroomLabel.Location = new System.Drawing.Point(123, 312);
            this.firstroomLabel.Name = "firstroomLabel";
            this.firstroomLabel.Size = new System.Drawing.Size(155, 40);
            this.firstroomLabel.TabIndex = 5;
            this.firstroomLabel.Text = "              First Room:\r\n(0 for NO, 1 for YES)";
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "sqyardsLabel";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sq. Yards:";
            // 
            // hardwoodcostLabel
            // 
            this.hardwoodcostLabel.AutoSize = true;
            this.hardwoodcostLabel.Location = new System.Drawing.Point(155, 443);
            this.hardwoodcostLabel.Name = "hardwoodcostLabel";
            this.hardwoodcostLabel.Size = new System.Drawing.Size(123, 20);
            this.hardwoodcostLabel.TabIndex = 7;
            this.hardwoodcostLabel.Text = "Hardwood Cost:";
            // 
            // underlaycostLabel
            // 
            this.underlaycostLabel.AutoSize = true;
            this.underlaycostLabel.Location = new System.Drawing.Point(165, 489);
            this.underlaycostLabel.Name = "underlaycostLabel";
            this.underlaycostLabel.Size = new System.Drawing.Size(113, 20);
            this.underlaycostLabel.TabIndex = 8;
            this.underlaycostLabel.Text = "Underlay Cost:";
            // 
            // laborcostLabel
            // 
            this.laborcostLabel.AutoSize = true;
            this.laborcostLabel.Location = new System.Drawing.Point(187, 534);
            this.laborcostLabel.Name = "laborcostLabel";
            this.laborcostLabel.Size = new System.Drawing.Size(91, 20);
            this.laborcostLabel.TabIndex = 9;
            this.laborcostLabel.Text = "Labor Cost:";
            // 
            // totalcostLabel
            // 
            this.totalcostLabel.AutoSize = true;
            this.totalcostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcostLabel.Location = new System.Drawing.Point(182, 582);
            this.totalcostLabel.Name = "totalcostLabel";
            this.totalcostLabel.Size = new System.Drawing.Size(96, 20);
            this.totalcostLabel.TabIndex = 10;
            this.totalcostLabel.Text = "Total Cost:";
            this.totalcostLabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(288, 100);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(160, 26);
            this.widthBox.TabIndex = 11;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(288, 153);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(160, 26);
            this.lengthBox.TabIndex = 12;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(288, 207);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(160, 26);
            this.priceBox.TabIndex = 13;
            // 
            // underlaymentBox
            // 
            this.underlaymentBox.Location = new System.Drawing.Point(288, 252);
            this.underlaymentBox.Name = "underlaymentBox";
            this.underlaymentBox.Size = new System.Drawing.Size(160, 26);
            this.underlaymentBox.TabIndex = 14;
            // 
            // firstroomBox
            // 
            this.firstroomBox.Location = new System.Drawing.Point(288, 312);
            this.firstroomBox.Name = "firstroomBox";
            this.firstroomBox.Size = new System.Drawing.Size(160, 26);
            this.firstroomBox.TabIndex = 15;
            // 
            // sqyardsOutput
            // 
            this.sqyardsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqyardsOutput.Location = new System.Drawing.Point(288, 393);
            this.sqyardsOutput.Name = "sqyardsOutput";
            this.sqyardsOutput.Size = new System.Drawing.Size(160, 25);
            this.sqyardsOutput.TabIndex = 16;
            // 
            // hardwoodcostOutput
            // 
            this.hardwoodcostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hardwoodcostOutput.Location = new System.Drawing.Point(288, 443);
            this.hardwoodcostOutput.Name = "hardwoodcostOutput";
            this.hardwoodcostOutput.Size = new System.Drawing.Size(160, 25);
            this.hardwoodcostOutput.TabIndex = 17;
            // 
            // underlaycostOutput
            // 
            this.underlaycostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.underlaycostOutput.Location = new System.Drawing.Point(288, 489);
            this.underlaycostOutput.Name = "underlaycostOutput";
            this.underlaycostOutput.Size = new System.Drawing.Size(160, 25);
            this.underlaycostOutput.TabIndex = 18;
            // 
            // laborcostOutput
            // 
            this.laborcostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborcostOutput.Location = new System.Drawing.Point(288, 534);
            this.laborcostOutput.Name = "laborcostOutput";
            this.laborcostOutput.Size = new System.Drawing.Size(160, 25);
            this.laborcostOutput.TabIndex = 19;
            this.laborcostOutput.Click += new System.EventHandler(this.label14_Click);
            // 
            // totalcostOutput
            // 
            this.totalcostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalcostOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcostOutput.Location = new System.Drawing.Point(288, 582);
            this.totalcostOutput.Name = "totalcostOutput";
            this.totalcostOutput.Size = new System.Drawing.Size(160, 25);
            this.totalcostOutput.TabIndex = 20;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(213, 635);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(155, 38);
            this.calculateButton.TabIndex = 21;
            this.calculateButton.Text = "Calculate Estimate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 685);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalcostOutput);
            this.Controls.Add(this.laborcostOutput);
            this.Controls.Add(this.underlaycostOutput);
            this.Controls.Add(this.hardwoodcostOutput);
            this.Controls.Add(this.sqyardsOutput);
            this.Controls.Add(this.firstroomBox);
            this.Controls.Add(this.underlaymentBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.totalcostLabel);
            this.Controls.Add(this.laborcostLabel);
            this.Controls.Add(this.underlaycostLabel);
            this.Controls.Add(this.hardwoodcostLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.firstroomLabel);
            this.Controls.Add(this.underlaymentPrice);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "E-Z Hardwood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label underlaymentPrice;
        private System.Windows.Forms.Label firstroomLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hardwoodcostLabel;
        private System.Windows.Forms.Label underlaycostLabel;
        private System.Windows.Forms.Label laborcostLabel;
        private System.Windows.Forms.Label totalcostLabel;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox underlaymentBox;
        private System.Windows.Forms.TextBox firstroomBox;
        private System.Windows.Forms.Label sqyardsOutput;
        private System.Windows.Forms.Label hardwoodcostOutput;
        private System.Windows.Forms.Label underlaycostOutput;
        private System.Windows.Forms.Label laborcostOutput;
        private System.Windows.Forms.Label totalcostOutput;
        private System.Windows.Forms.Button calculateButton;
    }
}

