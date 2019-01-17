// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint2
    {
        [TestCompiler]
        public static void uint2_zero()
        {
            TestUtils.AreEqual(uint2.zero.x, 0u);
            TestUtils.AreEqual(uint2.zero.y, 0u);
        }

        [TestCompiler]
        public static void uint2_constructor()
        {
            uint2 a = new uint2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public static void uint2_scalar_constructor()
        {
            uint2 a = new uint2(17u);
            TestUtils.AreEqual(a.x, 17u);
            TestUtils.AreEqual(a.y, 17u);
        }

        [TestCompiler]
        public static void uint2_static_constructor()
        {
            uint2 a = uint2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public static void uint2_static_scalar_constructor()
        {
            uint2 a = uint2(17u);
            TestUtils.AreEqual(a.x, 17u);
            TestUtils.AreEqual(a.y, 17u);
        }

        [TestCompiler]
        public static void uint2_operator_equal_wide_wide()
        {
            uint2 a0 = uint2(790229414, 970783976);
            uint2 b0 = uint2(612337669, 1214209108);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint2 a1 = uint2(1428432738, 1578747135);
            uint2 b1 = uint2(2120643427, 295461214);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint2 a2 = uint2(1733797753, 2001507228);
            uint2 b2 = uint2(1510890331, 1893316566);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint2 a3 = uint2(1446876437, 1777406370);
            uint2 b3 = uint2(921816149, 1834958575);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_equal_wide_scalar()
        {
            uint2 a0 = uint2(1211464300, 1921862607);
            uint b0 = (746972502);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint2 a1 = uint2(508076684, 1394594555);
            uint b1 = (1249127920);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint2 a2 = uint2(746862310, 1884008277);
            uint b2 = (1733655277);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint2 a3 = uint2(1682018538, 936027116);
            uint b3 = (795585660);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_equal_scalar_wide()
        {
            uint a0 = (1150044438);
            uint2 b0 = uint2(233855098, 924242519);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (1402948791);
            uint2 b1 = uint2(601381975, 2120518068);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (629187703);
            uint2 b2 = uint2(1971977031, 47183124);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (1061805787);
            uint2 b3 = uint2(1009011238, 312511148);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_not_equal_wide_wide()
        {
            uint2 a0 = uint2(1660932106, 982847023);
            uint2 b0 = uint2(107139049, 75478496);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint2 a1 = uint2(97046264, 1739517447);
            uint2 b1 = uint2(2055495054, 358586687);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint2 a2 = uint2(1253499180, 1830584069);
            uint2 b2 = uint2(942338347, 111564990);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint2 a3 = uint2(1841470429, 1397841646);
            uint2 b3 = uint2(113811950, 948912488);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_not_equal_wide_scalar()
        {
            uint2 a0 = uint2(747758183, 1033001286);
            uint b0 = (248693828);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint2 a1 = uint2(1439973882, 1197845089);
            uint b1 = (2138928797);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint2 a2 = uint2(1432672459, 238704450);
            uint b2 = (950170763);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint2 a3 = uint2(2105962247, 1640688041);
            uint b3 = (727205263);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_not_equal_scalar_wide()
        {
            uint a0 = (2076921066);
            uint2 b0 = uint2(2037494727, 1989050616);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (48833929);
            uint2 b1 = uint2(1897435904, 514354517);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (1783749164);
            uint2 b2 = uint2(364694471, 754315072);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (124108032);
            uint2 b3 = uint2(1512967900, 1178825850);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_less_wide_wide()
        {
            uint2 a0 = uint2(1182186063, 415538999);
            uint2 b0 = uint2(524633529, 1032195686);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint2 a1 = uint2(1667335818, 1566618442);
            uint2 b1 = uint2(760723389, 1505751409);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint2 a2 = uint2(1166180837, 639095188);
            uint2 b2 = uint2(431962172, 1287906509);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint2 a3 = uint2(1080836365, 771119973);
            uint2 b3 = uint2(1560084663, 1450178202);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_less_wide_scalar()
        {
            uint2 a0 = uint2(608447185, 818840405);
            uint b0 = (1491216667);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint2 a1 = uint2(869219329, 1214500548);
            uint b1 = (2080125385);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint2 a2 = uint2(1361741203, 1615392341);
            uint b2 = (1667165786);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint2 a3 = uint2(840091491, 1247103789);
            uint b3 = (469591900);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_less_scalar_wide()
        {
            uint a0 = (548436837);
            uint2 b0 = uint2(282703327, 14370648);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (1862117300);
            uint2 b1 = uint2(1304793311, 826073259);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (988910157);
            uint2 b2 = uint2(445132446, 1139670255);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (111349251);
            uint2 b3 = uint2(1102440676, 112183144);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_greater_wide_wide()
        {
            uint2 a0 = uint2(592884447, 2133928932);
            uint2 b0 = uint2(138737040, 192863971);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint2 a1 = uint2(918957182, 1284069471);
            uint2 b1 = uint2(1700841444, 1044631301);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint2 a2 = uint2(194584707, 739120780);
            uint2 b2 = uint2(1391589821, 730837695);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint2 a3 = uint2(241654068, 1340158550);
            uint2 b3 = uint2(253553987, 2078872742);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_greater_wide_scalar()
        {
            uint2 a0 = uint2(1097138316, 211763648);
            uint b0 = (438688675);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint2 a1 = uint2(1883002501, 43662641);
            uint b1 = (56406996);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint2 a2 = uint2(1923456111, 1219010035);
            uint b2 = (1437755186);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint2 a3 = uint2(2125058448, 893125636);
            uint b3 = (304028799);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_greater_scalar_wide()
        {
            uint a0 = (2024896938);
            uint2 b0 = uint2(599356784, 185671342);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (1932327391);
            uint2 b1 = uint2(2025591013, 1257191721);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (1312388500);
            uint2 b2 = uint2(1443698859, 779217735);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (691047512);
            uint2 b3 = uint2(741776730, 732565983);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_less_equal_wide_wide()
        {
            uint2 a0 = uint2(1577248162, 2043073061);
            uint2 b0 = uint2(903445031, 2108974565);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint2 a1 = uint2(1688380407, 176431985);
            uint2 b1 = uint2(210822256, 1281704747);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint2 a2 = uint2(223299035, 1502802140);
            uint2 b2 = uint2(453681718, 66138830);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint2 a3 = uint2(1691709825, 386789394);
            uint2 b3 = uint2(1229799377, 1620922595);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_less_equal_wide_scalar()
        {
            uint2 a0 = uint2(1722165358, 1219858357);
            uint b0 = (1688048545);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint2 a1 = uint2(860410743, 348104022);
            uint b1 = (411099660);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint2 a2 = uint2(1963256951, 58924407);
            uint b2 = (212084836);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint2 a3 = uint2(1459242706, 532949158);
            uint b3 = (1745758438);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_less_equal_scalar_wide()
        {
            uint a0 = (1777585);
            uint2 b0 = uint2(1181030049, 1787703989);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (1729760948);
            uint2 b1 = uint2(1816537388, 1359786460);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (874999193);
            uint2 b2 = uint2(1678863148, 1711365839);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (762067160);
            uint2 b3 = uint2(11953554, 1131583906);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_greater_equal_wide_wide()
        {
            uint2 a0 = uint2(263000030, 744235661);
            uint2 b0 = uint2(1395535146, 1178373944);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint2 a1 = uint2(1893760267, 237248);
            uint2 b1 = uint2(1237373760, 1364855321);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint2 a2 = uint2(1062370984, 1676977687);
            uint2 b2 = uint2(600811864, 362060472);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint2 a3 = uint2(816766880, 1089431546);
            uint2 b3 = uint2(290870624, 1839067862);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_greater_equal_wide_scalar()
        {
            uint2 a0 = uint2(2112791350, 1043657935);
            uint b0 = (1470533736);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint2 a1 = uint2(101764761, 556026890);
            uint b1 = (1529909067);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint2 a2 = uint2(281734132, 815093894);
            uint b2 = (1186600258);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint2 a3 = uint2(609211196, 829548642);
            uint b3 = (1604309397);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_greater_equal_scalar_wide()
        {
            uint a0 = (1525542481);
            uint2 b0 = uint2(1503244746, 861711266);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (817773856);
            uint2 b1 = uint2(925984572, 571221723);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (683686810);
            uint2 b2 = uint2(118252990, 1653952090);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (1240253990);
            uint2 b3 = uint2(1947039008, 1869136019);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_add_wide_wide()
        {
            uint2 a0 = uint2(2049228671, 1658660009);
            uint2 b0 = uint2(2088751567, 645762023);
            uint2 r0 = uint2(4137980238, 2304422032);
            TestUtils.AreEqual(a0 + b0, r0);

            uint2 a1 = uint2(491719392, 937013355);
            uint2 b1 = uint2(306868786, 4360271);
            uint2 r1 = uint2(798588178, 941373626);
            TestUtils.AreEqual(a1 + b1, r1);

            uint2 a2 = uint2(81108663, 1063894558);
            uint2 b2 = uint2(506047997, 2094559874);
            uint2 r2 = uint2(587156660, 3158454432);
            TestUtils.AreEqual(a2 + b2, r2);

            uint2 a3 = uint2(86954702, 843159721);
            uint2 b3 = uint2(1634712736, 1601474440);
            uint2 r3 = uint2(1721667438, 2444634161);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_add_wide_scalar()
        {
            uint2 a0 = uint2(2038218457, 134923711);
            uint b0 = (2124409227);
            uint2 r0 = uint2(4162627684, 2259332938);
            TestUtils.AreEqual(a0 + b0, r0);

            uint2 a1 = uint2(875689667, 997710928);
            uint b1 = (1338884463);
            uint2 r1 = uint2(2214574130, 2336595391);
            TestUtils.AreEqual(a1 + b1, r1);

            uint2 a2 = uint2(340490871, 70433301);
            uint b2 = (1067888129);
            uint2 r2 = uint2(1408379000, 1138321430);
            TestUtils.AreEqual(a2 + b2, r2);

            uint2 a3 = uint2(2003021861, 1160398286);
            uint b3 = (1635971971);
            uint2 r3 = uint2(3638993832, 2796370257);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_add_scalar_wide()
        {
            uint a0 = (391092078);
            uint2 b0 = uint2(519908870, 851424292);
            uint2 r0 = uint2(911000948, 1242516370);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (328314822);
            uint2 b1 = uint2(135622204, 740923360);
            uint2 r1 = uint2(463937026, 1069238182);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (655394201);
            uint2 b2 = uint2(1451896269, 1781697072);
            uint2 r2 = uint2(2107290470, 2437091273);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (996031825);
            uint2 b3 = uint2(1557774949, 779774940);
            uint2 r3 = uint2(2553806774, 1775806765);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_sub_wide_wide()
        {
            uint2 a0 = uint2(1353441118, 797269833);
            uint2 b0 = uint2(1332656812, 1827794007);
            uint2 r0 = uint2(20784306, 3264443122);
            TestUtils.AreEqual(a0 - b0, r0);

            uint2 a1 = uint2(659988112, 56022121);
            uint2 b1 = uint2(972557431, 2078233689);
            uint2 r1 = uint2(3982397977, 2272755728);
            TestUtils.AreEqual(a1 - b1, r1);

            uint2 a2 = uint2(365847472, 2062899435);
            uint2 b2 = uint2(1508184327, 1372307701);
            uint2 r2 = uint2(3152630441, 690591734);
            TestUtils.AreEqual(a2 - b2, r2);

            uint2 a3 = uint2(1380988474, 799885138);
            uint2 b3 = uint2(810327977, 936799885);
            uint2 r3 = uint2(570660497, 4158052549);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_sub_wide_scalar()
        {
            uint2 a0 = uint2(1176369558, 1934521195);
            uint b0 = (462232403);
            uint2 r0 = uint2(714137155, 1472288792);
            TestUtils.AreEqual(a0 - b0, r0);

            uint2 a1 = uint2(309452150, 108910717);
            uint b1 = (1417634074);
            uint2 r1 = uint2(3186785372, 2986243939);
            TestUtils.AreEqual(a1 - b1, r1);

            uint2 a2 = uint2(1306356714, 1451794815);
            uint b2 = (1502312334);
            uint2 r2 = uint2(4099011676, 4244449777);
            TestUtils.AreEqual(a2 - b2, r2);

            uint2 a3 = uint2(281174200, 1913724431);
            uint b3 = (87530840);
            uint2 r3 = uint2(193643360, 1826193591);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_sub_scalar_wide()
        {
            uint a0 = (1691534405);
            uint2 b0 = uint2(2022393810, 1612688515);
            uint2 r0 = uint2(3964107891, 78845890);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (496689713);
            uint2 b1 = uint2(887037586, 2097630964);
            uint2 r1 = uint2(3904619423, 2694026045);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (374934538);
            uint2 b2 = uint2(939035482, 935242277);
            uint2 r2 = uint2(3730866352, 3734659557);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (1789300421);
            uint2 b3 = uint2(264712893, 1231856067);
            uint2 r3 = uint2(1524587528, 557444354);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_mul_wide_wide()
        {
            uint2 a0 = uint2(245827027, 208934650);
            uint2 b0 = uint2(759663997, 350129201);
            uint2 r0 = uint2(3662155527, 1402281434);
            TestUtils.AreEqual(a0 * b0, r0);

            uint2 a1 = uint2(1019478917, 568231809);
            uint2 b1 = uint2(477450108, 1635735015);
            uint2 r1 = uint2(332447596, 2361989735);
            TestUtils.AreEqual(a1 * b1, r1);

            uint2 a2 = uint2(877289039, 1585782440);
            uint2 b2 = uint2(388710278, 757722665);
            uint2 r2 = uint2(2624048730, 1455036648);
            TestUtils.AreEqual(a2 * b2, r2);

            uint2 a3 = uint2(2111178729, 1186019069);
            uint2 b3 = uint2(1509388321, 1841703980);
            uint2 r3 = uint2(2128344329, 3700879228);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_mul_wide_scalar()
        {
            uint2 a0 = uint2(1762033447, 465343930);
            uint b0 = (1476837906);
            uint2 r0 = uint2(2981789374, 1326807828);
            TestUtils.AreEqual(a0 * b0, r0);

            uint2 a1 = uint2(1570757881, 1824319147);
            uint b1 = (1326409563);
            uint2 r1 = uint2(1666366339, 4042902473);
            TestUtils.AreEqual(a1 * b1, r1);

            uint2 a2 = uint2(1356578909, 154616909);
            uint b2 = (72749215);
            uint2 r2 = uint2(130042307, 1400257491);
            TestUtils.AreEqual(a2 * b2, r2);

            uint2 a3 = uint2(975743632, 1958912969);
            uint b3 = (573770299);
            uint2 r3 = uint2(414773040, 3595344211);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_mul_scalar_wide()
        {
            uint a0 = (99541948);
            uint2 b0 = uint2(1764461774, 657072478);
            uint2 r0 = uint2(3344568648, 4192918280);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (1459784358);
            uint2 b1 = uint2(1610646683, 1632058826);
            uint2 r1 = uint2(1040681602, 2635396348);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (868441654);
            uint2 b2 = uint2(1408757883, 335917146);
            uint2 r2 = uint2(1867178994, 2458009340);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (2105124483);
            uint2 b3 = uint2(1178393968, 1963904348);
            uint2 r3 = uint2(3266048080, 2084093460);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_div_wide_wide()
        {
            uint2 a0 = uint2(1590198532, 507812502);
            uint2 b0 = uint2(1434703236, 911965201);
            uint2 r0 = uint2(1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint2 a1 = uint2(126627032, 1058247011);
            uint2 b1 = uint2(390415521, 128746927);
            uint2 r1 = uint2(0, 8);
            TestUtils.AreEqual(a1 / b1, r1);

            uint2 a2 = uint2(427387861, 290676154);
            uint2 b2 = uint2(525835375, 816946613);
            uint2 r2 = uint2(0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint2 a3 = uint2(1829594484, 1127868739);
            uint2 b3 = uint2(878264647, 146789678);
            uint2 r3 = uint2(2, 7);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_div_wide_scalar()
        {
            uint2 a0 = uint2(560951562, 1218680769);
            uint b0 = (947861580);
            uint2 r0 = uint2(0, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            uint2 a1 = uint2(375341724, 1919409166);
            uint b1 = (1613542090);
            uint2 r1 = uint2(0, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            uint2 a2 = uint2(1397425408, 524526253);
            uint b2 = (1349573078);
            uint2 r2 = uint2(1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint2 a3 = uint2(341995568, 1515313790);
            uint b3 = (495895326);
            uint2 r3 = uint2(0, 3);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_div_scalar_wide()
        {
            uint a0 = (1161272038);
            uint2 b0 = uint2(187325733, 1594107378);
            uint2 r0 = uint2(6, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (2016183849);
            uint2 b1 = uint2(1589343709, 388768753);
            uint2 r1 = uint2(1, 5);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (1417077283);
            uint2 b2 = uint2(1773486938, 1154044032);
            uint2 r2 = uint2(0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (81831373);
            uint2 b3 = uint2(1476877645, 653688843);
            uint2 r3 = uint2(0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_mod_wide_wide()
        {
            uint2 a0 = uint2(146150818, 1846543305);
            uint2 b0 = uint2(983050390, 771341152);
            uint2 r0 = uint2(146150818, 303861001);
            TestUtils.AreEqual(a0 % b0, r0);

            uint2 a1 = uint2(1071447756, 308965362);
            uint2 b1 = uint2(942375212, 367361754);
            uint2 r1 = uint2(129072544, 308965362);
            TestUtils.AreEqual(a1 % b1, r1);

            uint2 a2 = uint2(659881575, 1002365460);
            uint2 b2 = uint2(749500619, 750718852);
            uint2 r2 = uint2(659881575, 251646608);
            TestUtils.AreEqual(a2 % b2, r2);

            uint2 a3 = uint2(861198439, 1510617532);
            uint2 b3 = uint2(2095151755, 88438806);
            uint2 r3 = uint2(861198439, 7157830);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_mod_wide_scalar()
        {
            uint2 a0 = uint2(164800505, 1062177828);
            uint b0 = (883951171);
            uint2 r0 = uint2(164800505, 178226657);
            TestUtils.AreEqual(a0 % b0, r0);

            uint2 a1 = uint2(1898749675, 820393245);
            uint b1 = (1701653318);
            uint2 r1 = uint2(197096357, 820393245);
            TestUtils.AreEqual(a1 % b1, r1);

            uint2 a2 = uint2(19002208, 1464010899);
            uint b2 = (128329633);
            uint2 r2 = uint2(19002208, 52384936);
            TestUtils.AreEqual(a2 % b2, r2);

            uint2 a3 = uint2(896587769, 1982762194);
            uint b3 = (405208598);
            uint2 r3 = uint2(86170573, 361927802);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_mod_scalar_wide()
        {
            uint a0 = (242383789);
            uint2 b0 = uint2(740000543, 1556450291);
            uint2 r0 = uint2(242383789, 242383789);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (1104736385);
            uint2 b1 = uint2(437976569, 1911837205);
            uint2 r1 = uint2(228783247, 1104736385);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (1507212038);
            uint2 b2 = uint2(1906405167, 247693265);
            uint2 r2 = uint2(1507212038, 21052448);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (293460573);
            uint2 b3 = uint2(1495295166, 873323603);
            uint2 r3 = uint2(293460573, 293460573);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_plus()
        {
            uint2 a0 = uint2(1643476803, 907898539);
            uint2 r0 = uint2(1643476803, 907898539);
            TestUtils.AreEqual(+a0, r0);

            uint2 a1 = uint2(379615839, 1735287433);
            uint2 r1 = uint2(379615839, 1735287433);
            TestUtils.AreEqual(+a1, r1);

            uint2 a2 = uint2(1743199272, 339091479);
            uint2 r2 = uint2(1743199272, 339091479);
            TestUtils.AreEqual(+a2, r2);

            uint2 a3 = uint2(401565897, 849339193);
            uint2 r3 = uint2(401565897, 849339193);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_neg()
        {
            uint2 a0 = uint2(1955022112, 662160019);
            uint2 r0 = uint2(2339945184, 3632807277);
            TestUtils.AreEqual(-a0, r0);

            uint2 a1 = uint2(370300775, 1004505619);
            uint2 r1 = uint2(3924666521, 3290461677);
            TestUtils.AreEqual(-a1, r1);

            uint2 a2 = uint2(28153593, 505708349);
            uint2 r2 = uint2(4266813703, 3789258947);
            TestUtils.AreEqual(-a2, r2);

            uint2 a3 = uint2(1115028238, 694995093);
            uint2 r3 = uint2(3179939058, 3599972203);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_prefix_inc()
        {
            uint2 a0 = uint2(864455342, 2035793213);
            uint2 r0 = uint2(864455343, 2035793214);
            TestUtils.AreEqual(++a0, r0);

            uint2 a1 = uint2(1275443862, 411610189);
            uint2 r1 = uint2(1275443863, 411610190);
            TestUtils.AreEqual(++a1, r1);

            uint2 a2 = uint2(446210725, 115573442);
            uint2 r2 = uint2(446210726, 115573443);
            TestUtils.AreEqual(++a2, r2);

            uint2 a3 = uint2(913293639, 1208161871);
            uint2 r3 = uint2(913293640, 1208161872);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_postfix_inc()
        {
            uint2 a0 = uint2(1751003569, 2063707595);
            uint2 r0 = uint2(1751003569, 2063707595);
            TestUtils.AreEqual(a0++, r0);

            uint2 a1 = uint2(1500486291, 1007848192);
            uint2 r1 = uint2(1500486291, 1007848192);
            TestUtils.AreEqual(a1++, r1);

            uint2 a2 = uint2(2028651936, 1190630527);
            uint2 r2 = uint2(2028651936, 1190630527);
            TestUtils.AreEqual(a2++, r2);

            uint2 a3 = uint2(1396179607, 177416855);
            uint2 r3 = uint2(1396179607, 177416855);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void uint2_operator_prefix_dec()
        {
            uint2 a0 = uint2(200904609, 871077500);
            uint2 r0 = uint2(200904608, 871077499);
            TestUtils.AreEqual(--a0, r0);

            uint2 a1 = uint2(968578728, 1995396216);
            uint2 r1 = uint2(968578727, 1995396215);
            TestUtils.AreEqual(--a1, r1);

            uint2 a2 = uint2(435367037, 1589827826);
            uint2 r2 = uint2(435367036, 1589827825);
            TestUtils.AreEqual(--a2, r2);

            uint2 a3 = uint2(1434377580, 1699290403);
            uint2 r3 = uint2(1434377579, 1699290402);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_postfix_dec()
        {
            uint2 a0 = uint2(283970262, 1109329936);
            uint2 r0 = uint2(283970262, 1109329936);
            TestUtils.AreEqual(a0--, r0);

            uint2 a1 = uint2(1073216143, 1932646215);
            uint2 r1 = uint2(1073216143, 1932646215);
            TestUtils.AreEqual(a1--, r1);

            uint2 a2 = uint2(1174104498, 524156737);
            uint2 r2 = uint2(1174104498, 524156737);
            TestUtils.AreEqual(a2--, r2);

            uint2 a3 = uint2(691209285, 802721301);
            uint2 r3 = uint2(691209285, 802721301);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void uint2_operator_bitwise_and_wide_wide()
        {
            uint2 a0 = uint2(779935043, 1097962163);
            uint2 b0 = uint2(307705143, 1710882162);
            uint2 r0 = uint2(39064835, 1097961522);
            TestUtils.AreEqual(a0 & b0, r0);

            uint2 a1 = uint2(1939593304, 800599247);
            uint2 b1 = uint2(866836769, 532490608);
            uint2 r1 = uint2(864731136, 263727168);
            TestUtils.AreEqual(a1 & b1, r1);

            uint2 a2 = uint2(952140918, 782792558);
            uint2 b2 = uint2(679371720, 1794035877);
            uint2 r2 = uint2(675283008, 715673636);
            TestUtils.AreEqual(a2 & b2, r2);

            uint2 a3 = uint2(1608557706, 396446406);
            uint2 b3 = uint2(1439832202, 519529812);
            uint2 r3 = uint2(1438646410, 379666500);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_bitwise_and_wide_scalar()
        {
            uint2 a0 = uint2(443615469, 490057985);
            uint b0 = (93423598);
            uint2 r0 = uint2(1114348, 85033216);
            TestUtils.AreEqual(a0 & b0, r0);

            uint2 a1 = uint2(2042441263, 1405175110);
            uint b1 = (1524760558);
            uint2 r1 = uint2(1486958126, 1388397894);
            TestUtils.AreEqual(a1 & b1, r1);

            uint2 a2 = uint2(510212004, 1236735839);
            uint b2 = (1941875181);
            uint2 r2 = uint2(304619940, 1102446925);
            TestUtils.AreEqual(a2 & b2, r2);

            uint2 a3 = uint2(1365509729, 607982857);
            uint b3 = (428270198);
            uint2 r3 = uint2(285475424, 262144);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (1144543590);
            uint2 b0 = uint2(420346723, 562416448);
            uint2 r0 = uint2(547170, 18752);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (1393127318);
            uint2 b1 = uint2(1560699552, 851218057);
            uint2 r1 = uint2(1358979712, 302517888);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (703880958);
            uint2 b2 = uint2(1159378889, 2031211279);
            uint2 r2 = uint2(17831624, 688935438);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (1089518981);
            uint2 b3 = uint2(270607307, 1349288930);
            uint2 r3 = uint2(2105729, 1080066432);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_bitwise_or_wide_wide()
        {
            uint2 a0 = uint2(1731159103, 659068416);
            uint2 b0 = uint2(1583847161, 692672727);
            uint2 r0 = uint2(2138044159, 793370327);
            TestUtils.AreEqual(a0 | b0, r0);

            uint2 a1 = uint2(382702471, 1821032196);
            uint2 b1 = uint2(1161585489, 1756207130);
            uint2 r1 = uint2(1476391895, 1823457054);
            TestUtils.AreEqual(a1 | b1, r1);

            uint2 a2 = uint2(1565773438, 1004000514);
            uint2 b2 = uint2(1321374429, 1287357212);
            uint2 r2 = uint2(1607720703, 2147473182);
            TestUtils.AreEqual(a2 | b2, r2);

            uint2 a3 = uint2(948501377, 600951835);
            uint2 b3 = uint2(2075767170, 1273513430);
            uint2 r3 = uint2(2075786115, 1811533279);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_bitwise_or_wide_scalar()
        {
            uint2 a0 = uint2(961259683, 471103264);
            uint b0 = (1666102508);
            uint2 r0 = uint2(2068823279, 2136930284);
            TestUtils.AreEqual(a0 | b0, r0);

            uint2 a1 = uint2(1733389229, 386953869);
            uint b1 = (1591585258);
            uint2 r1 = uint2(2145250287, 1608383471);
            TestUtils.AreEqual(a1 | b1, r1);

            uint2 a2 = uint2(1148351449, 1814263250);
            uint b2 = (1048929715);
            uint2 r2 = uint2(2130147323, 2124903923);
            TestUtils.AreEqual(a2 | b2, r2);

            uint2 a3 = uint2(860336789, 1227888278);
            uint b3 = (1637162093);
            uint2 r3 = uint2(1943518973, 1773477631);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (1213433101);
            uint2 b0 = uint2(1212928242, 1614462616);
            uint2 r0 = uint2(1213978111, 1752940445);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (936937728);
            uint2 b1 = uint2(764766995, 306352095);
            uint2 r1 = uint2(1071508243, 937070559);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (574719481);
            uint2 b2 = uint2(1283571271, 2109131012);
            uint2 r2 = uint2(1858191359, 2146946557);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (979469710);
            uint2 b3 = uint2(1348323481, 1407542578);
            uint2 r3 = uint2(2055064991, 2078664126);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_bitwise_xor_wide_wide()
        {
            uint2 a0 = uint2(1556324760, 207002929);
            uint2 b0 = uint2(1054997548, 1523759632);
            uint2 r0 = uint2(1646419380, 1451501345);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint2 a1 = uint2(1843444873, 1632079131);
            uint2 b1 = uint2(251164872, 110472397);
            uint2 r1 = uint2(1662567489, 1741824470);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint2 a2 = uint2(1460334334, 1607815585);
            uint2 b2 = uint2(384031112, 1109163205);
            uint2 r2 = uint2(1105803126, 499723620);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint2 a3 = uint2(220623650, 38668553);
            uint2 b3 = uint2(535118981, 179106262);
            uint2 r3 = uint2(314783655, 149092575);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_bitwise_xor_wide_scalar()
        {
            uint2 a0 = uint2(2124666952, 177397845);
            uint b0 = (493665894);
            uint2 r0 = uint2(1674536494, 402546227);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint2 a1 = uint2(574879617, 1136545648);
            uint b1 = (1937385541);
            uint2 r1 = uint2(1362747332, 818177845);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint2 a2 = uint2(213863690, 289301586);
            uint b2 = (535061373);
            uint2 r2 = uint2(324742775, 249169711);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint2 a3 = uint2(1305234431, 1308626970);
            uint b3 = (353786540);
            uint2 r3 = uint2(1490686291, 1528187574);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (1288453276);
            uint2 b0 = uint2(1077599928, 884741329);
            uint2 r0 = uint2(217506340, 2020616269);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (212164516);
            uint2 b1 = uint2(1585020328, 152985454);
            uint2 r1 = uint2(1390158348, 96141514);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (1775851275);
            uint2 b2 = uint2(1416249064, 1309317737);
            uint2 r2 = uint2(1035168227, 668192098);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (1773918217);
            uint2 b3 = uint2(1509843030, 1206045972);
            uint2 r3 = uint2(809875551, 777590045);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_left_shift()
        {
            uint2 a0 = uint2(197771193, 622182602);
            int b0 = (1321149625);
            uint2 r0 = uint2(1912602624, 2483027968);
            TestUtils.AreEqual(a0 << b0, r0);

            uint2 a1 = uint2(1283988958, 473415985);
            int b1 = (1327917304);
            uint2 r1 = uint2(3724541952, 822083584);
            TestUtils.AreEqual(a1 << b1, r1);

            uint2 a2 = uint2(432425717, 2058433484);
            int b2 = (870301196);
            uint2 r2 = uint2(1689210880, 322748416);
            TestUtils.AreEqual(a2 << b2, r2);

            uint2 a3 = uint2(1200694230, 1360008038);
            int b3 = (1531607705);
            uint2 r3 = uint2(2885681152, 3422552064);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_right_shift()
        {
            uint2 a0 = uint2(548167301, 1161338299);
            int b0 = (1266801540);
            uint2 r0 = uint2(34260456, 72583643);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint2 a1 = uint2(1617625829, 713958715);
            int b1 = (1860731847);
            uint2 r1 = uint2(12637701, 5577802);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint2 a2 = uint2(196552656, 1265099998);
            int b2 = (770466193);
            uint2 r2 = uint2(1499, 9651);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint2 a3 = uint2(572763124, 426807581);
            int b3 = (506619530);
            uint2 r3 = uint2(559338, 416804);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [TestCompiler]
        public static void uint2_operator_bitwise_not()
        {
            uint2 a0 = uint2(1403358969, 831360921);
            uint2 r0 = uint2(2891608326, 3463606374);
            TestUtils.AreEqual(~a0, r0);

            uint2 a1 = uint2(2088190243, 878283189);
            uint2 r1 = uint2(2206777052, 3416684106);
            TestUtils.AreEqual(~a1, r1);

            uint2 a2 = uint2(308994339, 1420884856);
            uint2 r2 = uint2(3985972956, 2874082439);
            TestUtils.AreEqual(~a2, r2);

            uint2 a3 = uint2(472965491, 627580960);
            uint2 r3 = uint2(3822001804, 3667386335);
            TestUtils.AreEqual(~a3, r3);
        }

        [TestCompiler]
        public static void uint2_shuffle_result_1()
        {
            uint2 a = uint2(0, 1);
            uint2 b = uint2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (3));
        }

        [TestCompiler]
        public static void uint2_shuffle_result_2()
        {
            uint2 a = uint2(0, 1);
            uint2 b = uint2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX), uint2(0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftX), uint2(1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), uint2(2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX), uint2(3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY), uint2(0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY), uint2(1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY), uint2(2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY), uint2(3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX), uint2(0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), uint2(1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX), uint2(2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), uint2(3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY), uint2(0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightY), uint2(1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY), uint2(2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY), uint2(3, 3));
        }

        [TestCompiler]
        public static void uint2_shuffle_result_3()
        {
            uint2 a = uint2(0, 1);
            uint2 b = uint2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightY), uint3(2, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightX), uint3(2, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightY), uint3(3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), uint3(1, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), uint3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), uint3(0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), uint3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftX), uint3(3, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), uint3(2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX), uint3(2, 2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), uint3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY), uint3(3, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), uint3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightX), uint3(3, 2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightY), uint3(0, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), uint3(3, 1, 1));
        }

        [TestCompiler]
        public static void uint2_shuffle_result_4()
        {
            uint2 a = uint2(0, 1);
            uint2 b = uint2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX), uint4(0, 0, 1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftX, ShuffleComponent.RightY), uint4(2, 1, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightX), uint4(3, 2, 3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), uint4(2, 0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightX), uint4(0, 3, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftY), uint4(3, 0, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.LeftX), uint4(2, 2, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), uint4(2, 2, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX, ShuffleComponent.LeftY), uint4(0, 1, 2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightY), uint4(2, 1, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftY), uint4(3, 3, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), uint4(2, 2, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), uint4(3, 0, 0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), uint4(2, 2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY), uint4(0, 3, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), uint4(2, 0, 0, 0));
        }


    }
}
