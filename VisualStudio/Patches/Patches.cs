
namespace HUDTweaks
{
    internal class Patches
    {
        [HarmonyPatch(typeof(Panel_HUD), "SetHoverText")] //Set Hover Text by Digital Zombie
        public class HoverTextPatch
        {
            public static bool Prefix(ref Panel_HUD __instance, ref string hoverText, ref GameObject itemUnderCrosshairs, ref HoverTextState textState)
            {
                if (itemUnderCrosshairs == null)
                {
                    return true;
                }

                if (itemUnderCrosshairs.GetComponent<Campfire>())
                {
                    return Settings.instance.hoverFire;
                }
                else if (itemUnderCrosshairs.GetComponent<WoodStove>())
                {
                    return Settings.instance.hoverFire;
                }
                else if (itemUnderCrosshairs.GetComponent<Forge>())
                {
                    return Settings.instance.hoverFire;
                }
                    return Settings.instance.hoverGeneral;
            }
        }
        [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
        internal static class RemoveAfflictionIcon
        {
            private static void Postfix(Panel_HUD __instance)
            {
                if (__instance == null) return;

                if (__instance != null)
                {
                    __instance.m_PlayerDamageEventsGrid.gameObject.SetActive(Settings.instance.AfflictionTable);

                    __instance.m_EquipItemPopup.gameObject.SetActive(Settings.instance.AmmoWidgets);

                    __instance.m_Sprite_Sheltered.gameObject.SetActive(Settings.instance.Sheltered);

                    __instance.m_SprintBar.gameObject.SetActive(Settings.instance.SprintMeter);

                    __instance.m_ThinIceWidget.gameObject.SetActive(Settings.instance.ThinIce);

                    __instance.m_Sprite_Crouching.gameObject.SetActive(Settings.instance.Crouch);

                    __instance.m_SprainWarningWidget.gameObject.SetActive(Settings.instance.SprainRiskWidget);

                    __instance.m_BuffNameLabel.gameObject.SetActive(Settings.instance.BuffPopups);

                     __instance.m_Sprite_CapacityBuff.gameObject.SetActive(Settings.instance.BuffPopups);

                    __instance.m_BuffSprite.gameObject.SetActive(Settings.instance.BuffPopups);

                    __instance.m_BuffNotificationAimingParent.gameObject.SetActive(Settings.instance.BuffPopups);

                    __instance.m_BuffNotificationPanel.gameObject.SetActive(Settings.instance.BuffPopups);

                    __instance.m_BuffHeaderLabel.gameObject.SetActive(Settings.instance.BuffPopups);

                    __instance.m_Sprite_SprintBuffBar.gameObject.SetActive(Settings.instance.BuffPopups);

                    __instance.m_BuffNotificationParent.gameObject.SetActive(Settings.instance.BuffPopups);

                    __instance.m_FeatUnlockedWidget.gameObject.SetActive(Settings.instance.feats);

                    __instance.m_AimingStaminaBar.gameObject.SetActive(Settings.instance.AimMeter);

                    __instance.m_SafehouseRoot.gameObject.SetActive(Settings.instance.SafehouseIcon);

                }
            }
        }
        [HarmonyPatch(typeof(EquipItemPopup), nameof(EquipItemPopup.Update))]
        private static class RemoveAmmoIcon
        {
            private static void Postfix(EquipItemPopup __instance)
            {
                if (__instance == null) return;

                if (__instance != null)
                {
                    __instance.m_AmmoWidget.gameObject.SetActive(Settings.instance.AmmoWidgets);
                }
            }
        }
        [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.UpdateRespiratorMeter))]
        internal class RespiratorWidgetPatches
        {
            private static bool Prefix(ref Panel_HUD __instance)
            {
                if (Settings.instance.RespiratorMeter == Settings.RespiratorMode.Hidden)
                {
                    __instance.m_RespiratorMeterWidget.gameObject.SetActive(false);
                    return false;
                }
                else return true;
            }
        }
        [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.UpdateSuffocatingMeter))]
        internal static class ToggleSuffocatingMeter
        {
            private static bool Prefix(Panel_HUD __instance)
            {
                if (Settings.instance.SuffocatingMeter == Settings.SuffocatingMode.Hidden)
                {
                    __instance.m_SuffocatingMeterWidget.gameObject.SetActive(false);
                    return false;
                }
                return true;
            }
        }
    }
}
