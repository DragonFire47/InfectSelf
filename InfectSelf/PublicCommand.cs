using PulsarModLoader.Chat.Commands.CommandRouter;
using PulsarModLoader.Utilities;

namespace InfectSelf
{
    internal class PCommand : PublicCommand
    {
        public override string[] CommandAliases()
        {
            return new string[] { "infectself" };
        }

        public override string Description()
        {
            return "Infects player ship with a harmless virus";
        }

        public override void Execute(string arguments, int SenderID)
        {
            if (Mod.Enabled)
            {
                Mod.InfectSelf();
            }
            else
            {
                Messaging.Notification("This command has been disabled by the host", PLServer.Instance.GetPlayerFromPlayerID(SenderID));
            }
        }
    }
}
