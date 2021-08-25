using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Command
{
    public class CommandDesignExample
    {
        public static void ShowMe()
        {
            Order order = new Order(new Chef(), "pasta");
            Waiter waiter = new Waiter(order);
            waiter.Execute();

            order = new Order(new Chef(), "cake");
            waiter = new Waiter(order);
            waiter.Execute();

        }
    }
}
