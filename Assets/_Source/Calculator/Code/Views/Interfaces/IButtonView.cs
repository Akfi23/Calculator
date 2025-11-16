using System;

namespace _Source.Calculator.Code.Views.Interfaces
{
    public interface IButtonView : IView
    {
        public event Action OnButtonClicked;
    }
}