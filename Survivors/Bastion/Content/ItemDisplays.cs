using Bastion.Modules;
using Bastion.Modules.Characters;
using RoR2;
using System.Collections.Generic;
using UnityEngine;

/* for custom copy format in keb's helper
{childName},
                    {localPos}, 
                    {localAngles},
                    {localScale})
*/

namespace Bastion.Content
{
    public class ItemDisplays : ItemDisplaysBase
    {
        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["AlienHead"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayAlienHead"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ArmorPlate"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayRepulsionArmorPlate"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ArmorReductionOnHit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayWarhammer"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["AttackSpeedAndMoveSpeed"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayCoffee"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["AttackSpeedOnCrit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayWolfPelt"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["AutoCastEquipment"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayFossil"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Bandolier"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBandolier"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BarrierOnKill"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBrooch"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BarrierOnOverHeal"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayAegis"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Bear"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBear"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BearVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBearVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BeetleGland"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBeetleGland"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Behemoth"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBehemoth"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BleedOnHit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayTriTip"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BleedOnHitAndExplode"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBleedOnHitAndExplode"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BleedOnHitVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayTriTipVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BonusGoldPackOnKill"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayTome"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BossDamageBonus"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayAPRound"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BounceNearby"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayHook"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ChainLightning"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayUkulele"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ChainLightningVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayUkuleleVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Clover"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayClover"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["CloverVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayCloverVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["CooldownOnCrit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySkull"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["CritDamage"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayLaserSight"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["CritGlasses"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGlasses"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["CritGlassesVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGlassesVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Crowbar"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayCrowbar"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Dagger"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayDagger"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["DeathMark"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayDeathMark"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ElementalRingVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayVoidRing"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["EmpowerAlways"],
                Modules.ItemDisplayBase.CreateLimbMaskDisplayRule(LimbFlags.Head),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySunHeadNeck"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySunHead"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["EnergizedOnEquipmentUse"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayWarHorn"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["EquipmentMagazine"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBattery"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["EquipmentMagazineVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayFuelCellVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ExecuteLowHealthElite"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGuillotine"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ExplodeOnDeath"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayWilloWisp"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ExplodeOnDeathVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayWillowWispVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ExtraLife"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayHippo"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ExtraLifeVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayHippoVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["FallBoots"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGravBoots"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGravBoots"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Feather"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayFeather"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["FireballsOnHit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayFireballsOnHit"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["FireRing"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayFireRing"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Firework"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayFirework"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["FlatHealth"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySteakCurved"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["FocusConvergence"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayFocusedConvergence"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["FragileDamageBonus"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayDelicateWatch"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["FreeChest"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayShippingRequestForm"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["GhostOnKill"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayMask"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["GoldOnHit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBoneCrown"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["GoldOnHurt"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayRollOfPennies"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["HalfAttackSpeedHalfCooldowns"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayLunarShoulderNature"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["HalfSpeedDoubleHealth"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayLunarShoulderStone"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["HeadHunter"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySkullcrown"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["HealingPotion"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayHealingPotion"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["HealOnCrit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayScythe"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["HealWhileSafe"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySnail"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Hoof"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayHoof"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateLimbMaskDisplayRule(LimbFlags.RightCalf)
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["IceRing"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayIceRing"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Icicle"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayFrostRelic"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["IgniteOnKill"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGasoline"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ImmuneToDebuff"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayRainCoatBelt"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["IncreaseHealing"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayAntler"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayAntler"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Incubator"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayAncestralIncubator"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Infusion"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayInfusion"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["JumpBoost"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayWaxBird"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["KillEliteFrenzy"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBrainstalk"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Knurl"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayKnurl"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["LaserTurbine"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayLaserTurbine"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["LightningStrikeOnHit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayChargedPerforator"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["LunarDagger"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayLunarDagger"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["LunarPrimaryReplacement"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBirdEye"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["LunarSecondaryReplacement"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBirdClaw"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["LunarSpecialReplacement"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBirdHeart"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["LunarTrinket"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBeads"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["LunarUtilityReplacement"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBirdFoot"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Medkit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayMedkit"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["MinorConstructOnKill"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayDefenseNucleus"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Missile"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayMissileLauncher"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["MissileVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayMissileLauncherVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["MonstersOnShrineUse"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayMonstersOnShrineUse"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["MoreMissile"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayICBM"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["MoveSpeedOnKill"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGrappleHook"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Mushroom"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayMushroom"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["MushroomVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayMushroomVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["NearbyDamageBonus"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayDiamond"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["NovaOnHeal"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayDevilHorns"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayDevilHorns"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["NovaOnLowHealth"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayJellyGuts"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["OutOfCombatArmor"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayOddlyShapedOpal"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ParentEgg"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayParentEgg"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Pearl"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayPearl"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["PermanentDebuffOnHit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayScorpion"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["PersonalShield"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayShieldGenerator"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Phasing"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayStealthkit"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Plant"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayInterstellarDeskPlant"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["PrimarySkillShuriken"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayShuriken"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["RandomDamageZone"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayRandomDamageZone"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["RandomEquipmentTrigger"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBottledChaos"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["RandomlyLunar"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayDomino"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["RegeneratingScrap"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayRegeneratingScrap"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["RepeatHeal"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayCorpseflower"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["SecondarySkillMagazine"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayDoubleMag"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Seed"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySeed"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ShieldOnly"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayShieldBug"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayShieldBug"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ShinyPearl"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayShinyPearl"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ShockNearby"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayTeslaCoil"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["SiphonOnLowHealth"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySiphonOnLowHealth"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["SlowOnHit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBauble"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["SlowOnHitVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBaubleVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["SprintArmor"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBuckler"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["SprintBonus"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySoda"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["SprintOutOfCombat"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayWhip"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["SprintWisp"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBrokenMask"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Squid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySquidTurret"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["StickyBomb"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayStickyBomb"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["StrengthenBurn"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGasTank"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["StunChanceOnHit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayStunGrenade"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Syringe"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySyringeCluster"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Talisman"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayTalisman"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Thorns"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayRazorwireLeft"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["TitanGoldDuringTP"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGoldHeart"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Tooth"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayToothNecklaceDecal"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayToothMeshLarge"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayToothMeshSmall1"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayToothMeshSmall2"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayToothMeshSmall2"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayToothMeshSmall1"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["TPHealingNova"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGlowFlower"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["TreasureCache"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayKey"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["TreasureCacheVoid"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayKeyVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["UtilitySkillMagazine"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["VoidMegaCrabItem"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayMegaCrabItem"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["WarCryOnMultiKill"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayPauldron"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["WardOnLevel"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayWarbanner"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BFG"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBFG"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Blackhole"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGravCube"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BossHunter"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayTricornGhost"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBlunderbuss"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BossHunterConsumed"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayTricornUsed"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["BurnNearby"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayPotion"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Cleanse"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayWaterPack"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["CommandMissile"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayMissileRack"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["CrippleWard"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayEffigy"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["CritOnUse"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayNeuralImplant"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["DeathProjectile"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayDeathProjectile"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["DroneBackup"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayRadio"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["EliteEarthEquipment"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayEliteMendingAntlers"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["EliteFireEquipment"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayEliteHorn"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayEliteHorn"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["EliteHauntedEquipment"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayEliteStealthCrown"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["EliteIceEquipment"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayEliteIceCrown"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["EliteLightningEquipment"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayEliteRhinoHorn"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayEliteRhinoHorn"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["EliteLunarEquipment"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayEliteLunar,Eye"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["ElitePoisonEquipment"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayEliteUrchinCrown"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["EliteVoidEquipment"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayAffixVoid"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["FireBallDash"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayEgg"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Fruit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayFruit"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["GainArmor"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayElephantFigure"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Gateway"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayVase"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["GoldGat"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGoldGat"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["GummyClone"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayGummyClone"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["IrradiatingLaser"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayIrradiatingLaser"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Jetpack"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBugWings"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["LifestealOnHit"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayLifestealOnHit"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Lightning"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayLightningArmRight"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    ),
                Modules.ItemDisplayBase.CreateLimbMaskDisplayRule(LimbFlags.RightArm)
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["LunarPortalOnUse"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayLunarPortalOnUse"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Meteor"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayMeteor"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Molotov"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayMolotov"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["MultiShopCard"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayExecutiveCard"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["QuestVolatileBattery"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayBatteryArray"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Recycle"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayRecycler"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Saw"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplaySawmerangFollower"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Scanner"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayScanner"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["TeamWarCry"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayTeamWarCry"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["Tonic"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayTonic"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
            itemDisplayRules.Add(Modules.ItemDisplayBase.CreateDisplayRuleGroupWithRules(Modules.ItemDisplayBase.KeyAssets["VendingMachine"],
                Modules.ItemDisplayBase.CreateDisplayRule(Modules.ItemDisplayBase.LoadDisplay("DisplayVendingMachine"),
                    "Chest",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)
                    )
                ));
        }
    }
}