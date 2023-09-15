using PulsarModLoader;

namespace InfectSelf
{
    public class Mod : PulsarMod
    {
        public static SaveValue<bool> Enabled = new SaveValue<bool>("Enabled", true);

        public static void InfectSelf()
        {
            if(PLServer.Instance == null)
            {
                return;
            }

            PLShipInfoBase Ship = PLEncounterManager.Instance.PlayerShip;
            PLVirus virus = new PLVirus(EVirusType.VIRUS_SHOP_AD, 0, 0)
            {
                NetID = PLShipInfoBase.ComponentIDCounter++,
                Sender = Ship,
                InitialTime = PLServer.Instance.GetEstimatedServerMs(),
                InfectionTimeLimitMs = 300000
            };
            virus.InfectionCompletedOnShips.Add(Ship.ShipID);
            Ship.MyStats.AddShipComponent(virus, virus.NetID, virus.ActualSlotType);
        }

        public override string Version => "1.0.0";

        public override string Author => "Dragon";

        public override string Name => "InfectSelf";

        public override string LongDescription => "Infects the player ship with a harmless virus.\n/infectself -runs for the host\n!infectself -runs for clients when enabled\n/infectselftoggle -toggles client command on/off";

        public override string HarmonyIdentifier()
        {
            return $"{Author}.{Name}";
        }

        public override bool CanBeDisabled()
        {
            return true;
        }

        public override bool IsEnabled()
        {
            return Enabled;
        }

        public override void Disable()
        {
            Enabled.Value = false;
        }

        public override void Enable()
        {
            Enabled.Value = true;
        }
    }
}
