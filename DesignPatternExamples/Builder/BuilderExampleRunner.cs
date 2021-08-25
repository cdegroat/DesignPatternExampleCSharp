using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Builder
{
    public class BuilderExampleRunner
    {
        public static void ShowMe()
        {
            LaptopCreationEngine laptopCreationEngine = new LaptopCreationEngine();

            var intelLaptop = laptopCreationEngine.CreateLaptop(new IntelLaptopBuilder());
            intelLaptop.DisplaySpecs();

            var betterIntelLaptop = laptopCreationEngine.CreateLaptop(new IntelBetterCaseLaptopBuilder());
            betterIntelLaptop.DisplaySpecs();
        }
    }
}
