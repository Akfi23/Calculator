using System.Collections.Generic;
using CalculatorModule.Bootstrap;
using TMPro;

namespace _Source.Code
{
    public interface IExpressionHistoryView:IView
    {
        void UpdateHistory(string expressionText,TMP_Text prefab);
    }
}