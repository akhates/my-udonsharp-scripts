
using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class MadLoggerScript : UdonSharpBehaviour
{
    [SerializeField] private DatabaseScript db;
    [SerializeField] private COMMON localizationCommon;
    [SerializeField] private Text console;
    VRCPlayerApi[] players = new VRCPlayerApi[20];
    private DateTime waittime;
    void Start()
    {
        waittime = DateTime.UtcNow + TimeSpan.FromSeconds(5.0);
        console.text = "";
    }

    void UpdateConsole()
    {
        VRCPlayerApi.GetPlayers(players);
        int a = 0;
        string instanceMaster = (Networking.GetOwner(gameObject) != null)
            ? "Master of instance: " + Networking.GetOwner(gameObject).displayName + " [id:" + Networking.GetOwner(gameObject).playerId + "]"
            : "";

        string temp = "";
        string temp2 = "";
        foreach (VRCPlayerApi player in players) {
            if (player != null) {
                temp += player.displayName + " [id:" + player.playerId + "]; "; 
                for (int i = 0; i < 5; i++) {
                    if (player.playerId == db.currentPlayersIds[i]) {
                        temp2 += "[" + player.displayName + "[id:" + player.playerId + "]" + ":" + localizationCommon.backgrounds[db.currentPlayersBackgroundIds[i]][0] + "] "; }}
            } }
        string temp3 = "";
        
        string playerList = (temp != "") ? "\nPlayers in instance: " + temp : "";
        string currentPlayers = (temp2 != "") ? "\nCurrent investigators: " + temp2 : "";
        string localData = "\n[localLanguage == " + db.localLanguage + "] [localScenario == " + db.localScenario + "] [localBackground == " + db.localBackground + "] ";

        console.text = instanceMaster + playerList + currentPlayers + localData;
    }

    private void Update()
    {
        if (waittime < DateTime.UtcNow)
        {    
            waittime = DateTime.UtcNow + TimeSpan.FromSeconds( 5.0 );
            UpdateConsole();
        }
    }
}
