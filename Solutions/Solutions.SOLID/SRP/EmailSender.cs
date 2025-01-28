using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.SOLID.SRP
{
    internal class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Email sent to {email} with message: {message}");
        }   
    }
}
