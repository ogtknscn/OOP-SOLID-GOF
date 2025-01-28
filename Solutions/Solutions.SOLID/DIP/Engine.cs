using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.SOLID.DIP
{
    internal class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine started");
        }
        public void Stop()
        {
            Console.WriteLine("Engine stopped");
        }
    }
}
