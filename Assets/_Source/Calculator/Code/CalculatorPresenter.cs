using _Source.Calculator.Code.Data;
using _Source.Calculator.Code.Views.Interfaces;

namespace _Source.Calculator.Code
{
    public class CalculatorPresenter
    {
        private readonly ICalculatorView _view;
        private readonly CalculatorService _service;
        private CalculationState _state;

        public CalculatorPresenter(CalculatorService service,ICalculatorView view)
        {
            _view = view;
            _service = service;
        }

        public void Init()
        {
            _view.ResultButtonView.OnButtonClicked += HandleResultButtonView;
            _view.InputTextView.OnInputChanged += HandleInputTextViewChanged;
            _view.ErrorMessageView.CloseScreenButton.OnButtonClicked += CloseErrorMessage;
            
            _state = _service.LoadState();
            
            _view.Init();
            
            LoadData();
            UpdateSizes();
            CloseErrorMessage();
        }

        private void LoadData()
        {
            _view.InputTextView.SetInputText(_state.CurrentInput);

            foreach (var expression in _state.History)
            {
                _view.HistoryView.UpdateHistory(expression,_service.GetHistoryTextPrefab());
            }
        }

        private void CloseErrorMessage()
        {
            _view.ErrorMessageView.Hide();
        }

        private void HandleInputTextViewChanged(string input)
        {
            _state.CurrentInput = input;
            _service.SaveState(_state);
        }

        private void HandleResultButtonView()
        {
            var result = _service.TryCalculate(_state.CurrentInput, out var outputText);
            _state.CurrentInput = string.Empty;

            if (!result)
                _view.ErrorMessageView.Show();
            
            _state.History.Add(outputText);
            
            UpdateView();
            UpdateSizes();
            _service.SaveState(_state);
        }

        private void UpdateView()
        {
            _view.InputTextView.SetInputText(_state.CurrentInput);
            _view.HistoryView.UpdateHistory(_state.History[^1],_service.GetHistoryTextPrefab());
        }
        
        private void UpdateSizes()
        {
            _view.SetHeightSize(_state.History.Count > 2 ? _service.GetExpandedHeight : _service.GetBaseHeight);
        }
    }
}