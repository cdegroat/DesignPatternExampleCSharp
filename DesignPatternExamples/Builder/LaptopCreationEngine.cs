using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Builder
{
    public class LaptopCreationEngine
    {
        public Laptop CreateLaptop(LaptopBuilder laptopBuilder)
        {
            laptopBuilder.CreateNewLaptop();
            laptopBuilder.SetCaseModel();
            laptopBuilder.SetPowerSupplyModel();
            laptopBuilder.SetProcessorModel();
            return laptopBuilder.GetLaptop();

        }
    }
}
