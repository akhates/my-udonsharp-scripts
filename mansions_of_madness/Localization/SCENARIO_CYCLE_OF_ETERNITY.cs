
using System;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SCENARIO_CYCLE_OF_ETERNITY : UdonSharpBehaviour
{
    public int items = 4;
    public int spells = 2;
    public int clues = 2;
    
    public string[][] jaggedArrayCycleOfEternity =
    {
        // scenarioName
        new [] 
        {
            "Cycle of Eternity", 
            "Круг вечности", 
            "永劫の輪廻"
        },
        // scenarioSummary
        new []
        {
            "After a rash of disappearances, your investigation brings you to the Vanderbilt mansion during a meeting of a particular astronomical society. Can you unravel the mystery before the Cycle of Eternity turns once more?",
            "Расследование череды исчезновений приводит вас в особняк Вандербильтов на встречу одного астрономического сообщества. Сумеете ли вы раскрыть тайну до того, как Круг вечности сделает ещё один оборот?",
            "頻発する失踪事件の調査の一環で、君は、ある天文学会の会議が催されているヴァンダービルト氏の屋敷を訪れた。永劫の輪廻がもう一度めぐる前に、この謎を解明できるだろうか？"
        },
    };

    public string[][] COE_Prologue =
    {
        // CUTSCENE_COE_PROLOGUE_ENGLISH
        new []
        {

            "You slump into your office chair after another long day of interviews. You have been investigating the disappearances surrounding a wealthy neighborhood for two weeks, but you have nothing to show for it.",
            "The telephone rings. You answer and hear the panicked voice of an older man.",
            "''Is this the investigator who visited the Vanderbilt estate?''",
            "You flip through the files on your desk. William Vanderbilt: a wealthy bachelor, mother recently deceased. He had refused to meet with you, but you were able to speak to several members of his serving staff.",
            "''This is Eugene, Mr. Vanderbilt's butler. I did not know who else to call. The police think I am crazy. Unnatural things have started happening here. I am worried for my master. I think he is in danger. Please help.''",
            "Finally. A lead. You hang up the phone, throw on your coat, and leave for the Vanderbilt estate."
        },
        // CUTSCENE_COE_PROLOGUE_RUSSIAN
        new []
        {
            "Вы устало опускаетесь в офисное кресло: ещё один долгий день, полный деловых встреч, остался позади. В данный момент вы расследуете исчезновения, которые уже две недели происходят в богатом районе, но результатов всё ещё нет.",
            "Раздаётся телефонный звонок. Вы поднимаете трубку и слышите испуганный голос пожилого мужчины:",
            "— Э-это вы тот сыщик, который посещал поместье Вандербильтов?",
            "Вы просматриваете документы на столе. Уильям Вандербильт: богатый холостяк, мать недавно скончалась. Он отказался встретиться с вами, но вы смогли побеседовать с несколькими людьми из прислуги.",
            "— Это Юджин, дворецкий мистера Вандербильта. Я-я не знал, к кому ещё обратиться. Полиция думает, что я свихнулся. Здесь происходит что-то противоестественное. Я беспокоюсь за хозяина, мне кажется, он в опасности. Пожалуйста, помогите нам!",
            "Наконец-то наводка! Вы вешаете трубку, накидываете пальто и отправляетесь в поместье Вандербильтов."
        }, 
        // CUTSCENE_COE_PROLOGUE_JAPANESE
        new []
        {
            "長い午後を聞き込みに費やした後、どさりとオフィスの椅子にへたり込んだ。２週間も、ある富豪の家の周辺で発生している、失踪事件について調査していた。しかし、何も分かっていない。",
            "電話が鳴った。電話を取ると、怯えた老人の声が聞こえた。",
            "「こちらは、あ……さきほど、ヴァンダービルト様のお屋敷にいらっしゃった、探偵様ですかな？」",
            "デスクの上の書類をめくる。ウィリアム・ヴァンダービルト。裕福な独身男性。母親が最近、死んだばかりだ。彼は面会を拒絶した。しかし、召使の何人かと話をすることができた。",
            "「私はユージンと申します。ヴァンダービルト様の執事でございます。こんなことについて、どなたにお話すべきなのか分からなくて……警察は、私のことを狂人などと申します。とにかく、大変おかしなことが、このお屋敷で起きております。ご主人様のことが心配で……私は、危険が迫っていると思うのです。どうか、ご助力をお願いしたく……」",
            "どうやら、遂に手がかりを得たようだ。電話を切り、コートを急いではおり、ヴァンダービルトの屋敷に向かった。"
        }, 
    };
}
