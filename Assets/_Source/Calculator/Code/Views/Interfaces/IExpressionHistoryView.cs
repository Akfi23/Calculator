using TMPro;

namespace _Source.Calculator.Code.Views.Interfaces
{
    public interface IExpressionHistoryView:IView
    {
        void UpdateHistory(string expressionText,TMP_Text prefab);
    }
}