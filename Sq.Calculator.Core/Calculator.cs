using System;
using System.Collections.Generic;

namespace Sq.Calculator.Core
{
    public class Calculator
    {
        public List<OperationHistoryItem> OperationHistory { get; set; } = new List<OperationHistoryItem>();
        public decimal State { get; set; }

        public decimal Add(decimal x)
        {
            State += x;
            OperationHistory.Add(new OperationHistoryItem(x, Operator.Add));
            return State;
        }
    }
}
