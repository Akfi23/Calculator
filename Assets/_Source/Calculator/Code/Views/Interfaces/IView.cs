using UnityEngine;

namespace _Source.Calculator.Code.Views.Interfaces
{
    public interface IView
    {
        public RectTransform Rect { get;}
        void Init();
    }
}