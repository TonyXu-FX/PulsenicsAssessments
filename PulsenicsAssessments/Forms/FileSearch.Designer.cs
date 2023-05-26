namespace PulsenicsAssessments.Forms
{
    partial class FileSearch
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
            FileDataTable = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            CreatedColumn = new DataGridViewTextBoxColumn();
            UpdatedColumn = new DataGridViewTextBoxColumn();
            SeeAssignedColumn = new DataGridViewButtonColumn();
            SearchButton = new Button();
            FileNameSearch = new TextBox();
            AssignedUsers = new Label();
            ((System.ComponentModel.ISupportInitialize)FileDataTable).BeginInit();
            SuspendLayout();
            // 
            // FileDataTable
            // 
            FileDataTable.AllowUserToAddRows = false;
            FileDataTable.AllowUserToDeleteRows = false;
            FileDataTable.BackgroundColor = SystemColors.Control;
            FileDataTable.BorderStyle = BorderStyle.None;
            FileDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FileDataTable.Columns.AddRange(new DataGridViewColumn[] { NameColumn, CreatedColumn, UpdatedColumn, SeeAssignedColumn });
            FileDataTable.Location = new Point(104, 110);
            FileDataTable.Name = "FileDataTable";
            FileDataTable.RowHeadersWidth = 51;
            FileDataTable.RowTemplate.Height = 29;
            FileDataTable.Size = new Size(596, 199);
            FileDataTable.TabIndex = 5;
            FileDataTable.CellContentClick += FileDataTable_CellClick;
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
            // CreatedColumn
            // 
            CreatedColumn.HeaderText = "Created";
            CreatedColumn.MinimumWidth = 6;
            CreatedColumn.Name = "CreatedColumn";
            CreatedColumn.ReadOnly = true;
            CreatedColumn.Width = 124;
            // 
            // UpdatedColumn
            // 
            UpdatedColumn.HeaderText = "Updated";
            UpdatedColumn.MinimumWidth = 6;
            UpdatedColumn.Name = "UpdatedColumn";
            UpdatedColumn.ReadOnly = true;
            UpdatedColumn.Width = 125;
            // 
            // SeeAssignedColumn
            // 
            SeeAssignedColumn.HeaderText = "See Assigned Users";
            SeeAssignedColumn.MinimumWidth = 6;
            SeeAssignedColumn.Name = "SeeAssignedColumn";
            SeeAssignedColumn.ReadOnly = true;
            SeeAssignedColumn.Resizable = DataGridViewTriState.True;
            SeeAssignedColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            SeeAssignedColumn.Width = 125;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(347, 75);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += Search_Click;
            // 
            // FileNameSearch
            // 
            FileNameSearch.Location = new Point(228, 42);
            FileNameSearch.Name = "FileNameSearch";
            FileNameSearch.Size = new Size(328, 27);
            FileNameSearch.TabIndex = 3;
            // 
            // AssignedUsers
            // 
            AssignedUsers.AutoSize = true;
            AssignedUsers.Location = new Point(104, 312);
            AssignedUsers.Name = "AssignedUsers";
            AssignedUsers.Size = new Size(0, 20);
            AssignedUsers.TabIndex = 7;
            // 
            // FileSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AssignedUsers);
            Controls.Add(FileDataTable);
            Controls.Add(SearchButton);
            Controls.Add(FileNameSearch);
            Name = "FileSearch";
            Text = "Search For Files";
            ((System.ComponentModel.ISupportInitialize)FileDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView FileDataTable;
        private Button SearchButton;
        private TextBox FileNameSearch;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn CreatedColumn;
        private DataGridViewTextBoxColumn UpdatedColumn;
        private DataGridViewButtonColumn SeeAssignedColumn;
        private ListView AssignedUsersList;
        private Label AssignedUsers;
    }
}