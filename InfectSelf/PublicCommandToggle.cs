using PulsarModLoader.Chat.Commands.CommandRouter;

namespace InfectSelf
{
    internal class PublicCommandToggle : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[] { "infectselftoggle" };
        }

        public override string Description()
        {
            return "Enables/disables the public command. Must be host to take effect.";
        }

        public override void Execute(string arguments)
        {
            Mod.Enabled.Value = !Mod.Enabled.Value;
        }
    }
}
