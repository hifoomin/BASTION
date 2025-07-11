using EntityStates;
using RoR2;
using UnityEngine;

namespace Bastion.States
{
    public class SelfRepair : BaseState
    {
        public static float buffInterval = 1f;
        public float timer = 0f;

        public override void OnEnter()
        {
            base.OnEnter();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            timer += Time.fixedDeltaTime;

            if (timer >= buffInterval)
            {
                this.characterBody.AddTimedBuffAuthority(RoR2Content.Buffs.CrocoRegen.buffIndex, 1f);
                timer = 0f;
            }

            this.characterBody.isSprinting = false;

            if (!inputBank.skill2.down)
            {
                this.outer.SetNextStateToMain();
            }
        }
    }
}