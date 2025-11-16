using System;
using _Source.Code;
using CalculatorModule.Bootstrap;
using UnityEngine;

namespace CalculatorModule.Domain
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