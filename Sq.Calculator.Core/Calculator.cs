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

        public decimal Subtract(decimal x)
        {
            State -= x;
            OperationHistory.Add(new OperationHistoryItem(x, Operator.Subtract));
            return State;
        }

        public decimal Multiply(decimal x)
        {
            State = State * x;
            OperationHistory.Add(new OperationHistoryItem(x, Operator.Multiply));
            return State;
        }

        public decimal Divide(decimal x)
        {
            if (x == 0) throw new ArgumentException("Can´t divide with zero");
            State = State / x;
            OperationHistory.Add(new OperationHistoryItem(x, Operator.Divide));
            return State;
        }
    }
}
