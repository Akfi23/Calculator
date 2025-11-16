namespace _Source.Calculator.Code.Views.Interfaces
{
    public interface IErrorMessageView:IView
    {
        IButtonView CloseScreenButton { get; }

        void Show();
        void Hide();
    }
}