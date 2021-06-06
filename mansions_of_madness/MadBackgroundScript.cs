
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class MadBackgroundScript : UdonSharpBehaviour
{
    [Header("Other Scripts")]
    [SerializeField] private COMMON localizationCommon;
    [SerializeField] private DatabaseScript db;

    [Space(10)] 
    [Header("Background Elements")]
    [SerializeField] private Text backgroundName;
    [SerializeField] private Text backgroundAbility;
    [SerializeField] private Text[] stats;

    [Space(10)]
    [Header("Footer")]
    [SerializeField] private setOwner avatarCameraScript;
    [SerializeField] private Camera avatarCamera;
    [SerializeField] private RenderTexture[] targetTextures = new RenderTexture[5];
    [SerializeField] public Text[] targetLabels = new Text[5];
    
    private bool[] activePrevies = new bool[5];
    [HideInInspector] public int localBackground;
    
    public void UpdateBackground(int id)
    {
        // background's id -> one of three arrays (name,ability,stats) - > value
        backgroundName.text = localizationCommon.backgrounds[id][0][0];
        backgroundAbility.text = localizationCommon.backgrounds[id][1][db.localLanguage];
        for (int i = 0; i < stats.Length; i++) {
            stats[i].text = localizationCommon.backgrounds[id][2][i];}
    }
    
    public void ToLast()
    {
        if (localBackground == 0)
            localBackground = localizationCommon.backgrounds.Length-1;
        else
            localBackground--;
        UpdateBackground(localBackground);
    }
    
    public void ToNext()
    {
        if (localBackground == localizationCommon.backgrounds.Length-1)
            localBackground = 0;
        else
            localBackground++;
        UpdateBackground(localBackground);
    }
    
    public void ResetBackground()
    { UpdateBackground(0); }

    public void SelectCurrentBackground()
    {
        foreach (var VARIABLE in db.currentPlayersIds) {
            if (Networking.LocalPlayer.playerId == VARIABLE) {
                return; }}
        avatarCameraScript.setter();
        SendCustomNetworkEvent(NetworkEventTarget.All, "getBackground" + localBackground);
    }
    
    public void getBackground0() { setBackground(0) ;}
    public void getBackground1() { setBackground(1) ;}
    public void getBackground2() { setBackground(2) ;}
    public void getBackground3() { setBackground(3) ;}
    public void getBackground4() { setBackground(4) ;}
    public void getBackground5() { setBackground(5) ;}
    public void getBackground6() { setBackground(6) ;}
    public void getBackground7() { setBackground(7) ;}
    public void getBackground8() { setBackground(8) ;}
    public void getBackground9() { setBackground(9) ;}
    public void getBackground10() { setBackground(10) ;}
    public void getBackground11() { setBackground(11) ;}
    public void getBackground12() { setBackground(12) ;}
    public void getBackground13() { setBackground(13) ;}
    public void getBackground14() { setBackground(14) ;}
    public void getBackground15() { setBackground(15) ;}
    public void getBackground16() { setBackground(16) ;}
    public void getBackground17() { setBackground(17) ;}
    public void getBackground18() { setBackground(18) ;}
    public void getBackground19() { setBackground(19) ;}
    public void getBackground20() { setBackground(20) ;}
    public void getBackground21() { setBackground(21) ;}
    public void getBackground22() { setBackground(22) ;}
    public void getBackground23() { setBackground(23) ;}
    public void getBackground24() { setBackground(24) ;}
    public void getBackground25() { setBackground(25) ;}
    public void getBackground26() { setBackground(26) ;}
    public void getBackground27() { setBackground(27) ;}
    public void getBackground28() { setBackground(28) ;}
    public void getBackground29() { setBackground(29) ;}
    public void getBackground30() { setBackground(30) ;}
    public void getBackground31() { setBackground(31) ;}
    public void getBackground32() { setBackground(32) ;}
    public void getBackground33() { setBackground(33) ;}
    public void getBackground34() { setBackground(34) ;}
    public void getBackground35() { setBackground(35) ;}
    public void getBackground36() { setBackground(36) ;}
    public void getBackground37() { setBackground(37) ;}
    public void getBackground38() { setBackground(38) ;}
    public void getBackground39() { setBackground(39) ;}
    
    public void setBackground(int id)
    {    // maybe add error that it has maximum amount of players later
        for (int i = 0; i < 5; i++) {
            if (!activePrevies[i]) {
                // render avatar's picture
                VRCPlayerApi.TrackingData playerHeadTransform = Networking.GetOwner(avatarCamera.gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head);
                avatarCamera.gameObject.transform.SetPositionAndRotation(playerHeadTransform.position, playerHeadTransform.rotation);
                avatarCamera.gameObject.transform.position = avatarCamera.gameObject.transform.forward;
                avatarCamera.gameObject.transform.LookAt(playerHeadTransform.position);
                avatarCamera.gameObject.GetComponent<Camera>().targetTexture = targetTextures[i];
                avatarCamera.gameObject.GetComponent<Camera>().Render();
                
                // saving player in array and adding background's name
                targetLabels[i].text = localizationCommon.backgrounds[id][0][0];
                activePrevies[i] = true;
                db.currentPlayersIds[i] = Networking.GetOwner(avatarCamera.gameObject).playerId;
                db.currentPlayersBackgroundIds[i] = id;
                break; } } }
}
