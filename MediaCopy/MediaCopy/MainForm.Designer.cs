namespace MediaCopy
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
            this.label1 = new System.Windows.Forms.Label();
            this.SourceDriveComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureExtensionsTextBox = new System.Windows.Forms.TextBox();
            this.VideoExtensionsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PictureDestinationTextBox = new System.Windows.Forms.TextBox();
            this.PictureDistinationButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.VideoDestinationTextBox = new System.Windows.Forms.TextBox();
            this.VideoDestinationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteAfterCopyCheckBox = new System.Windows.Forms.CheckBox();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.NameMappingTextBox = new System.Windows.Forms.TextBox();
            this.NameMappingLinkLabel = new System.Windows.Forms.LinkLabel();
            this.TestButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ScanButton = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DateFromTextBox = new System.Windows.Forms.TextBox();
            this.DateToTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Drive";
            // 
            // SourceDriveComboBox
            // 
            this.SourceDriveComboBox.FormattingEnabled = true;
            this.SourceDriveComboBox.Location = new System.Drawing.Point(89, 8);
            this.SourceDriveComboBox.Name = "SourceDriveComboBox";
            this.SourceDriveComboBox.Size = new System.Drawing.Size(48, 21);
            this.SourceDriveComboBox.TabIndex = 1;
            this.SourceDriveComboBox.SelectedIndexChanged += new System.EventHandler(this.SourceDriveComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pictures";
            // 
            // PictureExtensionsTextBox
            // 
            this.PictureExtensionsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureExtensionsTextBox.Location = new System.Drawing.Point(101, 60);
            this.PictureExtensionsTextBox.Name = "PictureExtensionsTextBox";
            this.PictureExtensionsTextBox.Size = new System.Drawing.Size(664, 20);
            this.PictureExtensionsTextBox.TabIndex = 4;
            this.PictureExtensionsTextBox.Text = "jpg bmp tif tiff";
            // 
            // VideoExtensionsTextBox
            // 
            this.VideoExtensionsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoExtensionsTextBox.Location = new System.Drawing.Point(101, 147);
            this.VideoExtensionsTextBox.Name = "VideoExtensionsTextBox";
            this.VideoExtensionsTextBox.Size = new System.Drawing.Size(664, 20);
            this.VideoExtensionsTextBox.TabIndex = 4;
            this.VideoExtensionsTextBox.Text = "mp4 mov avi fli mod moi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Extensions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Extensions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Destination";
            // 
            // PictureDestinationTextBox
            // 
            this.PictureDestinationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureDestinationTextBox.Location = new System.Drawing.Point(101, 86);
            this.PictureDestinationTextBox.Name = "PictureDestinationTextBox";
            this.PictureDestinationTextBox.Size = new System.Drawing.Size(632, 20);
            this.PictureDestinationTextBox.TabIndex = 4;
            // 
            // PictureDistinationButton
            // 
            this.PictureDistinationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureDistinationButton.Location = new System.Drawing.Point(739, 86);
            this.PictureDistinationButton.Name = "PictureDistinationButton";
            this.PictureDistinationButton.Size = new System.Drawing.Size(26, 23);
            this.PictureDistinationButton.TabIndex = 5;
            this.PictureDistinationButton.Text = "...";
            this.PictureDistinationButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Destination";
            // 
            // VideoDestinationTextBox
            // 
            this.VideoDestinationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoDestinationTextBox.Location = new System.Drawing.Point(101, 173);
            this.VideoDestinationTextBox.Name = "VideoDestinationTextBox";
            this.VideoDestinationTextBox.Size = new System.Drawing.Size(632, 20);
            this.VideoDestinationTextBox.TabIndex = 4;
            this.VideoDestinationTextBox.Text = "G:\\VideoFootage\\2010";
            // 
            // VideoDestinationButton
            // 
            this.VideoDestinationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoDestinationButton.Location = new System.Drawing.Point(739, 173);
            this.VideoDestinationButton.Name = "VideoDestinationButton";
            this.VideoDestinationButton.Size = new System.Drawing.Size(26, 23);
            this.VideoDestinationButton.TabIndex = 5;
            this.VideoDestinationButton.Text = "...";
            this.VideoDestinationButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Video";
            // 
            // DeleteAfterCopyCheckBox
            // 
            this.DeleteAfterCopyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAfterCopyCheckBox.AutoSize = true;
            this.DeleteAfterCopyCheckBox.Location = new System.Drawing.Point(642, 242);
            this.DeleteAfterCopyCheckBox.Name = "DeleteAfterCopyCheckBox";
            this.DeleteAfterCopyCheckBox.Size = new System.Drawing.Size(123, 17);
            this.DeleteAfterCopyCheckBox.TabIndex = 6;
            this.DeleteAfterCopyCheckBox.Text = "Delete After Copying";
            this.DeleteAfterCopyCheckBox.UseVisualStyleBackColor = true;
            // 
            // StatusText
            // 
            this.StatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusText.BackColor = System.Drawing.Color.MidnightBlue;
            this.StatusText.ForeColor = System.Drawing.Color.Yellow;
            this.StatusText.Location = new System.Drawing.Point(12, 265);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StatusText.Size = new System.Drawing.Size(753, 286);
            this.StatusText.TabIndex = 7;
            // 
            // NameMappingTextBox
            // 
            this.NameMappingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NameMappingTextBox.Location = new System.Drawing.Point(101, 216);
            this.NameMappingTextBox.Name = "NameMappingTextBox";
            this.NameMappingTextBox.Size = new System.Drawing.Size(396, 20);
            this.NameMappingTextBox.TabIndex = 4;
            this.NameMappingTextBox.Text = "yyyyMMdd_HH-mm-ss";
            // 
            // NameMappingLinkLabel
            // 
            this.NameMappingLinkLabel.AutoSize = true;
            this.NameMappingLinkLabel.Location = new System.Drawing.Point(16, 222);
            this.NameMappingLinkLabel.Name = "NameMappingLinkLabel";
            this.NameMappingLinkLabel.Size = new System.Drawing.Size(79, 13);
            this.NameMappingLinkLabel.TabIndex = 8;
            this.NameMappingLinkLabel.TabStop = true;
            this.NameMappingLinkLabel.Text = "Name Mapping";
            this.NameMappingLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NameMappingLinkLabel_LinkClicked);
            // 
            // TestButton
            // 
            this.TestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TestButton.Location = new System.Drawing.Point(503, 217);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(38, 19);
            this.TestButton.TabIndex = 9;
            this.TestButton.Tag = "Copy";
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.BackColor = System.Drawing.Color.Chartreuse;
            this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(673, 208);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(92, 33);
            this.CopyButton.TabIndex = 9;
            this.CopyButton.Tag = "Copy";
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // ScanButton
            // 
            this.ScanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScanButton.Location = new System.Drawing.Point(714, 13);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(46, 19);
            this.ScanButton.TabIndex = 9;
            this.ScanButton.Tag = "Copy";
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // Progress
            // 
            this.Progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Progress.Location = new System.Drawing.Point(16, 554);
            this.Progress.Maximum = 1000;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(749, 23);
            this.Progress.Step = 1;
            this.Progress.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(575, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 9;
            this.button1.Tag = "Copy";
            this.button1.Text = "Pretend Copy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.PretendCopyButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Date Range";
            // 
            // DateFromTextBox
            // 
            this.DateFromTextBox.Location = new System.Drawing.Point(274, 8);
            this.DateFromTextBox.Name = "DateFromTextBox";
            this.DateFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateFromTextBox.TabIndex = 11;
            // 
            // DateToTextBox
            // 
            this.DateToTextBox.Location = new System.Drawing.Point(397, 8);
            this.DateToTextBox.Name = "DateToTextBox";
            this.DateToTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateToTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "to";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 580);
            this.Controls.Add(this.DateToTextBox);
            this.Controls.Add(this.DateFromTextBox);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.NameMappingLinkLabel);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.DeleteAfterCopyCheckBox);
            this.Controls.Add(this.VideoDestinationButton);
            this.Controls.Add(this.PictureDistinationButton);
            this.Controls.Add(this.NameMappingTextBox);
            this.Controls.Add(this.VideoExtensionsTextBox);
            this.Controls.Add(this.VideoDestinationTextBox);
            this.Controls.Add(this.PictureDestinationTextBox);
            this.Controls.Add(this.PictureExtensionsTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SourceDriveComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MediaCopy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SourceDriveComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PictureExtensionsTextBox;
        private System.Windows.Forms.TextBox VideoExtensionsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PictureDestinationTextBox;
        private System.Windows.Forms.Button PictureDistinationButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VideoDestinationTextBox;
        private System.Windows.Forms.Button VideoDestinationButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox DeleteAfterCopyCheckBox;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.TextBox NameMappingTextBox;
        private System.Windows.Forms.LinkLabel NameMappingLinkLabel;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DateFromTextBox;
        private System.Windows.Forms.TextBox DateToTextBox;
        private System.Windows.Forms.Label label9;
    }
}

