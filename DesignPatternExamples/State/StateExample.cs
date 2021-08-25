using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.State
{
    public class StateExample
    {
        public static void ShowMe()
        {
            ATMMachine machine = new ATMMachine();
            machine.InsertDebitCard();
            machine.WithdrawMoney();
            machine.EjectDebitCard();
            machine.EnterPin();
            machine.InsertDebitCard();
            machine.EnterPin();
        }
    }
}
