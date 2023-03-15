namespace _Project.Scripts.ScriptableEvents
{
    public interface ITypedEvent<T>
    {
        void Raise(T value);
        void AddListener(ITypedEventListener<T> listener);
        void RemoveListener(ITypedEventListener<T> listener);
        void RemoveAll();
    }

    public interface IUntypedEvent
    {
        void Raise();
        void AddListener(IUntypedEventListener listener);
        void RemoveListener(IUntypedEventListener listener);
        void RemoveAll();
    }
}