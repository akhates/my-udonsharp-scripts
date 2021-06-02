
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class TakeOwnershipScript : UdonSharpBehaviour
{
	/*
	for whatever reason setting owner of gameObject in external script doesn't works, 
	so I had to make separate one and call it on said gameObject
	*/
    public void takeOwnership()
    {
        Networking.SetOwner(Networking.LocalPlayer, gameObject);
    }
}
