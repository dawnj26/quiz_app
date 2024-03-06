using System;
using System.Linq;

namespace quiz_app
{
    public class Question
    {
        private string _question;
        private string _answer;
        private string _option1;
        private string _option2;
        private string _option3;
        private string _option4;
        private int _choice;

        public string QuestionText { get => _question; set => _question = value; }
        public string Answer { get => _answer; set => _answer = value; }
        public string Option1 { get => _option1; set => _option1 = value; }
        public string Option2 { get => _option2; set => _option2 = value; }
        public string Option3 { get => _option3; set => _option3 = value; }
        public string Option4 { get => _option4; set => _option4 = value; }
        public int Choice { get => _choice; set => _choice = value; }

        public Question(string question, string answer, string option1, string option2, string option3, string option4)
        {
            _question = question;
            _answer = answer;
            _option1 = option1;
            _option2 = option2;
            _option3 = option3;
            _option4 = option4;
            _choice = -1;
        }

        public bool hasAnswer()
        {
            return Option1.ToLower() == _answer.ToLower() || Option2.ToLower() == _answer.ToLower() || Option3.ToLower() == _answer.ToLower() || Option4.ToLower() == _answer.ToLower();
        }

        public int checkAnswer()
        {
            Console.WriteLine(Option1.ToLower() + " " + _choice);

            if (_choice == -1)
            {
                return 0;
            }

            switch(_choice)
            {
                case 1:
                    return Option1.ToLower() == _answer.ToLower() ? 1 : 0;
                case 2:
                    return Option2.ToLower() == _answer.ToLower() ? 1 : 0;
                case 3:
                    return Option3.ToLower() == _answer.ToLower() ? 1 : 0;
                case 4:
                    return Option4.ToLower() == _answer.ToLower() ? 1 : 0;
                default:
                    return -1;
            }
        }
    }
}