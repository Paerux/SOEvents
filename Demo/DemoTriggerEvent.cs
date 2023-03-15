using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace _Project.Scripts.ScriptableEvents.Demo
{
    public class DemoTriggerEvent : MonoBehaviour
    {
        [SerializeField] private SimpleEvent _simpleEvent;
        [SerializeField] private BoolEvent _boolEvent;
        [SerializeField] private bool _eventValue;
        [SerializeField] private KeyCode _triggerKey;
        private void Update()
        {
            if (Input.GetKeyDown(_triggerKey))
            {
                _simpleEvent.Raise();
                _boolEvent.Raise(_eventValue);
            }
        }

        public void CatchRaisedEvent()
        {
            print("Event Raised!");
        }

        public void CatchBoolEvent(bool value)
        {
            print("Event Raised! Value: " + value );
        }
    }
}