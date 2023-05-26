namespace PulsenicsAssessments.Forms
{
    partial class AddUser
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
            UpdateUserButton = new Button();
            AddUserButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            EmailInput = new TextBox();
            PhoneInput = new TextBox();
            NameInput = new TextBox();
            ErrorMessage = new Label();
            SuspendLayout();
            // 
            // UpdateUserButton
            // 
            UpdateUserButton.Location = new Point(398, 145);
            UpdateUserButton.Name = "UpdateUserButton";
            UpdateUserButton.Size = new Size(94, 29);
            UpdateUserButton.TabIndex = 15;
            UpdateUserButton.Text = "Update";
            UpdateUserButton.UseVisualStyleBackColor = true;
            UpdateUserButton.Click += UpdateUserButton_Click;
            // 
            // AddUserButton
            // 
            AddUserButton.Location = new Point(298, 145);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(94, 29);
            AddUserButton.TabIndex = 14;
            AddUserButton.Text = "Add";
            AddUserButton.UseVisualStyleBackColor = true;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 82);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 115);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 12;
            label2.Text = "Phone Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 49);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(222, 79);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(372, 27);
            EmailInput.TabIndex = 10;
            // 
            // PhoneInput
            // 
            PhoneInput.Location = new Point(222, 112);
            PhoneInput.Name = "PhoneInput";
            PhoneInput.Size = new Size(372, 27);
            PhoneInput.TabIndex = 9;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(222, 46);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(372, 27);
            NameInput.TabIndex = 8;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.ForeColor = Color.Red;
            ErrorMessage.Location = new Point(298, 192);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(0, 20);
            ErrorMessage.TabIndex = 16;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ErrorMessage);
            Controls.Add(UpdateUserButton);
            Controls.Add(AddUserButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EmailInput);
            Controls.Add(PhoneInput);
            Controls.Add(NameInput);
            Name = "AddUser";
            Text = "Add Users";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateUserButton;
        private Button AddUserButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox EmailInput;
        private TextBox PhoneInput;
        private TextBox NameInput;
        private Label ErrorMessage;
    }
}