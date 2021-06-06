
using System;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class MadActionScript : UdonSharpBehaviour
{
    [Header("Target scenario script")]
    [SerializeField] private ScenarioScript scenario;
    
    [Header("Type of Action")]
    [SerializeField] private bool actionMove;
    [SerializeField] private bool actionExplore;
    [SerializeField] private bool actionSearch;
    [SerializeField] private bool actionSight;
    [SerializeField] private bool actionInteract;

    private Animator _animator;

    public void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    public void GetAction()
    {
        _animator.Play("Base Layer.GetAction", 0);
    }

    public void TakeAction()
    {
        if (actionMove && scenario.actionsLeft >= 5){ scenario.ActionMove(); SendCustomNetworkEvent(NetworkEventTarget.All, "FinishAction");}
        else if (actionExplore && scenario.actionsLeft >= 10){ scenario.ActionExplore(); SendCustomNetworkEvent(NetworkEventTarget.All, "FinishAction");}
        else if (actionSearch && scenario.actionsLeft >= 10){ scenario.ActionSearch(); SendCustomNetworkEvent(NetworkEventTarget.All, "FinishAction");}
        else if (actionSight && scenario.actionsLeft >= 10){ scenario.ActionSight(); SendCustomNetworkEvent(NetworkEventTarget.All, "FinishAction");}
        else if (actionInteract && scenario.actionsLeft >= 10){ scenario.ActionInteract(); SendCustomNetworkEvent(NetworkEventTarget.All, "FinishAction");}
        else { NotEnoughActionsLeft(); }
    }
    
    public void FinishAction()
    {
        _animator.Play("Base Layer.FinishAction", 0);
       
    }
    
    public void NotEnoughActionsLeft()
    {
         // display some text
    }
}
