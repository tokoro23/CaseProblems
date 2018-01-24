namespace Ch3_CaseProblem1
{
    partial class GreenvilleRevGUI
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
            this.lastYearLabel = new System.Windows.Forms.Label();
            this.thisYearLabel = new System.Windows.Forms.Label();
            this.lastYearTextBox = new System.Windows.Forms.TextBox();
            this.thisYearTextBox = new System.Windows.Forms.TextBox();
            this.resultsButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastYearLabel
            // 
            this.lastYearLabel.AutoSize = true;
            this.lastYearLabel.Location = new System.Drawing.Point(63, 14);
            this.lastYearLabel.Name = "lastYearLabel";
            this.lastYearLabel.Size = new System.Drawing.Size(165, 13);
            this.lastYearLabel.TabIndex = 0;
            this.lastYearLabel.Text = "Last year\'s number of contestants";
            // 
            // thisYearLabel
            // 
            this.thisYearLabel.AutoSize = true;
            this.thisYearLabel.Location = new System.Drawing.Point(63, 30);
            this.thisYearLabel.Name = "thisYearLabel";
            this.thisYearLabel.Size = new System.Drawing.Size(165, 13);
            this.thisYearLabel.TabIndex = 1;
            this.thisYearLabel.Text = "This year\'s number of contestants";
            // 
            // lastYearTextBox
            // 
            this.lastYearTextBox.Location = new System.Drawing.Point(234, 10);
            this.lastYearTextBox.Name = "lastYearTextBox";
            this.lastYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastYearTextBox.TabIndex = 2;
            // 
            // thisYearTextBox
            // 
            this.thisYearTextBox.Location = new System.Drawing.Point(234, 30);
            this.thisYearTextBox.Name = "thisYearTextBox";
            this.thisYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.thisYearTextBox.TabIndex = 3;
            // 
            // resultsButton
            // 
            this.resultsButton.BackColor = System.Drawing.Color.Silver;
            this.resultsButton.ForeColor = System.Drawing.Color.Black;
            this.resultsButton.Location = new System.Drawing.Point(162, 76);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(110, 66);
            this.resultsButton.TabIndex = 4;
            this.resultsButton.Text = "Get Revenue(s)";
            this.resultsButton.UseVisualStyleBackColor = false;
            this.resultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(12, 163);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(248, 18);
            this.resultsLabel.TabIndex = 5;
            this.resultsLabel.Text = "Results will appear here";
            // 
            // GreenvilleRevGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 273);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.thisYearTextBox);
            this.Controls.Add(this.lastYearTextBox);
            this.Controls.Add(this.thisYearLabel);
            this.Controls.Add(this.lastYearLabel);
            this.Name = "GreenvilleRevGUI";
            this.Text = "Greenville Revenue Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastYearLabel;
        private System.Windows.Forms.Label thisYearLabel;
        private System.Windows.Forms.TextBox lastYearTextBox;
        private System.Windows.Forms.TextBox thisYearTextBox;
        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.Label resultsLabel;
    }
}

