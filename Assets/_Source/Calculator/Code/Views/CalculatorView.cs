using _Source.Calculator.Code.Views.Interfaces;
using UnityEngine;

namespace _Source.Calculator.Code.Views
{
    public class CalculatorView : MonoBehaviour, ICalculatorView
    {
        [SerializeField] private RectTransform rectRoot;
        [SerializeField] private InputTextView input;
        [SerializeField] private ResultButtonView resultResultButton;
        [SerializeField] private ExpressionHistoryView history;
        [SerializeField] private ErrorMessageView errorMessage;

        public IInputTextView InputTextView => input;
        public IButtonView ResultButtonView => resultResultButton;
        public IExpressionHistoryView HistoryView => history;
        public IErrorMessageView ErrorMessageView => errorMessage;
        public RectTransform Rect => rectRoot;
        
        public void Init()
        {
            input.Init();
            resultResultButton.Init();
            history.Init();
            errorMessage.Init();
        }
        
        public void SetHeightSize(float height)
        {
            if (Rect != null)
            {
                Rect.sizeDelta = new Vector2(Rect.sizeDelta.x, height);
            }

            if (ErrorMessageView.Rect != null)
            {
                ErrorMessageView.Rect.sizeDelta = new Vector2(Rect.sizeDelta.x, height);
            }
        }
    }
}
