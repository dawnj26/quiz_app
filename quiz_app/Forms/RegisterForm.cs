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
    public partial class RegisterForm : Form
    {
        bool male = true;
        Form loginForm;
        public RegisterForm(Form loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void clearForm()
        {
            NameBox.Clear();
            UsernameBox.Clear();
            PasswordBox.Clear();
            studentRadio.Checked = true;
            genderToggle(true);
        }

        private void genderToggle(bool gender)
        {
            male = gender;

            if (male)
            {
                MaleBtn.BackColor = Color.FromArgb(73, 94, 87);
                MaleBtn.ForeColor = Color.White;
                FemaleBtn.BackColor = Color.Transparent;
                FemaleBtn.ForeColor = Color.FromArgb(73, 94, 87);
            }
           else
            {
                FemaleBtn.BackColor = Color.FromArgb(73, 94, 87);
                FemaleBtn.ForeColor = Color.White;
                MaleBtn.BackColor = Color.Transparent;
                MaleBtn.ForeColor = Color.FromArgb(73, 94, 87);
            }

            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaleBtn_Click(object sender, EventArgs e)
        {
            genderToggle(true);
        }

        private void FemaleBtn_Click(object sender, EventArgs e)
        {
            genderToggle(false);
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            User p = new User(NameBox.Text, UsernameBox.Text, male ? "male" : "female", PasswordBox.Text, studentRadio.Checked, 0);

            if (string.IsNullOrEmpty(p.Name) || string.IsNullOrEmpty(p.Username) || string.IsNullOrEmpty(p.Password))
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CsvHelper.isRegistered(p.Username))
            {
                MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CsvHelper.addUser(p);

            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearForm();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }
    }
}
