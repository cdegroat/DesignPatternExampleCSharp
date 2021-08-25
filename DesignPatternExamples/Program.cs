using DesignPatternExamples.Builder;
using DesignPatternExamples.Command;
using DesignPatternExamples.Decorator;
using DesignPatternExamples.State;
using System;
using System.Threading;

namespace DesignPatternExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Strategy Design Pattern");
            StrategyDesignPatternExample.ShowMe();


            Console.WriteLine("Builder Examples");
            BuilderExampleRunner.ShowMe();

            Console.WriteLine("Decorator Example");
            DecoratorExample.ShowMe();

            Console.WriteLine("Command Design Example");
            CommandDesignExample.ShowMe();

            Console.WriteLine("State Design Example");
            StateExample.ShowMe();

            // observer example not finished, got bored.

            Thread.Sleep(50000);

        }
    }
}
