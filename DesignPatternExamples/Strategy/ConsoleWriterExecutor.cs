using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.StrategyDesignPattern
{
    public class ConsoleWriterExecutor
    {
        IConsoleWriter consoleWriter;

        public ConsoleWriterExecutor(IConsoleWriter consoleWriter)
        {
            this.consoleWriter = consoleWriter;
        }

        public void ChangeWriters(IConsoleWriter consoleWriter)
        {
            this.consoleWriter = consoleWriter;
        }

        public void WriteLine(String line)
        {
            consoleWriter.WriteLine(line);
        }
    }
}
