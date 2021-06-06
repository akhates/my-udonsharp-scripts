
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class MadGameSetupScript : UdonSharpBehaviour
{
    [SerializeField] private DatabaseScript db;
    [SerializeField] private COMMON localizationCommon;
    [SerializeField] private Text quote0;
    [SerializeField] private Text quote1;
    [SerializeField] private GameObject prologueCOE;
    [SerializeField] private Transform teleportTarget;

    private void Start()
    { int seed = (int) Time.time; Random.InitState(seed); }
    
    // Thanks Udon
    public void getScenario(int id) {SendCustomNetworkEvent(NetworkEventTarget.All, "setScenario" + id);}
    public void getScenario0(){getScenario(0);}
    public void getScenario1(){getScenario(1);}
    public void setScenario(int id) {db.localScenario = id; Debug.Log("local scenario = " + db.localScenario);}
    public void setScenario0(){setScenario(0);}
    public void setScenario1(){setScenario(1);}

    public override void OnPlayerJoined(VRCPlayerApi player)
    {SendCustomNetworkEvent(NetworkEventTarget.Owner, "UpdateScenario");}
    public void UpdateScenario()
    {SendCustomNetworkEvent(NetworkEventTarget.All, "setScenario" + db.localScenario);}
    
    
    public void GenerateQuote()
    {
        int a = Random.Range(0, localizationCommon.LovecraftQuotes.Length);
        SendCustomNetworkEvent(NetworkEventTarget.All, "setQuote" + a.ToString());
    }

    public void setPrologue()
    {
        if (db.localScenario == 1)
        {
            Debug.Log("setPrologue");
            prologueCOE.SetActive(true);
        }
    }
    
    // Thanks Udon
    public void setQuote0(){setQuote(0);}
    public void setQuote1(){setQuote(1);}
    public void setQuote2(){setQuote(2);}
    public void setQuote3(){setQuote(3);}
    public void setQuote4(){setQuote(4);}
    public void setQuote5(){setQuote(5);}
    public void setQuote6(){setQuote(6);}
    public void setQuote7(){setQuote(7);}

    public void setQuote(int a)
    {
        quote0.text = "<i>" + localizationCommon.LovecraftQuotes[a][0][db.localLanguage] + "</i>";
        quote1.text = localizationCommon.LovecraftQuotes[a][1][db.localLanguage];
    }

    public void StartGame()
    { SendCustomNetworkEvent(NetworkEventTarget.All, "Teleport"); }
    
    public void Teleport()
    {
        foreach (var VARIABLE in db.currentPlayersIds) { 
            if (VARIABLE == Networking.LocalPlayer.playerId) {
                Networking.LocalPlayer.TeleportTo(teleportTarget.position, teleportTarget.rotation);  }}
    }

}
