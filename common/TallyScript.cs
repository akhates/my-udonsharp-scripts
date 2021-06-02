
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class TallyScript : UdonSharpBehaviour
{
    [SerializeField] private Text[] text;
    private int _localScore;

    public void IncrementScore()
    {
        if (_localScore < 99)
        {
            _localScore++;
            SendCustomNetworkEvent(NetworkEventTarget.All,"setScore" + _localScore);
        }
    }

    public void DecrementScore()
    {
        if (_localScore > 0)
        {
            _localScore--;
            SendCustomNetworkEvent(NetworkEventTarget.All,"setScore" + _localScore);
        }
    }

    public void setScore(int a)
    {
        _localScore = a;
        foreach (var VARIABLE in text)
        {
            VARIABLE.text = _localScore.ToString();
        }
    }
    
    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        SendCustomNetworkEvent(NetworkEventTarget.Owner,"UpdateScore");
    }

    public void UpdateScore()
    {
        SendCustomNetworkEvent(NetworkEventTarget.All,"setScore" + _localScore);
    }
    
    // Thanks Udon
    public void setScore0() { setScore(0) ;}
    public void setScore1() { setScore(1) ;}
    public void setScore2() { setScore(2) ;}
    public void setScore3() { setScore(3) ;}
    public void setScore4() { setScore(4) ;}
    public void setScore5() { setScore(5) ;}
    public void setScore6() { setScore(6) ;}
    public void setScore7() { setScore(7) ;}
    public void setScore8() { setScore(8) ;}
    public void setScore9() { setScore(9) ;}
    public void setScore10() { setScore(10) ;}
    public void setScore11() { setScore(11) ;}
    public void setScore12() { setScore(12) ;}
    public void setScore13() { setScore(13) ;}
    public void setScore14() { setScore(14) ;}
    public void setScore15() { setScore(15) ;}
    public void setScore16() { setScore(16) ;}
    public void setScore17() { setScore(17) ;}
    public void setScore18() { setScore(18) ;}
    public void setScore19() { setScore(19) ;}
    public void setScore20() { setScore(20) ;}
    public void setScore21() { setScore(21) ;}
    public void setScore22() { setScore(22) ;}
    public void setScore23() { setScore(23) ;}
    public void setScore24() { setScore(24) ;}
    public void setScore25() { setScore(25) ;}
    public void setScore26() { setScore(26) ;}
    public void setScore27() { setScore(27) ;}
    public void setScore28() { setScore(28) ;}
    public void setScore29() { setScore(29) ;}
    public void setScore30() { setScore(30) ;}
    public void setScore31() { setScore(31) ;}
    public void setScore32() { setScore(32) ;}
    public void setScore33() { setScore(33) ;}
    public void setScore34() { setScore(34) ;}
    public void setScore35() { setScore(35) ;}
    public void setScore36() { setScore(36) ;}
    public void setScore37() { setScore(37) ;}
    public void setScore38() { setScore(38) ;}
    public void setScore39() { setScore(39) ;}
    public void setScore40() { setScore(40) ;}
    public void setScore41() { setScore(41) ;}
    public void setScore42() { setScore(42) ;}
    public void setScore43() { setScore(43) ;}
    public void setScore44() { setScore(44) ;}
    public void setScore45() { setScore(45) ;}
    public void setScore46() { setScore(46) ;}
    public void setScore47() { setScore(47) ;}
    public void setScore48() { setScore(48) ;}
    public void setScore49() { setScore(49) ;}
    public void setScore50() { setScore(50) ;}
    public void setScore51() { setScore(51) ;}
    public void setScore52() { setScore(52) ;}
    public void setScore53() { setScore(53) ;}
    public void setScore54() { setScore(54) ;}
    public void setScore55() { setScore(55) ;}
    public void setScore56() { setScore(56) ;}
    public void setScore57() { setScore(57) ;}
    public void setScore58() { setScore(58) ;}
    public void setScore59() { setScore(59) ;}
    public void setScore60() { setScore(60) ;}
    public void setScore61() { setScore(61) ;}
    public void setScore62() { setScore(62) ;}
    public void setScore63() { setScore(63) ;}
    public void setScore64() { setScore(64) ;}
    public void setScore65() { setScore(65) ;}
    public void setScore66() { setScore(66) ;}
    public void setScore67() { setScore(67) ;}
    public void setScore68() { setScore(68) ;}
    public void setScore69() { setScore(69) ;}
    public void setScore70() { setScore(70) ;}
    public void setScore71() { setScore(71) ;}
    public void setScore72() { setScore(72) ;}
    public void setScore73() { setScore(73) ;}
    public void setScore74() { setScore(74) ;}
    public void setScore75() { setScore(75) ;}
    public void setScore76() { setScore(76) ;}
    public void setScore77() { setScore(77) ;}
    public void setScore78() { setScore(78) ;}
    public void setScore79() { setScore(79) ;}
    public void setScore80() { setScore(80) ;}
    public void setScore81() { setScore(81) ;}
    public void setScore82() { setScore(82) ;}
    public void setScore83() { setScore(83) ;}
    public void setScore84() { setScore(84) ;}
    public void setScore85() { setScore(85) ;}
    public void setScore86() { setScore(86) ;}
    public void setScore87() { setScore(87) ;}
    public void setScore88() { setScore(88) ;}
    public void setScore89() { setScore(89) ;}
    public void setScore90() { setScore(90) ;}
    public void setScore91() { setScore(91) ;}
    public void setScore92() { setScore(92) ;}
    public void setScore93() { setScore(93) ;}
    public void setScore94() { setScore(94) ;}
    public void setScore95() { setScore(95) ;}
    public void setScore96() { setScore(96) ;}
    public void setScore97() { setScore(97) ;}
    public void setScore98() { setScore(98) ;}
    public void setScore99() { setScore(99) ;}
}
