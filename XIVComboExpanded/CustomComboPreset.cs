using XIVComboExpandedPlugin.Combos;

namespace XIVComboExpandedPlugin
{
    /// <summary>
    /// Combo presets.
    /// </summary>
    public enum CustomComboPreset
    {
        // Last enum used: 113 is free

        // ====================================================================================
        #region ASTROLOGIAN

        [CustomComboInfo("Draw on Play", "Play turns into Draw when no card is drawn, as well as the usual Play behavior.", AST.JobID, AST.Play)]
        AstrologianCardsOnDrawFeature = 1,

        [CustomComboInfo("Minor Arcana to Sleeve Draw", "Changes Minor Arcana to Sleeve Draw when a card is not drawn.", AST.JobID, AST.MinorArcana)]
        AstrologianCrownPlayFeature = 2,

        [CustomComboInfo("Benefic 2 to Benefic Level Sync", "Changes Benefic 2 to Benefic when below level 26 in synced content.", AST.JobID, AST.Benefic2)]
        AstrologianBeneficFeature = 3,

        [CustomComboInfo("Swiftcast Feature", "Changes Swiftcast To Ascend", AST.JobID, AST.Swiftcast, AST.Ascend)]
        AstrologianAscendFeature = 4,



        #endregion
        // ====================================================================================
        #region BLACK MAGE

        [CustomComboInfo("Enochian Stance Switcher", "Change Enochian to Fire 4 or Blizzard 4 depending on stance.", BLM.JobID, BLM.Fire4)]
        BlackEnochianFeature = 100,

        [CustomComboInfo("Umbral Soul/Transpose Switcher", "Change Transpose into Umbral Soul when Umbral Soul is usable.", BLM.JobID, BLM.Transpose)]
        BlackManaFeature = 101,

        [CustomComboInfo("(Between the) Ley Lines", "Change Ley Lines into BTL when Ley Lines is active.", BLM.JobID, BLM.LeyLines)]
        BlackLeyLinesFeature = 102,

        [CustomComboInfo("Fire 1/3 Feature", "Fire 1 becomes Fire 3 outside of Astral Fire, and when Firestarter proc is up.", BLM.JobID, BLM.Fire)]
        BlackFireFeature = 103,

        [CustomComboInfo("Blizzard 1/2/3 Feature", "Blizzard 1 becomes Blizzard 3 when out of Umbral Ice. Freeze becomes Blizzard 2 when synced.", BLM.JobID, BLM.Blizzard, BLM.Freeze)]
        BlackBlizzardFeature = 104,

        [CustomComboInfo("Scathe/Xenoglossy Feature", "Scathe becomes Xenoglossy when available.", BLM.JobID, BLM.Scathe)]
        BlackScatheFeature = 105,

        [CustomComboInfo("Fire 1/3", "Fire 1 becomes Fire 3 outside of Astral Fire, OR when Firestarter proc is up.", BLM.JobID, BLM.Fire3, BLM.Fire)]
        BlackFire13Feature = 106,

        [CustomComboInfo("Thunder", "Thunder 1/3 replaces Enochian/Fire 4/Blizzard 4 on Enochian switcher.\n Occurs when Thundercloud is up and either\n- Thundercloud buff on you is about to run out, or\n- Thunder debuff on your CURRENT target is about to run out\nassuming it won't interrupt timer upkeep.\nEnochian Stance Switcher must be active.", BLM.JobID, BLM.Thunder, BLM.Thunder3)]
        BlackThunderFeature = 107,

        [CustomComboInfo("Despair Feature", "Despair replaces Fire 4 when below 2400 MP.\nEnochian Stance Switcher must be active.", BLM.JobID, BLM.Fire4)]
        BlackDespairFeature = 108,

        // [CustomComboInfo("All in one AoE Feature", "AoE version of all in one feature", BLM.JobID, BLM.Scathe)]
        //  BlackAoEComboFeature = 125,


        #endregion
        // ====================================================================================
        #region BARD

