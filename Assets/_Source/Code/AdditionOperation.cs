using System;

namespace CalculatorModule.Domain.Operations
{
    [Serializable]
    public class AdditionOperation : IOperation
    {
        public char Operator => '+';

        public long Execute(long a, long b) => checked(a + b); 

        public bool Validate(long a, long b) => true;
    }
}