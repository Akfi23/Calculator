using System;
using CalculatorModule.Bootstrap;

namespace _Source.Code
{
    public interface IButtonView : IView
    {
        public event Action OnButtonClicked;
    }
}