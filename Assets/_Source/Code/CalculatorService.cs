using System;
using System.Collections.Generic;
using System.Linq;
using CalculatorModule.Domain.Entities;
using CalculatorModule.Domain.Operations;
using CalculatorModule.Domain.Repositories;
using CalculatorModule.Presentation.Config;
using TMPro;
using UnityEngine;

namespace CalculatorModule.Domain.Services
{
    public class CalculatorService
    {
        private readonly ISaveService _saveService;
        
        private CalculatorConfig _config;
        private HashSet<char> _opChars;
        private List<IOperation> _supportedOperations;

        private const string StateKey = "CalculatorState";

        public CalculatorService(ISaveService saveService,CalculatorConfig config)
        {
            _saveService = saveService;
            _config = config;
            
            PrepareOperations();
        }

        private void PrepareOperations()
        {
            var operations = new List<IOperation>();
            foreach (var opType in _config.supportedOperations)
            {
                operations.Add(opType switch
                {
                    OperationType.Add => new AdditionOperation(),
                    OperationType.Subtract => new SubtractionOperation(),
                    OperationType.Multiply => new MultiplicationOperation(),
                    OperationType.Divide => new DivisionOperation(),
                    _ => null
                });
            }

            _supportedOperations = operations;
            
            _opChars = new HashSet<char>(_supportedOperations.Select(o => o.Operator));
        }

        public bool TryCalculate(string expression, out string formattedResult)
        {
            formattedResult = $"{expression}={_config.ErrorSuffix}";

            if (string.IsNullOrEmpty(expression))
                return false;

            var span = expression.AsSpan();

            int opIndex = -1;
            IOperation op = null;

            for (int i = 0; i < span.Length; i++)
            {
                char c = span[i];

                if (!_opChars.Contains(c))
                    continue;

                if (opIndex != -1)
                    return false;

                for (int j = 0; j < _supportedOperations.Count; j++)
                {
                    if (_supportedOperations[j].Operator == c)
                    {
                        op = _supportedOperations[j];
                        opIndex = i;
                        break;
                    }
                }

                if (op != null) break;
            }

            if (op == null || opIndex <= 0 || opIndex == span.Length - 1)
                return false;

            var left = span[..opIndex];
            var right = span[(opIndex + 1)..];

            if (left.IsEmpty || right.IsEmpty || left[0] == '-' || right[0] == '-')
                return false;

            if (!long.TryParse(left, out long a) || !long.TryParse(right, out long b))
                return false;

            if (!op.Validate(a, b))
                return false;

            try
            {
                long result = op.Execute(a, b);
                formattedResult = $"{expression}={result}";
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        public TMP_Text GetHistoryTextPrefab() => _config.HistoryTextPrefab;
        public float GetBaseHeight => _config.BaseHeight;
        public float GetExpandedHeight => _config.ExpandendHeight;
        
        public void SaveState(CalculationState state)
        {
            _saveService.Save(StateKey,state);
        }

        public CalculationState LoadState()
        {
            return _saveService.Load(StateKey,new CalculationState());
        }
    }
}