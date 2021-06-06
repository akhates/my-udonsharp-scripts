using UnityEngine;
using UdonSharp;
using VRC.SDKBase;

public class PlayerModSettings : UdonSharpBehaviour
{
    public float jumpHeight = 3f;
    public float runSpeed = 4f;
    public float walkSpeed = 2f;
    public float strafeSpeed = 2f;
    public float gravity = 1f;

    void Start()
    {
        var playerApi = Networking.LocalPlayer;
        if (playerApi != null)
        {
            playerApi.SetJumpImpulse(jumpHeight);
            playerApi.SetRunSpeed(runSpeed);
            playerApi.SetWalkSpeed(walkSpeed);
            playerApi.SetStrafeSpeed(strafeSpeed);
            playerApi.SetGravityStrength(gravity);
        }
    }
}