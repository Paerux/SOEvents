namespace _Project.Scripts.ScriptableEvents
{
    public interface ITypedEventListener<T>
    {
        void OnEventCalled(T value);
    }

    public interface IUntypedEventListener
    {
        void OnEventCalled();
    }
}