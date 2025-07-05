using Bastion.Modules;
using RoR2;
using UnityEngine;

namespace Bastion.Content
{
    public static class Unlocks
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = ContentBase.CreateAndAddUnlockbleDef(
                BastionMasteryAchievement.unlockableIdentifier,
                TokenBase.GetAchievementNameToken(BastionMasteryAchievement.identifier),
                BastionSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }

    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class BastionMasteryAchievement : Modules.Achievements.BaseMasteryAchievement
    {
        public const string identifier = BastionSurvivor.BASTION_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = BastionSurvivor.BASTION_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => BastionSurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}
