using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Decorator
{
    public class SugarAddOn:BeverageAddOn
    {
        public SugarAddOn(Beverage beverage): base("Sugar",beverage)
        {
            
        }

        public override double Cost()
        {
            return base.beverage.Cost() + .50;
        }

        public override string GetDescription()
        {
            return base.beverage.GetDescription() + " with Sugar";
        }
    }
}