        [CustomComboInfo("Wanderer's into Pitch Perfect", "Replaces Wanderer's Minuet with Pitch Perfect while in WM.", BRD.JobID, BRD.WanderersMinuet)]
        BardWanderersPitchPerfectFeature = 200,

        [CustomComboInfo("Heavy Shot into Straight Shot", "Replaces Heavy Shot/Burst Shot with Straight Shot/Refulgent Arrow when procced.", BRD.JobID, BRD.HeavyShot, BRD.BurstShot)]
        BardStraightShotUpgradeFeature = 201,

        [CustomComboInfo("Iron Jaws Feature", "Iron Jaws is replaced with Caustic Bite/Stormbite if one or both are not up.\nAlternates between the two if Iron Jaws isn't available.", BRD.JobID, BRD.IronJaws)]
        BardIronJawsFeature = 202,

        [CustomComboInfo("Burst Shot/Quick Nock into Apex Arrow", "Replaces Burst Shot and Quick Nock with Apex Arrow when gauge is full.", BRD.JobID, BRD.BurstShot, BRD.QuickNock)]
        BardApexFeature = 203,

        #endregion
        // ====================================================================================
        #region DANCER

        [CustomComboInfo("Fan Dance Combos", "Change Fan Dance and Fan Dance 2 into Fan Dance 3 while flourishing.", DNC.JobID, DNC.FanDance1, DNC.FanDance2)]
        DancerFanDanceCombo = 300,

        [SecretCustomCombo]
        [ConflictingCombos(DancerDanceComboCompatibility)]
        [CustomComboInfo("Dance Step Combo", "Change Standard Step and Technical Step into each dance step while dancing.", DNC.JobID, DNC.StandardStep, DNC.TechnicalStep)]
        DancerDanceStepCombo = 301,

        [CustomComboInfo("Flourish Proc Saver", "Change Flourish into any available procs before using.", DNC.JobID, DNC.Flourish)]
        DancerFlourishFeature = 302,

        [CustomComboInfo("Single Target Multibutton", "Change Cascade into procs and combos as available.", DNC.JobID, DNC.Cascade)]
        DancerSingleTargetMultibutton = 303,

        [CustomComboInfo("AoE Multibutton", "Change Windmill into procs and combos as available.", DNC.JobID, DNC.Windmill)]
        DancerAoeMultibutton = 304,

        [ConflictingCombos(DancerDanceStepCombo)]
        [CustomComboInfo(
            "Dance Step Feature",
            "Change actions into dance steps while dancing." +
            "\nThis helps ensure you can still dance with combos on, without using auto dance." +
            "\nYou can change the respective actions by inputting action IDs below for each dance step." +
            "\nThe defaults are Cascade, Flourish, Fan Dance and Fan Dance II. If set to 0, they will reset to these actions." +
            "\nYou can get Action IDs with Garland Tools by searching for the action and clicking the cog.",
            DNC.JobID)]
        DancerDanceComboCompatibility = 305,

        #endregion
        // ====================================================================================
        #region DRAGOON

        [CustomComboInfo("Jump + Mirage Dive", "Replace (High) Jump with Mirage Dive when Dive Ready.", DRG.JobID, DRG.Jump, DRG.HighJump)]
        DragoonJumpFeature = 400,

        [CustomComboInfo("BOTD Into Stardiver", "Replace Blood of the Dragon with Stardiver when in Life of the Dragon.", DRG.JobID, DRG.BloodOfTheDragon)]
        DragoonBOTDFeature = 401,

        [CustomComboInfo("Coerthan Torment Combo", "Replace Coerthan Torment with its combo chain.", DRG.JobID, DRG.CoerthanTorment)]
        DragoonCoerthanTormentCombo = 402,

        [CustomComboInfo("Chaos Thrust Combo", "Replace Chaos Thrust with its combo chain.", DRG.JobID, DRG.ChaosThrust)]
        DragoonChaosThrustCombo = 403,

        [CustomComboInfo("Full Thrust Combo", "Replace Full Thrust with its combo chain.", DRG.JobID, DRG.FullThrust)]
        DragoonFullThrustCombo = 404,

