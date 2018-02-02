namespace Ch12_CaseProblem1
{
    partial class GreenvilleAdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreenvilleAdForm));
            this.introLabel = new System.Windows.Forms.Label();
            this.introLabel2 = new System.Windows.Forms.Label();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.genderRadioButton2 = new System.Windows.Forms.RadioButton();
            this.genderRadioButton1 = new System.Windows.Forms.RadioButton();
            this.borderTopLeft = new System.Windows.Forms.PictureBox();
            this.borderTopRight = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.borderBottomLeft = new System.Windows.Forms.PictureBox();
            this.borderBottomRight = new System.Windows.Forms.PictureBox();
            this.agePicker = new System.Windows.Forms.DateTimePicker();
            this.ageLabel = new System.Windows.Forms.Label();
            this.genderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderTopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderBottomRight)).BeginInit();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.ForeColor = System.Drawing.Color.Black;
            this.introLabel.Location = new System.Drawing.Point(106, 9);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(318, 72);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "****************************\r\nGreenville Idol Competition\r\n**********************" +
    "******";
            // 
            // introLabel2
            // 
            this.introLabel2.AutoSize = true;
            this.introLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel2.ForeColor = System.Drawing.Color.Black;
            this.introLabel2.Location = new System.Drawing.Point(145, 81);
            this.introLabel2.Name = "introLabel2";
            this.introLabel2.Size = new System.Drawing.Size(241, 40);
            this.introLabel2.TabIndex = 1;
            this.introLabel2.Text = "Please fill out this form to enter!\r\nNote there is a $25 entrance fee.";
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.genderRadioButton2);
            this.genderGroupBox.Controls.Add(this.genderRadioButton1);
            this.genderGroupBox.ForeColor = System.Drawing.Color.Black;
            this.genderGroupBox.Location = new System.Drawing.Point(207, 137);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(114, 70);
            this.genderGroupBox.TabIndex = 2;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Select Gender";
            // 
            // genderRadioButton2
            // 
            this.genderRadioButton2.AutoSize = true;
            this.genderRadioButton2.Location = new System.Drawing.Point(7, 44);
            this.genderRadioButton2.Name = "genderRadioButton2";
            this.genderRadioButton2.Size = new System.Drawing.Size(48, 17);
            this.genderRadioButton2.TabIndex = 1;
            this.genderRadioButton2.TabStop = true;
            this.genderRadioButton2.Text = "Male";
            this.genderRadioButton2.UseVisualStyleBackColor = true;
            // 
            // genderRadioButton1
            // 
            this.genderRadioButton1.AutoSize = true;
            this.genderRadioButton1.ForeColor = System.Drawing.Color.Black;
            this.genderRadioButton1.Location = new System.Drawing.Point(7, 20);
            this.genderRadioButton1.Name = "genderRadioButton1";
            this.genderRadioButton1.Size = new System.Drawing.Size(59, 17);
            this.genderRadioButton1.TabIndex = 0;
            this.genderRadioButton1.TabStop = true;
            this.genderRadioButton1.Text = "Female";
            this.genderRadioButton1.UseVisualStyleBackColor = true;
            // 
            // borderTopLeft
            // 
            this.borderTopLeft.Image = ((System.Drawing.Image)(resources.GetObject("borderTopLeft.Image")));
            this.borderTopLeft.Location = new System.Drawing.Point(0, 0);
            this.borderTopLeft.Name = "borderTopLeft";
            this.borderTopLeft.Size = new System.Drawing.Size(116, 109);
            this.borderTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.borderTopLeft.TabIndex = 3;
            this.borderTopLeft.TabStop = false;
            // 
            // borderTopRight
            // 
            this.borderTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.borderTopRight.Image = ((System.Drawing.Image)(resources.GetObject("borderTopRight.Image")));
            this.borderTopRight.Location = new System.Drawing.Point(416, 0);
            this.borderTopRight.Name = "borderTopRight";
            this.borderTopRight.Size = new System.Drawing.Size(116, 109);
            this.borderTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.borderTopRight.TabIndex = 4;
            this.borderTopRight.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(186, 265);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(156, 24);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Enter Your Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(178, 292);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Black;
            this.resultLabel.Location = new System.Drawing.Point(111, 377);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(306, 50);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Thank you, Pallas Athena!\r\nYour form has been submitted.";
            this.resultLabel.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Green;
            this.submitButton.Location = new System.Drawing.Point(191, 318);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(146, 40);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit Form";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // borderBottomLeft
            // 
            this.borderBottomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.borderBottomLeft.Image = ((System.Drawing.Image)(resources.GetObject("borderBottomLeft.Image")));
            this.borderBottomLeft.Location = new System.Drawing.Point(0, 365);
            this.borderBottomLeft.Name = "borderBottomLeft";
            this.borderBottomLeft.Size = new System.Drawing.Size(116, 109);
            this.borderBottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.borderBottomLeft.TabIndex = 9;
            this.borderBottomLeft.TabStop = false;
            // 
            // borderBottomRight
            // 
            this.borderBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.borderBottomRight.Image = ((System.Drawing.Image)(resources.GetObject("borderBottomRight.Image")));
            this.borderBottomRight.Location = new System.Drawing.Point(416, 365);
            this.borderBottomRight.Name = "borderBottomRight";
            this.borderBottomRight.Size = new System.Drawing.Size(116, 109);
            this.borderBottomRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.borderBottomRight.TabIndex = 10;
            this.borderBottomRight.TabStop = false;
            // 
            // agePicker
            // 
            this.agePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.agePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.agePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            this.agePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.agePicker.CustomFormat = "yyyy";
            this.agePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.agePicker.Location = new System.Drawing.Point(228, 242);
            this.agePicker.MaxDate = new System.DateTime(2018, 2, 1, 0, 0, 0, 0);
            this.agePicker.Name = "agePicker";
            this.agePicker.ShowUpDown = true;
            this.agePicker.Size = new System.Drawing.Size(73, 20);
            this.agePicker.TabIndex = 11;
            this.agePicker.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.ForeColor = System.Drawing.Color.Black;
            this.ageLabel.Location = new System.Drawing.Point(211, 219);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(106, 13);
            this.ageLabel.TabIndex = 12;
            this.ageLabel.Text = "Enter Your Birth Year";
            // 
            // GreenvilleAdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(528, 470);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.agePicker);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.introLabel2);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.borderTopLeft);
            this.Controls.Add(this.borderTopRight);
            this.Controls.Add(this.borderBottomLeft);
            this.Controls.Add(this.borderBottomRight);
            this.Name = "GreenvilleAdForm";
            this.Text = "Greenville Advertisement";
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderTopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderBottomRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label introLabel2;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.PictureBox borderTopLeft;
        private System.Windows.Forms.PictureBox borderTopRight;
        private System.Windows.Forms.RadioButton genderRadioButton2;
        private System.Windows.Forms.RadioButton genderRadioButton1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.PictureBox borderBottomLeft;
        private System.Windows.Forms.PictureBox borderBottomRight;
        private System.Windows.Forms.DateTimePicker agePicker;
        private System.Windows.Forms.Label ageLabel;
    }
}

