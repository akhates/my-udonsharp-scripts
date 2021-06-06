
using System;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PlayerCamera : UdonSharpBehaviour
{
    private VRCPlayerApi playerApi;

    public void Start()
    {
        playerApi = Networking.LocalPlayer;
    }

    public void Update()
    {
        if (playerApi != null)
        {
            VRCPlayerApi.TrackingData playerHeadTransform = playerApi.GetTrackingData(VRCPlayerApi.TrackingDataType.Head);
            gameObject.transform.rotation = playerHeadTransform.rotation;
            gameObject.transform.position = playerHeadTransform.position + gameObject.transform.forward;
            gameObject.transform.LookAt(playerHeadTransform.position);
        }
    }
}
