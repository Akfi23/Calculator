using CalculatorModule.Domain.Entities;

namespace CalculatorModule.Domain.Repositories
{
    public interface ISaveService
    {
        T Load<T>(string key, T value);
        void Save<T>(string key, T value);
    }
}