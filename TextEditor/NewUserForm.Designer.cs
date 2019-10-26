namespace TextEditor
{
    partial class NewUserForm
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
            this.newUserGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.DOBdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newLastNameTextBox = new System.Windows.Forms.TextBox();
            this.newFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newUserGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newUserGroupBox
            // 
            this.newUserGroupBox.Controls.Add(this.cancelButton);
            this.newUserGroupBox.Controls.Add(this.submitButton);
            this.newUserGroupBox.Controls.Add(this.DOBdateTimePicker);
            this.newUserGroupBox.Controls.Add(this.newLastNameTextBox);
            this.newUserGroupBox.Controls.Add(this.newFirstNameTextBox);
            this.newUserGroupBox.Controls.Add(this.userTypeComboBox);
            this.newUserGroupBox.Controls.Add(this.newPasswordTextBox);
            this.newUserGroupBox.Controls.Add(this.newUsernameTextBox);
            this.newUserGroupBox.Controls.Add(this.label7);
            this.newUserGroupBox.Controls.Add(this.label6);
            this.newUserGroupBox.Controls.Add(this.label5);
            this.newUserGroupBox.Controls.Add(this.label4);
            this.newUserGroupBox.Controls.Add(this.label3);
            this.newUserGroupBox.Controls.Add(this.label2);
            this.newUserGroupBox.Controls.Add(this.label1);
            this.newUserGroupBox.Location = new System.Drawing.Point(38, 29);
            this.newUserGroupBox.Name = "newUserGroupBox";
            this.newUserGroupBox.Size = new System.Drawing.Size(411, 353);
            this.newUserGroupBox.TabIndex = 0;
            this.newUserGroupBox.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(223, 306);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(110, 306);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DOBdateTimePicker
            // 
            this.DOBdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBdateTimePicker.Location = new System.Drawing.Point(198, 249);
            this.DOBdateTimePicker.Name = "DOBdateTimePicker";
            this.DOBdateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.DOBdateTimePicker.TabIndex = 12;
            // 
            // newLastNameTextBox
            // 
            this.newLastNameTextBox.Location = new System.Drawing.Point(198, 206);
            this.newLastNameTextBox.Name = "newLastNameTextBox";
            this.newLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.newLastNameTextBox.TabIndex = 11;
            // 
            // newFirstNameTextBox
            // 
            this.newFirstNameTextBox.Location = new System.Drawing.Point(198, 167);
            this.newFirstNameTextBox.Name = "newFirstNameTextBox";
            this.newFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.newFirstNameTextBox.TabIndex = 10;
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.userTypeComboBox.Location = new System.Drawing.Point(198, 127);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.userTypeComboBox.TabIndex = 9;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(198, 88);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.newPasswordTextBox.TabIndex = 8;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newUsernameTextBox
            // 
            this.newUsernameTextBox.Location = new System.Drawing.Point(198, 49);
            this.newUsernameTextBox.Name = "newUsernameTextBox";
            this.newUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.newUsernameTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.newUserGroupBox);
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewUserForm_FormClosing);
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.newUserGroupBox.ResumeLayout(false);
            this.newUserGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newUserGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userTypeComboBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox newUsernameTextBox;
        private System.Windows.Forms.TextBox newLastNameTextBox;
        private System.Windows.Forms.TextBox newFirstNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker DOBdateTimePicker;
    }
}