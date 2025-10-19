using ExoScan.Enums;
using ExoScan.StellarStructs;

namespace ExoScan
{

    public class Zones
    {
        public static Dictionary<GalacticRegion, List<int>> RegionMap = new Dictionary<GalacticRegion, List<int>>
        {
            [GalacticRegion.OrionCygnus] = new List<int> { 1, 4, 7, 8, 16, 17, 18, 35 },
            [GalacticRegion.OrionCygnus1] = new List<int> { 4, 7, 8, 16, 17, 18, 35 },
            [GalacticRegion.OrionCygnusCore] = new List<int> { 7, 8, 16, 17, 18, 35 },
            [GalacticRegion.SagittariusCarina] = new List<int> { 1, 4, 9, 18, 19, 20, 21, 22, 23, 40 },
            [GalacticRegion.SagittariusCarinaCore] = new List<int> { 9, 18, 19, 20, 21, 22, 23, 40 },
            [GalacticRegion.SagittariusCarinaCore9] = new List<int> { 18, 19, 20, 21, 22, 23, 40 },
            [GalacticRegion.ScutumCentaurus] = new List<int> { 1, 4, 9, 10, 11, 12, 24, 25, 26, 42, 28 },
            [GalacticRegion.ScutumCentaurusCore] = new List<int> { 9, 10, 11, 12, 24, 25, 26, 42, 28 },
            [GalacticRegion.Outer] = new List<int> { 1, 2, 5, 6, 13, 14, 27, 29, 31, 41, 37 },
            [GalacticRegion.Perseus] = new List<int> { 1, 3, 7, 15, 30, 32, 33, 34, 36, 38, 39 },
            [GalacticRegion.PerseusCore] = new List<int> { 3, 7, 15, 30, 32, 33, 34, 36, 38, 39 },
            [GalacticRegion.Exterior] = new List<int> { 14, 21, 22, 23, 24, 25, 26, 27, 28, 29, 31, 34, 36,
                                       37, 38, 39, 40, 41, 42 },
            [GalacticRegion.AnemoneA] = new List<int> { 7, 8, 13, 14, 15, 16, 17, 18, 27, 32 },
            [GalacticRegion.Amphora] = new List<int> { 10, 19, 20, 21, 22 },
            [GalacticRegion.BrainTree] = new List<int> { 2, 9, 10, 17, 18, 35 },
            [GalacticRegion.EmpyreanStraits] = new List<int> { 2 },
            [GalacticRegion.Center] = new List<int> { 1, 2, 3 }
        };

        public static Dictionary<string, (int maxDistance, Position coordinates)> GuardianNebulae = new Dictionary<string, (int, Position)>
        {
            ["Hen 2-333"] = (750, new Position(-840.65625, -561.15625, 13361.8125)),
            ["Gamma Velorum"] = (750, new Position(1099.21875, -146.6875, -133.59375)),
            ["Skaudai AA-A h71"] = (100, new Position(-5493.09375, -589.28125, 10424.4375)),
            ["Blaa Hypai AA-A h68"] = (100, new Position(1220.40625, -694.625, 12312.8125)),
            ["Eorl Auwsy AA-A h72"] = (100, new Position(4949.9375, 164, 20640.125)),
            ["Prai Hypoo AA-A h60"] = (100, new Position(-9294.875, -458.40625, 7905.71875)),
            ["Eta Carina Nebula"] = (100, new Position(8579.96875, -138.96875, 2701.375)),
            ["NGC 3199"] = (100, new Position(14574.15625, -259.625, 3511.90625))
        };

        public static Dictionary<string, (int minDistance, int maxDistance, Position coordinates)> TuberZones = new Dictionary<string, (int, int, Position)>
        {
            ["Arcadian Stream"] = (200, 600, new Position(8885, -20, 20535)),
            ["Empyrean Straits"] = (200, 400, new Position(4325, 400, 21185)),
            ["Galactic Center"] = (500, 1000, new Position(44.5, 492.7, 25916)),
            ["Hawking A"] = (150, 600, new Position(5788, 150, 6335)),
            ["Hawking B"] = (200, 600, new Position(9990, -40, 8335)),
            ["Inner Orion Spur"] = (200, 600, new Position(-3485, 39, 7320)),
            ["Inner O-P Conflux"] = (350, 750, new Position(-13245, -80, 30285)),
            ["Inner S-C Arm A"] = (200, 600, new Position(-1600, -37, 10720)),
            ["Inner S-C Arm B 1"] = (150, 300, new Position(-6645, 0, 12590)),
            ["Inner S-C Arm B 2"] = (200, 600, new Position(-6645, 0, 12590)),
            ["Inner S-C Arm C"] = (200, 600, new Position(-9355, -50, 17175)),
            ["Inner S-C Arm D"] = (300, 400, new Position(-12000, 232, 22670)),
            ["Izanami"] = (200, 750, new Position(-4610, 370, 37225)),
            ["Norma Arm A"] = (500, 1000, new Position(3722.6, 200, 16441)),
            ["Norma Arm B"] = (200, 500, new Position(3740, 175, 16460)),
            ["Norma Expanse A"] = (200, 600, new Position(4245, -42, 12071)),
            ["Norma Expanse B"] = (150, 250, new Position(5580, 40, 11727)),
            ["Odin A"] = (750, 1000, new Position(-7945, 230, 28025)),
            ["Odin B"] = (200, 600, new Position(-5329, -68, 18647)),
            ["Ryker A"] = (250, 750, new Position(1715, 766, 34070)),
            ["Ryker B"] = (750, 1500, new Position(-1445, 345, 30345)),
            ["Trojan Belt"] = (250, 500, new Position(18600, 65, 31750))
        };
    }
}
