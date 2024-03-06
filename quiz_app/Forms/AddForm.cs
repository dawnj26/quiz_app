using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_app.Forms
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void clearForm()
        {
            questionBox.Clear();
            option1Box.Clear();
            option2Box.Clear();
            option3Box.Clear();
            option4Box.Clear();
            answerBox.Clear();
        }

        public void updateQuestionNumber()
        {
            asd.Text = "Question " + (CsvHelper.getQuestionCount() + 1).ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(CsvHelper.getQuestionCount());
            if (questionBox.Text == "" || option1Box.Text == "" || option2Box.Text == "" || option3Box.Text == "" || option4Box.Text == "" || answerBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            var question = new Question(questionBox.Text, answerBox.Text, option1Box.Text, option2Box.Text, option3Box.Text, option4Box.Text);

            if (!question.hasAnswer())
            {
                MessageBox.Show("Answer must be one of the options");
                return;
            }

            CsvHelper.addQuestion(question);

            clearForm();

            updateQuestionNumber();

            MessageBox.Show("Question added successfully");
        }

        private void questionBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true; // Suppress the key
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            updateQuestionNumber();
        }
    }
}
