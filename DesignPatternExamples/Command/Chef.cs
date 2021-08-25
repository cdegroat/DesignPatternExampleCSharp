using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Command
{
    public class Chef
    {
        public void CookPasta()
        {
            Console.WriteLine("Chef is cooking pasta");
        }

        public void BakeCake()
        {
            Console.WriteLine("Chef is baking cake");
        }
    }
}
