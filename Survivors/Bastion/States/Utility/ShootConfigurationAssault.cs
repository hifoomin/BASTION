using System;
using EntityStates;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Bastion.States
{
    public class ConfigurationAssault : EntityStates.GenericBulletBaseState
    {
        public static GameObject muzzleFlash = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/GoldGat/MuzzleflashGoldGat.prefab").WaitForCompletion();
        public static GameObject tracer = Addressables.LoadAssetAsync<GameObject>("RoR2/DLC1/Railgunner/TracerRailgunLight.prefab").WaitForCompletion();
        public override void OnEnter()
        {
            this.baseDuration = 0.033f;
            this.maxDistance = 100f;
            this.bulletRadius = 0.3f;
            this.damageCoefficient = 0.5f;
            this.fireSoundString = "Play_MULT_m1_snipe_shoot";
            this.useSmartCollision = true;
            this.minSpread = 0.5f;
            this.maxSpread = 1f;
            this.force = 200f;
            this.hitEffectPrefab = null;
            this.muzzleFlashPrefab = muzzleFlash;
            this.muzzleName = "Muzzle";
            this.procCoefficient = 0.85f;
            this.recoilAmplitudeX = 0.5f;
            this.recoilAmplitudeY = 0.8f;
            this.tracerEffectPrefab = tracer;
            base.OnEnter();
            // PlayAnimation("LeftArm, Override", "ShootGun", "ShootGun.playbackRate", this.duration);
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            this.characterBody.isSprinting = false;
        }

        public override void ModifyBulletAttack(ref BulletAttack bulletAttack)
        {
            base.ModifyBulletAttack(ref bulletAttack);
            bulletAttack.damageType = DamageTypeCombo.GenericPrimary;
            bulletAttack.falloffModel = BulletAttack.FalloffModel.DefaultBullet;
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }
    }
}
