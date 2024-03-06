using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_app.Forms
{
    public partial class ConfirmForm : Form
    {
        User user;
        LoginForm loginForm;

        private bool hasQuestions = CsvHelper.getQuestions().Count > 0;

        public ConfirmForm(LoginForm loginForm, User u)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            user = u;
        }


        private void ConfirmForm_Load(object sender, EventArgs e)
        {
            studentName.Text = user.Name;

            if (user.IsFinished == 1)
            {
                titleMsg.Text = "Your test is already submitted";
                subtitleMsg.Text = "GGs";
                startBtn.Text = "Log out";

                return;
            }

            if (!hasQuestions)
            {
                titleMsg.Text = "No questions available";
                subtitleMsg.Text = "Please contact your teacher";
                startBtn.Text = "Log out";

                return;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!hasQuestions || user.IsFinished == 1)
            {
                loginForm.Show();
                Close();
                return;
            }

            QuizForm quizForm = new QuizForm(user);

            quizForm.Show();
            Close();
        }
    }
}
