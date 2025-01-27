using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.OOP.Coupling
{
    internal class SmsSender : INotification
    {
        void INotification.SendNotification(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}
