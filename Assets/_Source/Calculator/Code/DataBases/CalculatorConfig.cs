using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace _Source.Calculator.Code.DataBases
{
    [CreateAssetMenu(fileName = "CalculatorConfig", menuName = "Calculator/Config")]
    public class CalculatorConfig : ScriptableObject
    {
        [Header("View")]
        public string ErrorSuffix;
        public TMP_Text HistoryTextPrefab;
        public float BaseHeight;
        public float ExpandendHeight;
        
        [Header("Operations")]
        public List<OperationType> supportedOperations = new List<OperationType> { OperationType.Add };
    }

    public enum OperationType
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}