using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.SOLID.DIP
{
    internal class Car
    {
        private IEngine _engine;
        public Car(IEngine engine)
        {
            this._engine = engine;
        }
        public void Start()
        {
            _engine.Start();
        }
        public void Stop()
        {
            _engine.Stop();
        }
    }
}
