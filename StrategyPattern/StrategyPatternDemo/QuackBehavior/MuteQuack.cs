using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class MuteQuack : IQuackBehavior
    {
        public void Speak()
        {
            Console.WriteLine("---MUTE---");
        }
    }
}
