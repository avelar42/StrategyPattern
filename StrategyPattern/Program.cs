using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new Context();

            Console.WriteLine("Hello World!");
            context.setStategy(new StategyConcrete1());
            context.DoSomeStategy();

            Console.WriteLine();

            context.setStategy(new StategyConcrete2());
            context.DoSomeStategy();
        }


       
    }
}
