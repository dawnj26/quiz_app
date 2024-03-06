using quiz_app.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_app
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(this);
            registerForm.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            Activate();
            if (usernameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (!CsvHelper.isRegistered(usernameBox.Text))
            {
                MessageBox.Show("User not found. Please register");
                return;
            }

            var user = CsvHelper.verifyUser(usernameBox.Text, passwordBox.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }

            if (!user.IsStudent)
            {
                TeacherForm teacherForm = new TeacherForm(this);
                teacherForm.Show();
                Hide();
            } else
            {
                ConfirmForm confirmForm = new ConfirmForm(this, user);
                confirmForm.Show();
                Hide();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CsvHelper.createDirectory();
        }
    }
}