        #endregion
        // ====================================================================================
        #region DARK KNIGHT

        [CustomComboInfo("Souleater Combo", "Replace Souleater with its combo chain.", DRK.JobID, DRK.Souleater)]
        DarkSouleaterCombo = 500,

        [CustomComboInfo("Stalwart Soul Combo", "Replace Stalwart Soul with its combo chain.", DRK.JobID, DRK.StalwartSoul)]
        DarkStalwartSoulCombo = 501,

        [CustomComboInfo("Delirium Feature", "Replace Souleater and Stalwart Soul with Bloodspiller and Quietus when Delirium is active.", DRK.JobID, DRK.Souleater, DRK.StalwartSoul)]
        DeliriumFeature = 502,

        [CustomComboInfo("Dark Knight Gauge Overcap Feature", "Replace AoE combo with gauge spender if you are about to overcap.", DRK.JobID, DRK.StalwartSoul)]
        DRKOvercapFeature = 503,

        [CustomComboInfo("Living Shadow Feature", "Living shadow will now be on main combo if its not on CD and you have gauge for it.", DRK.JobID, DRK.LivingShadow)]
        DRKLivingShadowFeature = 504,

        [CustomComboInfo("EoS Overcap Feature", "Uses EoS if you are above 8k mana and DarkSide is about to expire", DRK.JobID, DRK.EdgeOfShadow)]
        DarkManaOvercapFeature = 505,


        #endregion
        // ====================================================================================
        #region GUNBREAKER

        [CustomComboInfo("Solid Barrel Combo", "Replace Solid Barrel with its combo chain.", GNB.JobID, GNB.SolidBarrel)]
        GunbreakerSolidBarrelCombo = 600,

        [CustomComboInfo("Wicked Talon Combo", "Replace Wicked Talon with its combo chain.", GNB.JobID, GNB.WickedTalon)]
        GunbreakerGnashingFangCombo = 601,

        [CustomComboInfo("Wicked Talon Continuation", "In addition to the Wicked Talon combo chain, put Continuation moves on Wicked Talon when appropriate.", GNB.JobID, GNB.WickedTalon)]
        GunbreakerGnashingFangCont = 602,

        [CustomComboInfo("Demon Slaughter Combo", "Replace Demon Slaughter with its combo chain.", GNB.JobID, GNB.DemonSlaughter)]
        GunbreakerDemonSlaughterCombo = 603,

        [CustomComboInfo("Fated Circle Feature", "In addition to the Demon Slaughter combo, add Fated Circle when charges are full.", GNB.JobID, GNB.DemonSlaughter)]
        GunbreakerFatedCircleFeature = 604,

        [CustomComboInfo("Burst Strike to Bloodfest Feature", "Replace Burst Strike with Bloodfest if you have no powder gauge.", GNB.JobID, GNB.BurstStrike)]
        GunbreakerBloodfestOvercapFeature = 605,

        [CustomComboInfo("No Mercy Feature", "Replace No Mercy with Bow Shock, and then Sonic Break, while No Mercy is active.", GNB.JobID, GNB.NoMercy)]
        GunbreakerNoMercyFeature = 606,

        [CustomComboInfo("DangerZoneFeature", "Adds DangerZone on main combo.", GNB.JobID, GNB.DangerZone)]
        GunbreakerDangerZoneFeature = 607,

        [CustomComboInfo("DoubleDownFeature", "Adds DangerZone on main combo when under NoMercy buff", GNB.JobID, GNB.DoubleDown)]
        GunbreakerDoubleDownFeature = 608,

        #endregion
        // ====================================================================================
        #region MACHINIST

        [CustomComboInfo("(Heated) Shot Combo", "Replace either form of Clean Shot with its combo chain.", MCH.JobID, MCH.CleanShot, MCH.HeatedCleanShot)]
        MachinistMainCombo = 700,

        [CustomComboInfo("Spread Shot Heat", "Replace Spread Shot with Auto Crossbow when overheated.", MCH.JobID, MCH.SpreadShot)]
        MachinistSpreadShotFeature = 701,

