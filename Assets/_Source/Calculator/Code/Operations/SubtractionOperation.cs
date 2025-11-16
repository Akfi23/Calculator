using System;
using _Source.Calculator.Code.Operations.Interfaces;

namespace _Source.Calculator.Code.Operations
{
    [Serializable]
    public class SubtractionOperation : IOperation
    {
        public char Operator => '-';

        public long Execute(long a, long b) => checked(a - b);

        public bool Validate(long a, long b) => true;
    }
}