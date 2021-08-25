using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Builder
{
    public class IntelLaptopBuilder : LaptopBuilder
    {
        public override void SetCaseModel()
        {
            laptop.caseModel = "Intel ZZ Case";
        }

        public override void SetPowerSupplyModel()
        {
            laptop.powerSupplyModel = "Intel ZZZ Power Supply";
        }

        public override void SetProcessorModel()
        {
            laptop.processorModel = "Intel ZZZZ Processor Model";
        }
    }
}
