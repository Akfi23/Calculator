using System;
using CalculatorModule.Bootstrap;
using TMPro;
using UnityEngine;

namespace _Source.Code
{
    public class InputTextView : MonoBehaviour, IInputTextView
    {
        [SerializeField] private TMP_InputField inputField;
        public event Action<string> OnInputChanged;
        
        public RectTransform Rect => inputField.image.rectTransform;
        
        public void Init()
        {
            inputField.onValueChanged.AddListener(value => OnInputChanged?.Invoke(value));
        }
        
        public void SetInputText(string text)
        {
            inputField.text = text;
        }
    }
}