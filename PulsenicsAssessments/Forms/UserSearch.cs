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
    public partial class UserSearch : Form
    {
        public UserSearch()
        {
            InitializeComponent();
            UpdateTable(string.Empty);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            UpdateTable(UserNameSearch.Text);
        }

        private void UpdateTable(string searchText)
        {
            List<User> users = UserHandler.SearchForUser(searchText);
            UserTable.Rows.Clear();
            foreach (User user in users)
            {
                int index = UserTable.Rows.Add();
                UserTable.Rows[index].Cells[0].Value = user.Name;
                UserTable.Rows[index].Cells[1].Value = user.Email;
                UserTable.Rows[index].Cells[2].Value = user.Phone;
                UserTable.Rows[index].Cells[3].Value = "View";
                UserTable.Rows[index].Cells[4].Value = "Delete";
            }
            UserTable.Refresh();
        }

        private void UserTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == UserTable.Columns["SeeAssignedColumn"].Index)
            {
                string name = (string)UserTable.Rows[e.RowIndex].Cells[0].Value;
                User? user = UserHandler.GetUserWithFiles(name);
                if (user != null)
                {
                    AssignedFiles.Text = name + ":\n";
                    for (int i = 0; i < user.Files.Count; i++)
                    {
                        FileData file = user.Files[i];
                        string entryText = "  " + file.Name + file.Extension;
                        if (i < user.Files.Count - 1) entryText += "\n";
                        AssignedFiles.Text += entryText;
                    }
                }
            }
            else if (e.ColumnIndex == UserTable.Columns["DeleteColumn"].Index)
            {
                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this item?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                string name = (string)UserTable.Rows[e.RowIndex].Cells[0].Value;
                UserHandler.DeleteUser(name);
                UpdateTable(string.Empty);
                AssignedFiles.Text = string.Empty;
            }
        }
    }
}
