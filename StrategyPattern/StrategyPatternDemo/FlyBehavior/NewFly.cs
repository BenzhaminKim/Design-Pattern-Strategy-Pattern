using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class NewFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("New Fly Behavior!!!");
        }
    }
}
