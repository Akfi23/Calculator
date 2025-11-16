namespace CalculatorModule.Domain.Operations
{
    public interface IOperation
    {
        char Operator { get; }
        long Execute(long a, long b);
        bool Validate(long a, long b);
    }
}