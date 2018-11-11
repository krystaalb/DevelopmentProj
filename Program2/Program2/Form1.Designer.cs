namespace Program2
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.creditHoursLabel = new System.Windows.Forms.Label();
            this.enterInfoButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.creditHoursTextBox = new System.Windows.Forms.TextBox();
            this.regDayTimeOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(120, 15);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // creditHoursLabel
            // 
            this.creditHoursLabel.AutoSize = true;
            this.creditHoursLabel.Location = new System.Drawing.Point(61, 45);
            this.creditHoursLabel.Name = "creditHoursLabel";
            this.creditHoursLabel.Size = new System.Drawing.Size(120, 13);
            this.creditHoursLabel.TabIndex = 1;
            this.creditHoursLabel.Text = "Number of Credit Hours:";
            // 
            // enterInfoButton
            // 
            this.enterInfoButton.Location = new System.Drawing.Point(266, 100);
            this.enterInfoButton.Name = "enterInfoButton";
            this.enterInfoButton.Size = new System.Drawing.Size(99, 23);
            this.enterInfoButton.TabIndex = 3;
            this.enterInfoButton.Text = "Enter";
            this.enterInfoButton.UseVisualStyleBackColor = true;
            this.enterInfoButton.Click += new System.EventHandler(this.enterInfoButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lastNameTextBox.Location = new System.Drawing.Point(200, 12);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // creditHoursTextBox
            // 
            this.creditHoursTextBox.Location = new System.Drawing.Point(200, 38);
            this.creditHoursTextBox.Name = "creditHoursTextBox";
            this.creditHoursTextBox.Size = new System.Drawing.Size(165, 20);
            this.creditHoursTextBox.TabIndex = 5;
            // 
            // regDayTimeOutputLabel
            // 
            this.regDayTimeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regDayTimeOutputLabel.Location = new System.Drawing.Point(12, 74);
            this.regDayTimeOutputLabel.Name = "regDayTimeOutputLabel";
            this.regDayTimeOutputLabel.Size = new System.Drawing.Size(353, 23);
            this.regDayTimeOutputLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 126);
            this.Controls.Add(this.regDayTimeOutputLabel);
            this.Controls.Add(this.creditHoursTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.enterInfoButton);
            this.Controls.Add(this.creditHoursLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label creditHoursLabel;
        private System.Windows.Forms.Button enterInfoButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox creditHoursTextBox;
        private System.Windows.Forms.Label regDayTimeOutputLabel;
    }
}

