using PulsarModLoader.Chat.Commands.CommandRouter;
using PulsarModLoader.Utilities;

namespace InfectSelf
{
    internal class Command : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[] { "infectself" };
        }

        public override string Description()
        {
            return "Infects player ship with a harmless virus";
        }

        public override void Execute(string arguments)
        {
            if (PhotonNetwork.isMasterClient)
            {
                Mod.InfectSelf();
            }
            else
            {
                Messaging.Notification("Must be host to use this command");
            }
        }
    }
}
