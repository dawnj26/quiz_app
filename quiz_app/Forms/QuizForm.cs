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
    public partial class QuizForm : Form
    {
        private static List<Question> questions = CsvHelper.getQuestions();
        private int currentQuestion = 0;
        private int score = 0;

        private int totalTime = 600;

        private int[] correctQuestions = new int[questions.Count];

        private User user;

        private void checkAnswer()
        {


            var question = questions[currentQuestion];

            correctQuestions[currentQuestion] = question.checkAnswer(); 

            option1.Checked = false;
            option2.Checked = false;
            option3.Checked = false;
            option4.Checked = false;
        }
        

        private void updateQuestion()
        {
            var question = questions[currentQuestion];

            questionLabel.Text = "Question " + (currentQuestion + 1);   

            questionBox.Text = question.QuestionText;
            option1.Text = question.Option1;
            option2.Text = question.Option2;
            option3.Text = question.Option3;
            option4.Text = question.Option4;
        }

        public QuizForm(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            updateQuestion();
        }

        private void option1_Click(object sender, EventArgs e)
        {
            
            questions[currentQuestion].Choice = 1;
            Console.WriteLine("clicked " + questions[currentQuestion].Choice);
        }

        private void option2_Click(object sender, EventArgs e)
        {
            questions[currentQuestion].Choice = 2;
            Console.WriteLine("clicked " + questions[currentQuestion].Choice);
        }

        private void option3_CheckedChanged(object sender, EventArgs e)
        {
            questions[currentQuestion].Choice = 3;
            Console.WriteLine("clicked " + questions[currentQuestion].Choice);
        }

        private void option4_Click(object sender, EventArgs e)
        {

            questions[currentQuestion].Choice = 4;
            Console.WriteLine("clicked " + questions[currentQuestion].Choice);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (!option1.Checked && !option2.Checked && !option3.Checked && !option4.Checked)
            {
                MessageBox.Show("Please select an answer");
                return;
            }

            if (currentQuestion == questions.Count - 1)
            {
                checkAnswer();

                score = correctQuestions.Sum();

                ResultsForm res = new ResultsForm(score, user);
                res.Show();
                Close();

                //MessageBox.Show("Your score is " + score);
                return;
            }

            checkAnswer();

            currentQuestion++;

            if (currentQuestion == questions.Count - 1)
            {
                NextBtn.Text = "Finish";
            }

            updateQuestion();

            if (currentQuestion > 0)
            {
                PrevBtn.Enabled = true;
            }

            
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {

            currentQuestion--;
            NextBtn.Text = "Next";

            if (currentQuestion == 0)
            {
                PrevBtn.Enabled = false;
            }

            updateQuestion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalTime == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's up!");
                checkAnswer();

                score = correctQuestions.Sum();

                ResultsForm res = new ResultsForm(score, user);
                res.Show();
                Close();

                //MessageBox.Show("Your score is " + score);
                return;
            }

            totalTime--;
            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            timeLabel.Text = time.ToString(@"mm\:ss");
        }
    }
}
