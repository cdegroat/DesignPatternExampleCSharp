using DesignPatternExamples.StrategyDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples
{
    public class StrategyDesignPatternExample
    {

        public static void ShowMe()
        {
            var myConsoleWriter = new ConsoleWriterExecutor(new NormalConsoleWriter());
            myConsoleWriter.WriteLine("Dear John");

            myConsoleWriter.ChangeWriters(new GoofyConsoleWriter());
            myConsoleWriter.WriteLine("Dear John");
        }
    }
}
