namespace Ch4_CaseProblem1
{
    partial class GreenvilleRevGUI2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreenvilleRevGUI2));
            this.lastYearLabel = new System.Windows.Forms.Label();
            this.thisYearLabel = new System.Windows.Forms.Label();
            this.lastYearTextBox = new System.Windows.Forms.TextBox();
            this.thisYearTextBox = new System.Windows.Forms.TextBox();
            this.resultsButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.entryGroupBox = new System.Windows.Forms.GroupBox();
            this.greenvilleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.entryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lastYearLabel
            // 
            this.lastYearLabel.AutoSize = true;
            this.lastYearLabel.ForeColor = System.Drawing.Color.Black;
            this.lastYearLabel.Location = new System.Drawing.Point(6, 16);
            this.lastYearLabel.Name = "lastYearLabel";
            this.lastYearLabel.Size = new System.Drawing.Size(165, 13);
            this.lastYearLabel.TabIndex = 0;
            this.lastYearLabel.Text = "Last year\'s number of contestants";
            // 
            // thisYearLabel
            // 
            this.thisYearLabel.AutoSize = true;
            this.thisYearLabel.ForeColor = System.Drawing.Color.Black;
            this.thisYearLabel.Location = new System.Drawing.Point(6, 38);
            this.thisYearLabel.Name = "thisYearLabel";
            this.thisYearLabel.Size = new System.Drawing.Size(165, 13);
            this.thisYearLabel.TabIndex = 1;
            this.thisYearLabel.Text = "This year\'s number of contestants";
            // 
            // lastYearTextBox
            // 
            this.lastYearTextBox.BackColor = System.Drawing.Color.White;
            this.lastYearTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastYearTextBox.Location = new System.Drawing.Point(177, 13);
            this.lastYearTextBox.Name = "lastYearTextBox";
            this.lastYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastYearTextBox.TabIndex = 2;
            // 
            // thisYearTextBox
            // 
            this.thisYearTextBox.BackColor = System.Drawing.Color.White;
            this.thisYearTextBox.ForeColor = System.Drawing.Color.Black;
            this.thisYearTextBox.Location = new System.Drawing.Point(177, 31);
            this.thisYearTextBox.Name = "thisYearTextBox";
            this.thisYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.thisYearTextBox.TabIndex = 3;
            // 
            // resultsButton
            // 
            this.resultsButton.BackColor = System.Drawing.Color.White;
            this.resultsButton.ForeColor = System.Drawing.Color.Green;
            this.resultsButton.Location = new System.Drawing.Point(162, 157);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(110, 66);
            this.resultsButton.TabIndex = 4;
            this.resultsButton.Text = "Get Revenue(s)";
            this.resultsButton.UseVisualStyleBackColor = false;
            this.resultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.BackColor = System.Drawing.Color.White;
            this.resultsLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.ForeColor = System.Drawing.Color.Black;
            this.resultsLabel.Location = new System.Drawing.Point(36, 241);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(363, 108);
            this.resultsLabel.TabIndex = 5;
            this.resultsLabel.Text = "\r\n\r\n\r\n          Results will appear here";
            // 
            // entryGroupBox
            // 
            this.entryGroupBox.Controls.Add(this.lastYearLabel);
            this.entryGroupBox.Controls.Add(this.thisYearLabel);
            this.entryGroupBox.Controls.Add(this.lastYearTextBox);
            this.entryGroupBox.Controls.Add(this.thisYearTextBox);
            this.entryGroupBox.ForeColor = System.Drawing.Color.Black;
            this.entryGroupBox.Location = new System.Drawing.Point(75, 90);
            this.entryGroupBox.Name = "entryGroupBox";
            this.entryGroupBox.Size = new System.Drawing.Size(284, 61);
            this.entryGroupBox.TabIndex = 6;
            this.entryGroupBox.TabStop = false;
            // 
            // greenvilleLabel
            // 
            this.greenvilleLabel.AutoSize = true;
            this.greenvilleLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenvilleLabel.ForeColor = System.Drawing.Color.Black;
            this.greenvilleLabel.Location = new System.Drawing.Point(102, 23);
            this.greenvilleLabel.Name = "greenvilleLabel";
            this.greenvilleLabel.Size = new System.Drawing.Size(231, 48);
            this.greenvilleLabel.TabIndex = 7;
            this.greenvilleLabel.Text = "Greenville";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GreenvilleRevGUI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(434, 369);
            this.Controls.Add(this.greenvilleLabel);
            this.Controls.Add(this.entryGroupBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GreenvilleRevGUI2";
            this.Text = "Greenville Revenue Estimator";
            this.entryGroupBox.ResumeLayout(false);
            this.entryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox entryGroupBox;
        private System.Windows.Forms.Label greenvilleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

