using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Decorator
{
    public abstract class BeverageAddOn : Beverage
    {
        protected Beverage beverage;
        public BeverageAddOn(string description, Beverage beverage) : base(description)
        {
            this.beverage = beverage;
        }

        public abstract String GetDescription();
    }
}
