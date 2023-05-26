namespace PulsenicsAssessments.Forms
{
    partial class UserSearch
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
            AssignedFiles = new Label();
            UserTable = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            EmailColumn = new DataGridViewTextBoxColumn();
            PhoneColumn = new DataGridViewTextBoxColumn();
            SeeAssignedColumn = new DataGridViewButtonColumn();
            DeleteColumn = new DataGridViewButtonColumn();
            SearchButton = new Button();
            UserNameSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)UserTable).BeginInit();
            SuspendLayout();
            // 
            // AssignedFiles
            // 
            AssignedFiles.AutoSize = true;
            AssignedFiles.Location = new Point(60, 294);
            AssignedFiles.Name = "AssignedFiles";
            AssignedFiles.Size = new Size(0, 20);
            AssignedFiles.TabIndex = 11;
            // 
            // UserTable
            // 
            UserTable.AllowUserToAddRows = false;
            UserTable.AllowUserToDeleteRows = false;
            UserTable.BackgroundColor = SystemColors.Control;
            UserTable.BorderStyle = BorderStyle.None;
            UserTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserTable.Columns.AddRange(new DataGridViewColumn[] { NameColumn, EmailColumn, PhoneColumn, SeeAssignedColumn, DeleteColumn });
            UserTable.Location = new Point(60, 92);
            UserTable.Name = "UserTable";
            UserTable.RowHeadersWidth = 51;
            UserTable.RowTemplate.Height = 29;
            UserTable.Size = new Size(676, 199);
            UserTable.TabIndex = 10;
            UserTable.CellContentClick += UserTable_CellClick;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Resizable = DataGridViewTriState.True;
            NameColumn.Width = 125;
            // 
            // EmailColumn
            // 
            EmailColumn.HeaderText = "Email";
            EmailColumn.MinimumWidth = 6;
            EmailColumn.Name = "EmailColumn";
            EmailColumn.ReadOnly = true;
            EmailColumn.Width = 124;
            // 
            // PhoneColumn
            // 
            PhoneColumn.HeaderText = "Phone";
            PhoneColumn.MinimumWidth = 6;
            PhoneColumn.Name = "PhoneColumn";
            PhoneColumn.ReadOnly = true;
            PhoneColumn.Width = 125;
            // 
            // SeeAssignedColumn
            // 
            SeeAssignedColumn.HeaderText = "See Assigned Files";
            SeeAssignedColumn.MinimumWidth = 6;
            SeeAssignedColumn.Name = "SeeAssignedColumn";
            SeeAssignedColumn.ReadOnly = true;
            SeeAssignedColumn.Resizable = DataGridViewTriState.True;
            SeeAssignedColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            SeeAssignedColumn.Width = 125;
            // 
            // DeleteColumn
            // 
            DeleteColumn.HeaderText = "Delete";
            DeleteColumn.MinimumWidth = 6;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.Resizable = DataGridViewTriState.True;
            DeleteColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteColumn.Width = 125;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(343, 57);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += Search_Click;
            // 
            // UserNameSearch
            // 
            UserNameSearch.Location = new Point(224, 24);
            UserNameSearch.Name = "UserNameSearch";
            UserNameSearch.Size = new Size(328, 27);
            UserNameSearch.TabIndex = 8;
            // 
            // UserSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AssignedFiles);
            Controls.Add(UserTable);
            Controls.Add(SearchButton);
            Controls.Add(UserNameSearch);
            Name = "UserSearch";
            Text = "Search For Users";
            ((System.ComponentModel.ISupportInitialize)UserTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AssignedFiles;
        private DataGridView UserTable;
        private Button SearchButton;
        private TextBox UserNameSearch;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn EmailColumn;
        private DataGridViewTextBoxColumn PhoneColumn;
        private DataGridViewButtonColumn SeeAssignedColumn;
        private DataGridViewButtonColumn DeleteColumn;
    }
}