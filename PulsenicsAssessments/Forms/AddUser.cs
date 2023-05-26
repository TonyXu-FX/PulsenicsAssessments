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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            if (!UserHandler.AddUser(NameInput.Text, EmailInput.Text, PhoneInput.Text))
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Error: User already exists";
            }
            else
            {
                ErrorMessage.Visible = false;
                ErrorMessage.Text = "";
                ClearFields();
            }
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            if (!UserHandler.UpdateUser(NameInput.Text, EmailInput.Text, PhoneInput.Text))
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Error: User does not exist";
            }
            else
            {
                ErrorMessage.Visible = false;
                ErrorMessage.Text = "";
                ClearFields();
            }
        }

        private bool ValidateFields()
        {
            if (String.IsNullOrWhiteSpace(NameInput.Text) ||
                String.IsNullOrWhiteSpace(EmailInput.Text) ||
                String.IsNullOrWhiteSpace(PhoneInput.Text))
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Error: A field is not filled in";
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            NameInput.Text = String.Empty;
            EmailInput.Text = String.Empty;
            PhoneInput.Text = String.Empty;
        }
    }
}
