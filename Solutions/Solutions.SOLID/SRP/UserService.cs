using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.SOLID.SRP
{
    internal class UserService
    {
        public void Register(User user)
        {
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.GetEmail(), "Welcome to our platform!");
        }

    }
}
