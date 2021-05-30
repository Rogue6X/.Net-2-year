using System.Collections.Generic;

namespace lab4
{
    public class User
    {
        public string name { get; }
        public string surname { get; }

        public User(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public override string ToString()
        {
            return name+" "+surname;
        }
    }
}