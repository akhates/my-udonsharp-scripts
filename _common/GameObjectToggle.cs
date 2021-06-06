
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class GameObjectToggle : UdonSharpBehaviour
{
    [TextArea] public string localToggle;
    [SerializeField] private GameObject[] toDisable;
    [SerializeField] private GameObject[] toEnable;
    
    [Space(10)]
    [TextArea] public string localToggleOnlyMaster;
    [SerializeField] private GameObject[] toDisableMaster;
    [SerializeField] private GameObject[] toEnableMaster;
    
    [Space(10)]
    [TextArea] public string localToggleEveryoneButMaster;
    [SerializeField] private GameObject[] toDisableNotMaster;
    [SerializeField] private GameObject[] toEnableNotMaster;
    
    [Space(10)]
    [TextArea] public string networkedToggle;
    [SerializeField] private GameObject[] toEnableNetworked;
    [SerializeField] private GameObject[] toDisableNetworked;
    
    public override void Interact()
    {
        
        foreach (var VARIABLE in toDisable)
        { if (VARIABLE) VARIABLE.SetActive(false); }
        foreach (var VARIABLE in toEnable)
        { if (VARIABLE) VARIABLE.SetActive(true); }

        if (Networking.LocalPlayer != null)
        {
            if (Networking.LocalPlayer.isMaster)
            {
                foreach (var VARIABLE in toDisableMaster)
                { if (VARIABLE) VARIABLE.SetActive(false); }
                foreach (var VARIABLE in toEnableMaster)
                { if (VARIABLE) VARIABLE.SetActive(true); }
            }
            if (!Networking.LocalPlayer.isMaster)
            {
                foreach (var VARIABLE in toEnableNotMaster)
                { if (VARIABLE) VARIABLE.SetActive(true); }
                foreach (var VARIABLE in toDisableNotMaster)
                { if (VARIABLE) VARIABLE.SetActive(false); }
            }
        }

        if (toEnableNetworked.Length > 0 || toDisableNetworked.Length > 0)
        { SendCustomNetworkEvent(NetworkEventTarget.All,"toggle"); }
        
    }

    public void toggle()
    {
        foreach (var VARIABLE in toEnableNetworked)
        { if (VARIABLE) VARIABLE.SetActive(true); }
        foreach (var VARIABLE in toDisableNetworked)
        { if (VARIABLE) VARIABLE.SetActive(false); }
    }
}
