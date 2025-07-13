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
    public class CancelConfigurationAssault : BaseState
    {
        public override void OnEnter()
        {
            base.OnEnter();
            skillLocator.primary.UnsetSkillOverride(gameObject, Content.Bastion.configurationAssaultShootSkillDef, GenericSkill.SkillOverridePriority.Contextual);
            skillLocator.utility.UnsetSkillOverride(gameObject, Content.Bastion.configurationAssaultCancelSkillDef, GenericSkill.SkillOverridePriority.Contextual);

            characterBody.RemoveBuff(Buffs.stunBuff);
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }
    }
}
