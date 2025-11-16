using System;

namespace CalculatorModule.Domain.Operations
{
    [Serializable]
    public class DivisionOperation : IOperation
    {
        public char Operator => '/';

        public long Execute(long a, long b) => a / b;

        public bool Validate(long a, long b) => b != 0 && a % b == 0;
    }
}