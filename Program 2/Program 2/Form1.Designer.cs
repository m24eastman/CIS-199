namespace Program_2
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
            this.weightLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.daysBox = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.companyALabel = new System.Windows.Forms.Label();
            this.companyBLabel = new System.Windows.Forms.Label();
            this.companyCLabel = new System.Windows.Forms.Label();
            this.companyAOutput = new System.Windows.Forms.Label();
            this.companyBOutput = new System.Windows.Forms.Label();
            this.companyCOutput = new System.Windows.Forms.Label();
            this.resultsOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(39, 39);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(129, 20);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "Package Weight:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(43, 132);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(126, 20);
            this.distanceLabel.TabIndex = 1;
            this.distanceLabel.Text = "Distance (miles):";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(47, 219);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(108, 20);
            this.daysLabel.TabIndex = 2;
            this.daysLabel.Text = "Delivery Days:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(112, 312);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(135, 50);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(199, 33);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(134, 26);
            this.weightBox.TabIndex = 4;
            // 
            // distanceBox
            // 
            this.distanceBox.Location = new System.Drawing.Point(199, 132);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(134, 26);
            this.distanceBox.TabIndex = 5;
            // 
            // daysBox
            // 
            this.daysBox.Location = new System.Drawing.Point(199, 212);
            this.daysBox.Name = "daysBox";
            this.daysBox.Size = new System.Drawing.Size(134, 26);
            this.daysBox.TabIndex = 6;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(560, 13);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(76, 25);
            this.resultsLabel.TabIndex = 7;
            this.resultsLabel.Text = "Results";
            // 
            // companyALabel
            // 
            this.companyALabel.AutoSize = true;
            this.companyALabel.Location = new System.Drawing.Point(465, 55);
            this.companyALabel.Name = "companyALabel";
            this.companyALabel.Size = new System.Drawing.Size(132, 20);
            this.companyALabel.TabIndex = 8;
            this.companyALabel.Text = "Company A Cost:";
            // 
            // companyBLabel
            // 
            this.companyBLabel.AutoSize = true;
            this.companyBLabel.Location = new System.Drawing.Point(465, 118);
            this.companyBLabel.Name = "companyBLabel";
            this.companyBLabel.Size = new System.Drawing.Size(132, 20);
            this.companyBLabel.TabIndex = 9;
            this.companyBLabel.Text = "Company B Cost:";
            // 
            // companyCLabel
            // 
            this.companyCLabel.AutoSize = true;
            this.companyCLabel.Location = new System.Drawing.Point(465, 192);
            this.companyCLabel.Name = "companyCLabel";
            this.companyCLabel.Size = new System.Drawing.Size(132, 20);
            this.companyCLabel.TabIndex = 10;
            this.companyCLabel.Text = "Company C Cost:";
            // 
            // companyAOutput
            // 
            this.companyAOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyAOutput.Location = new System.Drawing.Point(624, 55);
            this.companyAOutput.Name = "companyAOutput";
            this.companyAOutput.Size = new System.Drawing.Size(135, 20);
            this.companyAOutput.TabIndex = 11;
            this.companyAOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // companyBOutput
            // 
            this.companyBOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyBOutput.Location = new System.Drawing.Point(624, 118);
            this.companyBOutput.Name = "companyBOutput";
            this.companyBOutput.Size = new System.Drawing.Size(135, 20);
            this.companyBOutput.TabIndex = 12;
            this.companyBOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // companyCOutput
            // 
            this.companyCOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyCOutput.Location = new System.Drawing.Point(624, 192);
            this.companyCOutput.Name = "companyCOutput";
            this.companyCOutput.Size = new System.Drawing.Size(135, 20);
            this.companyCOutput.TabIndex = 13;
            this.companyCOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultsOutput
            // 
            this.resultsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsOutput.Location = new System.Drawing.Point(469, 297);
            this.resultsOutput.Name = "resultsOutput";
            this.resultsOutput.Size = new System.Drawing.Size(292, 33);
            this.resultsOutput.TabIndex = 14;
            this.resultsOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsOutput);
            this.Controls.Add(this.companyCOutput);
            this.Controls.Add(this.companyBOutput);
            this.Controls.Add(this.companyAOutput);
            this.Controls.Add(this.companyCLabel);
            this.Controls.Add(this.companyBLabel);
            this.Controls.Add(this.companyALabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.distanceBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.weightLabel);
            this.Name = "Form1";
            this.Text = "Package Cost Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.TextBox daysBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label companyALabel;
        private System.Windows.Forms.Label companyBLabel;
        private System.Windows.Forms.Label companyCLabel;
        private System.Windows.Forms.Label companyAOutput;
        private System.Windows.Forms.Label companyBOutput;
        private System.Windows.Forms.Label companyCOutput;
        private System.Windows.Forms.Label resultsOutput;
    }
}

