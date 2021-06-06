
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MadScenarioScript : UdonSharpBehaviour
{
    public int actionsLeft;

    public void ResetActions()
    { actionsLeft = 20; }
    
    public void ActionMove()
    { actionsLeft -= 5; }

    public void ActionExplore()
    { actionsLeft -= 10; }
    
    public void ActionInteract()
    { actionsLeft -= 10; }

    public void ActionSight()
    { actionsLeft -= 10; }
    
    public void ActionSearch()
    { actionsLeft -= 10; }
    
}