        [CustomComboInfo("Hypercharge Feature", "Replace Heat Blast and Auto Crossbow with Hypercharge when not overheated.", MCH.JobID, MCH.HeatBlast, MCH.AutoCrossbow)]
        MachinistOverheatFeature = 702,

        [CustomComboInfo("Overdrive Feature", "Replace Rook Autoturret and Automaton Queen with Overdrive while active.", MCH.JobID, MCH.RookAutoturret, MCH.AutomatonQueen)]
        MachinistOverdriveFeature = 703,

        [SecretCustomCombo]
        [CustomComboInfo("Gauss Round / Ricochet Feature", "Replace Gauss Round and Ricochet with one or the other depending on which has more charges.", MCH.JobID, MCH.GaussRound, MCH.Ricochet)]
        MachinistGaussRoundRicochetFeature = 704,

        [CustomComboInfo("Drill/Air Feature", "Combines Drill/Air Anchor on one Button  ", MCH.JobID, MCH.Drill, MCH.AirAnchor, MCH.HotShot)]
        MchDrillAirFeature = 705,

        [CustomComboInfo("Drill/Air Feature On Main Combo", "Drill/Air Feature is added onto main combo (Note: If will add them onto main combo ONLY if you are under Reassemble Buff Or Reassemble is on CD(Will do nothing if Reassemble is OFF CD)) ", MCH.JobID, MCH.Drill, MCH.AirAnchor, MCH.HotShot, MCH.Reassemble)]
        MachinistDrillAirOnMainCombo = 706,

        #endregion
        // ====================================================================================
        #region MONK

        [CustomComboInfo("Monk AoE Combo", "Replaces Rockbreaker with the AoE combo chain, or Rockbreaker when Perfect Balance is active.", MNK.JobID, MNK.Rockbreaker)]
        MnkAoECombo = 800,

        [CustomComboInfo("Monk Bootshine Feature", "Replaces Dragon Kick with Bootshine if both a form and Leaden Fist are up.", MNK.JobID, MNK.DragonKick)]
        MnkBootshineFeature = 801,

        [CustomComboInfo("Monk Basic Rotation", "Basic Monk Combo on one button", MNK.JobID, MNK.Bootshine)]
        MnkBasicCombo = 802,

        #endregion
        // ====================================================================================
        #region NINJA

        [CustomComboInfo("Armor Crush Combo", "Replace Armor Crush with its combo chain.", NIN.JobID, NIN.ArmorCrush)]
        NinjaArmorCrushCombo = 900,

        [CustomComboInfo("Aeolian Edge Combo", "Replace Aeolian Edge with its combo chain.", NIN.JobID, NIN.AeolianEdge)]
        NinjaAeolianEdgeCombo = 901,

        [CustomComboInfo("Hakke Mujinsatsu Combo", "Replace Hakke Mujinsatsu with its combo chain.", NIN.JobID, NIN.HakkeMujinsatsu)]
        NinjaHakkeMujinsatsuCombo = 902,

        [CustomComboInfo("Dream to Assassinate", "Replace Dream Within a Dream with Assassinate when Assassinate Ready.", NIN.JobID, NIN.DreamWithinADream)]
        NinjaAssassinateFeature = 903,

        [CustomComboInfo("Kassatsu to Trick", "Replaces Kassatsu with Trick Attack while Suiton or Hidden is up.\nCooldown tracking plugin recommended.", NIN.JobID, NIN.Kassatsu)]
        NinjaKassatsuTrickFeature = 904,

        [CustomComboInfo("Ten Chi Jin to Meisui", "Replaces Ten Chi Jin (the move) with Meisui while Suiton is up.\nCooldown tracking plugin recommended.", NIN.JobID, NIN.TenChiJin)]
        NinjaTCJMeisuiFeature = 905,

