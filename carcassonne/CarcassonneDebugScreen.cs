
using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class CarcassonneDebugScreen : UdonSharpBehaviour
{
    [SerializeField] private Text screen;
    [SerializeField] private Text screen2;
    [SerializeField] private Text screen3;
    [SerializeField] private Text screen4;
    [SerializeField] private GameObject[] tiles;
    [SerializeField] private carcassonne_tile[] tileSettings;
    private void Start()
    {
        SendCustomNetworkEvent(NetworkEventTarget.All, "UpdateScreenNetworked");
    }

    public void UpdateScreen()
    {
        SendCustomNetworkEvent(NetworkEventTarget.All, "UpdateScreenNetworked");
    }

    public void UpdateScreenNetworked()
    {
        string screenText = "";
        string screenText2 = "";
        string screenText3 = "";
        string screenText4 = "";
        for (int i = 0; i < tiles.Length; i++)
        {
            if (i < 20)
            {
                screenText = screenText + "\n" + tiles[i].name + " " + tiles[i].activeInHierarchy;
            }
            else if (i < 40)
            {
                screenText2 = screenText2 + "\n" + tiles[i].name + " " + tiles[i].activeInHierarchy;
            }
            else if (i < 60)
            {
                screenText3 = screenText3 + "\n" + tiles[i].name + " " + tiles[i].activeInHierarchy;
            }
            else
            {
                screenText4 = screenText4 + "\n" + tiles[i].name + " " + tiles[i].activeInHierarchy;
            }
            
        }
        screen.text = screenText;
        screen2.text = screenText2;
        screen3.text = screenText3;
        screen4.text = screenText4;
    }
}
