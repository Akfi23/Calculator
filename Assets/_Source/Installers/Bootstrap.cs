using _Source.Calculator.Code;
using _Source.Calculator.Code.DataBases;
using _Source.Calculator.Code.Views;
using _Source.Saves;
using UnityEngine;

namespace _Source.Installers
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