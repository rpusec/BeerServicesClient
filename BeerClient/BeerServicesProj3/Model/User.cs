using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerServicesProj3.Model
{
    /// <summary>
    /// An individual user who can create an account
    /// and use the application. 
    /// </summary>
    public class User
    {
        private int _id;
        private string _Username;
        private string _Password;
        private int _Age;
        private string _AccessLevel;

        public User(string Username, string Password, int Age, string AccessLevel)
        {
            _Username = Username;
            _Password = Password;
            _Age = Age;
            _AccessLevel = AccessLevel;
        }

        public User(int id, string Username, string Password, int Age, string AccessLevel) 
        {
            _id = id;
            _Username = Username;
            _Password = Password;
            _Age = Age;
            _AccessLevel = AccessLevel;
        }

        public int Id
        {
            get { return _id; }
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        public string AccessLevel
        {
            get { return _AccessLevel; }
            set { _AccessLevel = value; }
        }
    }
}
