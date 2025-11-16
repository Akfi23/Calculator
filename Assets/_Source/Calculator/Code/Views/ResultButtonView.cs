using System;
using _Source.Calculator.Code.Views.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.Calculator.Code.Views
{
    public class ResultButtonView:MonoBehaviour,IButtonView
    {
        [SerializeField] private Button button;
        public event Action OnButtonClicked;

        public RectTransform Rect => button.image.rectTransform;
        
        // public void Awake()
        // {
        //     Init();
        // }
        
        public void Init()
        {
            button.onClick.AddListener(()=>OnButtonClicked?.Invoke());
        }
    }
}