
using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class MadLocalizationScript : UdonSharpBehaviour
{
    [TextArea] public string otherScripts;
    [SerializeField] private COMMON common;
    [SerializeField] private SCENARIO_CYCLE_OF_ETERNITY scenarioCycleOfEternity;
    [SerializeField] private DatabaseScript db;
    [SerializeField] private BackgroundScript _backgroundScript;
    
    [Space(10)]
    [Tooltip("gameObjects to alter from common")]
    [TextArea] public string commonTextFields;
    [SerializeField] private Text alertOnEnterText;
    [SerializeField] private Text startGameText;
    [SerializeField] private Text waitingOnMasterText;
    [SerializeField] private Text selectScenarioText;
    [SerializeField] private Text selectThisScenarioText;
    [SerializeField] private Text selectThisBackgroundText;
    [SerializeField] private Text startScenarioText;
    [SerializeField] private Text continueText;
    [SerializeField] private Text beginScenarioText;
    [Space(5)]
    [SerializeField] private Text[] backgroundStats;
    
    [Space(10)]
    [Tooltip("gameObjects to alter from scenario")]
    [TextArea] public string scenarioTextFields;
    [SerializeField] private Text scenarioName;
    [SerializeField] private Text scenarioSummary;
    [SerializeField] private Text[] COE_prologue;

    // 0 for english, 1 for russian, 2 for japanese
    public void changeToEnglish()
    {changeLanguage(0);}
    public void changeToRussian()
    {changeLanguage(1);}
    public void changeToJapanese()
    {changeLanguage(2);}

    public void changeLanguage(int id)
    {
        updateLanguage(id);
        db.localLanguage = id;
        _backgroundScript.UpdateBackground(_backgroundScript.localBackground);
    }

    public void updateLanguage(int localLanguage)
    {
        alertOnEnterText.text = common.jaggedArrayCommon[0][localLanguage];
        startGameText.text = common.jaggedArrayCommon[1][localLanguage];
        waitingOnMasterText.text = common.jaggedArrayCommon[2][localLanguage];
        selectScenarioText.text = common.jaggedArrayCommon[3][localLanguage];
        selectThisScenarioText.text = common.jaggedArrayCommon[4][localLanguage];
        
        scenarioName.text = scenarioCycleOfEternity.jaggedArrayCycleOfEternity[0][localLanguage];
        scenarioSummary.text = scenarioCycleOfEternity.jaggedArrayCycleOfEternity[1][localLanguage];
        for (int i = 0; i < 6; i++) {
            COE_prologue[i].text = scenarioCycleOfEternity.COE_Prologue[localLanguage][i]; }

        for (int i = 0; i < backgroundStats.Length; i++) { 
            backgroundStats[i].text = common.jaggedArrayStats[i][localLanguage]; }
        
        selectThisBackgroundText.text = common.jaggedArrayCommon[5][localLanguage];
        startScenarioText.text = common.jaggedArrayCommon[6][localLanguage];
        
        continueText.text = common.jaggedArrayCommon[7][localLanguage];
        beginScenarioText.text = common.jaggedArrayCommon[8][localLanguage];
    }
    
}
