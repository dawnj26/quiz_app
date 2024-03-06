using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace quiz_app
{
    internal class CsvHelper
    {
        private static string _userPath = Environment.GetEnvironmentVariable("USERPROFILE");
        private static string _userCSVpath = _userPath + @"\Documents\quiz_app\users.csv";
        private static string _questionCSVpath = _userPath + @"\Documents\quiz_app\questions.csv";
        private static string _scoresCSVpath = _userPath + @"\Documents\quiz_app\scores.csv";
        private static string _leaderboardCsvPath = _userPath + @"\Documents\quiz_app\leaderboard.csv";
        private static string _leaderboardPath = _userPath + @"\Documents\quiz_app\leaderboard.txt";

        public static void createDirectory()
        {
            if (!Directory.Exists(_userPath + @"\Documents\quiz_app"))
            {
                Directory.CreateDirectory(_userPath + @"\Documents\quiz_app");
            }
        }

        public static void addUser(User p)
        {
            string status = p.IsStudent ? "student" : "teacher";
            string data = $"{p.Name},{p.Username},{p.Gender},{p.Password},{status},{p.IsFinished}";

            using (StreamWriter w = new StreamWriter(_userCSVpath, true))
            {
                w.WriteLine(data);
            }

        }

        public static bool isRegistered(string username)
        {
            if (!File.Exists(_userCSVpath))
            {
                return false;
            }

            using (StreamReader r = new StreamReader(_userCSVpath))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data[1] == username)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static User verifyUser(string username, string password)
        {
            if (!File.Exists(_userCSVpath))
            {
                return null;
            }

            using (StreamReader r = new StreamReader(_userCSVpath))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data[1] == username && data[3] == password)
                    {
                        string name = data[0];
                        string gender = data[2];
                        bool isStudent = data[4] == "student";
                        int isFinished = int.Parse(data[5]);
                        return new User(name, username, gender, password, isStudent, isFinished);
                    }
                }
            }

            return null;
        }


        public static void addQuestion(Question q)
        {

            string data = $"{q.QuestionText},{q.Option1},{q.Option2},{q.Option3},{q.Option4},{q.Answer}";

            using (StreamWriter w = new StreamWriter(_questionCSVpath, true))
            {
                w.WriteLine(data);
            }
        }

        public static void deleteQuestion(int index)
        {
            string[] lines = File.ReadAllLines(_questionCSVpath);
            using (StreamWriter w = new StreamWriter(_questionCSVpath))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i == index)
                    {
                        continue;
                    }
                    w.WriteLine(lines[i]);
                }
            }
        }

        public static int getQuestionCount()
        {
            if (!File.Exists(_questionCSVpath))
            {
                return 0;
            }

            int count = 0;
            using (StreamReader r = new StreamReader(_questionCSVpath))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    count++;
                }
            }

            return count;
        }

        public static List<Question> getQuestions()
        {
            List<Question> questions = new List<Question>();

            if (!File.Exists(_questionCSVpath))
            {
                return questions;
            }

            using (StreamReader r = new StreamReader(_questionCSVpath))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    questions.Add(new Question(data[0], data[5], data[1], data[2], data[3], data[4]));
                }
            }

            return questions;
        }

        public static void saveScore(User u, int score)
        {
            string data = $"{u.Name},{u.Username},{score}";

            using (StreamWriter w = new StreamWriter(_scoresCSVpath, true))
            {
                w.WriteLine(data);
            }
        }

        public static void sortScores()
        {
            string[] lines = File.ReadAllLines(_scoresCSVpath);
            var sortedLines = lines
                .Select(line => new {
                            Score = int.Parse(line.Split(',')[2]), // Assuming score is at index 1
                            Line = line
                        })
                .OrderByDescending(x => x.Score)
                .Select(x => x.Line);

            using (StreamWriter w = new StreamWriter(_leaderboardCsvPath))
            {
                foreach (string line in sortedLines)
                {
                    w.WriteLine(line);
                }
            }
        }

        public static void saveToTxt()
        {
            string[] lines = File.ReadAllLines(_leaderboardCsvPath);

            using (StreamWriter w = new StreamWriter(_leaderboardPath))
            {
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    w.WriteLine($"Name: {data[0]} - Score: {data[2]}");
                }
            }
        }

        public static string[] getLeaderboard()
        {
            if (!File.Exists(_leaderboardCsvPath))
            {
                return new string[0];
            }

            return File.ReadAllLines(_leaderboardCsvPath);
        }

        public static void changeIsFinished(User u)
        {
            string[] lines = File.ReadAllLines(_userCSVpath);
            using (StreamWriter w = new StreamWriter(_userCSVpath))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    if (data[1] == u.Username)
                    {
                        data[5] = "1";
                        lines[i] = string.Join(",", data);
                    }
                    w.WriteLine(lines[i]);
                }
            }
        }
    }


}
