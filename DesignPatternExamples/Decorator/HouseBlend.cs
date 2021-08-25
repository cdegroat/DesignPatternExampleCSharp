using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() : base("House Blend")
        {

        }
        public override double Cost()
        {
            return 250;
        }
    }
}
