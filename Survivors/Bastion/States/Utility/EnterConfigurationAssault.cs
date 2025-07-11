using System.Net.Mime;
using System;
using System.Collections.Generic;
using EntityStates;
using RoR2.Skills;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Bastion.Content;

namespace Bastion.States
{
    public class ToggleConfigurationAssault : BaseState
    {
        public static float baseDuration = 0.5f;

        public override void OnEnter()
        {
            base.OnEnter();
            skillLocator.primary.SetSkillOverride(gameObject, Content.Bastion.configurationAssaultShootSkillDef, GenericSkill.SkillOverridePriority.Contextual);
            skillLocator.utility.SetSkillOverride(gameObject, Content.Bastion.configurationAssaultCancelSkillDef, GenericSkill.SkillOverridePriority.Contextual);

            characterBody.AddBuff(Buffs.stunBuff);
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }
    }
}
