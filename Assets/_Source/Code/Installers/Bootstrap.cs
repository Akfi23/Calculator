using _Source.Code;
using UnityEngine;
using CalculatorModule.Application.Presenters;
using CalculatorModule.Domain.Services;
using CalculatorModule.Infrastructure.Repositories;
using CalculatorModule.Presentation.Config;
using CalculatorModule.Presentation.Views;

namespace CalculatorModule.Bootstrap
{
    public class Bootstrapper : MonoBehaviour
    {
        [Header("Config")]
        [SerializeField]
        private CalculatorConfig config;
        
        [Space(10)] [Header("Views")] [SerializeField]
        private CalculatorView calculatorView;

       
        private void Awake()
        {
            var saveService = new SaveService();
            var service = new CalculatorService(saveService,config);
            
            var presenter = new CalculatorPresenter(service, calculatorView);

            presenter.Init();
        }
    }
}