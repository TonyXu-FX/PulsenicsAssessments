namespace PulsenicsAssessments
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToFileSearch = new Button();
            ToAddUpdateUsers = new Button();
            ToAssignFiles = new Button();
            ToUserSearch = new Button();
            SuspendLayout();
            // 
            // ToFileSearch
            // 
            ToFileSearch.Location = new Point(310, 141);
            ToFileSearch.Name = "ToFileSearch";
            ToFileSearch.Size = new Size(160, 29);
            ToFileSearch.TabIndex = 0;
            ToFileSearch.Text = "Search For Files";
            ToFileSearch.UseVisualStyleBackColor = true;
            ToFileSearch.Click += ToFileSearch_Click;
            // 
            // ToAddUpdateUsers
            // 
            ToAddUpdateUsers.Location = new Point(310, 211);
            ToAddUpdateUsers.Name = "ToAddUpdateUsers";
            ToAddUpdateUsers.Size = new Size(160, 29);
            ToAddUpdateUsers.TabIndex = 1;
            ToAddUpdateUsers.Text = "Add/Update Users";
            ToAddUpdateUsers.UseVisualStyleBackColor = true;
            ToAddUpdateUsers.Click += ToAddUpdateUsers_Click;
            // 
            // ToAssignFiles
            // 
            ToAssignFiles.Location = new Point(310, 246);
            ToAssignFiles.Name = "ToAssignFiles";
            ToAssignFiles.Size = new Size(160, 29);
            ToAssignFiles.TabIndex = 2;
            ToAssignFiles.Text = "Assign Files";
            ToAssignFiles.UseVisualStyleBackColor = true;
            ToAssignFiles.Click += ToAssignFiles_Click;
            // 
            // ToUserSearch
            // 
            ToUserSearch.Location = new Point(310, 176);
            ToUserSearch.Name = "ToUserSearch";
            ToUserSearch.Size = new Size(160, 29);
            ToUserSearch.TabIndex = 3;
            ToUserSearch.Text = "Search For Users";
            ToUserSearch.UseVisualStyleBackColor = true;
            ToUserSearch.Click += ToUserSearch_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ToUserSearch);
            Controls.Add(ToAssignFiles);
            Controls.Add(ToAddUpdateUsers);
            Controls.Add(ToFileSearch);
            Name = "MainForm";
            Text = "Main Page";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ToFileSearch;
        private Button ToAddUpdateUsers;
        private Button ToAssignFiles;
        private Button ToUserSearch;
    }
}