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
    public partial class ResultsForm : Form
    {
        private int score;
        private User user;

        public ResultsForm(int score, User u)
        {
            InitializeComponent();
            this.score = score;
            user = u;
        }


        private void ConfirmForm_Load(object sender, EventArgs e)
        {
            scoreLabel.Text = score.ToString();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            CsvHelper.saveScore(user, score);
            CsvHelper.sortScores();
            CsvHelper.saveToTxt();

            CsvHelper.changeIsFinished(user);

            Application.Exit();
        }
    }
}
