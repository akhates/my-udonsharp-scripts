
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class SuperfightScenarioRandomizer : UdonSharpBehaviour
{
	
	// had to make it separate since it's new type of card aside from character and attribute
	
    [SerializeField] string[] scenarioDeckLabels;
    [SerializeField] GameObject card;
    [SerializeField] Transform target;
    void Start()
    {
        int seed = (int) Time.time;
        UnityEngine.Random.InitState(seed);
    }

    public override void Interact()
    {
        int a;
        a = UnityEngine.Random.Range(0, scenarioDeckLabels.Length);
        SendCustomNetworkEvent(NetworkEventTarget.All, "wdraw" + a.ToString());
    }
    
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
    
    public void GenerateLabel(int value, string type)
    {
        card.SetActive(true);
        card.transform.position = target.position;
        card.transform.rotation = target.rotation;
        card.GetComponentInChildren<Text>().text = scenarioDeckLabels[value];
    }
}
