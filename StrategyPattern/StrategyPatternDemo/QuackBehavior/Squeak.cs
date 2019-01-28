using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class Squeak : IQuackBehavior
    {
        public void Speak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