        [CustomComboInfo("Kassatsu Chi/Jin Feature", "Replaces Chi with Jin while Kassatsu is up if you have Enhanced Kassatsu.", NIN.JobID, NIN.Chi)]
        NinjaKassatsuChiJinFeature = 906,

        [CustomComboInfo("Hide to Mug", "Replaces Hide with Mug while in combat.", NIN.JobID, NIN.Hide)]
        NinjaHideMugFeature = 907,

        [CustomComboInfo("Aeolian to Ninjutsu Feature", "Replaces Aeolian Edge (combo) with Ninjutsu if any Mudra are used.", NIN.JobID, NIN.AeolianEdge)]
        NinjaNinjutsuFeature = 908,

        [CustomComboInfo("GCDs to Ninjutsu Feature", "Every GCD combo becomes Ninjutsu while Mudras are being used.", NIN.JobID, NIN.AeolianEdge, NIN.ArmorCrush, NIN.HakkeMujinsatsu, NIN.GustSlash, NIN.SpinningEdge)]
        NinjaGCDNinjutsuFeature = 909,



        #endregion
        // ====================================================================================
        #region PALADIN

        [CustomComboInfo("Goring Blade Combo", "Replace Goring Blade with its combo chain.", PLD.JobID, PLD.GoringBlade)]
        PaladinGoringBladeCombo = 1000,

        [CustomComboInfo("Royal Authority Combo", "Replace Royal Authority/Rage of Halone with its combo chain.", PLD.JobID, PLD.RoyalAuthority, PLD.RageOfHalone)]
        PaladinRoyalAuthorityCombo = 1001,

        [CustomComboInfo("Atonement Feature", "Replace Royal Authority with Atonement when under the effect of Sword Oath.", PLD.JobID, PLD.RoyalAuthority)]
        PaladinAtonementFeature = 1002,

        [CustomComboInfo("Prominence Combo", "Replace Prominence with its combo chain.", PLD.JobID, PLD.Prominence)]
        PaladinProminenceCombo = 1003,

        [CustomComboInfo("Requiescat Confiteor", "Replace Requiescat with Confiter while under the effect of Requiescat.", PLD.JobID, PLD.Requiescat)]
        PaladinRequiescatCombo = 1004,

        [CustomComboInfo("Requiescat Feature", "Replace Royal Authority/Goring Blade combo with Holy Spirit and Prominence combo with Holy Circle while Requiescat is active.\nRequires said combos to be activated to work.", PLD.JobID, PLD.RoyalAuthority, PLD.GoringBlade, PLD.Prominence)]
        PaladinRequiescatFeature = 1005,

        [SecretCustomCombo]
        [CustomComboInfo("Confiteor Feature", "Replace Holy Spirit/Circle with Confiteor while MP is under 4000 and Requiescat is up.", PLD.JobID, PLD.HolySpirit, PLD.HolyCircle)]
        PaladinConfiteorFeature = 1006,

        #endregion
        // ====================================================================================
        #region RED MAGE

        [CustomComboInfo("Red Mage AoE Combo", "Replaces Veraero/Verthunder 2 with Impact when Dualcast or Swiftcast are active.", RDM.JobID, RDM.Veraero2, RDM.Verthunder2)]
        RedMageAoECombo = 1100,

        [CustomComboInfo("Redoublement combo", "Replaces Redoublement with its combo chain, following enchantment rules.", RDM.JobID, RDM.Redoublement)]
        RedMageMeleeCombo = 1101,

        [SecretCustomCombo]
        [CustomComboInfo("Redoublement Combo Plus", "Replaces Redoublement with Verflare/Verholy after Enchanted Redoublement, whichever is more appropriate.\nRequires Redoublement Combo.", RDM.JobID, RDM.Redoublement)]
        RedMageMeleeComboPlus = 1102,

