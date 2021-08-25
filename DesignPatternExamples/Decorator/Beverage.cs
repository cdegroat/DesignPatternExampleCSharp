using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Decorator
{
    public abstract class Beverage
    {
        private String description;

        public Beverage(String description)
        {
            this.description = description;
        }

        public String GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
