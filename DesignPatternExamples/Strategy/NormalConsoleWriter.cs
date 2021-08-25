using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.StrategyDesignPattern
{
    public class NormalConsoleWriter : IConsoleWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
