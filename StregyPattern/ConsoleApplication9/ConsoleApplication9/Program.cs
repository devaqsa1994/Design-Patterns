using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyBehavior flyBehavior = new FlyWithNoWings();

            MallardDuck m = new MallardDuck(flyBehavior);
            
            m.PerformFly();
            m.flybehavior = new FlyWithWings();
            m.PerformFly();
        }
    }
   public abstract class Duck
    {
        public IFlyBehavior flybehavior;
        public abstract void PerformFly();
    }
    public class MallardDuck : Duck
    {
        public MallardDuck()
        { 
        }
        public MallardDuck(IFlyBehavior _flyBahavior)
        {
            flybehavior = _flyBahavior;
        }
        public override void PerformFly()
        {
            flybehavior.Fly();
        }
    }

   public interface IFlyBehavior
    {
        void Fly();
    }
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with Wings");
        }
    }
    public class FlyWithNoWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with No Wings");
        }
    }

}
