namespace Program_3
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
            this.stateLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.productBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.initialcostLabel = new System.Windows.Forms.Label();
            this.discountedcostLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalpriceLabel = new System.Windows.Forms.Label();
            this.initialcostOutput = new System.Windows.Forms.Label();
            this.discountedcostOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalpriceOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(113, 37);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(52, 20);
            this.stateLabel.TabIndex = 0;
            this.stateLabel.Text = "State:";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(97, 81);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(68, 20);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Product:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(93, 131);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(72, 20);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(213, 131);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(174, 26);
            this.quantityBox.TabIndex = 3;
            // 
            // productBox
            // 
            this.productBox.Location = new System.Drawing.Point(213, 81);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(174, 26);
            this.productBox.TabIndex = 4;
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "KY",
            "OH",
            "IN",
            "IL"});
            this.stateComboBox.Location = new System.Drawing.Point(213, 37);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(174, 28);
            this.stateComboBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(178, 195);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(92, 35);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // initialcostLabel
            // 
            this.initialcostLabel.AutoSize = true;
            this.initialcostLabel.Location = new System.Drawing.Point(78, 260);
            this.initialcostLabel.Name = "initialcostLabel";
            this.initialcostLabel.Size = new System.Drawing.Size(87, 20);
            this.initialcostLabel.TabIndex = 7;
            this.initialcostLabel.Text = "Initial Cost:";
            // 
            // discountedcostLabel
            // 
            this.discountedcostLabel.AutoSize = true;
            this.discountedcostLabel.Location = new System.Drawing.Point(34, 316);
            this.discountedcostLabel.Name = "discountedcostLabel";
            this.discountedcostLabel.Size = new System.Drawing.Size(131, 20);
            this.discountedcostLabel.TabIndex = 8;
            this.discountedcostLabel.Text = "Discounted Cost:\r\n";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(125, 367);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(38, 20);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            // 
            // totalpriceLabel
            // 
            this.totalpriceLabel.AutoSize = true;
            this.totalpriceLabel.Location = new System.Drawing.Point(78, 412);
            this.totalpriceLabel.Name = "totalpriceLabel";
            this.totalpriceLabel.Size = new System.Drawing.Size(87, 20);
            this.totalpriceLabel.TabIndex = 10;
            this.totalpriceLabel.Text = "Total Price:";
            // 
            // initialcostOutput
            // 
            this.initialcostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialcostOutput.Location = new System.Drawing.Point(213, 260);
            this.initialcostOutput.Name = "initialcostOutput";
            this.initialcostOutput.Size = new System.Drawing.Size(174, 20);
            this.initialcostOutput.TabIndex = 11;
            // 
            // discountedcostOutput
            // 
            this.discountedcostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountedcostOutput.Location = new System.Drawing.Point(213, 316);
            this.discountedcostOutput.Name = "discountedcostOutput";
            this.discountedcostOutput.Size = new System.Drawing.Size(174, 20);
            this.discountedcostOutput.TabIndex = 12;
            // 
            // taxOutput
            // 
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutput.Location = new System.Drawing.Point(213, 367);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(174, 20);
            this.taxOutput.TabIndex = 13;
            // 
            // totalpriceOutput
            // 
            this.totalpriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalpriceOutput.Location = new System.Drawing.Point(213, 412);
            this.totalpriceOutput.Name = "totalpriceOutput";
            this.totalpriceOutput.Size = new System.Drawing.Size(170, 20);
            this.totalpriceOutput.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.totalpriceOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.discountedcostOutput);
            this.Controls.Add(this.initialcostOutput);
            this.Controls.Add(this.totalpriceLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.discountedcostLabel);
            this.Controls.Add(this.initialcostLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.stateLabel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.TextBox productBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label initialcostLabel;
        private System.Windows.Forms.Label discountedcostLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalpriceLabel;
        private System.Windows.Forms.Label initialcostOutput;
        private System.Windows.Forms.Label discountedcostOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalpriceOutput;
    }
}

