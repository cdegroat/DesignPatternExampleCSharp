using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Command
{
    public class Order : ICommand
    {
        private Chef Chef;
        private String Food;

        public Order(Chef chef, String food)
        {
            this.Chef = chef;
            this.Food = food;
        }

        public void Execute()
        {
            switch (Food.ToLower())
            {
                case "pasta":
                    this.Chef.CookPasta();
                    break;
                case "cake":
                    this.Chef.BakeCake();
                    break;
            }
        }
    }
}
