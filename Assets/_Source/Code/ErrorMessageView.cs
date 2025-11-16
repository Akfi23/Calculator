using UnityEngine;
using UnityEngine.Serialization;

namespace _Source.Code
{
    public class ErrorMessageView : MonoBehaviour,IErrorMessageView
    {
        [SerializeField] private CanvasGroup viewRoot;
        [SerializeField] private RectTransform rectRoot;
        [SerializeField] private CloseScreenButtonView closeScreenButton;
        public IButtonView CloseScreenButton => closeScreenButton;
        public RectTransform Rect => rectRoot;


        public void Show()
        {
            viewRoot.alpha = 1;
            viewRoot.interactable = true;
            viewRoot.blocksRaycasts = true;
        }

        public void Hide()
        {
            viewRoot.alpha = 0;
            viewRoot.interactable = false;
            viewRoot.blocksRaycasts = false;
        }
        
        public void Init()
        {
            closeScreenButton.Init();
        }
    }
}