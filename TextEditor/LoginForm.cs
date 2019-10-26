using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace TextEditor
{
    public partial class LoginForm : Form
    {

        public User user = new User();
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                //check the input username and password
                if (user.ValidLogin(username, password) == true)
                {
                    user = user.getCurrentUser(username);
                    this.Hide();
                    TextEditorForm textEditor = new TextEditorForm(user);
                    textEditor.Show();

                }
                else
                {
                    MessageBox.Show("Invalid credentials, please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exeption", MessageBoxButtons.OK);
            }
           

            
        }


        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void NewUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();
        }

       
    }
}
