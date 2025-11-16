using CalculatorModule.Bootstrap;

namespace _Source.Code
{
    public interface IErrorMessageView:IView
    {
        IButtonView CloseScreenButton { get; }

        void Show();
        void Hide();
    }
}