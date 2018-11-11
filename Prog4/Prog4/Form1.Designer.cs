namespace Prog4
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
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.copyrightYearTextBox = new System.Windows.Forms.TextBox();
            this.callNumberTextBox = new System.Windows.Forms.TextBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.libraryBookListBox = new System.Windows.Forms.ListBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.copyrightYearLabel = new System.Windows.Forms.Label();
            this.callNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(80, 49);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(80, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 0;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(80, 79);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherTextBox.TabIndex = 2;
            // 
            // copyrightYearTextBox
            // 
            this.copyrightYearTextBox.Location = new System.Drawing.Point(80, 112);
            this.copyrightYearTextBox.Name = "copyrightYearTextBox";
            this.copyrightYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.copyrightYearTextBox.TabIndex = 3;
            // 
            // callNumberTextBox
            // 
            this.callNumberTextBox.Location = new System.Drawing.Point(80, 150);
            this.callNumberTextBox.Name = "callNumberTextBox";
            this.callNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.callNumberTextBox.TabIndex = 4;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(95, 193);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 5;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // libraryBookListBox
            // 
            this.libraryBookListBox.FormattingEnabled = true;
            this.libraryBookListBox.Location = new System.Drawing.Point(186, 4);
            this.libraryBookListBox.Name = "libraryBookListBox";
            this.libraryBookListBox.Size = new System.Drawing.Size(120, 212);
            this.libraryBookListBox.TabIndex = 6;
            
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(312, 105);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 7;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(312, 150);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(75, 23);
            this.checkOutButton.TabIndex = 8;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(312, 191);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(34, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(34, 56);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 11;
            this.authorLabel.Text = "Author:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(26, 86);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(53, 13);
            this.publisherLabel.TabIndex = 12;
            this.publisherLabel.Text = "Publisher:";
            // 
            // copyrightYearLabel
            // 
            this.copyrightYearLabel.AutoSize = true;
            this.copyrightYearLabel.Location = new System.Drawing.Point(0, 119);
            this.copyrightYearLabel.Name = "copyrightYearLabel";
            this.copyrightYearLabel.Size = new System.Drawing.Size(79, 13);
            this.copyrightYearLabel.TabIndex = 13;
            this.copyrightYearLabel.Text = "Copyright Year:";
            // 
            // callNumberLabel
            // 
            this.callNumberLabel.AutoSize = true;
            this.callNumberLabel.Location = new System.Drawing.Point(12, 157);
            this.callNumberLabel.Name = "callNumberLabel";
            this.callNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.callNumberLabel.TabIndex = 14;
            this.callNumberLabel.Text = "Call Number:";
            // 
            // Form1
            // 
            this.AcceptButton = this.addBookButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 233);
            this.Controls.Add(this.callNumberLabel);
            this.Controls.Add(this.copyrightYearLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.libraryBookListBox);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.callNumberTextBox);
            this.Controls.Add(this.copyrightYearTextBox);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Name = "Form1";
            this.Text = "Program 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox copyrightYearTextBox;
        private System.Windows.Forms.TextBox callNumberTextBox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.ListBox libraryBookListBox;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label copyrightYearLabel;
        private System.Windows.Forms.Label callNumberLabel;
    }
}

