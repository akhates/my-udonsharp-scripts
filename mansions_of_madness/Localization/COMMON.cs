
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class COMMON : UdonSharpBehaviour
{
    /// <summary>
    /// common class contains all card strings and ui strings
    /// </summary>
    /// 0 for english, 1 for russian, 2 for japanese
    /// 
    public string[][] jaggedArrayCommon =
    {
        // alertOnEnterText 0
        new []
        {
            //"This set of content is for informational purposes only, \n in the future you agree to remove it and purchase licensed content.",
            "a",
            "a",
            "a"
        },
        // startGameText 1
        new []
        {
            "Start",
            "Начать",
            ""
        },
        // waitingOnMasterText 2
        new []
        {
            "Waiting for master to select the scenario...",
            "",
            ""
        },
        // selectScenarioText 3
        new []
        {
            "Select Scenario",
            "Выберите сценарий",
            "シナリオの選択"
        },
        // selectThisScenario 4
        new []
        {
            "Select this scenario",
            "Выбрать этот сценарий",
            ""
        },
        // selectThisBackgroundText 5
        new []
        {
            "Select This Background",
            "Выбрать эту предисторию",
            ""
        },
        // startScenarioText 6
        new []
        {
            "Start scenario",
            "Начать сценарий",
            ""
        },
        // continueText 7
        new []
        {
            "Continue",
            "Продолжить",
            ""
        },
        // beginScenarioText 8
        new []
        {
            "Begin Scenario",
            "Начать сценарий",
            "シナリオを開始する"
        },
    };


    public string[][][] LovecraftQuotes =
    {
        new []
        {
            new []
            {
                "It is absolutely necessary, for the peace and safety of mankind, that some of earth's dark, dead corners and unplumbed depths be let alone.",
                "Во имя мира и благополучия человечества оставим в покое иные тёмные, глухие уголки Земли и её неведомые глубины.",
                "人類の平和と安全のために、地球の暗い、隠れたいくつかの角や、計り知れない深淵については、絶対手をつけてはならない"
            },
            new []
            {
                "– H.P. Lovecraft, <i>At the Mountains of Madness</i>",
                "— Г. Ф. Лавкрафт, «Хребты безумия»",
                "-Ｈ・Ｐ・ラブクラフト, <i>狂気の山脈にて</i>"
            },
        },
        new []
        {
            new []
            {
                "The oldest and strongest emotion of mankind is fear. And the oldest and strongest kind of fear is fear of the unknown.",
                "Страх — самое древнее и сильное из человеческих чувств, а самый древний и самый сильный страх — страх неведомого.",
                "人類の最も古く、最も強い感情は恐怖である。そして恐怖の中で最も強い感情は、未知への恐怖である"
            },
            new []
            {
                "– H.P. Lovecraft",
                "— Г. Ф. Лавкрафт",
                "Ｈ・Ｐ・ラブクラフト"
            },
        },
        new []
        {
            new []
            {
                "That is not dead which can eternal lie, And with strange aeons even death may die.",
                "Не мёртво то, что в вечности живёт, со смертью времени и смерть умрёт.",
                "かれは永遠に横たわる死者にあらじ。永劫の末には死もまた消滅せり。"
            },
            new []
            {
                "– H.P. Lovecraft, <i>The Nameless City</i>",
                "— Г. Ф. Лавкрафт, «Безымянный город»",
                "-Ｈ・Ｐ・ラブクラフト, <i>無名都市</i>"
            },
        },
        new []
        {
            new []
            {
                "Sometimes I believe that this less material life is our truer life, and that our vain presence on the terraqueous globe is itself the secondary or merely virtual phenomenon.",
                "Порой мне кажется, что именно та жизнь является подлинной, а наше суетное существование на земле — явление вторичное или даже мнимое.",
                "時々私は、この実体の薄い世界こそが真の世界であると、水と陸地からなるこの球体にいる、空虚な存在である我々のほうが第二の存在、または単なる仮想の存在であると、信じてしまうのだ。"
            },
            new []
            {
                "– H.P. Lovecraft, <i>Beyond the Wall of Sleep</i>",
                "— Г. Ф. Лавкрафт, «За стеной сна»",
                "-Ｈ・Ｐ・ラブクラフト, <i>眠りの壁の彼方</i>"
            },
        },
        new []
        {
            new []
            {
                "We shall see that at which dogs howl in the dark, and that at which cats prick up their ears after midnight.",
                "Мы узреем причину, по которой ночью воют собаки, а кошки навостряют слух.",
                "夜半過ぎ、犬が暗闇の中で吠える相手を、猫が耳をピンと立てる相手を、我々は見ることになるだろう。"
            },
            new []
            {
                "– H.P. Lovecraft, <i>From Beyond</i>",
                "— Г. Ф. Лавкрафт, «Из глубин мироздания»",
                "-Ｈ・Ｐ・ラブクラフト, <i>彼方より</i>"
            },
        },
        new []
        {
            new []
            {
                "From even the greatest of horrors irony is seldom absent. Sometimes it enters directly into the composition of the events, while sometimes it relates only to their fortuitous position among persons and places.",
                "Даже самые леденящие душу ужасы редко обходятся без иронии. Порою она входит в них как составная часть, порою, по воле случая, бывает связана с их близостью к тем или иным лицам и местам.",
                ""
            },
            new []
            {
                "– H.P. Lovecraft, <i>The Shunned House</i>",
                "— Г. Ф. Лавкрафт, «Заброшенный дом»",
                "-Ｈ・Ｐ・ラブクラフト, <i>忌み嫌われる家</i>"
            },
        },
        new []
        {
            new []
            {
                "The most merciful thing in the world, I think, is the inability of the human mind to correlate all its contents. We live on a placid island of ignorance in the midst of black seas of infinity, and it was not meant that we should voyage far.",
                "Проявлением наибольшего милосердия в нашем мире является, на мой взгляд, неспособность человеческого разума связать воедино всё, что этот мир в себя включает. Мы живем на тихом островке невежества посреди тёмного моря бесконечности, и нам вовсе не следует плавать на далёкие расстояния.",
                "最も巨大な恐怖の中でさえ、皮肉は存在する。時々、それは出来事の枠の中に直接入り込んでしまったり、または時々、人々と場所との関わりの中に、偶然関係してきたりするのだ。"
            },
            new []
            {
                "– H.P. Lovecraft, <i>The Call of Cthulhu</i>",
                "— Г. Ф. Лавкрафт, «Зов ктулху»",
                "-Ｈ・Ｐ・ラブクラフト, <i>クトゥルフの呼び声</i>"
            },
        },
        new []
        {
            new []
            {
                "There was thunder in the air on the night I went to the deserted mansion atop Tempest Mountain to find the lurking fear.",
                "В ночь, когда я направлялся в заброшенный особняк на Горе Бурь, чтобы понять, что же такое этот затаившийся страх, в небе гремели грозовые раскаты.",
                "この世界で最も慈悲深いことは、思うに、人間の心に物事を関連付ける能力がないことだろう。我々は無限の暗黒の海原のただ中にある、無知の平穏な島で生きているようなものだ。そして我々は島を離れ、遠くに航海すべきではない。"
            },
            new []
            {
                "– H.P. Lovecraft, <i>The Lurking Fear</i>",
                "— Г. Ф. Лавкрафт, «Затаившийся Страх»",
                "-Ｈ・Ｐ・ラブクラフト, <i>潜み棲む恐怖</i>"
            },
        },
    };
    
    public string[][] jaggedArrayStats =
    {
        // ...LabelStrength
        new []
        {
            "strength",
            "сила",
            "力 (strength)"
        }, 
        // ...LabelAgility
        new []
        {
            "agility",
            "ловкость",
            "機敏 (agility)"
        }, 
        // ...LabelObservation
        new []
        {
            "observation",
            "наблюдательность",
            "観察 (observation)"
        }, 
        // ...LabelLore
        new []
        {
            "lore",
            "знания",
            "伝承 (lore)"
        }, 
        // ...LabelInfluence
        new []
        {
            "influence",
            "влиятельность",
            "影響 (influence)"
        }, 
        // ...LabelWill
        new []
        {
            "will",
            "воля",
            "意志 (will)"
        }, 
        // ...LabelWound
        new []
        {
            "wound",
            "рана",
            "創傷 (wound)"
        }, 
        // ...LabelHorror
        new []
        {
            "horror",
            "ужас",
            "ホラー (horror)"
        }, 
    };

    // first array for name
    // second array for ability and it's translations
    // third array for stats
    public string[][][] backgrounds =
    {    /*
        new []
        {
            new [] { "" },
            new [] { "", "", "" },
            new [] { "","","","","","","","" },
        },*/
        new []
        {
            new [] { "The Drifter" },
            new [] { "You begin the game with 'Duke' unique item", "", "" },
            new [] { "7","7","4","4","4","3","2","4",},
        },
        new []
        {
            new [] { "The Parapsychologist" },
            new [] { "After you resolve the Horror check gain 1 Clue", "", "" },
            new [] { "5","9","2","3","4","5","3","4", },
        },
        new []
        {
            new [] { "The Waitress" },
            new [] { "You begin the game with 'Storm of spirits' Spell", "", "" },
            new [] { "7","7","2","3","4","5","4","3", },
        },
        new []
        {
            new [] { "The Shaman" },
            new [] { "Effects cannot make you discard clues", "", "" },
            new [] { "6","8","3","2","4","4","3","5", },
        },
        new []
        {
            new [] { "The Student" },
            new [] { "You may preform two additional puzzle steps while attempting an puzzle", "", "" },
            new [] { "7","7","3","3","4","4","3","4", },
        },
        new []
        {
            new [] { "The Salesman" },
            new [] { "Once per round, when you spend an action to interact with person, you may flip 1 Horror facedown or discard 1 facedown Horror", "", "" },
            new [] { "7","7","3","3","4","2","5","4", },
        },
        new []
        {
            new [] { "The Psychologist" },
            new [] { "Action: You or another Investigator withing same space flip 1 Horror facedown or discard 1 facedown Horror", "", "" },
            new [] { "6","8","3","2","4","3","4","5", },
        },
        new []
        {
            new [] { "The Butler" },
            new [] { "Action: Once per round another Investigator within range may preform 1 more action.", "", "" },
            new [] { "8","6","3","2","5","4","4","3", },
        },
        new []
        {
            new [] { "The Politician" },
            new [] { "Once per test, while within a Person or another Investigator, you may convert an Clue to Success", "", "" },
            new [] { "5","9","3","2","4","3","5","4", },
        },
        new []
        {
            new [] { "The Mechanic" },
            new [] { "The the puzzle is solved you gain 2 Clues and discard 1 Horror", "", "" },
            new [] { "8","6","5","4","3","3","3","3", },
        },
        new []
        {
            new [] { "The Photographer" },
            new [] { "Once per round when you gain Clue, you can become Focused instead", "", "" },
            new [] { "8","6","3","4","5","3","3","3", },
        },
        new []
        {
            new [] { "The Magician" },
            new [] { "Once per round, when you gain spell, become Focused", "", "" },
            new [] { "6","8","3","3","3","5","4","3", },
        },
        new []
        {
            new [] { "The Reformed Cultist" },
            new [] { "If you would suffer 2 or more Horror, suffer 1 fewer instead", "", "" },
            new [] { "8","6","3","4","4","5","4","2", },
        },
        new []
        {
            new [] { "The Priest" },
            new [] { "Action, once per round: Another Investigator within space becomes Focused", "", "" },
            new [] { "6","8","3","3","2","4","4","5", },
        },
        new []
        {
            new [] { "The Bootlegger" },
            new [] { "Once per round you may move 1 space before or after performing Search action", "", "" },
            new [] { "8","6","3","3","4","3","4","4", },
        },
        new []
        {
            new [] { "The Author" },
            new [] { "At the start of the turn, if you have no Clues, gain 1 Clue", "", "" },
            new [] { "7","7","2","3","4","4","4","4", },
        },
        new []
        {
            new [] { "The Professor" },
            new [] { "Action, once per round: Another Investigator within space gains 1 Clue", "", "" },
            new [] { "5","9","3","2","4","4","4","4", },
        },
        new []
        {
            new [] { "The Dilettante" },
            new [] { "If you have no Clues, gain 2 Clues and discard 1 Horror", "", "" },
            new [] { "8","6","3","4","3","3","5","3", },
        },
        new []
        {
            new [] { "The Musician" },
            new [] { "You begin the game with the 'Golden Trumpet' Unique Item", "", "" },
            new [] { "6","8","3","3","3","4","4","4", },
        },
        new []
        {
            new [] { "The Private Eye" },
            new [] { "If you spend a Clue, you may convert it twice instead", "", "" },
            new [] { "8","6","4","5","3","3","3","3", },
        },
        new []
        {
            new [] { "The Scientist" },
            new [] { "You begin the game with 'Flux Stabilizer' Unique Item", "", "" },
            new [] { "6","8","3","3","5","4","3","3", },
        },
        new []
        {
            new [] { "The Expedition Leader" },
            new [] { "Once per round when you perform Move action, another investigator may move 1 Space", "", "" },
            new [] { "7","7","4","4","4","2","3","4", },
        },
        new []
        {
            new [] { "The Martial Artist" },
            new [] { "While you are attacking unarmed, if a monster suffers 1 or more damage, it suffers 2 additional damage", "", "" },
            new [] { "7","7","4","4","3","3","3","4", },
        },
        new []
        {
            new [] { "The Researcher" },
            new [] { "Once per round, when you gain a Clue, gain 1 more Clue", "", "" },
            new [] { "6","8","2","3","5","4","4","3", },
        },
        new []
        {
            new [] { "The Entertainer" },
            new [] { "At the start of your turn, you may cast a Spell without spending an action", "", "" },
            new [] { "6","8","3","4","2","4","5","3", },
        },
        new []
        {
            new [] { "The Gangster" },
            new [] { "Whenever is monster is defeated, become Focused", "", "" },
            new [] { "9","5","5","3","4","2","3","4", },
        },
        new []
        {
            new [] { "The Secretary" },
            new [] { "Once per round: you or another Investigator in same space may reroll 1 die while rerolling a test", "", "" },
            new [] { "7","7","3","4","4","3","4","3", },
        },
        new []
        {
            new [] { "The Archaeologist" },
            new [] { "Other Investigators in your space do not need to evade monsters", "", "" },
            new [] { "8","6","5","3","4","3","3","3", },
        },
        new []
        {
            new [] { "The Astronomer" },
            new [] { "Action, once per round: if you are in outdoor space gain 2 Clues or discard 1 Horror", "", "" },
            new [] { "6","8","3","3","4","4","2","5", },
        },
        new []
        {
            new [] { "The Millionaire" },
            new [] { "Once per round, when you gain an Item,you may flip 1 Horror facedown or discard 1 facedown Horror", "", "" },
            new [] { "7","7","4","4","3","2","5","3", }, // wrong health/sanity
        },
        
        new []
        {
            new [] { "The Athlete" },
            new [] { "You may move 1 additional space when preforming Move action", "", "" },
            new [] { "9","5","5","4","3","3","2","4", },
        },
        new []
        {
            new [] { "The Sailor" },
            new [] { "Once per round, you may flip 1 Horror face up to reroll all of your dice while resolving a test", "", "" },
            new [] { "9","5","4","5","4","2","3","3", },
        },
        new []
        {
            new [] { "The Nun" },
            new [] { "Once per round, another investigator may convert an Clue dice to Success while resolving a test", "", "" },
            new [] { "6","8","3","3","3","4","3","5", },
        },
        new []
        {
            new [] { "The Rookie Cop" },
            new [] { "You begin the game with 'Becky' Unique Item", "", "" },
            new [] { "7","7","4","4","4","2","4","3", },
        },
        new []
        {
            new [] { "The Spy" },
            new [] { "Once per round you may convert up to two Clue dices to Success while performing Search action", "", "" },
            new [] { "8","6","4","4","5","2","3","3", },
        },
        new []
        {
            new [] { "The Explorer" },
            new [] { "Once per round, you may move 1 space before or after Explore action or resolving effects of Sight Token", "", "" },
            new [] { "7","7","3","4","4","4","3","3", },
        },
        new []
        {
            new [] { "The Doctor" },
            new [] { "Action: you or another Investigator in same space flip 1 Damagr facedown or discard 1 facedown Damage", "", "" },
            new [] { "8","6","4","2","4","3","4","4", },
        },
        new []
        {
            new [] { "The Urchin" },
            new [] { "You cannot become Stunned or Restrained", "", "" },
            new [] { "6","8","3","5","4","3","3","3", },
        },
        new []
        {
            new [] { "The Gravedigger" },
            new [] { "Whenever a monster is defeated gain 1 Clue", "", "" },
            new [] { "7","7","4","3","4","3","3","4", },
        },
        new []
        {
            new [] { "The Handyman" },
            new [] { "After you resolve a Horror check, become Focused", "", "" },
            new [] { "8","6","5","4","3","2","4","3", },
        },
    };
    
    // stressed
    public string conditionStressed = 
        "Stressed \n After rerolling and converting dice results while resolving a test, you must remove 1 {*} from your dice pool. " +
        "At the end of your turn, discard this card.";
    public string conditionDazed = 
        "Dazed \n You cannot spend {clue} to convert dice results or perform additional puzzle steps. " +
        "At the end of your turn, discard this card.";
    public string conditionFocused = 
        "Focused \n You may discard this card to convert all {clue} to {*} while resolving a test.";
    public string conditionRestrained = 
        "Restrained \n You cannot move voluntarily. At the end of your turn, discard this card.";
    public string conditionRighteous = 
        "Righteous \n Once per round, you may convert an O to a When you suffer 1 or more Horror, discard this card.";
    public string conditionStunned = 
        "Stunned \n You cannot perform more than a single action during your turn. At the end of your turn, discard this card.";
    public string conditionWounded = 
        "Wounded \n You cannot perform the move action more than once each round. When you have suffered Damage equal to your health, you are eliminated.";
    public string conditionFearless =
        "Fearless \n Effects cannot cause you to suffer Horror unless you choose to. At the end of your turn, discard this card.";

    // lost in time and space
    public string conditionLost = 
        "Lost in Time and Space \n Remove your figure from the board. You are unaffected by other game effects and cannot perform other actions. " +
        "Action: You attempt to find your way. Flip this card.";
    public string conditionLostFuture = 
        "THE FUTURE \n The people of this era claim to have small devices that can guide you ({bond}; 2). " +
        "If you pass, you convince them to help, but are horrified at the breadth of knowledge they command; suffer 1 facedown Horror. " +
        "Then place your investigator figure in any explored space and discard this card. " +
        "If you fail, you attempt to use the device yourself and fail; discard this card and become Lost in Time and Space.";
    public string conditionLostPast =
        "THE PAST \n You recall an anomaly in this time period and try to access it safely ({wisdom}; 2). " +
        "If you pass, the anomaly you recall has a price; suffer 1 facedown Damage. " +
        "Then place your investigator figure in any explored space and discard this card. " +
        "If you fail, you remember the steps incorrectly and must face the consequences; " +
        "discard this card and become Lost in Time and Space.";
    public string conditionLostCity =
        "CITY OF THE GREAT RACE \n The denizens of this world are welcoming, but you feel uneasy ({perception}; 2). " +
        "If you pass, you realize the creatures would keep you; suffer 1 facedown Horror. " +
        "Then place your investigator figure in any explored space and discard this card. " +
        "If you fail, the creatures swap your consciousness with one of their own for a time; " +
        "discard this card and become Lost in Time and Space.";
    public string conditionLostYuggoth =
        "YUGGOTH \n The terraced, black-stone towers of this world are hard to maneuver around ({agility}; 2). " +
        "If you pass, you stumble only occasionally; suffer 1 facedown Damage. " +
        "Then place your investigator figure in any explored space and discard this card. " +
        "If you fail, you become hopelessly lost and escape at your earliest opportunity; " +
        "discard this card and become Lost in Time and Space.";
    public string conditionLostRlyeh =
        "R’LYEH \n You find yourself in a strange, submerged city and try not to panic ({mind}; 2). " +
        "If you pass, you recognize some symbols on the non-Euclidean buildings and escape; " +
        "place your investigator figure in any explored space and discard this card. " +
        "If you fail, you flail in the water until you collide with a strange artifact; " +
        "discard this card and become Lost in Time and Space.";

    // poisoned
    public string conditionPoisoned =
        "Poisoned \n At the end of your turn, suffer 1 facedown Damage. Then flip this card.";
    public string conditionPoisonedNeurotoxin =
        "NEUROTOXIN \n Spots and visions appear before you as the venom reaches your brain ({perception}; 2). " +
        "If you pass, you manage to keep your wits about you while administering the antivenom; " +
        "discard this card. If you fail, your hands tremble too violently to successfully cure yourself; " +
        "discard this card and become Poisoned.";
    public string conditionPoisonedCardiotoxin = 
        "CARDIOTOXIN \n Your muscles grow weak, and open sores spread over your flesh ({consitution}; 2). " +
        "If you pass, you drive the needle through undamaged skin; discard this card. " +
        "If you fail, every movement aggravates your weeping wounds; discard this card and become Poisoned.";
    public string conditionPoisonedCytotoxin =
        "CYTOTOXIN \n You try to remember how to apply the antidote ({wisdom}; 2). " +
        "If you pass, you realize it is not as difficult as it seems; " +
        "discard this card. If you fail, you cannot recall the proper treatment through the haze of agony; " +
        "discard this card and become Poisoned.";
    public string conditionPoisonedDendrotoxin = 
        "DENDROTOXIN \n You feel a sharp pain in the back of your head as your lips start to go numb ({mind}; 2). " +
        "If you pass, you struggle to stay oriented as you inject the antivenom into your skin; discard this card. " +
        "If you fail, a sudden and powerful headache commands all of your attention; discard this card and become Poisoned.";
    public string conditionPoisonedHemotoxin = 
        "HEMOTOXIN \n The wound from the bite feels like it is on fire ({agility}; 2). " +
        "If you pass, you swiftly administer the antivenom before the flames spread; discard this card. " +
        "If you fail, the burning sensation is too great and you cannot control the tremors; " +
        "discard this card and become Poisoned.";

    // insane
    public string conditionInsane = 
        "Insane \n Look at the back of this card but do not reveal it to the other investigators. " +
        "When you have suffered Horror equal to your sanity, you are eliminated.";
    public string conditionInsaneCalculating = 
        "CALCULATING \n Trust in your companions is unnecessary. This proof will be your insurance. " +
        "You do not win the game as normal. Instead, you win only if the investigation is complete and you have more Evidence than than {player_name}. " +
        "Otherwise, you lose the game.";
    public string conditionInsaneEnvious = 
        "ENVIOUS \n The sight of other people having more than you is unacceptable. " +
        "Everything should be yours. You do not win the game as normal. " +
        "Instead, you win only if the investigation is complete and you have more Items than {player_name}. Otherwise, you lose the game.";
    public string conditionInsaneDisciple = 
        "FERVID DISCIPLE \n The common rabble do not deserve such power, but your devotion is unquestionable. " +
        "You do not win the game as normal. Instead, you win only if the investigation is complete and you have more Spells than {player_name} " +
        "Otherwise, you lose the game.";
    public string conditionInsanePact = 
        "PACT WITH YOG-SOTHOTH \n The Lurker at the Threshold has promised you great knowledge in exchange for a small price. " +
        "You are ready to learn the first and last secret. You do not win the game as normal. " +
        "At the start of your turn, if you have a Spell and you are in a space with exactly 1 other investigator, you immediately win the game and the game ends. " +
        "If the game ends for any other reason, you lose the game.";
    public string conditionInsanePassive = 
        "PASSIVE \n You do not want to start a disagreement. Arguing now just wastes precious time and resources. " +
        "It is not like anyone would take your side anyway. You cannot verbally disagree with any other player. You win or lose the game as normal.";
    public string conditionInsanePrepared = 
        "PREPARED \n You know now that anything can go wrong at any moment. " +
        "Without the proper tools, all might be lost. You do not win the game as normal. " +
        "Instead, you win only if the investigation is complete and you have 1 or more Bladed Weapons or Light Sources.";
    public string conditionArcaneAspirations = 
        "ARCANE ASPIRATIONS \n Regular weapons are useless against the powers that are aligned against you. " +
        "The only thing that can keep you safe from otherworldly harm is otherworldly protection. " +
        "You do not win the game as normal. Instead, you win only if the investigation is complete and you have l or more Spells. Otherwise, you lose the game.";
    public string conditionInsaneSuspicious = 
        "SUSPICIOUS \n Your friends glance at you, distrust in their eyes. No effect. You win or lose the game as normal.";
    public string conditionInsaneTruth = 
        "SPREAD THE TRUTH \n No one believes you, but you have seen it. The truth is out there. " +
        "You do not win the game as normal. Instead, you win only if the investigation is complete and you have two or more Evidence Unique Items. Otherwise, you lose the game.";
    public string conditionInsaneGreaterGood = 
        "FOR THE GREATER GOOD \n You have gazed too far into the abyss and fought too long with monsters. " +
        "There is no room for you in the better world you fight to preserve. Best if you not live to see it. " +
        "You do not win the game as normal. Instead, you win only if the investigation is complete and you have been eliminated. Otherwise, you lose the game.";
    public string conditionInsaneObsessive = 
        "OBSESSIVE \n You must find it. You do not know what it is, but when you see it, you will know and finally have some peace. " +
        "You do not win the game as normal. Instead, you win only if the investigation is complete and there are no Search tokens on the board. Otherwise, you lose the game.";
    public string conditionInsaneThousand = 
        "ONE OF THE THOUSAND \n You must make a sacrifice to the Black Goat of the Woods! Tä! Tä! Shub-Niggurath fhtagn! You do not win the game as normal. " +
        "At the start of your turn, if you have a Bladed Weapon and you are in a space with exactly one other investigator, you immediately win the game and the game ends. " +
        "If the game ends for any other reason, you lose the game.";
    public string conditionInsaneConscience = 
        "CRISIS OF CONSCIENCE \n It is clear that you and your companions are here meddling in things you do not understand. " +
        "There is a natural order to the universe, and who are you to determine its course? You do not win the game as normal. " +
        "Instead, at the end of the game, you win if the investigation is not complete. Otherwise, you lose the game.";
    public string conditionInsaneMisery = 
        "MISERY LOVES COMPANY \n They are laughing at your misfortune. You can tell. But they will not laugh for very much longer... " +
        "You do not win the game as normal. Instead, you win only if the investigation is complete and one or more other investigators are Wounded or Insane. " +
        "Otherwise, you lose the game.";
    public string conditionInsaneForbiddenWords = 
        "FORBIDDEN WORDS \n You fear words will be your downfall, and you think to yourself that you shall never speak again. " +
        "You cannot speak words in any way. You win or lose the game as normal.";
    public string conditionInsaneRestlessAnxiety = 
        "RESTLESS ANXIETY \n You are suddenly stricken with the sense that your life up to this point has been not only boring but pointless. " +
        "Life is too short to not experience as much of the world as possible. Variety is the spice of life after all! " +
        "You cannot perform any single action more than once each round. You win or lose the game as normal."; 
    public string conditionInsaneNarcissism = 
        "NARCISSISM \n It seems self-evident that you deserve to have all those lovely things, certainly more than anyone else deserves them. And why not? " +
        "You worked hard to get where you are! You do not win the game as normal. Instead, at the end of the game, you win if you have 6 or more Items. Otherwise, you lose the game.";
    public string conditionInsaneSelfishMotives =
        "SELFISH MOTIVES \n You do not trust your ''friends'', and you sure as hell will not sacrifice  yourself for them. You do not win the game as normal. " +
        "Instead, you win only if the investigation is complete and you are not Wounded. Otherwise, you  lose the game. ";
    public string conditionInsanePyromania = 
        "PYROMANIA \n Fire keeps you warm, and it keeps away the darkness. The only way you will be safe is if you light as many beautiful, beautiful fires as you can. " +
        "You do not win the game as normal. At the start of your turn, if 6 or more rooms contain Fire, you immediately win the game and the game ends. " +
        "If the game ends for any other reason, you lose the game.";
    public string conditionInsaneDevotee = 
        "SILVER TWILIGHT DEVOTEE \n The Order of the Silver Twilight has need of the information and artifacts you uncover. You do not win the game as normal. " +
        "Instead, you win only if the investigation is complete and you have 1 or more Bladed Weapons and 1 or more Unique Items. Otherwise, you lose the game.";
    public string conditionInsaneAggressive = 
        "AGGRESSIVE \n You cannot agree with these people. They insist on wasting precious time and resources. " +
        "Someone has to advocate for the devil or important matters may be overlooked. You must start each of your sentences with the word 'No.' " +
        "You win or lose the game as normal.";
    public string conditionInsaneParalyzingFear = 
        "PARALYZING FEAR \n Get close to-that!? No! Absolutely not! You cannot voluntarily move into a space that contains 1 or more monsters. You win or lose the game as normal.";
    public string conditionInsaneLost = 
        "RIGHT TIME, RIGHT PLACE \n Uou just want to be home. You do not win the game as normal. " +
        "Instead, you win only if the investigation is complete and you are not Lost in Time and Space. Otherwise, you lose the game.";
    public string conditionInsaneHybrid = 
        "DEEP ONE HYBRID \n Your ancestors trace back to Y’ha-nthlei and Innsmouth. They demand that you prove your worth. " +
        "You do not win the game as normal. Instead, at the end of the game, you win if the investigation is not complete and you have 2 or more Evidence.";

    // mesmerized
    public string conditionMesmerized = 
        "Mesmerized \n At the end of your turn, an alien will takes control; flip this card.";
    public string conditionMesmerizedDeadWeight = 
        "DEAD WEIGHT \n These things are so heavy. They are weighing you down. You must get rid of them immediately. " +
        "Suffer 1 facedown Horror unless you drop an Item. Then discard this card.";
    public string conditionMesmerizedFriendlyAdvice = 
        "FRIENDLY ADVICE \n Your friends do not realize what power truly means. You must tell them of the glory that awaits them. " +
        "Move 2 spaces toward another random investigator. Then discard this card.";
    public string conditionMesmerizedRelativeSafety = 
        "RELATIVE SAFETY \n What lies beneath friendly faces. Your companions have secrets of their own. " +
        "You must leave them. Move 2 spaces away from another random investigator. Then discard this card.";
    public string conditionMesmerizedArcaneDanger = 
        "ARCANE DANGER \n Knowledge has roots in dark and dangerous practices. " +
        "You must consider which risks are worth taking. Suffer 1 facedown Horror unless you drop a Spell. Then discard this card.";
    public string conditionMesmerizedToAsh = 
        "TO ASH \n Nothing is as it should be. Everything must be rebuilt. You must prepare this world for rebuilding. Place Fire in your space. Then discard this card.";

    // horror
    public string horrorMinorShock = 
        "Minor Shock \n Ah! Your heart races, and your breath catches in your throat. " +
        "Resolve Immediately. No additional effect. Flip this card facedown.";
    public string horrorAbsoluteTerror = 
        "Absolute Terror \n The only thing louder than your pounding heart is your desperate, ragged breathing. " +
        "Resolve Immediately. Suffer 1 additional facedown Horror. Then flip this card facedown.";
    public string horrorSuddenShock = 
        "Sudden Shock \n Gasping in surprise and fear, you clutch at your face, forgetting for a moment what you had been holding only seconds before. " +
        "Resolve Immediately. Drop 2 random Items. Then flip this card facedown.";
    public string horrorPanic = 
        "Panic \n You scream, leaping desperately away, and tumble to the ground. " +
        "Resolve Immediately. Suffer 1 additional facedown Damage. Then flip this card facedown.";
    public string horrorHysteria =
        "Hysteria \n Screaming hysterically, you claw at your own flesh with your nails. " +
        "Resolve Immediately. Flip 1 Damage faceup. Then flip this card facedown.";
    public string horrorParanoia = 
        "Paranoia \n Every noise makes you startle and jump. Even your companions unnerve you. " +
        "Keep Faceup. Whenever you end your turn within range of another investigator, flip 1 Horror faceup.";
    public string horrorSqueamish = 
        "Squeamish \n Even the sight of blood turns your stomach. " +
        "Keep Faceup. After you perform an attack action, flip 1 Horror faceup.";
    public string horrorTerribleTruths = 
        "Terrible Truths \n The horrifying things that flash through your mind can be put to good use. " +
        "Resolve Immediately. Gain 1 {clue}. Then flip this card facedown.";
    public string horrorWeakWilled = 
        "Weak-willed \n You feel something sinister take root within your mind. " +
        "Resolve Immediately. Become Mesmerized. Then flip this card facedown.";
    public string horrorClaustrophobia = 
        "Claustrophobia \n It is too close in here, too tight. You cannot breathe. You must get to open air. " +
        "Keep Faceup. Whenever you end your turn within range of 2 or fewer spaces, suffer 1 facedown Horror.";
    public string horrorAcalculia = 
        "Acalculia \n You cannot seem to put the letters or numbers in their proper order. You know you had this skill once, but it has deserted you." +
        "Keep Faceup. Roll 1 fewer die while resolving a {wisdom} test.";
    public string horrorHallucinations = 
        "Hallucinations \n Everywhere you look you see horrible shadows or ghosts from your past. You cannot bear to look any longer. " +
        "Keep Faceup. Roll 1 fewer die while resolving an {perception} test.";
    public string horrorFrayedNerves = 
        "Frayed Nerves \n You breathe deeply, but it fails to restore your calm. You feel as if the slightest thing will push you over the edge. " +
        "Keep Faceup. Roll 1 fewer die while resolving a {mind} test.";
    public string horrorNyctophobia = 
        "Nyctophobia \n You are not afraid of the darkness, exactly. But you are afraid of what the darkness might be concealing. " +
        "Keep Faceup. Whenever you end your turn in a space with Darkness, suffer 1 facedown Horror.";
    public string horrorCowerInFear = 
        "Cower in Fear \n You scramble into a corner and hide there, just for a little while. " +
        "Resolve Immediately. Become Stunned. Then discard this card.";
    public string horrorKleptomania = 
        "Kleptomania \n You do not understand why you need to keep stealing things, but you cannot help yourself. " +
        "Keep Faceup. Whenever you end your turn in a space with another investigator, take 1 Item at random from another investigator in your space.";
    public string horrorShriekingFit = 
        "Shrieking Fit \n You scream and scream and scream, and then you cry and cry, and then giggle, and then hiccough. " +
        "Resolve Immediately. Become Restrained. Then discard this card.";
    public string horrorDisoriented = 
        "Disoriented \n our wits desert you, leaving you mumbling and uncertain. How could what you have just seen be real? " +
        "Resolve Immediately. Become Dazed. Then flip this card facedown.";
    public string horrorSteelyResolve = 
        "Steely Resolve \n You swallow your fear and take a deep breath. " +
        "Resolve Immediately. Become Focused. Then flip this card facedown.";
    public string horrorHorrificArcana = 
        "Horrific Arcana \n You whimper as your mind rejects the impossible. " +
        "Resolve Immediately. Suffer 1 additional facedown Horror for each Spell you have. Then flip this card facedown.";
    public string horrorDementia = 
        "Dementia \n You turn away, already feeling the fog of memory clouding your mind. It is a mercy, truly. " +
        "Resolve Immediately. Discard 1 {clue}. Then flip this card facedown.";
    public string horrorStartled =
        "Startled \n You stagger backward in alarm. " +
        "Resolve Immediately. No effect. Discard this card.";
    public string horrorFlashback = 
        "Flashback \n Recent memories claw their way to the surface, despite your best efforts. " +
        "Resolve Immediately. Flip 1 other Horror faceup. Then discard this card.";
    public string horrorFervor = 
        "Fervor \n Adversity only stokes the fire of your resolve to make things right again, no matter what. " +
        "Resolve Immediately. Become Righteous. Then flip this card facedown.";
    public string horrorMediocrity =  
        "Mediocrity \n It will never matter what you do, because people like you can never become heroes. " +
        "Keep faceup. You cannot improve any skill.";
    public string horrorRegression = 
        "Regression \n Life was bliss when you were young. If only you could go back to that time. " +
        "Resolve Immediately. Discard 1 Improvement. Then discard this card.";
    public string horrorAnxiety= 
        "Anxiety \n Your worries are overwhelming. What can one person do against so much evil? " +
        "Resolve Immediately. Become Stressed. Then discard this card.";
    public string horrorPhotophobia =
        "Photophobia \n The light burns, and you instinctively lash out to destroy the source of your pain. " +
        "Resolve Immediately. Place Darkness in your space. Then flip this card facedown.";
    public string horrorAwareOfTheVoid = 
        "Aware of the Void \n Traumatized by your experiences, you wish nothing more than to escape the here and now... " +
        "Resolve Immediately. Become Lost in Time and Space. Then discard this card.";
    public string horrorFearTheUnknown = 
        "Fear the Unknown \n You do not want to know what happens next. " +
        "Keep Faceup. Whenever you end your turn become Lost in Time and Space, flip 1 Horror faceup.";
    
    // wound
    public string woundMinorInjury = 
        "Minor Injury \n Only a flesh wound. " +
        "Resolve Immediately. No additional effect. Flip this card facedown.";
    public string woundScratch = 
        "Just a Scratch \n You thought the wound was much deeper than it is. " +
        "Resolve Immediately. No effect. Discard this card.";
    public string woundFeeble = 
        "Feeble \n Bruises mottle your body, tender and aching at the slightest touch. " +
        "Keep Faceup. You cannot move a Barricade.";
    public string woundPainfulClarity = 
        "Painful Clarity \n The pain cuts through your muddled thoughts, allowing you to see the solution clearly. " +
        "Resolve Immediately. Gain 1 Clue. Then flip this card facedown.";
    public string woundHeadTrauma =
        "Head Trauma \n Your thoughts spin out of your control, knocked loose by the latest blow." +
        "Resolve Immediately. Become Mesmerized. Then flip this card facedown.";
    public string woundFogOfPain = 
        "Fog of Pain \n You know you could achieve more if only your injuries would stop throbbing. " +
        "Resolve Immediately. Discard 1 Improvement. Then discard this card.";
    public string woundThirstForJustice = 
        "Thirst for Justice \n Even though you are injured, your only thought is to see justice carried out. " +
        "Resolve Immediately. Become Righteous. Then flip this card facedown.";
    public string woundExhaustion = 
        "Exhaustion \n As the night drags on, you feel the details of your investigation slipping away." +
        "Keep Faceup. When you gain a Condition, discard 1 Clue.";
    public string woundOldInjuries = 
        "Old Injuries \n You avoid the worst of it, but you aggravate an older injury. " +
        "Resolve Immediately. Flip 1 other Damage faceup. Then discard this card.";
    public string woundDisfigured = 
        "Disfigured \n You cannot bring yourself to look in a mirror. The look on people's fạces tells you all you need to know. " +
        "Keep Faceup. Roll 1 fewer die while resolving an {bond} test.";
    public string woundGutShot = 
        "Gut Shot \n All the breath leaves your body in a whoosh as the blow catches you in the stomach. You wheeze and gasp for air. " +
        "Resolve Immediately. Become Stunned. Then discard this card.";
    public string woundLastingInjury = 
        "Lasting Injury \n Blood oozes from the wound and trickles down your arm, no matter what you do. " +
        "Keep Faceup. No effect. Keep this card faceup.";
    public string woundMuscleTear = 
        "Muscle Tear \n When you stand still, the pain is a dull throb. When you move, it is sharp agony. " +
        "Keep Faceup. Roll 1 fewer die while resolving a {constitution} test.";
    public string woundRupturedEardrum = 
        "Ruptured Eardrum \n After the splitting pain and partial deafness, you find that your balance is off. " +
        "Keep Faceup. Roll 1 fewer die while resolving an {agility} test.";
    public string woundStingingPain = 
        "Stinging Pain \n You pull your hand back from the pain, shaking and clenching your teeth. You drop whatever you were holding. " +
        "Resolve Immediately. Drop 2 random Items. Then flip this card facedown.";
    public string woundGrimResolve = 
        "Grim Resolve \n The injury is serious, but you will not allow it to slow you down. The stakes are too high for that. " +
        "Resolve Immediately. Become Focused. Then flip this card facedown.";
    public string woundBlowToTheHead = 
        "Blow to the Head \n Your vision swims with pulsing, painful light. " +
        "Resolve Immediately. Become Dazed. Then flip this card facedown.";
    public string woundTwistedAnkle = 
        "Twisted Ankle \n You fall, clutching your ankle and hissing in pain. You are not certain you can stand. " +
        "Resolve Immediately. Become Restrained. Then discard this card.";
    public string woundGrievousInjury = 
        "Grievous Injury \n The pain clouds your vision and sends you staggering. " +
        "Resolve Immediately. Suffer 1 additional facedown Damage. Then flip this card facedown.";
    public string woundConcussion = 
        "Concussion \n Your head feels clouded, as if your thoughts swim through a fog. " +
        "Resolve Immediately. Discard 1 Clue. Then flip this card facedown.";
    public string woundDemoralizingInjury = 
        "Demoralizing Injury \n You gag at the scent of your own blood. " +
        "Resolve Immediately. Suffer 1 additional facedown Horror. Then flip this card facedown.";
    public string woundLightHeaded = 
        "Light-headed \n The sight of your own blood makes your stomach turn over. Your breath becomes ragged for a moment." +
        "Resolve Immediately. Flip 1 Horror faceup. Then flip this card facedown.";
    public string woundBrokenLeg = 
        "Broken Leg \n You fall as pain lances up your leg. When you try to stand, you fall all over again. " +
        "Keep Faceup. If you move more than a single space as part of a move action, flip 1 Damage faceup.";
    public string woundBrokerArm = 
        "Broker Arm \n You cannot feel your arm at all. You think that this might be a bad sign. " +
        "Keep Faceup. If you ever have more than 2 Items, drop all but 2 of your Items.";
    public string woundBackSpasm = 
        "Back Spasm \n Pain flares up and down your back and suddenly you cannot stand up straight. " +
        "Resolve Immediately. Drop 1 random Item. Then flip this card facedown.";
    public string woundAchesAndPains = 
        "Aches and Pains \n The lingering ache of your wounds could be a sign of some deeper, unseen injury. " +
        "Resolve Immediately. Become Stressed. Then discard this card.";
    public string woundPinchedNerve = 
        "Pinched Nerve \n You feel a sharp pain followed by a sickening pop in your lower back as your legs go weak." +
        "Keep Faceup. At the end of your turn, if you have not performed the move action this round, flip this card facedown.";
    public string woundKnockedLoose = 
        "Knocked Loose \n The pain you feel transcends reality. " +
        "Resolve Immediately. Become Lost in Time and Space. Then discard this card.";
    public string woundMotionSickness = 
        "Motion Sickness \n The bile rises in your throat with every sudden shift. " +
        "Keep Faceup. You cannot spend Clues while resolving a {agility} or {constitution} test.";
    
    // unique items
    public string oilLamp = 
        "OIL LAMP \n Light Source \n The flame produced by the lamp is so beautiful that you begin to wish you could see it everywhere you look.";
    public string puzzleBox = 
        "PUZZLE Box \n Equipment \n The intricate patterns seem to shift and change as you move the panels. You cannot imagine what prize awaits you.";
    public string fluxStabilizer = 
        "FLUX STABILIZER \n Equipment \n At the start of your turn, move a monster within range up to 1 space.";
    public string duke =
        "DUKE \n Ally \n At the start of your turn, you may perform a trade action as if you are in any space within range.";
    public string becky = 
        "BECKY \n Firearm \n Once per round, you may reroll 1 die.";
    public string satchelOfTheVoid =
        "SATCHEL OF THE VOID \n Equipment \n Action: You slip the bag over the suspect's head ({wisdom}; 2). " +
        "If you pass, another investigator in your space becomes Lost in Time and Space.";
    public string goldenTrumpet = 
        "GOLDEN TRUMPET \n Equipment \n Action: Each investigator within range may discard 1 facedown Horror. " +
        "Activate this ability only once per round.";
    public string fuel = 
        "FUEL \n Equipment \n If it burns... ";
    public string rope = 
        "ROPE \n Equipment \n Action: You attempt to restrain the suspect ({constitution}; 2). " +
        "If you pass, flip this card and give it to another investigator in your space.";
    public string ropeActive = 
        "ROPE \n You struggle against your bonds, but the rope is too sturdy to break. You cannot move voluntarily. " +
        "This card cannot be dropped or traded. Action: You attempt to slip your bonds ({agility}; 2). " +
        "If you pass, you manage to escape; Flip this card. Any investigator in this space can perform this action.";
    public string handcuffs =
        "HANDCUFFS \n Equipment \n Action: You attempt to handcuff the suspect ({agility}; 2). " +
        "If you pass, flip this card and give it to another investigator in your space.";
    public string handcuffsActive = 
        "HANDCUFFS \n You struggle against the handcuffs to no effect. You will have to pick the lock. " +
        "You cannot spend Clues to convert dice results or perform additional puzzle steps. This card cannot be dropped or traded. " +
        "Action: You attempt to pick the lock ({perception}; 2). If you pass, you manage to escape your bonds; flip this card. " +
        "Any investigator in this space can perform this action.";
    public string fishingNet = "";
    public string fishingNetActive = 
        "FISHING NET \n You struggle under the woven rope, but cannot find your way out easily. You cannot move voluntarily. " +
        "This card cannot be dropped or traded. Action: You attempt to cast off the heavy rope ({constitution}; 2). " +
        "If you pass, you are freed from your confines; flip this card. Any investigator in this space can perform this action.";

    // evidence
    public string circumstantialEvidence = 
        "CIRCUMSTANTIAL EVIDENCE \n Evidence \n Just a bit more and this case is closed.";
    public string conclusiveEvidence = 
        "CONCLUSIVE EVIDENCE \n Evidence \n Irrefutable proof of the culprits involvement.";
    public string oldJournal = 
        "OLD JOURNAL \n Evidence \n This journal entry in the culprit's own handwriting is practically a confession.";
    public string grotesqueStone = 
        "GROTESQUE STONE \n Evidence \n Thousands of years seem to be recorded in this statue's dim and greenish surface of unrecognizable stone.";
    public string forensicEvidence = 
        "FORENSIC EVIDENCE \n Evidence \n Proof of the victim's identification.";
    public string incriminatingEvidence = 
        "INCRIMINATING EVIDENCE \n Evidence \n You thought the man seemed suspicious, but here is the proof.";
    public string missingLink = 
        "MISSING LINK \n Evidence \n With this, everything falls into place.";
    public string photographicEvidence = 
        "PHOTOGRAPHIC EVIDENCE \n Evidence \n The proof can be seen clear as day.";
    public string ritualComponents = 
        "RITUAL COMPONENTS \n Evidence \n A collection of eerie objects to be used for some heinous ritual.";
    public string cultistsJournal = 
        "CULTIST'S JOURNAL \n Evidence, Tome \n This journal describes the crime in brutal detail.";
    public string oldMap = 
        "OLD MAP \n Evidence \n Your path is clearly marked, but the dangers you may encounter upon it are not.";
    public string ledger = 
        "LEDGER \n Evidence, Tome \n According to this, nearly everyone in Arkham owed the O'Bannions money for various services rendered.";
    public string deVermisMysteriis = 
        "DE VERMIS MYSTERIIS \n Evidence, Tome \n The profane knowledge held within these pages promises power, but at a terrible cost.";
    public string membershipRing = 
        "MEMBERSHIP RING \n Evidence \n “Silver Twilight Lodge membership requires sacrifice. \n -Carl Sanford";
    public string ticket = 
        "TICKET \n Evidence \n This ticket is only one-way.";
    public string cultSigil = 
        "CULT SIGIL \n Evidence, Key \n This token serves as proof of membership for a cult.";
    
    // key
    public string brassKey = 
        "BRASS KEY \n Key \n As you hold the key, you look around for a matching doorknob or padlock.";
    public string silverKey = 
        "SILVER KEY \n Key \n Yog-Sothoth is the gate. Yog-Sothoth is the key and the guardian of the gate.";
    public string goldKey = 
        "GOLD KEY \n Key \n The intricate etched pattern on the key's neck indicates it belongs to an equally fancy lock.";
    public string oldKeys = 
        "OLD KEYS \n Key \n The clinking of the keys echoes through the quiet night. You fear the sound might draw unwanted attention.";
    
    // relic
    public string strangeTablet = 
        "STRANGE TABLET \n Relic \n When you suffer 1 or more Horror, become Dazed.";
    public string mysteriousIdol = 
        "MYSTERIOUS IDOL \n Relic \n When you suffer 1 or more Horror, become Dazed.";
    public string stoneChest = 
        "STONE CHEST \n Relic \n When you perform a move action, you can only move up to 1 space.";
    public string starCalendar = 
        "STAR CALENDAR \n Relic \n If you move more than a single space as part of a move action, suffer 1 facedown Damage.";
    public string bonePipes = 
        "BONE PIPES \n Relic \n You cannot evade monsters.";
    public string twilightDiadem = 
        "TWILIGHT DIADEM \n Relic \n The ancient jewels sparkle in the light. You get the feeling it is more than a pretty trinket.";
    
    // elixir
    public string elixir = 
        "Elixir \n At the start of your turn, you may improve 1 skill of your choice. If you do, flip this card.";
    public string elixirWakingDreams = 
        "WAKING DREAMS \n Time is meaningless when memories and premonitions run together into a crescendo of fear. " +
        "At the end of your turn, Flip 1 Horror faceup.";
    public string elixirPlacebo = 
        "PLACEBO \n Yes, you can feel the tincture working its way through your veins as a gentle tingling. It must have delayed effects. " +
        "No additional effect. Discard this card.";
    public string elixirNumbing = 
        "MIND-NUMBING REAGENTS \n You find each task more difficult than the last, while your mind seems stuck like a fly in honey. " +
        "Become Dazed. Then discard this card.";
    public string elixirLuminous = 
        "LUMINOUS ELIXIR \n From just the right angle, you can see your skin giving off a faint luster in the dark night. " +
        "Become Righteous. Then discard this card.";
    public string elixirAcidic = 
        "ACIDIC COMPOUND \n Your blood flows freely, skin sloughing away to release the steaming scarlet liquid inside. " +
        "At the end of your turn, Flip 1 Damage faceup.";
    public string elixirNightmare = 
        "NIGHTMARE JUICE \n A window into the whirling infinite opens in your mind, and it requires all of your effort to hold the violent chaos at bay. " +
        "Become Stunned. Then discard this card.";
    
    // common items
    public string twoToFour = 
        "2x4 \n Heavy Weapon \n Action: You brace the door with the board. Flip this card and place it against a door to your space.";
    public string twoToFourActive = 
        "2x4 \n The door is reinforced with a board. Treat this card as a Barricade that blocks the door it is placed against. " +
        "When an investigator picks up this card or moves this card away from the door it blocks, flip this card.";
    public string arcaneManuscript =
        "ARCANE MANUSCRIPT \n Tome \n Roll 1 additional die while resolving a {wisdom} test.";
    public string fortyFiveAutomatic = 
        ".45 AUTOMATIC \n Firearm \n Being a detective can be a dangerous career, but these babies will see you through.";
    public string twentyFiveAutomatic = 
        "25 AUTOMATIC \n Firearm \n You may convert an {clue} to a {*} while attacking with this card.";
    public string axe =
        "AXE \n Heavy Weapon \n You may suffer 2 facedown Horror to convert all {clue} to a {*} while attacking with this card.";
    public string bandages = 
        "BANDAGES \n Equipment \n Action: Discard up to 2 facedown Damage. Then discard this card.";
    public string bindingPowder = 
        "BINDING POWDER \n Equipment \n Action: Place a Restraint in a space within range. Then discard this card.";
    public string blackjack = 
        "BLACKJACK \n Heavy Weapon \n ''Non-violent measures? Tetsuo, you have a lot to learn about Arkham.'' \n –Deputy Dingby";
    public string brassKnuckles =
        "BRASS KNUCKLES \n Equipment \n Roll 2 additional dice while attacking unarmed.";
    public string bulletproofvest = 
        "BULLETPROOF VEST \n Equipment \n If you would suffer 2 or more Damage, suffer 1 fewer Damage instead.";
    public string bullseyeLantern = 
        "BULLSEYE LANTERN \n Light Source \n Action: Another investigator within range becomes Dazed.";
    public string candles = 
        "CANDLES \n Light Source \n You may discard this card to convert all {clue} to {*} while casting a Spell.";
    public string captainsHat = 
        "CAPTAIN'S HAT \n Equipment \n You may convert an {clue} to a {*} while resolving {bond} test.";
    public string carbineRifle = 
        "CARBINE RIFLE \n Firearm \n You cannot attack a monster in your space with this card.";
    public string ceroseneLantern = 
        "KEROSENE LANTERN \n Light Source \n You may discard this card to convert all {clue} to {9} while attacking unarmed.";
    public string coalShovel = 
        "COAL SHOVEL \n Heavy Weapon \n There is more than one way to keep your investigation moving along.";
    public string convincingDummy = 
        "CONVINCING DUMMY \n Equipment \n Action: Place a Restraint in your space. Then discard this card.";
    public string crowbar = 
        "CROWBAR \n Heavy Weapon \n A hefty tool for getting the job done right";
    public string eighteenDerringer = 
        ".18 DERRINGER \n Firearm \n No gal should be out on the town without a bit of protection.";
    public string fortyOneDerringer = 
        ".41 DERRINGER \n Firearm \n You may deal 1 additional damage while attacking a monster in your space with this card.";
    public string diversHelmet = 
        "DIVER'S HELMET \n Equipment \n You may ignore Water. You cannot become Dazed or Stunned.";
    public string diversJournal = 
        "DIVER'S JOURNAL \n Tome \n You may ignore Water. Roll 1 additional die while attacking a monster with the aquatic ability.";
    public string dynamite = 
        "DYNAMITE \n Equipment \n Action: You light the fuse and toss the explosive. Flip this card and place it in a space within range.";
    public string dynamiteActive = 
        "DYNAMITE \n The fuse is only so long. It would be wise to run. " +
        "At the end of the investigator phase, each investigator in this space or an adjacent space suffers 8 Damage, and each monster in those spaces suffers 10 damage. " +
        "Then discard this card.";
    public string elderSignPendant = 
        "ELDER SIGN PENDANT \n Equipment \n Roll 1 additional die while evading a monster.";
    public string elderWard = 
        "ELDER WARD \n Equipment \n Roll 1 additional die while a monster is attacking you.";
    public string enhancingSerum = 
        "ENHANCING SERUM \n Equipment \n Action: Improve to Then discard this card.";
    public string enchantedBlade = 
        "ENCHANTED BLADE \n Bladed Weapon \n ''I would draw no swords but what are sanctified.'' \n -William Yorrick";
    public string fineClothes = 
        "FINE CLOTHES \n Equipment \n Roll 1 additional die while resolving an 3 test.";
    public string fireExtinguisher = 
        "FIRE EXTINGUISHER \n Heavy Weapon \n Action: Discard all Fire in your space and adjacent spaces.";
    public string flareGun = 
        "FLARE GUN \n Equipment \n Action: Place Fire in a space within range. Each monster in that space suffers 2 damage. Then flip this card.";
    public string flareGunActive = 
        "FLARE GUN \n You have only one more shell remaining. You had better make it count. " +
        "Action: Place Fire in a space within range. Each monster in that space suffers 2 damage. Then discard this card.";
    public string flask = 
        "FLASK \n Equipment Action: Improve {mind} Then discard this card.";
    public string gamblersDice = 
        "GAMBLER'S DICE \n Equipment \n Once per round, you may reroll one dice.";
    public string gateBox = 
        "GATE BOX \n Equipment \n Action: Discard all Rifts from your space and adjacent spaces. Then gain 1 Clue.";
    public string gatlingGun = 
        "GATLING GUN \n Firearm \n This weapon's damage is equal to the number of ☆rolled while attacking with this card.";
    public string astronomyGuidebook = 
        "ASTRONOMY GUIDEBOOK \n Tome \n You may ignore Rifts.";
    public string harpoon = 
        "HARPOON \n Bladed Weapon \n Action: You hurl your weapon ({agility}; 2). If you pass, place this card in a space within range, then a monster in that space suffers 3 damage.";
    public string holyCross = 
        "HOLY CROSS \n Equipment \n Roll 1 additional die while resolving a {mind} test.";
    public string holyWater = 
        "HOLY WATER \n Equipment \n Action: Discard 1 Horror and become Focused. Then discard this card.";
    public string kingJamesBible = 
        "KING JAMES BIBLE \n Tome \n Action: You or another investigator within range may discard 1 facedown Horror.";
    public string knife = 
        "KNIFE \n Bladed Weapon \n It can cut many things, including monsters.";
    public string leadPipe = 
        "LEAD PIPE \n Heavy Weapon ''A bloodied pipe was found at the scene of the crime. The cause of death is still unknown.'' \n -Deputy Dingby";
    public string lifePreserver = 
        "LIFE PRESERVER \n Heavy Weapon \n You may ignore Water.";
    public string luckyCigaretteCase = 
        "LUCKY CIGARETTE CASE \n Equipment \n Once per round, you may convert an {clue} to a {*}.";
    public string luckyRing = 
        "LUCKY RING \n Equipment \n Once per round, you may reroll all of your dice.";
    public string luckyRabbitsFoot = 
        "LUCKY RABBIT'S FOOT \n Equipment \n Once per round, you may reroll 1 die.";
    public string machete = 
        "MACHETE \n Bladed Weapon \n Although more commonly used as a tool for cutting vegetation, it will do well against the horrors you now face.";
    public string magnifyingGlass = 
        "MAGNIFYING GLASS \n Equipment \n Roll 1 additional die while resolving an {perception} test.";
    public string mapOfLeyLines = 
        "MAP OF THE LEY LINES \n Equipment \n You may discard Lost in Time and Space during your turn to place your investigator figure in any explored space.";
    public string meatCleaver = 
        "MEAT CLEAVER \n Bladed Weapon \n You may suffer 2 facedown Horror to convert all {clue} to {*} while attacking with this card.";
    public string medicalTextbook = 
        "MEDICAL TEXTBOOK \n Equipment \n Action: You or another investigator within range may discard 1 facedown Damage.";
    public string mentalStimulant = 
        "MENTAL STIMULANT \n Equipment \n Action: Improve {wisdom} Then discard this card.";
    public string moonPotion = 
        "MOON POTION \n Equipment Action: Improve {bond} Then discard this card.";
    public string mysticSextant = 
        "MYSTIC SEXTANT \n Equipment \n Roll 1 additional die while Lost in Time and Space.";
    public string mutationJuice = 
        "MUTATION JUICE \n Equipment \n Action: Improve {agility} Then discard this card.";
    public string ocularExtract = 
        "OCULAR EXTRACT \n Equipment \n Action: Improve {perception} Then discard this card.";
    public string painkillers = 
        "PAINKILLERS \n Equipment \n Action: Discard 1 facedown Damage and 1 facedown Horror. Then discard this card.";
    public string pickaxe = 
        "PICKAXE \n Heavy Weapon \n With a single hard swing, the tool's head pierces deeply into even the hardest materials.";
    public string pocketWatch = 
        "POCKET WATCH \n Equipment \n You may perform 1 additional puzzle step while attempting a puzzle.";
    public string razor = 
        "RAZOR \n Bladed Weapon \n You may suffer 1 facedown Damage to convert an {clue} to {*} while attacking with this card.";
    public string thirtyEightRevolver = 
        ".38 REVOLVER \n Firearm \n A trusty service piece for any member of the armed forces.";
    public string riotWhistle = 
        "RIOT WHISTLE \n Equipment \n Once per round, you or another investigator within range may reroll any number of dice while evading a monster.";
    public string ritualDagger = 
        "RITUAL DAGGER \n Bladed Weapon \n Roll 1 additional die while casting a Spell.";
    public string scalpel = 
        "SCALPEL\n Bladed Weapon \n You may deal 1 additional damage while attacking with this card.";
    public string scribesJournal = 
        "SCRIBE'S JOURNAL \n Tome \n Effects cannot cause you to discard your Clues unless you choose to.";
    public string sedatives = 
        "SEDATIVES \n Equipment \n At the start of your turn, you may discard 3 Damage and 3 Horror. If you do, discard this card and end your turn.";
    public string sensibleShoes = 
        "SENSIBLE SHOES \n Equipment Roll 1 additional die while resolving an {agility} test.";
    public string shotgun = 
        "SHOTGUN \n Firearm \n You cannot attack a monster that is more than 1 space away with this card.";
    public string shovel = 
        "SHOVEL \n Heavy Weapon \n Digging holes is just one of its many uses.";
    public string sledgehammer =
        "SLEDGEHAMMER \n Heavy Weapon \n You may suffer 2 facedown Damage to convert all {clue} to {*} while attacking with this card.";
    public string snubnoseRevolver = 
        "SNUBNOSE REVOLVER \n Firearm \n You may deal 1 damage to a monster in your space when you forfeit an action while evading a monster.";
    public string silverTwilghtDagger = 
        "SILVER TWILIGHT DAGGER \n Bladed Weapon \n You may deal 1 additional damage while casting an attack Spell.";
    public string sturdyLuggage = 
        "STURDY LUGGAGE \n Heavy Weapon \n There is at least one benefit to lugging around your belongings.";
    public string swordCaneSide1 = 
        "SWORD CANE \n Bladed Weapon \n You may convert an {clue} to a {*} while attacking with this card. You may flip this card.";
    public string swordCaneSide2 = 
        "SWORD CANE \n Heavy Weapon \n You may convert an {clue} to a {*} while attacking with this card. You may flip this card.";
    public string thermos = 
        "THERMOS \n Equipment \n Action: Discard 1 Damage and become Focused. Then flip this card.";
    public string thermosActive = 
        "THERMOS \n Soup is not the only thing good for the soul. Treat this card as a Heavy Weapon.";
    public string tomeOfHorrors = 
        "TOME OF HORRORS \n Tome When you suffer 1 or more Horror while resolving a horror check, gain 1 Clue.";
    public string tomeOfSecrets = 
        "TOME OF SECRETS \n Tome You may become Mesmerized to convert all on to while resolving a test.";
    public string tommyGun = 
        "TOMMY GUN \n Firearm \n Once per round, you may reroll all of your dice while attacking with this card.";
    public string torch = 
        "TORCH \n Heavy Weapon, Light Source \n When an investigator drops this card, place Fire in this space.";
    public string toteBag = 
        "TOTE BAG \n Equipment Effects cannot cause you to drop Items unless you choose to.";
    public string trackShoes = 
        "TRACK SHOES \n Equipment \n You may move 1 additional space as part of a move action.";
    public string whiskey = 
        "WHISKEY \n Equipment \n Action: Discard up to 2 facedown Horror. Then flip this card.";
    public string whiskeyActive = 
        "BROKEN BOTTLE \n You smash the bottle. It is crude, but it will make a good enough weapon if you get into trouble. Treat this card as a Bladed Weapon.";
    public string wrench = 
        "WRENCH \n Heavy Weapon \n “Arkham's got a lot o'problems. I'm here ta fix 'um.” \n -Wilson Richards";
}