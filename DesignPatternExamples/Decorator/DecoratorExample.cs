using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Decorator
{
    public class DecoratorExample
    {
        public static void ShowMe()
        {
            HouseBlend houseBlend = new HouseBlend();
            PrintBeverageInfo(houseBlend);
            var houseBlendWithMilk = new MilkAddOn(houseBlend);
            PrintBeverageInfo(houseBlendWithMilk);
            var houseBlendWithMilkAndSugar = new SugarAddOn(houseBlendWithMilk);
            PrintBeverageInfo(houseBlendWithMilkAndSugar);
        }

        private static void PrintBeverageInfo(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " " + beverage.Cost());
        }
    }
}
