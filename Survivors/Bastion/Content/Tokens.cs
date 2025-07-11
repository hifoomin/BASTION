using System;
using Bastion.Modules;

namespace Bastion.Content
{
    public static class Tokens
    {
        public static void Init()
        {
            AddHenryTokens();

            ////uncomment this to spit out a lanuage file with all the above tokens that people can translate
            ////make sure you set Language.usingLanguageFolder and printingEnabled to true
            //Language.PrintOutput("Henry.txt");
            ////refer to guide on how to build and distribute your mod with the proper folders
        }

        public static void AddHenryTokens()
        {
            string prefix = Content.Bastion.BASTION_PREFIX;

            string desc = "Henry is a skilled fighter who makes use of a wide arsenal of weaponry to take down his foes.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine
             + "< ! > Sword is a good all-rounder while Boxing Gloves are better for laying a beatdown on more powerful foes." + Environment.NewLine + Environment.NewLine
             + "< ! > Pistol is a powerful anti air, with its low cooldown and high damage." + Environment.NewLine + Environment.NewLine
             + "< ! > Roll has a lingering armor buff that helps to use it aggressively." + Environment.NewLine + Environment.NewLine
             + "< ! > Bomb can be used to wipe crowds with ease." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so he left, searching for a new identity.";
            string outroFailure = "..and so he vanished, forever a blank slate.";

            LanguageBase.Add(prefix + "NAME", "BASTION");
            LanguageBase.Add(prefix + "DESCRIPTION", desc);
            LanguageBase.Add(prefix + "SUBTITLE", "The Chosen One");
            LanguageBase.Add(prefix + "LORE", "sample lore");
            LanguageBase.Add(prefix + "OUTRO_FLAVOR", outro);
            LanguageBase.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            LanguageBase.Add(prefix + "MASTERY_SKIN_NAME", "Alternate");
            #endregion

            #region Passive
            LanguageBase.Add(prefix + "PASSIVE_NAME", "Henry passive");
            LanguageBase.Add(prefix + "PASSIVE_DESCRIPTION", "Sample text.");
            #endregion

            #region Primary
            LanguageBase.Add(prefix + "PRIMARY_NAME", "CONFIGURATION: Recon");
            LanguageBase.Add(prefix + "PRIMARY_DESC", $"Rapidly fire bullets for <style=cIsDamage>100% damage</style>.");
            #endregion

            #region Secondary
            LanguageBase.Add(prefix + "SECONDARY_NAME", "SELF-REPAIR");
            LanguageBase.Add(prefix + "SECONDARY_DESC", $"Reconstruct your components, healing for <style=cIsHealing>10%</style> of your <style=cIsHealing>maximum health</style> per second.");
            #endregion

            #region Utility
            LanguageBase.Add(prefix + "UTILITY_NAME", "CONFIGURATION: Assault");
            LanguageBase.Add(prefix + "UTILITY_DESC", "Reconfigure into a <style=cIsUtility>stationary turret</style>, equipped with with a <style=cIsDamage>powerful minigun</style> dealing <style=cIsDamage>1500%</style> damage per second.");

            LanguageBase.Add(prefix + "UTILITY_OVERRIDE_ASSAULT_NAME", "Cancel CONFIGURATION: Assault");
            LanguageBase.Add(prefix + "UTILITY_OVERRIDE_ASSAULT_DESC", "Reconfigure into a <style=cIsUtility>stationary turret</style>, equipped with with a <style=cIsDamage>powerful minigun</style> dealing <style=cIsDamage>1500%</style> damage per second.");
            #endregion

            #region Special
            LanguageBase.Add(prefix + "SPECIAL_BOMB_NAME", "Bomb");
            LanguageBase.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Throw a bomb for <style=cIsDamage>a% damage</style>.");
            #endregion

            #region Achievements
            LanguageBase.Add(TokenBase.GetAchievementNameToken(BastionMasteryAchievement.identifier), "Henry: Mastery");
            LanguageBase.Add(TokenBase.GetAchievementDescriptionToken(BastionMasteryAchievement.identifier), "As Henry, beat the game or obliterate on Monsoon.");
            #endregion
        }
    }
}
