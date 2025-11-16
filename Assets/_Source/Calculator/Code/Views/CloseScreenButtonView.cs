using System;
using _Source.Calculator.Code.Views.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.Calculator.Code.Views
{
    public class CloseScreenButtonView : MonoBehaviour,IButtonView
    {
        [SerializeField] private Button button;

        public RectTransform Rect => button.image.rectTransform;

        public void Init()
        {
            button.onClick.AddListener(()=>OnButtonClicked?.Invoke());
        }

        public event Action OnButtonClicked;
    }
}