using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Command
{
    public class Waiter
    {
        private Order order;

        public Waiter(Order order)
        {
            this.order = order;
        }

        public void Execute()
        {
            this.order.Execute();
        }
    }
}
