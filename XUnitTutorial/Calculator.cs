using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTutorial
{
    public class Calculator
    {
        //private CalculatorState _state = CalculatorState.Cleared;
        public decimal Value { get; private set; } = 0;
        public decimal Add(decimal value)
        {
            return Value += value;
        }
    }
}
