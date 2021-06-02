
using System;
using System.Linq;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class SupefightMainDeckRandomizer : UdonSharpBehaviour
{
    [SerializeField] GameObject[] buttons = new GameObject[0];
    [SerializeField] GameObject whiteCard;
    [SerializeField] GameObject blackCard;
    [SerializeField] GameObject additiveCard;
    [SerializeField] GameObject cardSwitch1;
    [SerializeField] GameObject cardSwitch2;
    [SerializeField] GameObject cardSelect1;
    [SerializeField] GameObject cardSelect2;
    [SerializeField] GameObject interactButton;
    [SerializeField] Transform[] cardResetPositions = new Transform[3];

    [SerializeField] superfight_deck pinkDeck;
    [SerializeField] superfight_deck orangeDeck;
    
    private readonly string[] _commonCharacterDeckLabels = 
    {
        "VELOCIRAPTOR", "ABRAHAM LINCOLN", "STREET FIGHTER", "T-REX", "DEXTER", "CHUCK NORRIS", "BLOB", "JESTER", "SPARTAN", "CANADIAN", "OCTOPUS", "CIA AGENT", "THE DUDE", "DRUG LORD", 
        "THE SNAKE", "SKELETON", "VAMPIRE", "PTERODACTYL", "NINJA", "DARTH VADER", "EVIL DOLL", "BARNEY", "BULL", "SHERLOCK HOLMES", "PET ROCK", "BOXER", "PIRATE", "VAMPIRE SLAYER", 
        "BODYBUILDER", "MAD SCIENTIST", "VEGAN", "HIPSTER", "THE POPE", "BILLIONAIRE PLAYBOY", "BUSINASSWOMAN", "CONNOISSEUR OF YOUNG GIRLS", "SHARK", "THE ILLUMINATI", "LEPRECHAUN", "SINGER", 
        "OLD MAN", "SUPERMODEL", "FBI AGENT", "ANDROID", "K-POP STAR", "CHEETAH","MARSHMALLOW MAN", "WEREWOLF", "ROBOT", "ARTIST", "HEADLESS HORSEMAN", "EAGLE", "WHALE", "WIZARD", "POLAR BEAR", 
        "RUNNER IN 90", "HANNIBAL", "ELECTRIC EEL", "MUSKETEER", "SASQUATCH", "MY BOSS", "GIANT SQUID", "CRAZY CAT LADY", "GLADIATOR", "DRAGON", "MERMAID", "SMOKE MONSTER", "COWBOY", "NUDIST", 
        "DOG", "THE DEVIL", "FRANKENSTEIN", "CHEMPANZEE", "UNICORN", "MOOSE", "SHARPSHOOTER", "NIGERIAN PRINCE", "SLOTH", "GIRAFFE", "CTU AGENT", "GRIM REAPER", "SAMURAI", "REDNECK", "PSYCHIC", 
        "ALIEN", "HIPPO", "WILLY WONKA", "GANDHI", "GIANT BEE", "KINDERGARTEN CLASS", "ASTROPHYSICIST", "TERMINATOR", "CROCODILE", "CLOWN", "ZOMBIE", "CONAN", "FREDDY", "RAMBO", "HUNCHBACK", 
        "GENGHIS KHAN", "GEORGE BUSH", "OWL", "MICHAEL JACKSON", "WRESTLER", "RHINOCEROS", "OBAMA", "CAT", "PUPPETEER", "YAKUZA", "YOUR MOM", "MIME", "ULTIMATE FIGHTING CHAMPION", "GORILLA", 
        "LAVA MONSTER", "WITCH", "SPIDER", "ROBIN HOOD", "CONJOINED TWINS", "TAXIST", "TURTLE", "THE DOCTOR", "DEMON", "IRON MAN", "PAPARAZZI", "BOY SCOUT", "ASSASSIN", "SABER TOOTHED TIGER", 
        "ANIMATED STATUE", "MUMMY", "MY EX", "POLITICIAN", "HOBO", "APACHE WARRIOR", "DOLPHIN", "MAMMOTH", "ANGEL", "HOCKEY PLAYER", "VIKING", "GIRL SCOUT", "KING", "EMPEROR", "HULK", 
        "BRUCE LEE", "MAFIA DON", "PLAYER TO YOUR LEFT", "PLAYER TO YOUR RIGHT", "MEN IN BLACK", "SUMO WRESTLER"
    };

    private readonly string[] _commonCharacterDeckLabelsExtra = { };
    
    private readonly string[] _pinkCharacterDeckLabels =
    {
        "THE MEMBERS OF FUTURE GADGET LABORATORY", "EVERYONE AT ANIME CONVENTION", "AFRO SAMURAI", "MAGICAL GIRL", "SAKURA", "MONKEY D LUFFY", "FOX DEMON", "PIKACHU", "DEMON BUTLER", "SHINIGAMI",
        "ICHIGO", "YUGI", "SIMON", "HOMUNCULUS", "WEEABOO", "SPIRIT OF THE FOREST", "PRINCESS MONONOKE", "TOTORO", "ASTRO BOY", "NARUTO", "AKIRA", "CARDCAPTOR", "VEGETA", "GOKU", 
        "FULLMETAL ALCHEMIST", "TEAM ROCKET", "ASH KETCHUM", "VASH THE STAMPEDE", "ADORABLE TALKING CAT", "COLOSSAL TITAN", "ALUCARD", "MIKASA", "SAILOR MOON", "MADOKA", "L", "KIRA", "SPIKE SPIEGEL"
    };

    private readonly string[] _orangeCharacterDeckLabels =
    {
        "THE DARK LORD", "THE PREDATOR", "DWARF", "WRAITH", "FOX", "LINK", "CYCLOPS", "TESLA", "ELF", "FINN", "LEEROY JENKINS", "GOBLIN KING", "CENTAUR", "KIRBY", "CREEPER", "BARBARIAN", 
        "DEATH KNIGHT", "PYRO", "V", "MONK", "KIRK", "NEO", "MEDUSA", "MINOTAUR", "JASON", "HOMER", "KRAKEN", "CTHULHU", "RIPLEY", "LIGER", "BOWSER", "WOLVERINE", "LOKI", "MASTER CHIEF",
        "BRONY", "HE-MAN", "SPOCK", "STEVE", "COLOSSUS", "TITAN", "DOGE", "ZEUS", "RODENT", "MANURU", "LEONARD", "AVATAR"
    };
    
    private readonly string[] _commonAttributeDeckLabels = 
    {
        "LASER EYES", "CATLIKE REFLEXES", "REALLY CLUMSY", "UNCONTROLLABLY DABS", "CAN HOLD BREATH FOREVER", "HAS TWO EXTRA ARMS", 
        "CAN STOP TIME WHILE HOLDING BREATH", "HEALS 100 TIMES FASTER", "SHOOTS TEAR GAS", "CAN MAKE FORCEFIELD WHILE HOLDING BREATH", "CAN CONTROL ANIMALS", "SHOOTS BEES", 
        "SUFFERING FROM DELUSIONS OF GRANDEUR", "ARMED WITH SHOTGUN THAT SHOOTS FIREBALLS", "CARRYING TOO MANY GROCERY BAGS", "ARMED WITH MACHINE GUN", "INSIDE A HAMSTER BALL TWICE THEIR SIZE", 
        "CAN BLOW 200-mph WINDS", "ARMED WITH SNIPER RIFLE", "IS REALLY REALLY GOOD-LOOKING", "HAS A VOODOO DOLL OF OPPONENT", "COVERED IN EYES", "100 STORES TALL", "SUPER ENDURANCE", 
        "ARMED WITH FREEZE RAY", "IS A HOARDER", "ARMED WITH BASEBALL BAT", "IS A SUPER GENIUS", "ARMED WITH FLAMETHROWER", "NO ARMS", "RIDING A HORSE", "CAN BREATHE UNDERWATER", 
        "CAN DIG AND RUN THROUGH TUNNELS WITH SUPER SPEED", "USES THE FORCE", "3-FOOT FINGERNAILS", "10 OF THEM", "BELIEVES THEY ARE INVISIBLE", "IN A HOT HAIR BALLOON", "ARMED WITH NUNCHUCKS", 
        "RIDING A DEPRESSED CENTAUR", "IN A SPACE SUIT", "WEARING A TIN FOIL HAT", "AFRAID OF WATER", "ARMED WITH CATAPULT AND UNLIMITED LIVESTOCK", "HANDS GLUED TO HIPS", "HAS VAMPIRISM",
        "IS REALLY REALLY HUNGRY", "BEING GUARDED BY SECRET SERVICE", "IN A JET FIGHTER", "CAN'T SEE", "HAS MAJESTIC FLAMING ANTLERS ON THEIR HEAD", "ARMED WITH LIVE T-REX HEAD ON A STICK", 
        "ARMED WITH INIFNITE LASSO", "CAN CONTROL GRAVITY", "ARMED WITH STILETTOS", "ON A MOTORCYCLE", "steal random attribute from opponent", "WEARING A ROBOTIC EXOSKELETON", "BIONIC", 
        "RIDING A HOVERBOARD", "HAS NO BONES", "BLIND BUT RELIES ON SONAR TO SEE", "HAS FEET INSTEAD OF HANDS", "ON A POGO STICK", "CAN READ MINDS", "CAN'T STOP DANCING", "THROWS ANTIQUES",
        "FROST BREATH", "HAS A HOSTAGE", "10 STORES TALL", "ARMED WITH TRANQULIZER GUN", "ON A VELOCIPEDE", "CAN'T STOP SOBBING", "9 FEET TALL", "CONTROLS A CLONE ARMY", "CAN ONLY SEE MOVEMENT", 
        "TWO EXTRA LEGS", "KNOWS KUNG FU", "VENOMOUS BITE", "JUST DRANK FIVE ENERGY DRINKS", "RIDING A WAR ELEPHANT", "6 INCHES TALL", "FLOATING DOWN ON A PARACHUTE", "ARMED WITH LIGHTSABER", 
        "CAN POSSES OPPONENT FOR 30 SECONDS BUT ONCE", "CAN TAKE FORM OF ANYTHING THEY TOUCH", "THROWS 200-MPH FASTBALLS", "HAS X-RAY VISION", "HAS AN INVISIBILITY CLOAK", 
        "CAN ONLY MOVE WHEN OPPONENT MOVES", "IN A BERSERK RAGE", "CAN MATCH OPPONENT'S SIZE", "ARMED WITH SHRINK RAY", "HAS A SKUNK ON A STICK", "COVERED IN SPIKES", "IS A PINATA", 
        "ARMED WITH A ROCKET LAUNCHER", "DUMB", "CAN TELEPORT ONCE PER TEN SECONDS", "FIGURATIVELY `ON FIRE` \n ...AND LITERALLY", "ARMED WITH BOW AND UNLIMITED ARROWS", "CAN CONTROL MACHINES", 
        "WEARING IMPENETRABLE TUXEDO", "INVISIBLE", "SUPER STRENGTH", "CAN STRETCH LIKE RUBBER", "ARMED WITH HARPOON GUN", "WEARING SCUBA SUIT", "IS RABID", "PACIFIST", "ARMED WITH DYNAMITE", 
        "WITH A PREHENSILE TAIL", "CAN HOVER ABOVE GROUND", "SHOOTS LAUGHING GAS", "SONIC SCREAM", "CAN TURN INTO ANY VEHICLE", "50 OF THEM", "NARCOLEPTIC", "duplicate one opponent attribute", 
        "CAN'T STOP CLAPPING", "TONGUE CAN STRETCH AND MOVE AT WILL", "HAS A MIRROR THAT DEFLECTS RAYS", "WEARING SKIES", "RIDING A BATTLE CAT", "ARMED WITH PORTAL GUN", "THROWS FIREBALLS", 
        "HAS VERTIGO", "ON A SEGWAY", "CAN BECOME ANY ANIMAL", "THROWS NINJA STARS", "CAN RUN 200-MPH", "WEARING ONE OF THOSE CONES THEY PUT ON PETS TO KEEP THEM FROM LICKING THEMSELVES", 
        "ARMED WITH AXE", "BREATHES FIRE", "ENTIRE BODY IS VERY STICKY", "3 OF THEM", "ARMED WITH PEPPER SPRAY", "CAN CLONE SELF", "ARMED WITH WHIP", "ARMED WITH SHOTGUN", 
        "ARMED WITH STICKY BOMBS", "UNAFFECTED BY IMPACT", "ARMED WITH THROWING KNIVES", "3 STORES TALL", "CAN'T STOP LAUGHING", "CAN FLY", "DRIVING ARMED POPEMOBILE", "ON STILTS", 
        "LONG METAL CLAWS OUT OF HANDS", "SCREAMS NAMES OF ATTACKS BEFORE USING THEM \n BUT THEY ARE TWICE AS POWERFUL", "NO LEGS", "ARMED WITH SAMURAI SWORD", "DISTRACTED BY SHINY THINGS", 
        "IN A HELICOPTER", "CAN ANIMATE DIRT", "ON A JET SKI", "IS AMISH", "ARMED WITH SHIELD", "CAN CONTROL PLANTS", "1000 YEARS OLD", "HAS TIME MACHINE PHONE BOOTH", "SHOOTS GLITTER", 
        "IS A STUFFED ANIMAL", "CONTROLS ARMY OF FLYING MONKEYS", "IS DRUNK", "CAN KILL WITH A KISS", "CONTROLS WEATHER", "DISABLE ALL ATTRIBUTES", "CAN ONLY MOVE BY BACKFLIPPING", 
        "ARMED WITH CHAINSAW", "TRAPPED IN POTATO SACK", "SHOOTS BLINDING LIGHT FROM HANDS", "DRIVING A TANK", "RELIES ON HEAT VISION TO SEE", "PILOTING ATTACK DRONE", "RIDING A BROOMSTICK", 
        "CAN SUPER JUMP", "CAN BECOME MIST WHILE HOLDING BREATH", "HAS A 8-FOOT NECK", "WEARING A SUIT OF ARMOR", "IS A HYPNOTIST", "CAN SUMMON ARMY OF INTERNET TROLLS", 
        "THROWS SPEARS", "ARMED WITH HOLY HAND GRENADES", "OBESE", "SWINGING SHARK ON A CHAIN", "CAN ONLY BE KILLED BY BEHEADING", "50 OF THEM", "ARMED WITH NAIL GUN", "HAS TINY BIRD LEGS", 
        "ARMED WITH CROWBAR", "CAN WALK THROUGH SOLID OBJECTS", "RIDING UNICORN", "SHOOTS WEBS", "CAN CONTROL OPPONENT'S RIGHT HAND", "ARMED WITH TRIDENT", "ON A BATTLESHIP", 
        "CAN CREATE HOLOGRAM OF HIMSELF", "ACID BLOOD", "ARMED WITH CUPID BOW", "SCISSOR HANDS", "WEARING JETPACK", "WEARING ROCKET-POWERED ROLLERSKATES", "ONLY ONE LEG", 
        "MUSTACHE CAN STRETCH AND MOVE AT WILL", "ARMED WITH BARBED WIRE NET", "WIELDING HUGE SILVER REVOLVER", "ARMED WITH POISON-TIP LANCE", "HANDCUFFED TO GOLF CART", "SHOOTS LIGHTING", 
        "RIDING FLYING NARWHAL", "CAN SEE 3 SECONDS INTO THE FUTURE", "CONTROLS MAGNETISM", "HAS TELEKINESIS", "IS RADIOACTIVE", "ARMED WITH CATARANGS", "SPRAYS NEUROTOXIN", 
        "STONE GAZE", "ARMED WITH SADNESS RAY", "HAS TINY T-REX ARMS", "SHOOTS ACID"
    };
    
    private readonly string[] _commonAttributeDeckLabelsExtra =
    {
        "INSIDE A GIANT ROBOTIC _ ", "BOTTOM HALF IS _ ", "TOP HALF IS _", "HAS __ AND __", "RIDING A _", "HAS A _ WITH __ AS SIDEKICK", "CAN CHANGE INTO _ AT WILL", 
        "MEGAFIGHTER \n RIGHT HAND IS _ \n LEFT HAND IS _ \n RIGHT LEG IS _ \n LEFT LEG IS _"
    };

    private readonly string[] _pinkAttributeDeckLabels =
    {
        "WIELDING HUGE SILVER REVOLVER", "ARMED WITH MASTER BALL", "SOUL IS BOUND TO SUIT OF ARMOR", "IS QUEEN OF SAILOR SOLDIERS", "CAN TURN INTO ZODIAC ANIMAL AT WILL", 
        "JUST WENT SUPER SAIYAN", "HAS ALL THE DRAGON BALLS", "IS A MAID", "IS AN ADOLESCENT NINJA", "IS A MAGICAL GIRL", "PILOTING AN GUNDAM", "PILOTING AN EVANGELION", 
        "EYES ARE HIDDEN BY HAIR", "WEARING AT 3D MANEUVER GEAR", "HAS A NOSEBLEED", "HAS FIVE SUPER STRONG INVISIBLE ARMS", "LEADING A HAREM OF FIGHTER GIRLS",
        "ARMED WITH CHANISAW DEATH SCYTHE", "ARMED WITH BOOMERANG", "ARMED WITH DOMINATOR", "ARMED WITH ANGEL ARM", "HAS A CELLPHONE THAT PREDICTS FUTURE", "ARMED WITH KEYBLADE",
        "TURNS INTO TITAN WHEN WOUNDED", "HAS A PET DIRE WOLF", "ARMED WITH MIRROR SHIELD", "HAS THREE PET DRAGONS", "IS WEARING DIAMOND ARMOR", "ARMED WITH BUSTER SWORD",
        "IS WEARING RED SHIRT", "ARMED WITH MJOLNIR", "HAS THE ONE RING", "LEFT HAND IS A CHANISAW", "ARMED WITH DIAMOND SWORD", "ARMED WITH VORPAL BLADE", "SHOOTS MAGIC MISSLES",
        "THEIR ACTIONS IS SUPER EFFECTIVE", "JUST ROLLED CRITICAL FAILURE", "JUST ROLLED CRITICAL SUCCESS", "CAN CREATE LIGHTING FIELD", "IS AT LEVEL 1", "IS AT LEVEL 90"
    };

    private readonly string[] _orangeAttributeDeckLabels =
    {
        "HAS A TOWEL", "IS RIDING A PEGASUS", "HAS A SONIC SCREWDRIVER", "TOOK ARROW INTO THE KNEE", "POWER LEVEL IS OVER 9000", "ARMED WITH THERMAL DETONATOR", "IN A STEALTH MODE", 
        "RIDING A SPEEDER BIKE", "ARMED WITH A PHASER", "ARMED WITH PHOENIX FEATHER WAND", "ARMED WITH A DAGGER THAT REWINDS TIME", "ARMED WITH WHIP MADE OF FIRE", "IN A MECH", 
        "ARMED WITH RED TURTLE SHELLS", "CAN BUILD SENTRY TURRETS", "ARMED WITH THE MASTER SWORD", "ARMED WITH GRAVIRY GUN", "IS THE SUPREME", "AT HALF HP", "IS OUT OF MANA",
        "ARMED WITH GOLDEN GUN"
    };

    
    private string[] _characterCardSet;
    private string[] _attributeCardSet;
    private int _currentCard = 0;
    private int[] _history;
    
    void Start()
    {
        var characterCardSet = new string[_commonCharacterDeckLabels.Length + _pinkCharacterDeckLabels.Length + _orangeCharacterDeckLabels.Length];
        for (int i = 0; i < _commonCharacterDeckLabels.Length; i++)
        {
            characterCardSet[i] = _commonCharacterDeckLabels[i];
        }
        int j = 0;
        for (int i = _commonCharacterDeckLabels.Length;  i < _commonCharacterDeckLabels.Length + _pinkCharacterDeckLabels.Length; i++)
        {
            characterCardSet[i] = _pinkCharacterDeckLabels[j];
            j++;
        }
        j = 0;
        for (int i = _commonCharacterDeckLabels.Length + _pinkCharacterDeckLabels.Length;  i < _commonCharacterDeckLabels.Length + _pinkCharacterDeckLabels.Length + _orangeCharacterDeckLabels.Length; i++)
        {
            characterCardSet[i] = _orangeCharacterDeckLabels[j];
            j++;
        }
        _characterCardSet = characterCardSet;
        
        var attributeCardSet = new string[_commonAttributeDeckLabels.Length + _pinkAttributeDeckLabels.Length + _orangeAttributeDeckLabels.Length];
        for (int i = 0; i < _commonAttributeDeckLabels.Length; i++)
        {
            attributeCardSet[i] = _commonAttributeDeckLabels[i];
        }
        j = 0;
        for (int i = _commonAttributeDeckLabels.Length;  i < _commonAttributeDeckLabels.Length + _pinkAttributeDeckLabels.Length; i++)
        {
            attributeCardSet[i] = _pinkAttributeDeckLabels[j];
            j++;
        }
        j = 0;
        for (int i = _commonAttributeDeckLabels.Length + _pinkAttributeDeckLabels.Length;  i < _commonAttributeDeckLabels.Length + _pinkAttributeDeckLabels.Length + _orangeAttributeDeckLabels.Length; i++)
        {
            attributeCardSet[i] = _orangeAttributeDeckLabels[j];
            j++;
        }
        _attributeCardSet = attributeCardSet;
        
        int seed = (int) Time.time;
        UnityEngine.Random.InitState(seed);
        Debug.Log(characterCardSet.Length); // 231
        Debug.Log(attributeCardSet.Length); // 284

    }

    public void GenerateCards()
    {
        _history = new int[] {-1,-1,-1,-1};
        SendCustomNetworkEvent(NetworkEventTarget.All, "switchUI");
        cardSelect1.SetActive(true);
        cardSelect2.SetActive(true);
        
        // remove duplicated code later
        for (int i = 0; i < 3; i++)
        {
            int a;
            while(((a = UnityEngine.Random.Range(0, _characterCardSet.Length)) == _history[0]) || (a == _history[1] || a == _history[2]))
            {}
            _history[i] = a;
            SendEvent("wdraw", a);
        }
        _history = new int[] {-1,-1,-1,-1};
        for (int i = 0; i < 4; i++)
        {
            int a;
            while(((a = UnityEngine.Random.Range(0, _attributeCardSet.Length)) == _history[0]) || (a == _history[1] || a == _history[2] || a == _history[3]))
            {}
            _history[i] = a;
            SendEvent("bdraw", a);
        }
        
        SendCustomNetworkEvent(NetworkEventTarget.All, "reset_current_card");
        SendCustomNetworkEvent(NetworkEventTarget.All, "create_additive");
    }

    public void SendEvent(string name, int id)
    {
        SendCustomNetworkEvent(NetworkEventTarget.All, name + id.ToString());
    }

    // Thanks Udon
    public void wdraw0() { GenerateLabel(0, "w") ;}
    public void wdraw1() { GenerateLabel(1, "w") ;}
    public void wdraw2() { GenerateLabel(2, "w") ;}
    public void wdraw3() { GenerateLabel(3, "w") ;}
    public void wdraw4() { GenerateLabel(4, "w") ;}
    public void wdraw5() { GenerateLabel(5, "w") ;}
    public void wdraw6() { GenerateLabel(6, "w") ;}
    public void wdraw7() { GenerateLabel(7, "w") ;}
    public void wdraw8() { GenerateLabel(8, "w") ;}
    public void wdraw9() { GenerateLabel(9, "w") ;}
    public void wdraw10() { GenerateLabel(10, "w") ;}
    public void wdraw11() { GenerateLabel(11, "w") ;}
    public void wdraw12() { GenerateLabel(12, "w") ;}
    public void wdraw13() { GenerateLabel(13, "w") ;}
    public void wdraw14() { GenerateLabel(14, "w") ;}
    public void wdraw15() { GenerateLabel(15, "w") ;}
    public void wdraw16() { GenerateLabel(16, "w") ;}
    public void wdraw17() { GenerateLabel(17, "w") ;}
    public void wdraw18() { GenerateLabel(18, "w") ;}
    public void wdraw19() { GenerateLabel(19, "w") ;}
    public void wdraw20() { GenerateLabel(20, "w") ;}
    public void wdraw21() { GenerateLabel(21, "w") ;}
    public void wdraw22() { GenerateLabel(22, "w") ;}
    public void wdraw23() { GenerateLabel(23, "w") ;}
    public void wdraw24() { GenerateLabel(24, "w") ;}
    public void wdraw25() { GenerateLabel(25, "w") ;}
    public void wdraw26() { GenerateLabel(26, "w") ;}
    public void wdraw27() { GenerateLabel(27, "w") ;}
    public void wdraw28() { GenerateLabel(28, "w") ;}
    public void wdraw29() { GenerateLabel(29, "w") ;}
    public void wdraw30() { GenerateLabel(30, "w") ;}
    public void wdraw31() { GenerateLabel(31, "w") ;}
    public void wdraw32() { GenerateLabel(32, "w") ;}
    public void wdraw33() { GenerateLabel(33, "w") ;}
    public void wdraw34() { GenerateLabel(34, "w") ;}
    public void wdraw35() { GenerateLabel(35, "w") ;}
    public void wdraw36() { GenerateLabel(36, "w") ;}
    public void wdraw37() { GenerateLabel(37, "w") ;}
    public void wdraw38() { GenerateLabel(38, "w") ;}
    public void wdraw39() { GenerateLabel(39, "w") ;}
    public void wdraw40() { GenerateLabel(40, "w") ;}
    public void wdraw41() { GenerateLabel(41, "w") ;}
    public void wdraw42() { GenerateLabel(42, "w") ;}
    public void wdraw43() { GenerateLabel(43, "w") ;}
    public void wdraw44() { GenerateLabel(44, "w") ;}
    public void wdraw45() { GenerateLabel(45, "w") ;}
    public void wdraw46() { GenerateLabel(46, "w") ;}
    public void wdraw47() { GenerateLabel(47, "w") ;}
    public void wdraw48() { GenerateLabel(48, "w") ;}
    public void wdraw49() { GenerateLabel(49, "w") ;}
    public void wdraw50() { GenerateLabel(50, "w") ;}
    public void wdraw51() { GenerateLabel(51, "w") ;}
    public void wdraw52() { GenerateLabel(52, "w") ;}
    public void wdraw53() { GenerateLabel(53, "w") ;}
    public void wdraw54() { GenerateLabel(54, "w") ;}
    public void wdraw55() { GenerateLabel(55, "w") ;}
    public void wdraw56() { GenerateLabel(56, "w") ;}
    public void wdraw57() { GenerateLabel(57, "w") ;}
    public void wdraw58() { GenerateLabel(58, "w") ;}
    public void wdraw59() { GenerateLabel(59, "w") ;}
    public void wdraw60() { GenerateLabel(60, "w") ;}
    public void wdraw61() { GenerateLabel(61, "w") ;}
    public void wdraw62() { GenerateLabel(62, "w") ;}
    public void wdraw63() { GenerateLabel(63, "w") ;}
    public void wdraw64() { GenerateLabel(64, "w") ;}
    public void wdraw65() { GenerateLabel(65, "w") ;}
    public void wdraw66() { GenerateLabel(66, "w") ;}
    public void wdraw67() { GenerateLabel(67, "w") ;}
    public void wdraw68() { GenerateLabel(68, "w") ;}
    public void wdraw69() { GenerateLabel(69, "w") ;}
    public void wdraw70() { GenerateLabel(70, "w") ;}
    public void wdraw71() { GenerateLabel(71, "w") ;}
    public void wdraw72() { GenerateLabel(72, "w") ;}
    public void wdraw73() { GenerateLabel(73, "w") ;}
    public void wdraw74() { GenerateLabel(74, "w") ;}
    public void wdraw75() { GenerateLabel(75, "w") ;}
    public void wdraw76() { GenerateLabel(76, "w") ;}
    public void wdraw77() { GenerateLabel(77, "w") ;}
    public void wdraw78() { GenerateLabel(78, "w") ;}
    public void wdraw79() { GenerateLabel(79, "w") ;}
    public void wdraw80() { GenerateLabel(80, "w") ;}
    public void wdraw81() { GenerateLabel(81, "w") ;}
    public void wdraw82() { GenerateLabel(82, "w") ;}
    public void wdraw83() { GenerateLabel(83, "w") ;}
    public void wdraw84() { GenerateLabel(84, "w") ;}
    public void wdraw85() { GenerateLabel(85, "w") ;}
    public void wdraw86() { GenerateLabel(86, "w") ;}
    public void wdraw87() { GenerateLabel(87, "w") ;}
    public void wdraw88() { GenerateLabel(88, "w") ;}
    public void wdraw89() { GenerateLabel(89, "w") ;}
    public void wdraw90() { GenerateLabel(90, "w") ;}
    public void wdraw91() { GenerateLabel(91, "w") ;}
    public void wdraw92() { GenerateLabel(92, "w") ;}
    public void wdraw93() { GenerateLabel(93, "w") ;}
    public void wdraw94() { GenerateLabel(94, "w") ;}
    public void wdraw95() { GenerateLabel(95, "w") ;}
    public void wdraw96() { GenerateLabel(96, "w") ;}
    public void wdraw97() { GenerateLabel(97, "w") ;}
    public void wdraw98() { GenerateLabel(98, "w") ;}
    public void wdraw99() { GenerateLabel(99, "w") ;}
    public void wdraw100() { GenerateLabel(100, "w") ;}
    public void wdraw101() { GenerateLabel(101, "w") ;}
    public void wdraw102() { GenerateLabel(102, "w") ;}
    public void wdraw103() { GenerateLabel(103, "w") ;}
    public void wdraw104() { GenerateLabel(104, "w") ;}
    public void wdraw105() { GenerateLabel(105, "w") ;}
    public void wdraw106() { GenerateLabel(106, "w") ;}
    public void wdraw107() { GenerateLabel(107, "w") ;}
    public void wdraw108() { GenerateLabel(108, "w") ;}
    public void wdraw109() { GenerateLabel(109, "w") ;}
    public void wdraw110() { GenerateLabel(110, "w") ;}
    public void wdraw111() { GenerateLabel(111, "w") ;}
    public void wdraw112() { GenerateLabel(112, "w") ;}
    public void wdraw113() { GenerateLabel(113, "w") ;}
    public void wdraw114() { GenerateLabel(114, "w") ;}
    public void wdraw115() { GenerateLabel(115, "w") ;}
    public void wdraw116() { GenerateLabel(116, "w") ;}
    public void wdraw117() { GenerateLabel(117, "w") ;}
    public void wdraw118() { GenerateLabel(118, "w") ;}
    public void wdraw119() { GenerateLabel(119, "w") ;}
    public void wdraw120() { GenerateLabel(120, "w") ;}
    public void wdraw121() { GenerateLabel(121, "w") ;}
    public void wdraw122() { GenerateLabel(122, "w") ;}
    public void wdraw123() { GenerateLabel(123, "w") ;}
    public void wdraw124() { GenerateLabel(124, "w") ;}
    public void wdraw125() { GenerateLabel(125, "w") ;}
    public void wdraw126() { GenerateLabel(126, "w") ;}
    public void wdraw127() { GenerateLabel(127, "w") ;}
    public void wdraw128() { GenerateLabel(128, "w") ;}
    public void wdraw129() { GenerateLabel(129, "w") ;}
    public void wdraw130() { GenerateLabel(130, "w") ;}
    public void wdraw131() { GenerateLabel(131, "w") ;}
    public void wdraw132() { GenerateLabel(132, "w") ;}
    public void wdraw133() { GenerateLabel(133, "w") ;}
    public void wdraw134() { GenerateLabel(134, "w") ;}
    public void wdraw135() { GenerateLabel(135, "w") ;}
    public void wdraw136() { GenerateLabel(136, "w") ;}
    public void wdraw137() { GenerateLabel(137, "w") ;}
    public void wdraw138() { GenerateLabel(138, "w") ;}
    public void wdraw139() { GenerateLabel(139, "w") ;}
    public void wdraw140() { GenerateLabel(140, "w") ;}
    public void wdraw141() { GenerateLabel(141, "w") ;}
    public void wdraw142() { GenerateLabel(142, "w") ;}
    public void wdraw143() { GenerateLabel(143, "w") ;}
    public void wdraw144() { GenerateLabel(144, "w") ;}
    public void wdraw145() { GenerateLabel(145, "w") ;}
    public void wdraw146() { GenerateLabel(146, "w") ;}
    public void wdraw147() { GenerateLabel(147, "w") ;}
    public void wdraw148() { GenerateLabel(148, "w") ;}
    public void wdraw149() { GenerateLabel(149, "w") ;}
    public void wdraw150() { GenerateLabel(150, "w") ;}
    public void wdraw151() { GenerateLabel(151, "w") ;}
    public void wdraw152() { GenerateLabel(152, "w") ;}
    public void wdraw153() { GenerateLabel(153, "w") ;}
    public void wdraw154() { GenerateLabel(154, "w") ;}
    public void wdraw155() { GenerateLabel(155, "w") ;}
    public void wdraw156() { GenerateLabel(156, "w") ;}
    public void wdraw157() { GenerateLabel(157, "w") ;}
    public void wdraw158() { GenerateLabel(158, "w") ;}
    public void wdraw159() { GenerateLabel(159, "w") ;}
    public void wdraw160() { GenerateLabel(160, "w") ;}
    public void wdraw161() { GenerateLabel(161, "w") ;}
    public void wdraw162() { GenerateLabel(162, "w") ;}
    public void wdraw163() { GenerateLabel(163, "w") ;}
    public void wdraw164() { GenerateLabel(164, "w") ;}
    public void wdraw165() { GenerateLabel(165, "w") ;}
    public void wdraw166() { GenerateLabel(166, "w") ;}
    public void wdraw167() { GenerateLabel(167, "w") ;}
    public void wdraw168() { GenerateLabel(168, "w") ;}
    public void wdraw169() { GenerateLabel(169, "w") ;}
    public void wdraw170() { GenerateLabel(170, "w") ;}
    public void wdraw171() { GenerateLabel(171, "w") ;}
    public void wdraw172() { GenerateLabel(172, "w") ;}
    public void wdraw173() { GenerateLabel(173, "w") ;}
    public void wdraw174() { GenerateLabel(174, "w") ;}
    public void wdraw175() { GenerateLabel(175, "w") ;}
    public void wdraw176() { GenerateLabel(176, "w") ;}
    public void wdraw177() { GenerateLabel(177, "w") ;}
    public void wdraw178() { GenerateLabel(178, "w") ;}
    public void wdraw179() { GenerateLabel(179, "w") ;}
    public void wdraw180() { GenerateLabel(180, "w") ;}
    public void wdraw181() { GenerateLabel(181, "w") ;}
    public void wdraw182() { GenerateLabel(182, "w") ;}
    public void wdraw183() { GenerateLabel(183, "w") ;}
    public void wdraw184() { GenerateLabel(184, "w") ;}
    public void wdraw185() { GenerateLabel(185, "w") ;}
    public void wdraw186() { GenerateLabel(186, "w") ;}
    public void wdraw187() { GenerateLabel(187, "w") ;}
    public void wdraw188() { GenerateLabel(188, "w") ;}
    public void wdraw189() { GenerateLabel(189, "w") ;}
    public void wdraw190() { GenerateLabel(190, "w") ;}
    public void wdraw191() { GenerateLabel(191, "w") ;}
    public void wdraw192() { GenerateLabel(192, "w") ;}
    public void wdraw193() { GenerateLabel(193, "w") ;}
    public void wdraw194() { GenerateLabel(194, "w") ;}
    public void wdraw195() { GenerateLabel(195, "w") ;}
    public void wdraw196() { GenerateLabel(196, "w") ;}
    public void wdraw197() { GenerateLabel(197, "w") ;}
    public void wdraw198() { GenerateLabel(198, "w") ;}
    public void wdraw199() { GenerateLabel(199, "w") ;}
    public void wdraw200() { GenerateLabel(200, "w") ;}
    public void wdraw201() { GenerateLabel(201, "w") ;}
    public void wdraw202() { GenerateLabel(202, "w") ;}
    public void wdraw203() { GenerateLabel(203, "w") ;}
    public void wdraw204() { GenerateLabel(204, "w") ;}
    public void wdraw205() { GenerateLabel(205, "w") ;}
    public void wdraw206() { GenerateLabel(206, "w") ;}
    public void wdraw207() { GenerateLabel(207, "w") ;}
    public void wdraw208() { GenerateLabel(208, "w") ;}
    public void wdraw209() { GenerateLabel(209, "w") ;}
    public void wdraw210() { GenerateLabel(210, "w") ;}
    public void wdraw211() { GenerateLabel(211, "w") ;}
    public void wdraw212() { GenerateLabel(212, "w") ;}
    public void wdraw213() { GenerateLabel(213, "w") ;}
    public void wdraw214() { GenerateLabel(214, "w") ;}
    public void wdraw215() { GenerateLabel(215, "w") ;}
    public void wdraw216() { GenerateLabel(216, "w") ;}
    public void wdraw217() { GenerateLabel(217, "w") ;}
    public void wdraw218() { GenerateLabel(218, "w") ;}
    public void wdraw219() { GenerateLabel(219, "w") ;}
    public void wdraw220() { GenerateLabel(220, "w") ;}
    public void wdraw221() { GenerateLabel(221, "w") ;}
    public void wdraw222() { GenerateLabel(222, "w") ;}
    public void wdraw223() { GenerateLabel(223, "w") ;}
    public void wdraw224() { GenerateLabel(224, "w") ;}
    public void wdraw225() { GenerateLabel(225, "w") ;}
    public void wdraw226() { GenerateLabel(226, "w") ;}
    public void wdraw227() { GenerateLabel(227, "w") ;}
    public void wdraw228() { GenerateLabel(228, "w") ;}
    public void wdraw229() { GenerateLabel(229, "w") ;}
    public void wdraw230() { GenerateLabel(230, "w") ;}
    public void wdraw231() { GenerateLabel(231, "w") ;}
    public void wdraw232() { GenerateLabel(232, "w") ;}
    public void wdraw233() { GenerateLabel(233, "w") ;}
    public void wdraw234() { GenerateLabel(234, "w") ;}
    public void wdraw235() { GenerateLabel(235, "w") ;}
    public void wdraw236() { GenerateLabel(236, "w") ;}
    public void wdraw237() { GenerateLabel(237, "w") ;}
    public void wdraw238() { GenerateLabel(238, "w") ;}
    public void wdraw239() { GenerateLabel(239, "w") ;}
    public void wdraw240() { GenerateLabel(240, "w") ;}
    public void wdraw241() { GenerateLabel(241, "w") ;}
    public void wdraw242() { GenerateLabel(242, "w") ;}
    public void wdraw243() { GenerateLabel(243, "w") ;}
    public void wdraw244() { GenerateLabel(244, "w") ;}
    public void wdraw245() { GenerateLabel(245, "w") ;}
    public void wdraw246() { GenerateLabel(246, "w") ;}
    public void wdraw247() { GenerateLabel(247, "w") ;}
    public void wdraw248() { GenerateLabel(248, "w") ;}
    public void wdraw249() { GenerateLabel(249, "w") ;}
    public void wdraw250() { GenerateLabel(250, "w") ;}
    public void wdraw251() { GenerateLabel(251, "w") ;}
    public void wdraw252() { GenerateLabel(252, "w") ;}
    public void wdraw253() { GenerateLabel(253, "w") ;}
    public void wdraw254() { GenerateLabel(254, "w") ;}
    public void wdraw255() { GenerateLabel(255, "w") ;}
    public void wdraw256() { GenerateLabel(256, "w") ;}
    public void wdraw257() { GenerateLabel(257, "w") ;}
    public void wdraw258() { GenerateLabel(258, "w") ;}
    public void wdraw259() { GenerateLabel(259, "w") ;}
    public void wdraw260() { GenerateLabel(260, "w") ;}
    public void wdraw261() { GenerateLabel(261, "w") ;}
    public void wdraw262() { GenerateLabel(262, "w") ;}
    public void wdraw263() { GenerateLabel(263, "w") ;}
    public void wdraw264() { GenerateLabel(264, "w") ;}
    public void wdraw265() { GenerateLabel(265, "w") ;}
    public void wdraw266() { GenerateLabel(266, "w") ;}
    public void wdraw267() { GenerateLabel(267, "w") ;}
    public void wdraw268() { GenerateLabel(268, "w") ;}
    public void wdraw269() { GenerateLabel(269, "w") ;}
    public void wdraw270() { GenerateLabel(270, "w") ;}
    public void wdraw271() { GenerateLabel(271, "w") ;}
    public void wdraw272() { GenerateLabel(272, "w") ;}
    public void wdraw273() { GenerateLabel(273, "w") ;}
    public void wdraw274() { GenerateLabel(274, "w") ;}
    public void wdraw275() { GenerateLabel(275, "w") ;}
    public void wdraw276() { GenerateLabel(276, "w") ;}
    public void wdraw277() { GenerateLabel(277, "w") ;}
    public void wdraw278() { GenerateLabel(278, "w") ;}
    public void wdraw279() { GenerateLabel(279, "w") ;}
    public void wdraw280() { GenerateLabel(280, "w") ;}
    public void wdraw281() { GenerateLabel(281, "w") ;}
    public void wdraw282() { GenerateLabel(282, "w") ;}
    public void wdraw283() { GenerateLabel(283, "w") ;}
    public void wdraw284() { GenerateLabel(284, "w") ;}
    public void wdraw285() { GenerateLabel(285, "w") ;}
    public void wdraw286() { GenerateLabel(286, "w") ;}
    public void wdraw287() { GenerateLabel(287, "w") ;}
    public void wdraw288() { GenerateLabel(288, "w") ;}
    public void wdraw289() { GenerateLabel(289, "w") ;}
    public void wdraw290() { GenerateLabel(290, "w") ;}
    public void wdraw291() { GenerateLabel(291, "w") ;}
    public void wdraw292() { GenerateLabel(292, "w") ;}
    public void wdraw293() { GenerateLabel(293, "w") ;}
    public void wdraw294() { GenerateLabel(294, "w") ;}
    public void wdraw295() { GenerateLabel(295, "w") ;}
    public void wdraw296() { GenerateLabel(296, "w") ;}
    public void wdraw297() { GenerateLabel(297, "w") ;}
    public void wdraw298() { GenerateLabel(298, "w") ;}
    public void wdraw299() { GenerateLabel(299, "w") ;}
    
    public void bdraw0() { GenerateLabel(0, "b") ;}
    public void bdraw1() { GenerateLabel(1, "b") ;}
    public void bdraw2() { GenerateLabel(2, "b") ;}
    public void bdraw3() { GenerateLabel(3, "b") ;}
    public void bdraw4() { GenerateLabel(4, "b") ;}
    public void bdraw5() { GenerateLabel(5, "b") ;}
    public void bdraw6() { GenerateLabel(6, "b") ;}
    public void bdraw7() { GenerateLabel(7, "b") ;}
    public void bdraw8() { GenerateLabel(8, "b") ;}
    public void bdraw9() { GenerateLabel(9, "b") ;}
    public void bdraw10() { GenerateLabel(10, "b") ;}
    public void bdraw11() { GenerateLabel(11, "b") ;}
    public void bdraw12() { GenerateLabel(12, "b") ;}
    public void bdraw13() { GenerateLabel(13, "b") ;}
    public void bdraw14() { GenerateLabel(14, "b") ;}
    public void bdraw15() { GenerateLabel(15, "b") ;}
    public void bdraw16() { GenerateLabel(16, "b") ;}
    public void bdraw17() { GenerateLabel(17, "b") ;}
    public void bdraw18() { GenerateLabel(18, "b") ;}
    public void bdraw19() { GenerateLabel(19, "b") ;}
    public void bdraw20() { GenerateLabel(20, "b") ;}
    public void bdraw21() { GenerateLabel(21, "b") ;}
    public void bdraw22() { GenerateLabel(22, "b") ;}
    public void bdraw23() { GenerateLabel(23, "b") ;}
    public void bdraw24() { GenerateLabel(24, "b") ;}
    public void bdraw25() { GenerateLabel(25, "b") ;}
    public void bdraw26() { GenerateLabel(26, "b") ;}
    public void bdraw27() { GenerateLabel(27, "b") ;}
    public void bdraw28() { GenerateLabel(28, "b") ;}
    public void bdraw29() { GenerateLabel(29, "b") ;}
    public void bdraw30() { GenerateLabel(30, "b") ;}
    public void bdraw31() { GenerateLabel(31, "b") ;}
    public void bdraw32() { GenerateLabel(32, "b") ;}
    public void bdraw33() { GenerateLabel(33, "b") ;}
    public void bdraw34() { GenerateLabel(34, "b") ;}
    public void bdraw35() { GenerateLabel(35, "b") ;}
    public void bdraw36() { GenerateLabel(36, "b") ;}
    public void bdraw37() { GenerateLabel(37, "b") ;}
    public void bdraw38() { GenerateLabel(38, "b") ;}
    public void bdraw39() { GenerateLabel(39, "b") ;}
    public void bdraw40() { GenerateLabel(40, "b") ;}
    public void bdraw41() { GenerateLabel(41, "b") ;}
    public void bdraw42() { GenerateLabel(42, "b") ;}
    public void bdraw43() { GenerateLabel(43, "b") ;}
    public void bdraw44() { GenerateLabel(44, "b") ;}
    public void bdraw45() { GenerateLabel(45, "b") ;}
    public void bdraw46() { GenerateLabel(46, "b") ;}
    public void bdraw47() { GenerateLabel(47, "b") ;}
    public void bdraw48() { GenerateLabel(48, "b") ;}
    public void bdraw49() { GenerateLabel(49, "b") ;}
    public void bdraw50() { GenerateLabel(50, "b") ;}
    public void bdraw51() { GenerateLabel(51, "b") ;}
    public void bdraw52() { GenerateLabel(52, "b") ;}
    public void bdraw53() { GenerateLabel(53, "b") ;}
    public void bdraw54() { GenerateLabel(54, "b") ;}
    public void bdraw55() { GenerateLabel(55, "b") ;}
    public void bdraw56() { GenerateLabel(56, "b") ;}
    public void bdraw57() { GenerateLabel(57, "b") ;}
    public void bdraw58() { GenerateLabel(58, "b") ;}
    public void bdraw59() { GenerateLabel(59, "b") ;}
    public void bdraw60() { GenerateLabel(60, "b") ;}
    public void bdraw61() { GenerateLabel(61, "b") ;}
    public void bdraw62() { GenerateLabel(62, "b") ;}
    public void bdraw63() { GenerateLabel(63, "b") ;}
    public void bdraw64() { GenerateLabel(64, "b") ;}
    public void bdraw65() { GenerateLabel(65, "b") ;}
    public void bdraw66() { GenerateLabel(66, "b") ;}
    public void bdraw67() { GenerateLabel(67, "b") ;}
    public void bdraw68() { GenerateLabel(68, "b") ;}
    public void bdraw69() { GenerateLabel(69, "b") ;}
    public void bdraw70() { GenerateLabel(70, "b") ;}
    public void bdraw71() { GenerateLabel(71, "b") ;}
    public void bdraw72() { GenerateLabel(72, "b") ;}
    public void bdraw73() { GenerateLabel(73, "b") ;}
    public void bdraw74() { GenerateLabel(74, "b") ;}
    public void bdraw75() { GenerateLabel(75, "b") ;}
    public void bdraw76() { GenerateLabel(76, "b") ;}
    public void bdraw77() { GenerateLabel(77, "b") ;}
    public void bdraw78() { GenerateLabel(78, "b") ;}
    public void bdraw79() { GenerateLabel(79, "b") ;}
    public void bdraw80() { GenerateLabel(80, "b") ;}
    public void bdraw81() { GenerateLabel(81, "b") ;}
    public void bdraw82() { GenerateLabel(82, "b") ;}
    public void bdraw83() { GenerateLabel(83, "b") ;}
    public void bdraw84() { GenerateLabel(84, "b") ;}
    public void bdraw85() { GenerateLabel(85, "b") ;}
    public void bdraw86() { GenerateLabel(86, "b") ;}
    public void bdraw87() { GenerateLabel(87, "b") ;}
    public void bdraw88() { GenerateLabel(88, "b") ;}
    public void bdraw89() { GenerateLabel(89, "b") ;}
    public void bdraw90() { GenerateLabel(90, "b") ;}
    public void bdraw91() { GenerateLabel(91, "b") ;}
    public void bdraw92() { GenerateLabel(92, "b") ;}
    public void bdraw93() { GenerateLabel(93, "b") ;}
    public void bdraw94() { GenerateLabel(94, "b") ;}
    public void bdraw95() { GenerateLabel(95, "b") ;}
    public void bdraw96() { GenerateLabel(96, "b") ;}
    public void bdraw97() { GenerateLabel(97, "b") ;}
    public void bdraw98() { GenerateLabel(98, "b") ;}
    public void bdraw99() { GenerateLabel(99, "b") ;}
    public void bdraw100() { GenerateLabel(100, "b") ;}
    public void bdraw101() { GenerateLabel(101, "b") ;}
    public void bdraw102() { GenerateLabel(102, "b") ;}
    public void bdraw103() { GenerateLabel(103, "b") ;}
    public void bdraw104() { GenerateLabel(104, "b") ;}
    public void bdraw105() { GenerateLabel(105, "b") ;}
    public void bdraw106() { GenerateLabel(106, "b") ;}
    public void bdraw107() { GenerateLabel(107, "b") ;}
    public void bdraw108() { GenerateLabel(108, "b") ;}
    public void bdraw109() { GenerateLabel(109, "b") ;}
    public void bdraw110() { GenerateLabel(110, "b") ;}
    public void bdraw111() { GenerateLabel(111, "b") ;}
    public void bdraw112() { GenerateLabel(112, "b") ;}
    public void bdraw113() { GenerateLabel(113, "b") ;}
    public void bdraw114() { GenerateLabel(114, "b") ;}
    public void bdraw115() { GenerateLabel(115, "b") ;}
    public void bdraw116() { GenerateLabel(116, "b") ;}
    public void bdraw117() { GenerateLabel(117, "b") ;}
    public void bdraw118() { GenerateLabel(118, "b") ;}
    public void bdraw119() { GenerateLabel(119, "b") ;}
    public void bdraw120() { GenerateLabel(120, "b") ;}
    public void bdraw121() { GenerateLabel(121, "b") ;}
    public void bdraw122() { GenerateLabel(122, "b") ;}
    public void bdraw123() { GenerateLabel(123, "b") ;}
    public void bdraw124() { GenerateLabel(124, "b") ;}
    public void bdraw125() { GenerateLabel(125, "b") ;}
    public void bdraw126() { GenerateLabel(126, "b") ;}
    public void bdraw127() { GenerateLabel(127, "b") ;}
    public void bdraw128() { GenerateLabel(128, "b") ;}
    public void bdraw129() { GenerateLabel(129, "b") ;}
    public void bdraw130() { GenerateLabel(130, "b") ;}
    public void bdraw131() { GenerateLabel(131, "b") ;}
    public void bdraw132() { GenerateLabel(132, "b") ;}
    public void bdraw133() { GenerateLabel(133, "b") ;}
    public void bdraw134() { GenerateLabel(134, "b") ;}
    public void bdraw135() { GenerateLabel(135, "b") ;}
    public void bdraw136() { GenerateLabel(136, "b") ;}
    public void bdraw137() { GenerateLabel(137, "b") ;}
    public void bdraw138() { GenerateLabel(138, "b") ;}
    public void bdraw139() { GenerateLabel(139, "b") ;}
    public void bdraw140() { GenerateLabel(140, "b") ;}
    public void bdraw141() { GenerateLabel(141, "b") ;}
    public void bdraw142() { GenerateLabel(142, "b") ;}
    public void bdraw143() { GenerateLabel(143, "b") ;}
    public void bdraw144() { GenerateLabel(144, "b") ;}
    public void bdraw145() { GenerateLabel(145, "b") ;}
    public void bdraw146() { GenerateLabel(146, "b") ;}
    public void bdraw147() { GenerateLabel(147, "b") ;}
    public void bdraw148() { GenerateLabel(148, "b") ;}
    public void bdraw149() { GenerateLabel(149, "b") ;}
    public void bdraw150() { GenerateLabel(150, "b") ;}
    public void bdraw151() { GenerateLabel(151, "b") ;}
    public void bdraw152() { GenerateLabel(152, "b") ;}
    public void bdraw153() { GenerateLabel(153, "b") ;}
    public void bdraw154() { GenerateLabel(154, "b") ;}
    public void bdraw155() { GenerateLabel(155, "b") ;}
    public void bdraw156() { GenerateLabel(156, "b") ;}
    public void bdraw157() { GenerateLabel(157, "b") ;}
    public void bdraw158() { GenerateLabel(158, "b") ;}
    public void bdraw159() { GenerateLabel(159, "b") ;}
    public void bdraw160() { GenerateLabel(160, "b") ;}
    public void bdraw161() { GenerateLabel(161, "b") ;}
    public void bdraw162() { GenerateLabel(162, "b") ;}
    public void bdraw163() { GenerateLabel(163, "b") ;}
    public void bdraw164() { GenerateLabel(164, "b") ;}
    public void bdraw165() { GenerateLabel(165, "b") ;}
    public void bdraw166() { GenerateLabel(166, "b") ;}
    public void bdraw167() { GenerateLabel(167, "b") ;}
    public void bdraw168() { GenerateLabel(168, "b") ;}
    public void bdraw169() { GenerateLabel(169, "b") ;}
    public void bdraw170() { GenerateLabel(170, "b") ;}
    public void bdraw171() { GenerateLabel(171, "b") ;}
    public void bdraw172() { GenerateLabel(172, "b") ;}
    public void bdraw173() { GenerateLabel(173, "b") ;}
    public void bdraw174() { GenerateLabel(174, "b") ;}
    public void bdraw175() { GenerateLabel(175, "b") ;}
    public void bdraw176() { GenerateLabel(176, "b") ;}
    public void bdraw177() { GenerateLabel(177, "b") ;}
    public void bdraw178() { GenerateLabel(178, "b") ;}
    public void bdraw179() { GenerateLabel(179, "b") ;}
    public void bdraw180() { GenerateLabel(180, "b") ;}
    public void bdraw181() { GenerateLabel(181, "b") ;}
    public void bdraw182() { GenerateLabel(182, "b") ;}
    public void bdraw183() { GenerateLabel(183, "b") ;}
    public void bdraw184() { GenerateLabel(184, "b") ;}
    public void bdraw185() { GenerateLabel(185, "b") ;}
    public void bdraw186() { GenerateLabel(186, "b") ;}
    public void bdraw187() { GenerateLabel(187, "b") ;}
    public void bdraw188() { GenerateLabel(188, "b") ;}
    public void bdraw189() { GenerateLabel(189, "b") ;}
    public void bdraw190() { GenerateLabel(190, "b") ;}
    public void bdraw191() { GenerateLabel(191, "b") ;}
    public void bdraw192() { GenerateLabel(192, "b") ;}
    public void bdraw193() { GenerateLabel(193, "b") ;}
    public void bdraw194() { GenerateLabel(194, "b") ;}
    public void bdraw195() { GenerateLabel(195, "b") ;}
    public void bdraw196() { GenerateLabel(196, "b") ;}
    public void bdraw197() { GenerateLabel(197, "b") ;}
    public void bdraw198() { GenerateLabel(198, "b") ;}
    public void bdraw199() { GenerateLabel(199, "b") ;}
    public void bdraw200() { GenerateLabel(200, "b") ;}
    public void bdraw201() { GenerateLabel(201, "b") ;}
    public void bdraw202() { GenerateLabel(202, "b") ;}
    public void bdraw203() { GenerateLabel(203, "b") ;}
    public void bdraw204() { GenerateLabel(204, "b") ;}
    public void bdraw205() { GenerateLabel(205, "b") ;}
    public void bdraw206() { GenerateLabel(206, "b") ;}
    public void bdraw207() { GenerateLabel(207, "b") ;}
    public void bdraw208() { GenerateLabel(208, "b") ;}
    public void bdraw209() { GenerateLabel(209, "b") ;}
    public void bdraw210() { GenerateLabel(210, "b") ;}
    public void bdraw211() { GenerateLabel(211, "b") ;}
    public void bdraw212() { GenerateLabel(212, "b") ;}
    public void bdraw213() { GenerateLabel(213, "b") ;}
    public void bdraw214() { GenerateLabel(214, "b") ;}
    public void bdraw215() { GenerateLabel(215, "b") ;}
    public void bdraw216() { GenerateLabel(216, "b") ;}
    public void bdraw217() { GenerateLabel(217, "b") ;}
    public void bdraw218() { GenerateLabel(218, "b") ;}
    public void bdraw219() { GenerateLabel(219, "b") ;}
    public void bdraw220() { GenerateLabel(220, "b") ;}
    public void bdraw221() { GenerateLabel(221, "b") ;}
    public void bdraw222() { GenerateLabel(222, "b") ;}
    public void bdraw223() { GenerateLabel(223, "b") ;}
    public void bdraw224() { GenerateLabel(224, "b") ;}
    public void bdraw225() { GenerateLabel(225, "b") ;}
    public void bdraw226() { GenerateLabel(226, "b") ;}
    public void bdraw227() { GenerateLabel(227, "b") ;}
    public void bdraw228() { GenerateLabel(228, "b") ;}
    public void bdraw229() { GenerateLabel(229, "b") ;}
    public void bdraw230() { GenerateLabel(230, "b") ;}
    public void bdraw231() { GenerateLabel(231, "b") ;}
    public void bdraw232() { GenerateLabel(232, "b") ;}
    public void bdraw233() { GenerateLabel(233, "b") ;}
    public void bdraw234() { GenerateLabel(234, "b") ;}
    public void bdraw235() { GenerateLabel(235, "b") ;}
    public void bdraw236() { GenerateLabel(236, "b") ;}
    public void bdraw237() { GenerateLabel(237, "b") ;}
    public void bdraw238() { GenerateLabel(238, "b") ;}
    public void bdraw239() { GenerateLabel(239, "b") ;}
    public void bdraw240() { GenerateLabel(240, "b") ;}
    public void bdraw241() { GenerateLabel(241, "b") ;}
    public void bdraw242() { GenerateLabel(242, "b") ;}
    public void bdraw243() { GenerateLabel(243, "b") ;}
    public void bdraw244() { GenerateLabel(244, "b") ;}
    public void bdraw245() { GenerateLabel(245, "b") ;}
    public void bdraw246() { GenerateLabel(246, "b") ;}
    public void bdraw247() { GenerateLabel(247, "b") ;}
    public void bdraw248() { GenerateLabel(248, "b") ;}
    public void bdraw249() { GenerateLabel(249, "b") ;}
    public void bdraw250() { GenerateLabel(250, "b") ;}
    public void bdraw251() { GenerateLabel(251, "b") ;}
    public void bdraw252() { GenerateLabel(252, "b") ;}
    public void bdraw253() { GenerateLabel(253, "b") ;}
    public void bdraw254() { GenerateLabel(254, "b") ;}
    public void bdraw255() { GenerateLabel(255, "b") ;}
    public void bdraw256() { GenerateLabel(256, "b") ;}
    public void bdraw257() { GenerateLabel(257, "b") ;}
    public void bdraw258() { GenerateLabel(258, "b") ;}
    public void bdraw259() { GenerateLabel(259, "b") ;}
    public void bdraw260() { GenerateLabel(260, "b") ;}
    public void bdraw261() { GenerateLabel(261, "b") ;}
    public void bdraw262() { GenerateLabel(262, "b") ;}
    public void bdraw263() { GenerateLabel(263, "b") ;}
    public void bdraw264() { GenerateLabel(264, "b") ;}
    public void bdraw265() { GenerateLabel(265, "b") ;}
    public void bdraw266() { GenerateLabel(266, "b") ;}
    public void bdraw267() { GenerateLabel(267, "b") ;}
    public void bdraw268() { GenerateLabel(268, "b") ;}
    public void bdraw269() { GenerateLabel(269, "b") ;}
    public void bdraw270() { GenerateLabel(270, "b") ;}
    public void bdraw271() { GenerateLabel(271, "b") ;}
    public void bdraw272() { GenerateLabel(272, "b") ;}
    public void bdraw273() { GenerateLabel(273, "b") ;}
    public void bdraw274() { GenerateLabel(274, "b") ;}
    public void bdraw275() { GenerateLabel(275, "b") ;}
    public void bdraw276() { GenerateLabel(276, "b") ;}
    public void bdraw277() { GenerateLabel(277, "b") ;}
    public void bdraw278() { GenerateLabel(278, "b") ;}
    public void bdraw279() { GenerateLabel(279, "b") ;}
    public void bdraw280() { GenerateLabel(280, "b") ;}
    public void bdraw281() { GenerateLabel(281, "b") ;}
    public void bdraw282() { GenerateLabel(282, "b") ;}
    public void bdraw283() { GenerateLabel(283, "b") ;}
    public void bdraw284() { GenerateLabel(284, "b") ;}
    public void bdraw285() { GenerateLabel(285, "b") ;}
    public void bdraw286() { GenerateLabel(286, "b") ;}
    public void bdraw287() { GenerateLabel(287, "b") ;}
    public void bdraw288() { GenerateLabel(288, "b") ;}
    public void bdraw289() { GenerateLabel(289, "b") ;}
    public void bdraw290() { GenerateLabel(290, "b") ;}
    public void bdraw291() { GenerateLabel(291, "b") ;}
    public void bdraw292() { GenerateLabel(292, "b") ;}
    public void bdraw293() { GenerateLabel(293, "b") ;}
    public void bdraw294() { GenerateLabel(294, "b") ;}
    public void bdraw295() { GenerateLabel(295, "b") ;}
    public void bdraw296() { GenerateLabel(296, "b") ;}
    public void bdraw297() { GenerateLabel(297, "b") ;}
    public void bdraw298() { GenerateLabel(298, "b") ;}
    public void bdraw299() { GenerateLabel(299, "b") ;}
    
    public void white1() { SendCustomNetworkEvent(NetworkEventTarget.All, "cardPick1"); }
    public void white2() { SendCustomNetworkEvent(NetworkEventTarget.All, "cardPick2"); }
    public void white3() { SendCustomNetworkEvent(NetworkEventTarget.All, "cardPick3"); }
    public void black1() { SendCustomNetworkEvent(NetworkEventTarget.All, "cardPick4"); }
    public void black2() { SendCustomNetworkEvent(NetworkEventTarget.All, "cardPick5"); }
    public void black3() { SendCustomNetworkEvent(NetworkEventTarget.All, "cardPick6"); }
    
    public void cardPick1(){ CardPick(0);}
    public void cardPick2(){ CardPick(1);}
    public void cardPick3(){ CardPick(2);}
    public void cardPick4(){ CardPick(3);}
    public void cardPick5(){ CardPick(4);}
    public void cardPick6(){ CardPick(5);}

    public void CardPick(int elm)
    {
        if (elm < 3)
        {
            whiteCard.GetComponentInChildren<Text>().text = buttons[elm].GetComponentInChildren<Text>().text;
            cardSwitch1.SetActive(true);
            cardSelect1.SetActive(false);
        }
        else
        {
            blackCard.GetComponentInChildren<Text>().text = buttons[elm].GetComponentInChildren<Text>().text;
            cardSwitch2.SetActive(true);
            cardSelect2.SetActive(false);
        }
    }

    public void create_additive()
    {
        additiveCard.GetComponentInChildren<Text>().text = buttons[6].GetComponentInChildren<Text>().text;
    }
    public void GenerateLabel(int id, string color)
    {
        if (color == "w")
        {
            buttons[_currentCard].GetComponentInChildren<Text>().text = _characterCardSet[id];
        }
        if (color == "b")
        {
            buttons[_currentCard].GetComponentInChildren<Text>().text = _attributeCardSet[id];
        }
        _currentCard++;
    }

    public void reset_current_card()
    {
        _currentCard = 0;
    }

    public void switchUI()
    {
        interactButton.SetActive(false);
    }

    public void reset_card_position()
    {
        SendCustomNetworkEvent(NetworkEventTarget.All, "card_reset");
    }

    public void card_reset()
    {
        whiteCard.transform.position = cardResetPositions[0].transform.position;
        whiteCard.transform.rotation = cardResetPositions[0].transform.rotation;
        blackCard.transform.position = cardResetPositions[1].transform.position;
        blackCard.transform.rotation = cardResetPositions[1].transform.rotation;
        additiveCard.transform.position = cardResetPositions[2].transform.position;
        additiveCard.transform.rotation = cardResetPositions[2].transform.rotation;
    }
}
