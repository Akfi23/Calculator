namespace _Source.Calculator.Code.Operations.Interfaces
{
    public interface IOperation
    {
        char Operator { get; }
        long Execute(long a, long b);
        bool Validate(long a, long b);
    }
}