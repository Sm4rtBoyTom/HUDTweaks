
namespace HUDTweaks
{
	public class HudTweaks : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLoader.MelonLogger.Msg(System.ConsoleColor.Green, "Hi, HUD Tweaks is on!");
            Settings.instance.AddToModSettings("HUD Tweaks");
        }
    }
}
