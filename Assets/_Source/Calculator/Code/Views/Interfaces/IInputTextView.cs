using System;

namespace _Source.Calculator.Code.Views.Interfaces
{
    public interface IInputTextView : IView
    {
        event Action<string> OnInputChanged;
        
        void SetInputText(string text);

    }
}