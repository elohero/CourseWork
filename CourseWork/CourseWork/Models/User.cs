using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    public class User 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string name, string surname, string username)
        {
            Name = name;
            Surname = surname;
            Username = username;
        }
    }
}
