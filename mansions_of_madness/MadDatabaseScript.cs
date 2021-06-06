
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MadDatabaseScript : UdonSharpBehaviour
{
    public int localLanguage = -1;
    public int localBackground = -1;
    public int localScenario = -1;
    public int[] currentPlayersIds = new int[5] {-1,-1,-1,-1,-1,};
    public int[] currentPlayersBackgroundIds = new int[5];
}
