using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.State
{
    public interface IATMState
    {
        bool InsertDebitCard();
        bool EjectDebitCard();
        bool EnterPin();
        bool WithdrawMoney();
    }
}
