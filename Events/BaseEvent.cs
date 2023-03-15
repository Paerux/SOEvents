using System;
using System.Collections.Generic;
using UnityEngine;


namespace _Project.Scripts.ScriptableEvents
{
    public abstract class BaseTypedEvent<T> : ScriptableObject, ITypedEvent<T>
    {
        private readonly List<ITypedEventListener<T>> _typedListeners = new List<ITypedEventListener<T>>();

        public void Raise(T value)
        {
            for (var i = _typedListeners.Count - 1; i >= 0; i--)
            {
                _typedListeners[i].OnEventCalled(value);
            }
        }

        public void AddListener(ITypedEventListener<T> listener)
        {
            if (!_typedListeners.Contains(listener))
            {
                _typedListeners.Add(listener);
            }
        }

        public void RemoveListener(ITypedEventListener<T> listener)
        {
            if (_typedListeners.Contains(listener))
            {
                _typedListeners.Remove(listener);
            }
        }

        public void RemoveAll()
        {
            _typedListeners.RemoveRange(0,_typedListeners.Count);
        }
    }

    public abstract class BaseUntypedEvent : ScriptableObject, IUntypedEvent
    {
        private readonly List<IUntypedEventListener> _untypedListeners = new List<IUntypedEventListener>();

        public void Raise()
        {
            for (var i = _untypedListeners.Count - 1; i >= 0; i--)
            {
                _untypedListeners[i].OnEventCalled();
            }
        }

        public void AddListener(IUntypedEventListener listener)
        {
            if (!_untypedListeners.Contains(listener))
            {
                _untypedListeners.Add(listener);
            }
        }

        public void RemoveListener(IUntypedEventListener listener)
        {
            if (_untypedListeners.Contains(listener))
            {
                _untypedListeners.Remove(listener);
            }
        }

        public void RemoveAll()
        {
            _untypedListeners.RemoveRange(0,_untypedListeners.Count);
        }
    }
}