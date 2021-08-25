using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.StrategyDesignPattern
{
    public class GoofyConsoleWriter : IConsoleWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine("I'm so goofy: " + line);
        }
    }
}
