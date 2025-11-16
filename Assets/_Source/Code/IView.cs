using UnityEngine;

namespace CalculatorModule.Bootstrap
{
    public interface IView
    {
        public RectTransform Rect { get;}
        void Init();
    }
}