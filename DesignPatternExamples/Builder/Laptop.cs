using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Builder
{
    public class Laptop
    {
        public String processorModel;
        public String caseModel;
        public String powerSupplyModel;

        public void DisplaySpecs()
        {
            Console.WriteLine("processor: " + processorModel);
            Console.WriteLine("caseModel: " + caseModel);
            Console.WriteLine("powerSupplyModel: " + powerSupplyModel);
        }
    }
}
