namespace _Source.Calculator.Code.Views.Interfaces
{
    public interface ICalculatorView : IView
    {
        IInputTextView InputTextView { get; }
        IButtonView ResultButtonView { get; }
        IExpressionHistoryView HistoryView { get; }
        IErrorMessageView ErrorMessageView { get; }
        
        void SetHeightSize(float height);
    }
}