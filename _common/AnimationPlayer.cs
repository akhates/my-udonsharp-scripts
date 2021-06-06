
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class AnimationPlayer : UdonSharpBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private string animationName;
    [SerializeField] private string layer = "Base Layer";
    [SerializeField] private int layerId = 0;
    [SerializeField] private bool playOnce = false;
    [SerializeField] private bool playNetworked = false;
    private Animator _animator;
    private bool _isPlayed = false;
    void Start()
    { _animator = target.GetComponent<Animator>(); }

    public void PlayAnimation()
    { 
        if (playOnce) {
            if (!_isPlayed) {
                if (playNetworked) { SendCustomNetworkEvent(NetworkEventTarget.All, "AnimationStartOnce"); }
                else { AnimationStartOnce(); } } 
        }
        else {
            if (playNetworked) { SendCustomNetworkEvent(NetworkEventTarget.All, "AnimationStart"); }
            else { AnimationStart(); }
        }
    }

    public void AnimationStart()
    { _animator.Play(layer + "." + animationName, layerId);}

    public void AnimationStartOnce()
    { _animator.Play(layer + "." + animationName, layerId); _isPlayed = true;}
}
