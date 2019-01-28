using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck modelDuck = new ModelDuck();
            modelDuck.Display();
            modelDuck.PerformFly();
            modelDuck.PerformQuack();

            Duck redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.PerformFly();
            redheadDuck.PerformQuack();

            Duck robberDuck = new RubberDuck();
            robberDuck.Display();
            robberDuck.PerformFly();
            robberDuck.PerformQuack();

            robberDuck.SetFlyBehavior(new NewFly());
            robberDuck.PerformFly();

            redheadDuck.SetQuackBehavior(new NewQuack());
            redheadDuck.PerformQuack();
        }
    }
}
