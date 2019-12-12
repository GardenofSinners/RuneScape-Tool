using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace RuneScape_Tool.Enums
{
    class Activities_Minigames
    {
        enum RS3Activities
        {
            [Display(Name = "Bounty Hunters")]
            Bounty_Hunters,
            [Display(Name = "B.H Rogues")]
            BH_Rogues,
            [Display(Name = "Dominion Tower")]
            Dominion_Tower,
            [Display(Name = "The Crucible")]
            The_Crucible,
            [Display(Name = "Castle Wars Games")]
            Castle_Wars_Games,
            [Display(Name = "B.A Attackers")]
            BA_Attackers,
            [Display(Name = "B.A Defenders")]
            BA_Defenders,
            [Display(Name = "B.A Collectors")]
            BA_Collectors,
            [Display(Name = "B.A Healers")]
            BA_Healers,
            [Display(Name = "Duel Tournament")]
            Duel_Tournament,
            [Display(Name = "Mobilising Army")]
            Mobilising_Army,
            Conquest,
            [Display(Name = "Fist of Guthix")]
            Fist_of_Guthix,
            [Display(Name = "GG: Resource Race")]
            GG_Resource_Race,
            [Display(Name = "GG: Athletics")]
            GG_Athletics,
            [Display(Name = "WE2: Armadyl Lifetime Contribution")]
            WE2_Armadyl_Lifetime_Contribution,
            [Display(Name = "WE2: Bandos Lifetime Contribution")]
            WE2_Bandos_Lifetime_Contribution,
            [Display(Name = "WE2: Armadyl PvP Kills")]
            WE2_Armadyl_PvP_Kills,
            [Display(Name = "WE2: Bandos PvP Kills")]
            WE2_Bandos_PvP_Kills,
            [Display(Name = "Heist Guard Level")]
            Heist_Guard_Level,
            [Display(Name = "Heist Robber Level")]
            Heist_Robber_Level,
            [Display(Name = "CFP: 5 Game Average")]
            CFP_5_Game_Average,
            RuneScore,
            [Display(Name = "Clue Scrolls (Easy)")]
            Clue_Scrolls_Easy,
            [Display(Name = "Clue Scrolls (Medium)")]
            Clue_Scrolls_Medium,
            [Display(Name = "Clue Scrolls (Hard)")]
            Clue_Scrolls_Hard,
            [Display(Name = "Clue Scrolls (Elite)")]
            Clue_Scrolls_Elite,
            [Display(Name = "Clue Scrolls (Master)")]
            Clue_Scrolls_Master
        }

        enum OSRSMinigames
        {
            [Display(Name = "League Points")]
            League_Points,
            [Display(Name = "Bounty Hunter - Hunter")]
            Bounty_Hunter_Hunter,
            [Display(Name = "Bounty Hunter - Rogue")]
            Bounty_Hunter_Rogue,
            [Display(Name = "Clue Scrolls (All)")]
            Clue_Scrolls_All,
            [Display(Name = "Clue Scrolls(Beginner)")]
            Clue_Scrolls_Beginner,
            [Display(Name = "Clue Scrolls(Easy)")]
            Clue_Scrolls_Easy,
            [Display(Name = "Clue Scrolls(Medium)")]
            Clue_Scrolls_Medium,
            [Display(Name = "Clue Scrolls (Hard)")]
            Clue_Scrolls_Hard,
            [Display(Name = "Clue Scrolls (Elite)")]
            Clue_Scrolls_Elite,
            [Display(Name = "Clue Scrolls (Master)")]
            Clue_Scrolls_Master,
            [Display(Name = "LMS - Rank")]
            LMS_Rank,
            [Display(Name = "Abyssal Sire")]
            Abyssal_Sire,
            [Display(Name = "Alchemical Hydra")]
            Alchemical_Hydra,
            [Display(Name = "Barrows Chests")]
            Barrows_Chests,
            Bryophyta,
            Callisto,
            Cerberus,
            [Display(Name = "Chambers of Xeric")]
            Chambers_of_Xeric,
            [Display(Name = "Chambers of Xeric: Challenge Mode")]
            Chambers_of_Xeric_Challenge_Mode,
            [Display(Name = "Chaos Elemental")]
            Chaos_Elemental,
            [Display(Name = "Chaos Fanatic")]
            Chaos_Fanatic,
            [Display(Name = "Commander Zilyana")]
            Commander_Zilyana,
            [Display(Name = "Corporeal Beast")]
            Corporeal_Beast,
            [Display(Name = "Crazy Archaeologist")]
            Crazy_Archaeologist,
            [Display(Name = "Dagannoth Prime")]
            Dagannoth_Prime,
            [Display(Name = "Dagannoth Rex")]
            Dagannoth_Rex,
            [Display(Name = "Dagannoth Supreme")]
            Dagannoth_Supreme,
            [Display(Name = "Deranged Archaeologist")]
            Deranged_Archaeologist,
            [Display(Name = "General Graardor")]
            General_Graardor,
            [Display(Name = "Giant Mole")]
            Giant_Mole,
            [Display(Name = "Grotesque Guardians")]
            Grotesque_Guardians,
            Hespori,
            [Display(Name = "Kalphite Queen")]
            Kalphite_Queen,
            [Display(Name = "King Black Dragon")]
            King_Black_Dragon,
            Kraken,
            [Display(Name = "Kree'Arra")]
            KreeArra,
            [Display(Name = "K'ril Tsutsaroth")]
            Kril_Tsutsaroth,
            Mimic,
            Obor,
            Sarachnis,
            Scorpia,
            Skotizo,
            [Display(Name = "The Gauntlet")]
            The_Gauntlet,
            [Display(Name = "The Corrupted Gauntlet")]
            The_Corrupted_Gauntlet,
            [Display(Name = "Theatre of Blood")]
            Theatre_of_Blood,
            [Display(Name = "Thermonuclear Smoke Devil")]
            Thermonuclear_Smoke_Devil,
            [Display(Name = "TzKal-Zuk")]
            TzKal_Zuk,
            [Display(Name = "TzTok-Jad")]
            TzTok_Jad,
            Venenatis,
            [Display(Name = "Vet'ion")]
            Vetion,
            Vorkath,
            Wintertodt,
            Zalcano,
            Zulrah
        }
    }
}
