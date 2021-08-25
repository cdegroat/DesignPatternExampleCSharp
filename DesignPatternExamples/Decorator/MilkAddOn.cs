using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Decorator
{
    public class MilkAddOn : BeverageAddOn
    {
        public MilkAddOn(Beverage beverage) : base("Milk", beverage)
        {

        }
        public override double Cost()
        {
            return base.beverage.Cost() + 1;
        }

        public override string GetDescription()
        {
            return base.beverage.GetDescription() + " with milk";
        }
    }
}
