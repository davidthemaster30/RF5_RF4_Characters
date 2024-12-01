using HarmonyLib;

namespace RF5_RF4_Chara;

[HarmonyPatch(typeof(SaveData.RF5SystemData), nameof(SaveData.RF5SystemData.GetSaveFlag))]
internal static class SystemDataPatch
{
	internal static bool Prefix(SaveData.RF5SystemData.FLAG id, ref bool __result)
	{
		if (id == SaveData.RF5SystemData.FLAG.SaveLink)
		{
			Main.Log.LogInfo($"SaveLink flagged!");
			__result = true;
			return false;
		}

		return true;
	}
}
