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
    public partial class TeacherForm : Form
    {
        AddForm addForm;
        QuestionForm questionForm;
        LeaderForm leaderForm;

        LoginForm loginForm;

        public TeacherForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddQBtn_Click(object sender, EventArgs e)
        {
            if (addForm == null)
            {
                addForm = new AddForm();
                addForm.MdiParent = this;
                addForm.Dock = DockStyle.Fill;
                addForm.Show();
            }
            else
            {
                addForm.Activate();
                addForm.updateQuestionNumber();
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            addForm = new AddForm();
            addForm.MdiParent = this;
            addForm.Dock = DockStyle.Fill;
            addForm.Show();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            if (questionForm == null)
            {
                questionForm = new QuestionForm();
                questionForm.MdiParent = this;
                questionForm.Dock = DockStyle.Fill;
                questionForm.Show();
            }
            else
            {
                questionForm.Activate();
                questionForm.updateTable();
            }
        }

        private void leaderBtn_Click(object sender, EventArgs e)
        {
            if (leaderForm == null)
            {
                leaderForm = new LeaderForm();
                leaderForm.MdiParent = this;
                leaderForm.Dock = DockStyle.Fill;
                leaderForm.Show();
            }
            else
            {
                leaderForm.Activate();
                leaderForm.updateLeaderboard();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }
    }
}
