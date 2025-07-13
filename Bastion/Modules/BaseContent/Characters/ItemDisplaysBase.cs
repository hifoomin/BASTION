using RoR2;
using System.Collections.Generic;

namespace Bastion.Modules.Characters
{
    public abstract class ItemDisplaysBase
    {
        public void SetItemDisplays(ItemDisplayRuleSet itemDisplayRuleSet)
        {
            List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules = new List<ItemDisplayRuleSet.KeyAssetRuleGroup>();

            ItemDisplayBase.LazyInit();

            SetItemDisplayRules(itemDisplayRules);

            itemDisplayRuleSet.keyAssetRuleGroups = itemDisplayRules.ToArray();

            ItemDisplayBase.DisposeWhenDone();
        }

        protected abstract void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules);
    }
}
