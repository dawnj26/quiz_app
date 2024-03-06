using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_app
{
    public class User
    {
        private string _name;
        private string _username;
        private string _gender;
        private string _password;
        private bool _isStudent;
        private int _isFinished;

        public string Name { get => _name; set => _name = value; }
        public string Username { get => _username; set => _username = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Password { get => _password; set => _password = value; }
        public bool IsStudent { get => _isStudent; set => _isStudent = value; }
        public int IsFinished { get => _isFinished; set => _isFinished = value; }

        public User(string name, string username, string gender, string password, bool isStudent, int isFinished)
        {
            _name = name;
            _username = username;
            _gender = gender;
            _password = password;
            _isStudent = isStudent;
            IsFinished = isFinished;
        }
    }
}
