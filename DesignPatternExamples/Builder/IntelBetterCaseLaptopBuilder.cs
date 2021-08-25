using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Builder
{
    public class IntelBetterCaseLaptopBuilder : IntelLaptopBuilder
    {
        public override void SetCaseModel()
        {
            laptop.caseModel = "Intel Best Case Case";
        }
    }
}
