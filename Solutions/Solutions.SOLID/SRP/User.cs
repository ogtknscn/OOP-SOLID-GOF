using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.SOLID.SRP
{
    internal class User
    {
        private string _name { get; set; }
        private string _email { get; set; }

        public User(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetEmail()
        {
            return _email;
        }

    }
}