        [CustomComboInfo("Verproc into Jolt", "Replaces Verstone/Verfire with Jolt/Scorch when no proc is available.", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocCombo = 1103,

        [CustomComboInfo("Verproc into Jolt Plus", "Additionally replaces Verstone/Verfire with Veraero/Verthunder if dualcast/swiftcast are up.\nRequires Verproc into Jolt.", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocComboPlus = 1104,

        [CustomComboInfo("Verproc into Jolt Plus Opener Feature", "Turns Verfire into Verthunder when out of combat.\nRequires Verproc into Jolt Plus.", RDM.JobID, RDM.Verfire)]
        RedMageVerprocOpenerFeature = 1105,

        [CustomComboInfo("Ogcd's all in one button", "Ogcd Combo", RDM.JobID, RDM.ContreSixte, RDM.Engagement, RDM.Fleche)]
        RedMageOgcdCombo = 1106,

        #endregion
        // ====================================================================================
        #region SAMURAI

        [CustomComboInfo("Yukikaze Combo", "Replace Yukikaze with its combo chain.", SAM.JobID, SAM.Yukikaze)]
        SamuraiYukikazeCombo = 1200,

        [CustomComboInfo("Gekko Combo", "Replace Gekko with its combo chain.", SAM.JobID, SAM.Gekko)]
        SamuraiGekkoCombo = 1201,

        [CustomComboInfo("Kasha Combo", "Replace Kasha with its combo chain.", SAM.JobID, SAM.Kasha)]
        SamuraiKashaCombo = 1202,

        [CustomComboInfo("Mangetsu Combo", "Replace Mangetsu with its combo chain.", SAM.JobID, SAM.Mangetsu)]
        SamuraiMangetsuCombo = 1203,

        [CustomComboInfo("Oka Combo", "Replace Oka with its combo chain.", SAM.JobID, SAM.Oka)]
        SamuraiOkaCombo = 1204,

        [CustomComboInfo("Seigan to Third Eye", "Replace Seigan with Third Eye when not procced.", SAM.JobID, SAM.Seigan)]
        SamuraiThirdEyeFeature = 1205,

        [CustomComboInfo("Jinpu/Shifu Feature", "Replace Meikyo Shisui with Jinpu or Shifu depending on what is needed.", SAM.JobID, SAM.MeikyoShisui)]
        SamuraiJinpuShifuFeature = 1206,

        [ConflictingCombos(SamuraiIaijutsuTsubameGaeshiFeature)]
        [CustomComboInfo("Tsubame-gaeshi to Iaijutsu", "Replace Tsubame-gaeshi with Iaijutsu when Sen is empty.", SAM.JobID, SAM.TsubameGaeshi)]
        SamuraiTsubameGaeshiIaijutsuFeature = 1207,

        [ConflictingCombos(SamuraiIaijutsuShohaFeature)]
        [CustomComboInfo("Tsubame-gaeshi to Shoha", "Replace Tsubame-gaeshi with Shoha when meditation is 3.", SAM.JobID, SAM.TsubameGaeshi)]
        SamuraiTsubameGaeshiShohaFeature = 1208,

        [ConflictingCombos(SamuraiTsubameGaeshiIaijutsuFeature)]
        [CustomComboInfo("Iaijutsu to Tsubame-gaeshi", "Replace Iaijutsu with Tsubame-gaeshi when Sen is not empty.", SAM.JobID, SAM.Iaijutsu)]
        SamuraiIaijutsuTsubameGaeshiFeature = 1209,

        [ConflictingCombos(SamuraiTsubameGaeshiShohaFeature)]
        [CustomComboInfo("Iaijutsu to Shoha", "Replace Iaijutsu with Shoha when meditation is 3.", SAM.JobID, SAM.Iaijutsu)]
        SamuraiIaijutsuShohaFeature = 1210,

        #endregion
        // ====================================================================================
        #region SCHOLAR

        [CustomComboInfo("Seraph Fey Blessing/Consolation", "Change Fey Blessing into Consolation when Seraph is out.", SCH.JobID, SCH.FeyBless)]
        ScholarSeraphConsolationFeature = 1300,

        [CustomComboInfo("ED Aetherflow", "Change Energy Drain into Aetherflow when you have no more Aetherflow stacks.", SCH.JobID, SCH.EnergyDrain)]
        ScholarEnergyDrainFeature = 1301,

        [CustomComboInfo("Sch Raise Feature", "Replaces Rez with swiftcast when available.", SCH.JobID, SCH.Resurrection)]
        SchRaiseFeature = 1302,

        #endregion
        // ====================================================================================
        #region SUMMONER

        // FESTER
        [CustomComboInfo("ED Fester", "Change Fester into Energy Drain when our of Aetherflow stacks.", SMN.JobID, SMN.Fester)]
        SummonerEDFesterCombo = 1400,

        [CustomComboInfo("ES Painflare", "Change Painflare into Energy Siphon when out of Aetherflow stacks.", SMN.JobID, SMN.Painflare)]
        SummonerESPainflareCombo = 1401,

        [CustomComboInfo("Ruin IV Fester Feature", "Change Fester into Ruin IV when out of Aetherflow stacks, ED/ES is on cooldown, and Ruin IV is up.", SMN.JobID, SMN.Painflare)]
        SummonerFesterPainflareRuinFeature = 1402,

        // SINGLE TARGET
        [CustomComboInfo("Single Target Combo", "Enables changing Single-Target Combo (Ruin III).", SMN.JobID, SMN.Ruin3, SMN.Deathflare)]
        SummonerMainComboFeature = 1403,

        [CustomComboInfo("Single Target Demi Feature", "Replaces Astral Impulse/Fountain of Fire with Enkindle/Deathflare/Rekindle when appropriate. Requires Single Target Combo Feature.", SMN.JobID, SMN.Ruin3)]
        SummonerSingleTargetDemiFeature = 1404,

        [CustomComboInfo("Garuda Unique Feature", "Adds Slipstream on Ruin III. Requires Single Target Combo Feature.", SMN.JobID, SMN.Ruin3)]
        SummonerGarudaUniqueFeature = 1405,

        [CustomComboInfo("Ifrit Unique Feature", "Adds Crimson Cyclone/Crimson Strike on Ruin III. Requires Single Target Combo Feature.", SMN.JobID, SMN.Ruin3)]
        SummonerIfritUniqueFeature = 1406,

        [CustomComboInfo("Titan Unique Feature", "Adds Mountain Buster on Ruin III. Requires Single Target Combo Feature.", SMN.JobID, SMN.Ruin3)]
        SummonerTitanUniqueFeature = 1407,

        // AOE
        [CustomComboInfo("AOE Combo", "Enables changing AOE Combo (Tri-Disaster)", SMN.JobID, SMN.Tridisaster, SMN.Deathflare)]
        SummonerAOEComboFeature = 1408,

        [CustomComboInfo("AOE Demi Feature", "Replaces Astral Flare/Brand of Purgatory with Enkindle/Deathflare/Rekindle when appropriate. Requires AOE Combo Feature.", SMN.JobID, SMN.Ruin3)]
        SummonerAOEDemiFeature = 1409,

        [CustomComboInfo("Egi AOE Combo Feature", "Adds Requires Single Target Combo Feature.", SMN.JobID, SMN.Tridisaster)]
        SummonerEgiAoeComboFeature = 1410,

        // BOTH
        [CustomComboInfo("Egi Attacks Feature", "Replaces Ruin III and Tri-Disaster with Egi attacks. Requires Single Target or AOE Combo feature.", SMN.JobID, SMN.Fester, SMN.EnergyDrain, SMN.Ruin4)]
        SummonerEgiAttacksFeature = 1411,



        #endregion
        // ====================================================================================
        #region WARRIOR

        [CustomComboInfo("Storms Path Combo", "All in one main combo feature adds Storm's Eye/Path", WAR.JobID, WAR.StormsPath)]
        WarriorStormsPathCombo = 1500,

        [CustomComboInfo("Storms Eye Combo", "Replace Storms Eye with its combo chain", WAR.JobID, WAR.StormsEye)]
        WarriorStormsEyeCombo = 1501,

        [CustomComboInfo("Mythril Tempest Combo", "Replace Mythril Tempest with its combo chain", WAR.JobID, WAR.MythrilTempest)]
        WarriorMythrilTempestCombo = 1502,

        [CustomComboInfo("Warrior Gauge Overcap Feature", "Replace Single-target or AoE combo with gauge spender if you are about to overcap and are before a step of a combo that would generate beast gauge", WAR.JobID, WAR.MythrilTempest, WAR.StormsEye, WAR.StormsPath)]
        WarriorGaugeOvercapFeature = 1503,

        [CustomComboInfo("Inner Release Feature", "Replace Single-target and AoE combo with Fell Cleave/Decimate during Inner Release", WAR.JobID, WAR.MythrilTempest, WAR.StormsPath)]
        WarriorInnerReleaseFeature = 1504,

        [CustomComboInfo("Nascent Flash Feature", "Replace Nascent Flash with Raw intuition when level synced below 76", WAR.JobID, WAR.NascentFlash)]
        WarriorNascentFlashFeature = 1505,

        [CustomComboInfo("Fellcleave/IB Feature", "Replaces Main Combo With Fellcleave/IB When you are about to overcap ", WAR.JobID, WAR.FellCleave, WAR.InnerBeast)]
        WarriorFellCleaveOvercapFeature = 1506,

        [CustomComboInfo("Upheaval Feature", "Adds Upheaval into maincombo if Beserk/IR buff is present or Beserk/IR is ON CD", WAR.JobID, WAR.Upheaval)]
        WarriorUpheavalMainComboFeature = 1507,

        [CustomComboInfo("Upheaval Feature During IR", "Adds upheaval onto main combo during InnerRelease", WAR.JobID, WAR.Upheaval)]
        WarriorUpheavalMainComboFeatureDuringIR = 1508,

        #endregion
        // ====================================================================================
        #region WHITE MAGE

        [CustomComboInfo("Solace into Misery", "Replaces Afflatus Solace with Afflatus Misery when Misery is ready to be used", WHM.JobID, WHM.AfflatusSolace)]
        WhiteMageSolaceMiseryFeature = 1600,

        [CustomComboInfo("Rapture into Misery", "Replaces Afflatus Rapture with Afflatus Misery when Misery is ready to be used", WHM.JobID, WHM.AfflatusRapture)]
        WhiteMageRaptureMiseryFeature = 1601,

        [CustomComboInfo("Cure 2 to Cure Level Sync", "Changes Cure 2 to Cure when below level 30 in synced content.", WHM.JobID, WHM.Cure2)]
        WhiteMageCureFeature = 1602,

        [CustomComboInfo("Afflatus Feature", "Changes Cure 2 into Afflatus Solace, and Medica into Afflatus Rapture, when lilies are up.", WHM.JobID, WHM.Cure2, WHM.Medica)]
        WhiteMageAfflatusFeature = 1603,

        [CustomComboInfo("Swiftcast Into Raise", "Changes Swiftcast into Raise", WHM.JobID, WHM.Raise, WHM.Swiftcast)]
        WHMRaiseFeature = 1604,
        #endregion
        // ====================================================================================
        #region Reaper

        [CustomComboInfo("Reaper Main Combo Feature", "Main Combo on 1 button", RPR.JobID, RPR.Slice)]
        ReaperSliceCombo = 1700,

        [CustomComboInfo("Reaper AOE Combo Feature", "AoE on one button", RPR.JobID, RPR.SpinningScythe)]
        ReaperScytheCombo = 1701,

        [CustomComboInfo("Reaper Enshroud Feature", "Enshroud feature", RPR.JobID, RPR.Enshroud)]
        ReaperEnshroudCommunioFeature = 1702,


        #endregion
        // ====================================================================================
        #region DISCIPLE OF MAGIC

        //[CustomComboInfo("SwiftcastToRes", "Replaces Swiftcast with ressurection", DoM.JobID, WHM.Raise, SMN.Resurrection, SCH.Resurrection, AST.Ascend, RDM.Verraise)]
        // DoMSwiftcastFeature = 109,

        #endregion
    }
}
