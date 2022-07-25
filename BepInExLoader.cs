using BepInEx;
using HarmonyLib;

namespace RF5.HisaCat.Lib.InputHelper
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    internal class BepInExLoader : BepInEx.IL2CPP.BasePlugin
    {
        public const string
            MODNAME = "Lib.InputHelper",
            AUTHOR = "HisaCat",
            GUID = "RF5." + AUTHOR + "." + MODNAME,
            VERSION = "1.0.0";

        public static BepInEx.Logging.ManualLogSource log;

        public BepInExLoader()
        {
            log = Log;
        }

        public override void Load()
        {
            try
            {
                Harmony.CreateAndPatchAll(typeof(PadHooker));
                Harmony.CreateAndPatchAll(typeof(SteamInputManagerHooker));
            }
            catch
            {
                log.LogError("[Lib.InputHelper] Harmony - FAILED to Apply Patch's!");
            }
        }

        [HarmonyPatch]
        public class PadHooker
        {
            [HarmonyPatch(typeof(RF5Input.Pad), nameof(RF5Input.Pad.Update))]
            [HarmonyPostfix]
            public static void UpdatePostfix(RF5Input.Pad __instance)
            {
            }
        }

        [HarmonyPatch]
        public class SteamInputManagerHooker
        {
            [HarmonyPatch(typeof(RF5SteamInput.SteamInputManager), nameof(RF5SteamInput.SteamInputManager.Update))]
            [HarmonyPostfix]
            public static void UpdatePostfix(RF5SteamInput.SteamInputManager __instance)
            {
            }
        }
    }
}
