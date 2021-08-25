using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(): base("Dark Roast")
        {

        }
        public override double Cost()
        {
            return 300;
        }
    }
}
