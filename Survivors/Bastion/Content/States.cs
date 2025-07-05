using Bastion.Modules;
using Bastion.States;

namespace Bastion.Content
{
    public static class States
    {
        public static void Init()
        {
            ContentBase.AddEntityState(typeof(CONFIGURATIONRecon));

            ContentBase.AddEntityState(typeof(SELFREPAIR));

            ContentBase.AddEntityState(typeof(Roll));
        }
    }
}
