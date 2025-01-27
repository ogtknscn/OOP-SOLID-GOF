using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.OOP.Abstraction
{
    internal class EmailService
    {
        public void SendEmail()
        {
            Connect("gmail");
            Authenticate();
            Console.WriteLine("Email sent successfully");
            Disconnect();
        }

        private void Connect(string url)
        {
            Console.WriteLine($"Connected to the email server at {url}");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticated to the email server");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnected from the email server");
        }
    }
}
