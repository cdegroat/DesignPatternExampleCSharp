using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.State
{
    public class StartingState : IATMState
    {
        public bool EjectDebitCard()
        {
            Console.WriteLine("Not possible, No Card in slot");
            return false;
        }

        public bool EnterPin()
        {
            Console.WriteLine("Not possible, No Card in slot");
            return false;
        }

        public bool InsertDebitCard()
        {
            Console.WriteLine("Card inserted into slot");
            return true;
        }

        public bool WithdrawMoney()
        {
            Console.WriteLine("Not possible, No Card in slot");
            return false;
        }
    }
}
