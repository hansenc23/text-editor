using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class NewUserForm : Form
    {
        User user = new User();
        LoginForm loginForm;
        public NewUserForm()
        {
            InitializeComponent();
            DOBdateTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            newUser();
            DialogResult result = MessageBox.Show("User successfully created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                this.Hide();
                loginForm.Show();
            }
        }

        private void NewUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void newUser()
        {
            string username = newUsernameTextBox.Text;
            string password = newPasswordTextBox.Text;
            string userType = userTypeComboBox.Text;
            string firstName = newFirstNameTextBox.Text;
            string lastName = newLastNameTextBox.Text;
            string dateOfBirth = DOBdateTimePicker.Text;

            user.newUser(username, password, userType, firstName, lastName, dateOfBirth); //create new user and append it to login.txt
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
         
            loginForm.Show();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
