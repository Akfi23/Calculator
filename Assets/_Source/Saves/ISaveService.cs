namespace _Source.Saves
{
    public interface ISaveService
    {
        T Load<T>(string key, T value);
        void Save<T>(string key, T value);
    }
}