using UnityEngine;
using UnityEngine.Events;

namespace _Project.Scripts.ScriptableEvents
{
    public abstract class BaseTypedEventListener<T1, T2, T3> : MonoBehaviour, ITypedEventListener<T1>
    where T2 : BaseTypedEvent<T1>
    where T3 : UnityEvent<T1>
    {
       [SerializeField] private T2 _event;
        [SerializeField] private T3 _response;
        public void OnEventCalled(T1 value)
        {
            _response?.Invoke(value);
        }

        private void OnEnable()
        {
            if (_event == null) return;
            _event.AddListener(this);
        }

        private void OnDisable()
        {
            if(_event != null)
                _event.RemoveListener(this);
        }
    }

    public abstract class BaseUntypedEventListener<T1, T2> : MonoBehaviour, IUntypedEventListener
    where T1 : BaseUntypedEvent
    where T2 : UnityEvent
    {
        [SerializeField] private T1 _event;
        [SerializeField] private T2 _response;
        public void OnEventCalled()
        {
            _response?.Invoke();
        }

        private void OnEnable()
        {
            if (_event == null) return;
            _event.AddListener(this);
        }

        private void OnDisable()
        {
            if(_event != null)
                _event.RemoveListener(this);
        }
    }
}