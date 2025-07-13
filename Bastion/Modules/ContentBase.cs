using RoR2;
using RoR2.Skills;
using System;
using UnityEngine;

namespace Bastion.Modules
{
    //consolidate contentaddition here in case something breaks and/or want to move to r2api
    internal class ContentBase
    {
        internal static void AddCharacterBodyPrefab(GameObject bprefab)
        {
            ContentPack.bodyPrefabs.Add(bprefab);
        }

        internal static void AddMasterPrefab(GameObject prefab)
        {
            ContentPack.masterPrefabs.Add(prefab);
        }

        internal static void AddProjectilePrefab(GameObject prefab)
        {
            ContentPack.projectilePrefabs.Add(prefab);
        }

        internal static void AddSurvivorDef(SurvivorDef survivorDef)
        {

            ContentPack.survivorDefs.Add(survivorDef);
        }
        internal static void CreateSurvivor(GameObject bodyPrefab, GameObject displayPrefab, Color charColor, string tokenPrefix) { CreateSurvivor(bodyPrefab, displayPrefab, charColor, tokenPrefix, null, 100f); }
        internal static void CreateSurvivor(GameObject bodyPrefab, GameObject displayPrefab, Color charColor, string tokenPrefix, float sortPosition) { CreateSurvivor(bodyPrefab, displayPrefab, charColor, tokenPrefix, null, sortPosition); }
        internal static void CreateSurvivor(GameObject bodyPrefab, GameObject displayPrefab, Color charColor, string tokenPrefix, UnlockableDef unlockableDef) { CreateSurvivor(bodyPrefab, displayPrefab, charColor, tokenPrefix, unlockableDef, 100f); }
        internal static void CreateSurvivor(GameObject bodyPrefab, GameObject displayPrefab, Color charColor, string tokenPrefix, UnlockableDef unlockableDef, float sortPosition)
        {
            SurvivorDef survivorDef = ScriptableObject.CreateInstance<SurvivorDef>();
            survivorDef.bodyPrefab = bodyPrefab;
            survivorDef.displayPrefab = displayPrefab;
            survivorDef.primaryColor = charColor;

            survivorDef.cachedName = bodyPrefab.name.Replace("Body", "");
            survivorDef.displayNameToken = tokenPrefix + "NAME";
            survivorDef.descriptionToken = tokenPrefix + "DESCRIPTION";
            survivorDef.outroFlavorToken = tokenPrefix + "OUTRO_FLAVOR";
            survivorDef.mainEndingEscapeFailureFlavorToken = tokenPrefix + "OUTRO_FAILURE";

            survivorDef.desiredSortPosition = sortPosition;
            survivorDef.unlockableDef = unlockableDef;

            AddSurvivorDef(survivorDef);
        }

        internal static void AddUnlockableDef(UnlockableDef unlockableDef)
        {
            ContentPack.unlockableDefs.Add(unlockableDef);
        }
        internal static UnlockableDef CreateAndAddUnlockbleDef(string identifier, string nameToken, Sprite achievementIcon)
        {
            UnlockableDef unlockableDef = ScriptableObject.CreateInstance<UnlockableDef>();
            unlockableDef.cachedName = identifier;
            unlockableDef.nameToken = nameToken;
            unlockableDef.achievementIcon = achievementIcon;

            AddUnlockableDef(unlockableDef);

            return unlockableDef;
        }

        internal static void AddSkillDef(SkillDef skillDef)
        {
            ContentPack.skillDefs.Add(skillDef);
        }

        internal static void AddSkillFamily(SkillFamily skillFamily)
        {
            ContentPack.skillFamilies.Add(skillFamily);
        }

        internal static void AddEntityState(Type entityState)
        {
            ContentPack.entityStates.Add(entityState);
        }

        internal static void AddBuffDef(BuffDef buffDef)
        {
            ContentPack.buffDefs.Add(buffDef);
        }
        internal static BuffDef CreateAndAddBuff(string buffName, Sprite buffIcon, Color buffColor, bool canStack, bool isDebuff)
        {
            BuffDef buffDef = ScriptableObject.CreateInstance<BuffDef>();
            buffDef.name = buffName;
            buffDef.buffColor = buffColor;
            buffDef.canStack = canStack;
            buffDef.isDebuff = isDebuff;
            buffDef.eliteDef = null;
            buffDef.iconSprite = buffIcon;

            AddBuffDef(buffDef);

            return buffDef;
        }

        internal static void AddEffectDef(EffectDef effectDef)
        {
            ContentPack.effectDefs.Add(effectDef);
        }
        internal static EffectDef CreateAndAddEffectDef(GameObject effectPrefab)
        {
            EffectDef effectDef = new EffectDef(effectPrefab);

            AddEffectDef(effectDef);

            return effectDef;
        }

        internal static void AddNetworkSoundEventDef(NetworkSoundEventDef networkSoundEventDef)
        {
            ContentPack.networkSoundEventDefs.Add(networkSoundEventDef);
        }
        internal static NetworkSoundEventDef CreateAndAddNetworkSoundEventDef(string eventName)
        {
            NetworkSoundEventDef networkSoundEventDef = ScriptableObject.CreateInstance<NetworkSoundEventDef>();
            networkSoundEventDef.akId = AkSoundEngine.GetIDFromString(eventName);
            networkSoundEventDef.eventName = eventName;

            AddNetworkSoundEventDef(networkSoundEventDef);

            return networkSoundEventDef;
        }
    }
}