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
    public partial class LeaderForm : Form
    {
        public LeaderForm()
        {
            InitializeComponent();
        }

        public void updateLeaderboard()
        {
            var scores = CsvHelper.getLeaderboard();
            
            leaderView.Rows.Clear();

            foreach (var score in scores)
            {
                var data = score.Split(',');
                leaderView.Rows.Add(data[0], data[2]);
            }

            leaderView.ClearSelection();
        }

        private void LeaderForm_Load(object sender, EventArgs e)
        {
            updateLeaderboard();
        }
    }
}
