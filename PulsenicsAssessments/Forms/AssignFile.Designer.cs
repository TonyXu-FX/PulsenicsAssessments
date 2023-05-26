namespace PulsenicsAssessments.Forms
{
    partial class AssignFile
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
            ErrorMessage = new Label();
            label3 = new Label();
            label1 = new Label();
            FileInput = new TextBox();
            UserInput = new TextBox();
            AddUserButton = new Button();
            SuspendLayout();
            // 
            // ErrorMessage
            // 
            ErrorMessage.Anchor = AnchorStyles.None;
            ErrorMessage.AutoSize = true;
            ErrorMessage.ForeColor = Color.Red;
            ErrorMessage.Location = new Point(348, 208);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(0, 20);
            ErrorMessage.TabIndex = 25;
            ErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 146);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 22;
            label3.Text = "File";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 113);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 20;
            label1.Text = "User";
            // 
            // FileInput
            // 
            FileInput.Location = new Point(228, 143);
            FileInput.Name = "FileInput";
            FileInput.Size = new Size(372, 27);
            FileInput.TabIndex = 19;
            // 
            // UserInput
            // 
            UserInput.Location = new Point(228, 110);
            UserInput.Name = "UserInput";
            UserInput.Size = new Size(372, 27);
            UserInput.TabIndex = 17;
            // 
            // AddUserButton
            // 
            AddUserButton.Location = new Point(371, 176);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(94, 29);
            AddUserButton.TabIndex = 23;
            AddUserButton.Text = "Assign";
            AddUserButton.UseVisualStyleBackColor = true;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // AssignFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ErrorMessage);
            Controls.Add(AddUserButton);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(FileInput);
            Controls.Add(UserInput);
            Name = "AssignFile";
            Text = "Assign Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrorMessage;
        private Label label3;
        private Label label1;
        private TextBox FileInput;
        private TextBox UserInput;
        private Button AddUserButton;
    }
}