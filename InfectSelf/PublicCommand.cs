using PulsarModLoader.Chat.Commands.CommandRouter;

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
            Mod.InfectSelf();
        }
    }
}
