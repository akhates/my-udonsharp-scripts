
using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class CarcassonneMainScript : UdonSharpBehaviour
{
    [SerializeField] private GameObject[] baseDeck = new GameObject[72];
    [SerializeField] private Transform spawnpoint;
    [SerializeField] private Transform spawnanchor;
    [SerializeField] private Text counter;
    [SerializeField] private GameObject reset;

    void Start()
    {
        int seed = (int) Time.time;
        UnityEngine.Random.InitState(seed);
    }
    void Interact()
    {
        int a;
        foreach (var VARIABLE in baseDeck)
        {
            if (!VARIABLE.activeSelf)
            {
                while(baseDeck[a = UnityEngine.Random.Range(0, baseDeck.Length)].activeSelf)
                {}
                SendCustomNetworkEvent(NetworkEventTarget.All, "pickTile" + a.ToString());
                break;
            }
        }
        UpdateCounter();
        SendCustomNetworkEvent(NetworkEventTarget.All, "UpdateCounter");
    }

    public void UpdateCounter()
    {
        int a = 0;
        foreach (var VARIABLE in baseDeck)
        {
            if (!VARIABLE.activeInHierarchy)
            {
                a++;
            }
        }
        if (a == 0)
        {
            reset.SetActive(true);
        }
        counter.text = a.ToString();
    }

    public void ResetGame()
    {
        SendCustomNetworkEvent(NetworkEventTarget.All, "ResetGameNetworked");
    }

    public void ResetGameNetworked()
    {
        foreach (var VARIABLE in baseDeck)
        {
            if (VARIABLE != baseDeck[0])
            {
                VARIABLE.SetActive(false);
                VARIABLE.transform.parent.transform.position = spawnanchor.transform.position;
                ((VRC_Pickup)VARIABLE.transform.parent.GetComponent(typeof(VRC_Pickup))).pickupable = false;
            }
        }
        baseDeck[0].SetActive(true);
        reset.SetActive(false);
    }


    // Thanks Udon
    public void pickTile0() { pickTile(0) ;}
    public void pickTile1() { pickTile(1) ;}
    public void pickTile2() { pickTile(2) ;}
    public void pickTile3() { pickTile(3) ;}
    public void pickTile4() { pickTile(4) ;}
    public void pickTile5() { pickTile(5) ;}
    public void pickTile6() { pickTile(6) ;}
    public void pickTile7() { pickTile(7) ;}
    public void pickTile8() { pickTile(8) ;}
    public void pickTile9() { pickTile(9) ;}
    public void pickTile10() { pickTile(10) ;}
    public void pickTile11() { pickTile(11) ;}
    public void pickTile12() { pickTile(12) ;}
    public void pickTile13() { pickTile(13) ;}
    public void pickTile14() { pickTile(14) ;}
    public void pickTile15() { pickTile(15) ;}
    public void pickTile16() { pickTile(16) ;}
    public void pickTile17() { pickTile(17) ;}
    public void pickTile18() { pickTile(18) ;}
    public void pickTile19() { pickTile(19) ;}
    public void pickTile20() { pickTile(20) ;}
    public void pickTile21() { pickTile(21) ;}
    public void pickTile22() { pickTile(22) ;}
    public void pickTile23() { pickTile(23) ;}
    public void pickTile24() { pickTile(24) ;}
    public void pickTile25() { pickTile(25) ;}
    public void pickTile26() { pickTile(26) ;}
    public void pickTile27() { pickTile(27) ;}
    public void pickTile28() { pickTile(28) ;}
    public void pickTile29() { pickTile(29) ;}
    public void pickTile30() { pickTile(30) ;}
    public void pickTile31() { pickTile(31) ;}
    public void pickTile32() { pickTile(32) ;}
    public void pickTile33() { pickTile(33) ;}
    public void pickTile34() { pickTile(34) ;}
    public void pickTile35() { pickTile(35) ;}
    public void pickTile36() { pickTile(36) ;}
    public void pickTile37() { pickTile(37) ;}
    public void pickTile38() { pickTile(38) ;}
    public void pickTile39() { pickTile(39) ;}
    public void pickTile40() { pickTile(40) ;}
    public void pickTile41() { pickTile(41) ;}
    public void pickTile42() { pickTile(42) ;}
    public void pickTile43() { pickTile(43) ;}
    public void pickTile44() { pickTile(44) ;}
    public void pickTile45() { pickTile(45) ;}
    public void pickTile46() { pickTile(46) ;}
    public void pickTile47() { pickTile(47) ;}
    public void pickTile48() { pickTile(48) ;}
    public void pickTile49() { pickTile(49) ;}
    public void pickTile50() { pickTile(50) ;}
    public void pickTile51() { pickTile(51) ;}
    public void pickTile52() { pickTile(52) ;}
    public void pickTile53() { pickTile(53) ;}
    public void pickTile54() { pickTile(54) ;}
    public void pickTile55() { pickTile(55) ;}
    public void pickTile56() { pickTile(56) ;}
    public void pickTile57() { pickTile(57) ;}
    public void pickTile58() { pickTile(58) ;}
    public void pickTile59() { pickTile(59) ;}
    public void pickTile60() { pickTile(60) ;}
    public void pickTile61() { pickTile(61) ;}
    public void pickTile62() { pickTile(62) ;}
    public void pickTile63() { pickTile(63) ;}
    public void pickTile64() { pickTile(64) ;}
    public void pickTile65() { pickTile(65) ;}
    public void pickTile66() { pickTile(66) ;}
    public void pickTile67() { pickTile(67) ;}
    public void pickTile68() { pickTile(68) ;}
    public void pickTile69() { pickTile(69) ;}
    public void pickTile70() { pickTile(70) ;}
    public void pickTile71() { pickTile(71) ;}

    void pickTile(int a)
    {
        baseDeck[a].SetActive(true);
        baseDeck[a].transform.parent.transform.position = spawnpoint.transform.position;
        ((VRC_Pickup)baseDeck[a].transform.parent.GetComponent(typeof(VRC_Pickup))).pickupable = true;
    }

    // Thanks Udon
    public void syncTile0() { syncTile(0) ;}
    public void syncTile1() { syncTile(1) ;}
    public void syncTile2() { syncTile(2) ;}
    public void syncTile3() { syncTile(3) ;}
    public void syncTile4() { syncTile(4) ;}
    public void syncTile5() { syncTile(5) ;}
    public void syncTile6() { syncTile(6) ;}
    public void syncTile7() { syncTile(7) ;}
    public void syncTile8() { syncTile(8) ;}
    public void syncTile9() { syncTile(9) ;}
    public void syncTile10() { syncTile(10) ;}
    public void syncTile11() { syncTile(11) ;}
    public void syncTile12() { syncTile(12) ;}
    public void syncTile13() { syncTile(13) ;}
    public void syncTile14() { syncTile(14) ;}
    public void syncTile15() { syncTile(15) ;}
    public void syncTile16() { syncTile(16) ;}
    public void syncTile17() { syncTile(17) ;}
    public void syncTile18() { syncTile(18) ;}
    public void syncTile19() { syncTile(19) ;}
    public void syncTile20() { syncTile(20) ;}
    public void syncTile21() { syncTile(21) ;}
    public void syncTile22() { syncTile(22) ;}
    public void syncTile23() { syncTile(23) ;}
    public void syncTile24() { syncTile(24) ;}
    public void syncTile25() { syncTile(25) ;}
    public void syncTile26() { syncTile(26) ;}
    public void syncTile27() { syncTile(27) ;}
    public void syncTile28() { syncTile(28) ;}
    public void syncTile29() { syncTile(29) ;}
    public void syncTile30() { syncTile(30) ;}
    public void syncTile31() { syncTile(31) ;}
    public void syncTile32() { syncTile(32) ;}
    public void syncTile33() { syncTile(33) ;}
    public void syncTile34() { syncTile(34) ;}
    public void syncTile35() { syncTile(35) ;}
    public void syncTile36() { syncTile(36) ;}
    public void syncTile37() { syncTile(37) ;}
    public void syncTile38() { syncTile(38) ;}
    public void syncTile39() { syncTile(39) ;}
    public void syncTile40() { syncTile(40) ;}
    public void syncTile41() { syncTile(41) ;}
    public void syncTile42() { syncTile(42) ;}
    public void syncTile43() { syncTile(43) ;}
    public void syncTile44() { syncTile(44) ;}
    public void syncTile45() { syncTile(45) ;}
    public void syncTile46() { syncTile(46) ;}
    public void syncTile47() { syncTile(47) ;}
    public void syncTile48() { syncTile(48) ;}
    public void syncTile49() { syncTile(49) ;}
    public void syncTile50() { syncTile(50) ;}
    public void syncTile51() { syncTile(51) ;}
    public void syncTile52() { syncTile(52) ;}
    public void syncTile53() { syncTile(53) ;}
    public void syncTile54() { syncTile(54) ;}
    public void syncTile55() { syncTile(55) ;}
    public void syncTile56() { syncTile(56) ;}
    public void syncTile57() { syncTile(57) ;}
    public void syncTile58() { syncTile(58) ;}
    public void syncTile59() { syncTile(59) ;}
    public void syncTile60() { syncTile(60) ;}
    public void syncTile61() { syncTile(61) ;}
    public void syncTile62() { syncTile(62) ;}
    public void syncTile63() { syncTile(63) ;}
    public void syncTile64() { syncTile(64) ;}
    public void syncTile65() { syncTile(65) ;}
    public void syncTile66() { syncTile(66) ;}
    public void syncTile67() { syncTile(67) ;}
    public void syncTile68() { syncTile(68) ;}
    public void syncTile69() { syncTile(69) ;}
    public void syncTile70() { syncTile(70) ;}
    public void syncTile71() { syncTile(71) ;}
    
	/*
		game will sync position automatically so I only need to enable objects to pickup and exclude from deck
	*/
	
    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        SendCustomNetworkEvent(NetworkEventTarget.Owner, "SyncGame");
    }

    void SyncGame()
    {
        int i = 0;
        foreach (var VARIABLE in baseDeck)
        {
            i++;
            if (VARIABLE.activeSelf == true)
            {
                SendCustomNetworkEvent(NetworkEventTarget.All, "syncTile" + i);
            }
        }
    }
    
    void syncTile(int a)
    {
        baseDeck[a].SetActive(true);
        ((VRC_Pickup)baseDeck[a].transform.parent.GetComponent(typeof(VRC_Pickup))).pickupable = true;
    }

}
