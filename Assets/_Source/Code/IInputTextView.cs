using System;

namespace CalculatorModule.Bootstrap
{
    public interface IInputTextView : IView
    {
        event Action<string> OnInputChanged;
        
        void SetInputText(string text);

    }
}