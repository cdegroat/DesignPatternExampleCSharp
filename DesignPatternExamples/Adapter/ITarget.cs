using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Adapter
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }
}
