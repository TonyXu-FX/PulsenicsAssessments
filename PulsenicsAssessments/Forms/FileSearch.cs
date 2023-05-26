using PulsenicsAssessments.Helpers;
using PulsenicsAssessments.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsenicsAssessments.Forms
{
    public partial class FileSearch : Form
    {
        public FileSearch()
        {
            InitializeComponent();
            UpdateTable(string.Empty);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            UpdateTable(FileNameSearch.Text);
        }

        private void UpdateTable(String searchText)
        {
            List<FileData> files = FileHandler.GetDbFiles(searchText);
            FileDataTable.Rows.Clear();
            foreach (FileData file in files)
            {
                int index = FileDataTable.Rows.Add();
                FileDataTable.Rows[index].Cells[0].Value = file.Name + file.Extension;
                FileDataTable.Rows[index].Cells[1].Value = file.Created;
                FileDataTable.Rows[index].Cells[2].Value = file.Updated;
                FileDataTable.Rows[index].Cells[3].Value = "View";
            }
            FileDataTable.Refresh();
        }

        private void FileDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == FileDataTable.Columns["SeeAssignedColumn"].Index)
            {
                string fileName = (string)FileDataTable.Rows[e.RowIndex].Cells[0].Value;
                FileData? fileData = FileHandler.GetDbFileWithUsers(fileName);
                if (fileData != null)
                {
                    AssignedUsers.Text = fileName + ":\n";
                    for (int i = 0; i < fileData.Users.Count; i++)
                    {
                        User user = fileData.Users[i];
                        string entryText = "  ";
                        entryText += string.Join(" | ", user.Name, "Email: " + user.Email, "Phone: " + user.Phone);
                        if (i < fileData.Users.Count - 1) entryText += "\n";
                        AssignedUsers.Text += entryText;
                    }
                }
            }
        }
    }
}
