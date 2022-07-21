using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using BepInEx;

namespace RF5_RF4_Chara
{
	[HarmonyPatch(typeof(SaveData.RF5SystemData), nameof(SaveData.RF5SystemData.GetSaveFlag))]
	public class SystemDataPatch
	{
		public static bool Prefix(SaveData.RF5SystemData.FLAG id, ref bool __result)
		{
			if (id == SaveData.RF5SystemData.FLAG.SaveLink)
			{
				__result = true;
				return false;
			}

			return true;
		}
	}
}
