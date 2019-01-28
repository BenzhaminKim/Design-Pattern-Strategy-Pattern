using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class NewQuack : IQuackBehavior
    {
        public void Speak()
        {
            Console.WriteLine("New Speak Behavior!!!");
        }
    }
}
