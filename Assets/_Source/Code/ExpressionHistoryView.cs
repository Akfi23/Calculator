using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Source.Code
{
    public class ExpressionHistoryView:MonoBehaviour,IExpressionHistoryView
    {
        [SerializeField] private ScrollRect historyScroll;
        [SerializeField] private RectTransform rectRoot;

        public RectTransform Rect => rectRoot;

        public void Init()
        {
            historyScroll.content.sizeDelta = new Vector2(historyScroll.content.sizeDelta.x, 0);
        }

        public void UpdateHistory(string expressionText,TMP_Text textPrefab)
        {
            var text = Instantiate(textPrefab, historyScroll.content);
            text.SetText(expressionText);
            
            historyScroll.content.sizeDelta = new Vector2(historyScroll.content.sizeDelta.x, historyScroll.content.sizeDelta.y + text.rectTransform.sizeDelta.y);
        }
    }
}