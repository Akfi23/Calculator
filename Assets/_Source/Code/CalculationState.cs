using System.Collections.Generic;

namespace CalculatorModule.Domain.Entities
{
    public class CalculationState
    {
        public string CurrentInput { get; set; } = string.Empty;
        public List<string> History { get; set; } = new List<string>();
    }
}