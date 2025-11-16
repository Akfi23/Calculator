using System;
using _Source.Calculator.Code.Operations.Interfaces;

namespace _Source.Calculator.Code.Operations
{
    [Serializable]
    public class DivisionOperation : IOperation
    {
        public char Operator => '/';

        public long Execute(long a, long b) => a / b;

        public bool Validate(long a, long b) => b != 0 && a % b == 0;
    }
}