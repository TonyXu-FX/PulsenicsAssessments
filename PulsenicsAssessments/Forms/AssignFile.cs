using PulsenicsAssessments.Exceptions;
using PulsenicsAssessments.Helpers;
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
    public partial class AssignFile : Form
    {
        public AssignFile()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserHandler.AssignFileToUser(FileInput.Text, UserInput.Text);
                ErrorMessage.Text = "";
                ErrorMessage.Visible = false;
                ClearFields();
            }
            catch (FileDataNotFoundException)
            {
                ErrorMessage.Text = "Error: File not found";
                ErrorMessage.Visible = true;
            }
            catch (UserNotFoundException)
            {
                ErrorMessage.Text = "Error: User not found";
                ErrorMessage.Visible = true;
            }
        }

        private void ClearFields()
        {
            UserInput.Text = string.Empty;
            FileInput.Text = string.Empty;
        }
    }
}
