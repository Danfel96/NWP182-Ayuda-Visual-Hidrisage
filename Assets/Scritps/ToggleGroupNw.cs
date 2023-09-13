using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Newronizer
{
    public class ToggleGroupNw : UnityEngine.UI.ToggleGroup
    {
        [SerializeField] UnityEvent onAnyToggleOn, onAnyToggleOff;
        bool invokedToggleOn, invokedToggleOff;

        private void Update()
        {
            if(AnyTogglesOn() && !invokedToggleOn)
            {
                invokedToggleOn = true;
                invokedToggleOff = false;
                print("On");
                InvokeEvent(onAnyToggleOn);
            }
            else if(!AnyTogglesOn() && !invokedToggleOff)
            {
                invokedToggleOn = false;
                invokedToggleOff = true;
                print("Off");
                InvokeEvent(onAnyToggleOff);
            }

        }

        private void InvokeEvent(UnityEvent e)
        {
            if (e != null)
                e.Invoke();
        }
    }
}
