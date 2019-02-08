using System;
using System.Collections.Generic;
using System.Text;

namespace Sq.Calculator.Core
{
    public enum Operator
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    public class OperationHistoryItem
    {
        public decimal Value { get; set; }
        public Operator Operator { get; set; }

        public OperationHistoryItem(decimal value, Operator op)
        {
            Value = value;
            Operator = op;
        }
    }
}
