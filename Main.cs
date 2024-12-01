﻿using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace RF5_RF4_Chara
{
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInProcess(GAME_PROCESS)]
    public class Main : BasePlugin
    {
        #region PluginInfo
        private const string GUID = "8F4D47FB-3DED-F400-04CD-181FE5F14785";
        private const string NAME = "RF5_RF4_Chara";
        private const string VERSION = "1.0";
        private const string GAME_PROCESS = "Rune Factory 5.exe";
        #endregion

        internal static readonly new ManualLogSource Log = BepInEx.Logging.Logger.CreateLogSource("RF5_RF4_Chara");
        public override void Load()
        {
            Log.LogInfo($"Plugin {NAME} is loaded!");
            new Harmony(GUID).PatchAll();
        }
    }
}
