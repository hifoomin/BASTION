using System;
using Bastion.Modules;
using EntityStates;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using R2API;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Bastion.Content
{
    public static class Buffs
    {
        // armor buff gained during roll
        public static BuffDef armorBuff;
        public static BuffDef stunBuff;

        public static void Init(AssetBundle assetBundle)
        {
            armorBuff = ContentBase.CreateAndAddBuff("HenryArmorBuff",
                LegacyResourcesAPI.Load<BuffDef>("BuffDefs/HiddenInvincibility").iconSprite,
                Color.white,
                false,
                false);

            stunBuff = ContentBase.CreateAndAddBuff("CONFIGURATION: Assault Stun",
            Addressables.LoadAssetAsync<Sprite>("RoR2/Base/LunarSkillReplacements/texBuffLunarySecondaryRootIcon.tif").WaitForCompletion(), Color.white, false, false);

            RecalculateStatsAPI.GetStatCoefficients += StatChanges;
            IL.EntityStates.GenericCharacterMain.ProcessJump_bool += Stun;
        }

        private static void Stun(ILContext il)
        {
            ILCursor c = new(il);
            if (c.TryGotoNext(MoveType.Before,
                x => x.MatchLdarg(0),
                x => x.MatchLdfld<GenericCharacterMain>("jumpInputReceived")))
            {
                c.Index += 2;
                c.Emit(OpCodes.Ldarg_0);
                c.EmitDelegate<Func<bool, GenericCharacterMain, bool>>((orig, self) =>
                {
                    var body = self.characterBody;
                    if (body && body.HasBuff(stunBuff))
                    {
                        return false;
                    }

                    return orig;
                });
            }
            else
            {
                Log.Error("Failed to apply Jump Hook");
            }
        }

        private static void StatChanges(CharacterBody sender, RecalculateStatsAPI.StatHookEventArgs args)
        {
            if (sender.HasBuff(stunBuff))
            {
                args.moveSpeedRootCount += 1;
            }
        }
    }
}
