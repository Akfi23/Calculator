using System.Collections.Generic;

namespace _Source.Calculator.Code.Data
{
    public class CalculationState
    {
        public string CurrentInput { get; set; } = string.Empty;
        public List<string> History { get; set; } = new List<string>();
    }
}