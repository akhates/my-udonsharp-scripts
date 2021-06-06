
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class TeleporterScript : UdonSharpBehaviour
{
    [SerializeField] private Transform Target;
	
    void Interact() {Networking.LocalPlayer.TeleportTo(Target.position, Target.rotation);}
}
