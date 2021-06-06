
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class EnableOnPlay : UdonSharpBehaviour
{
    [SerializeField] private GameObject[] enableOnPlay;
    void Start()
    {
        foreach (var VARIABLE in enableOnPlay)
        {
            VARIABLE.SetActive(true);
        }
    }
}
