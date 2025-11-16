using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.Code
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