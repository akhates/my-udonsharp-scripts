
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class GameObjectSwitch : UdonSharpBehaviour
{
    [SerializeField] GameObject[] itemsToDisable= new GameObject[0];
    [SerializeField] GameObject[] itemsToEnable= new GameObject[0];
    void Interact()
    {
        if (!itemsToDisable.Length.Equals(0))
        {
            foreach (var elm in itemsToDisable)
            {
                if (elm)
                { 
                    elm.SetActive(false);
                }
            }
        }
        
        if (!itemsToEnable.Length.Equals(0))
        {
            foreach (var elm in itemsToEnable)
            {
                if (elm)
                { 
                    elm.SetActive(true);
                }
            }
        }
    }
}
