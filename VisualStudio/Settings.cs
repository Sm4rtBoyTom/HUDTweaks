
using System.Diagnostics.Metrics;
using Unity.VisualScripting;

namespace HUDTweaks
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Yes I Know Settings")]

        [Name("General Items")]
        [Description("Enable/disable hovertext on items")]
        public bool hoverGeneral = true;

        [Name("Fire")]
        [Description("Enable/disable hovertext on fire/stoves")]
        public bool hoverFire = true;

        [Section("Essential")]

        [Name("Meter Widgets")]
        [Description("If enabled, displays all meter widgets in the lower-right corner (ammunition count, lantern/torch fuel, etc.).")]
        public bool AmmoWidgets = true;

        [Name("Sprain Risk Icon")]
        [Description("If enabled, displays the sprain risk icon in the lower-right corner.")]
        public bool SprainRiskWidget = true;

        [Name("Sprint Stamina Meter")]
        [Description("If enabled, displays the sprint stamina meter.")]
        public bool SprintMeter = true;

        [Name("Aiming Stamina Meter")]
        [Description("If enabled, displays the aiming stamina meter.")]
        public bool AimMeter = true;

        [Name("Affliction Event Table")]
        [Description("If enabled, displays the affliction event table on the right side of the screen.")]
        public bool AfflictionTable = true;

        [Name("Thin Ice Warning")]
        [Description("If enabled, displays the thin ice warning at the top of the screen.")]
        public bool ThinIce = true;

        [Name("Respirator Meter Mode")]
        [Description("Vanilla — Shows only while wearing a respirator. Hidden — Never shows.")]
        public RespiratorMode RespiratorMeter = RespiratorMode.Vanilla;

        [Name("Suffocating Meter Mode")]
        [Description("Vanilla — Shows only while suffocating. Hidden — Never shows.")]
        public SuffocatingMode SuffocatingMeter = SuffocatingMode.Vanilla;

        [Section("Non-Essential")]

        [Name("Buff Pop-ups")]
        [Description("If enabled, displays buff pop-up notifications on the screen.")]
        public bool BuffPopups = false;

        [Name("Feat Unlocked Icon")]
        [Description("If enabled, displays the “Feat Unlocked” notification icon.")]
        public bool feats = false;

        [Name("Crouch Icon")]
        [Description("If enabled, displays the crouch icon in the lower-right corner.")]
        public bool Crouch = true;

        [Name("Safehouse Customization Icon")]
        [Description("If enabled, displays the Safehouse Customization icon in the top-left corner.")]
        public bool SafehouseIcon = false;

        [Name("Sheltered Icon")]
        [Description("If enabled, displays the sheltered status icon at the top of the screen.")]
        public bool Sheltered = true;

        protected override void OnConfirm()
        {
            base.OnConfirm();
            instance.RefreshGUI();
        }
        public enum SuffocatingMode
        {
            Vanilla, // shows only when suffocating
            Hidden   // never shows
        }

        public enum RespiratorMode
        {
            Vanilla, // shows only when suffocating
            Hidden   // never shows
        }
    }
}