using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.State
{
    public class ATMMachine : IATMState
    {
        public IATMState atmMachineState { get; set; }

        public ATMMachine()
        {
            atmMachineState = new StartingState();
        }
        public bool EjectDebitCard()
        {
            var val = atmMachineState.EjectDebitCard();
            if(val)
            {
                atmMachineState = new StartingState();
            }
            return val;
        }

        public bool EnterPin()
        {
            var val = atmMachineState.EnterPin();
            if (val)
            {
                //something
            }
            return val;
        }

        public bool InsertDebitCard()
        {
            var val = atmMachineState.InsertDebitCard();
            if (val)
            {
                atmMachineState = new DebitCardInsertedState();
            }
            return val;
        }

        public bool WithdrawMoney()
        {
            var val = atmMachineState.WithdrawMoney();
            if (val)
            {
                atmMachineState = new StartingState();
            }
            return val;
        }
    }
}
