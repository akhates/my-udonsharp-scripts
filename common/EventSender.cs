
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class EventSender : UdonSharpBehaviour
{
    [SerializeField] private UdonBehaviour script;
    [SerializeField] string customEvent;
    void Interact()
    {
        script.SendCustomEvent(customEvent);
    }
}
