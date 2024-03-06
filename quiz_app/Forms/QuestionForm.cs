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
    public partial class QuestionForm : Form
    {
        private int selectedQuestion = -1;

        public QuestionForm()
        {
            InitializeComponent();
        }

        public void updateTable()
        {
            var questions = CsvHelper.getQuestions();

            questionView.Rows.Clear();

            foreach (var question in questions)
            {
                questionView.Rows.Add(question.QuestionText, question.Option1, question.Option2, question.Option3, question.Option4, question.Answer);
            }
            questionView.ClearSelection();
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            updateTable();
        }

        private void questionView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (questionView.SelectedRows.Count > 0)
            {
                selectedQuestion = questionView.SelectedRows[0].Index;
                // Use the row index for your needs
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (selectedQuestion == -1)
            {
                MessageBox.Show("Please select a question to delete");
                return;
            }

            CsvHelper.deleteQuestion(selectedQuestion);
            MessageBox.Show("Question deleted successfully");

            updateTable();
        }
    }
}
