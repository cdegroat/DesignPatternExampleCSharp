using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.State
{
    public class DebitCardInsertedState : IATMState
    {
        public bool EjectDebitCard()
        {
            Console.WriteLine("Card Ejected");
            return true;
        }

        public bool EnterPin()
        {
            Console.WriteLine("Pin entered");
            return true;
        }

        public bool InsertDebitCard()
        {
            Console.WriteLine("Not possible, card already entered");
            return false;
        }

        public bool WithdrawMoney()
        {
            Console.WriteLine("Not possible, no pin entered");
            return false;
        }
    }
}
