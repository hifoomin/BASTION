using System;
using EntityStates;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Bastion.States
{
    public class CONFIGURATIONRecon : EntityStates.GenericBulletBaseState
    {
        public static GameObject muzzleFlash = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/RoboBallBoss/MuzzleflashRoboBall.prefab").WaitForCompletion();
        public override void OnEnter()
        {
            this.baseDuration = 0.2f;
            this.maxDistance = 100f;
            this.bulletRadius = 0.2f;
            this.damageCoefficient = 1f;
            this.fireSoundString = "Play_captain_m1_shotgun_shootTight";
            this.useSmartCollision = true;
            this.spreadBloomValue = 2f;
            this.spreadPitchScale = 2f;
            this.spreadYawScale = 2f;
            this.minSpread = 2f;
            this.maxSpread = 4f;
            this.force = 100f;
            this.hitEffectPrefab = null;
            this.muzzleFlashPrefab = muzzleFlash;
            this.muzzleName = "";
            this.procCoefficient = 1f;
            this.recoilAmplitudeX = 0.5f;
            this.recoilAmplitudeY = 2f;
            base.OnEnter();
            PlayAnimation("LeftArm, Override", "ShootGun", "ShootGun.playbackRate", this.duration);
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return base.GetMinimumInterruptPriority();
        }

        public override void OnExit()
        {
            base.OnExit();
        }
    }
}
