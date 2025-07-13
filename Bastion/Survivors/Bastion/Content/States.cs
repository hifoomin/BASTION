using Bastion.Modules;
using Bastion.States;

namespace Bastion.Content
{
    public static class States
    {
        public static void Init()
        {
            ContentBase.AddEntityState(typeof(ConfigurationRecon));

            ContentBase.AddEntityState(typeof(SelfRepair));

            ContentBase.AddEntityState(typeof(ToggleConfigurationAssault));

            ContentBase.AddEntityState(typeof(ConfigurationAssault));

            ContentBase.AddEntityState(typeof(Roll));
        }
    }
}
