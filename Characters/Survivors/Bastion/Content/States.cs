using Bastion.Modules;
using Bastion.States;

namespace Bastion.Content
{
    public static class States
    {
        public static void Init()
        {
            ContentBase.AddEntityState(typeof(CONFIGURATIONRecon));

            ContentBase.AddEntityState(typeof(SlashCombo));

            ContentBase.AddEntityState(typeof(Shoot));

            ContentBase.AddEntityState(typeof(Roll));

            ContentBase.AddEntityState(typeof(ThrowBomb));
        }
    }
}
