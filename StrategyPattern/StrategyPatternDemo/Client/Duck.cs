using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck()
        {

        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Speak();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float");
        }

        //it's to dinamically change the fly behavior
        public void SetFlyBehavior(IFlyBehavior fb) 
        {
            flyBehavior = fb;
        }

        //it's to dinamically change the quack behavior
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
