using Rage;
using Rage.Attributes;
using Rage.Native;

[assembly: Plugin("NorthYanktonExample", Description = "North Yankton example", Author = "Pursuit")]
namespace NorthYanktonExample
{
	public static class EntryPoint
	{
		public static void Main()
		{
			SetNorthYanktonEnabled(true);
			GameFiber.Hibernate();
		}

		[ConsoleCommand]
		public static void SetNorthYanktonEnabled(bool enabled)
		{
			NativeFunction.Natives.SetAudioFlag("PoliceScannerDisabled", enabled);
			NativeFunction.Natives.SetAmbientZoneStatePersistent("AZ_YANKTON_CEMETARY", false, enabled);

			if(enabled)
			{
				NativeFunction.Natives.RequestIpl("prologue01");
				NativeFunction.Natives.RequestIpl("prologue01c");
				NativeFunction.Natives.RequestIpl("prologue01d");
				NativeFunction.Natives.RequestIpl("prologue01e");
				NativeFunction.Natives.RequestIpl("prologue01f");
				NativeFunction.Natives.RequestIpl("prologue01g");
				NativeFunction.Natives.RequestIpl("prologue01h");
				NativeFunction.Natives.RequestIpl("prologue01i");
				NativeFunction.Natives.RequestIpl("prologue01j");
				NativeFunction.Natives.RequestIpl("prologue01k");
				NativeFunction.Natives.RequestIpl("prologue01z");
				NativeFunction.Natives.RequestIpl("prologue02");
				NativeFunction.Natives.RequestIpl("prologue03");
				NativeFunction.Natives.RequestIpl("prologue03_grv_fun");
				NativeFunction.Natives.RequestIpl("prologue04");
				NativeFunction.Natives.RequestIpl("prologue04b");
				NativeFunction.Natives.RequestIpl("prologue05");
				NativeFunction.Natives.RequestIpl("prologue05b");
				NativeFunction.Natives.RequestIpl("prologue06");
				NativeFunction.Natives.RequestIpl("prologue06b");
				NativeFunction.Natives.RequestIpl("prologuerd");
				NativeFunction.Natives.RequestIpl("prologuerdb");
				NativeFunction.Natives.RequestIpl("prologue_DistantLights");
				NativeFunction.Natives.RequestIpl("prologue_LODLights");
				NativeFunction.Natives.RequestIpl("prologue_m2_door");
			}
			else
			{
				NativeFunction.Natives.RemoveIpl("prologue01");
				NativeFunction.Natives.RemoveIpl("prologue01c");
				NativeFunction.Natives.RemoveIpl("prologue01d");
				NativeFunction.Natives.RemoveIpl("prologue01e");
				NativeFunction.Natives.RemoveIpl("prologue01f");
				NativeFunction.Natives.RemoveIpl("prologue01g");
				NativeFunction.Natives.RemoveIpl("prologue01h");
				NativeFunction.Natives.RemoveIpl("prologue01i");
				NativeFunction.Natives.RemoveIpl("prologue01j");
				NativeFunction.Natives.RemoveIpl("prologue01k");
				NativeFunction.Natives.RemoveIpl("prologue01z");
				NativeFunction.Natives.RemoveIpl("prologue02");
				NativeFunction.Natives.RemoveIpl("prologue03");
				NativeFunction.Natives.RemoveIpl("prologue03_grv_fun");
				NativeFunction.Natives.RemoveIpl("prologue04");
				NativeFunction.Natives.RemoveIpl("prologue04b");
				NativeFunction.Natives.RemoveIpl("prologue05");
				NativeFunction.Natives.RemoveIpl("prologue05b");
				NativeFunction.Natives.RemoveIpl("prologue06");
				NativeFunction.Natives.RemoveIpl("prologue06b");
				NativeFunction.Natives.RemoveIpl("prologuerd");
				NativeFunction.Natives.RemoveIpl("prologuerdb");
				NativeFunction.Natives.RemoveIpl("prologue_DistantLights");
				NativeFunction.Natives.RemoveIpl("prologue_LODLights");
				NativeFunction.Natives.RemoveIpl("prologue_m2_door");
				NativeFunction.Natives.RemoveIpl("DES_ProTree_start");
				NativeFunction.Natives.RemoveIpl("DES_ProTree_start_lod");
			}

			NativeFunction.Natives.xAF12610C644A35C9("prologue", enabled); //Audio
			NativeFunction.Natives.xAF12610C644A35C9("Prologue_Main", enabled); //Audio
			NativeFunction.Natives.SetFrontendRadioActive(!enabled);
			NativeFunction.Natives.SetUserRadioControlEnabled(!enabled);
			NativeFunction.Natives.SetAmbientZoneListState("ZONE_LIST_YANKTON", enabled, false);
			Game.LocalPlayer.WantedLevel = 0;
			NativeFunction.Natives.SetMaxWantedLevel(enabled ? 0 : 5);
			NativeFunction.Natives.SetWantedLevelMultiplier(enabled ? 0f : 1f);
			NativeFunction.Natives.SetDispatchCopsForPlayer(Game.LocalPlayer, !enabled);
			NativeFunction.Natives.SetCreateRandomCops(!enabled);
			NativeFunction.Natives.EnableDispatchService(1, !enabled);
			NativeFunction.Natives.EnableDispatchService(2, !enabled);
			NativeFunction.Natives.EnableDispatchService(3, !enabled);
			NativeFunction.Natives.EnableDispatchService(4, !enabled);
			NativeFunction.Natives.EnableDispatchService(5, !enabled);
			NativeFunction.Natives.SetRandomTrains(!enabled);
			NativeFunction.Natives.DeleteAllTrains();
			NativeFunction.Natives.x228E5C6AD4D74BFD(enabled); //Pathfind

			NativeFunction.Natives.SetRoadsInAngledArea(5526.24f, -5137.23f, 61.78925f, 3679.327f, -4973.879f, 125.0828f, 192f, false, enabled, true);
			NativeFunction.Natives.SetRoadsInAngledArea(3691.211f, -4941.24f, 94.59368f, 3511.115f, -4869.191f, 126.7621f, 16f, false, enabled, true);
			NativeFunction.Natives.SetRoadsInAngledArea(3510.004f, -4865.81f, 94.69557f, 3204.424f, -4833.817f, 126.8152f, 16f, false, enabled, true);
			NativeFunction.Natives.SetRoadsInAngledArea(3186.534f, -4832.798f, 109.8148f, 3202.187f, -4833.993f, 114.815f, 16f, false, enabled, true);

			if(enabled)
			{
				NativeFunction.Natives.SetWeatherTypeNowPersist("SNOW");
				NativeFunction.Natives.xFC4842A34657BFCB("RAIN", 0.0f); //GAMEPLAY::_SET_CLOUD_HAT_TRANSITION
			}
			else
			{
				NativeFunction.Natives.ClearWeatherTypePersist();
				NativeFunction.Natives.x957E790EA1727B64(); //GAMEPLAY::_CLEAR_CLOUD_HAT
				NativeFunction.Natives.SetWeatherTypeNow("EXTRASUNNY");
			}

			NativeFunction.Natives.x9133955F1A2DA957(enabled); //UI::_SET_NORTH_YANKTON_MAP
			int zoneId = NativeFunction.Natives.GetZoneFromNameId<int>("PrLog");
			NativeFunction.Natives.SetZoneEnabled(zoneId, enabled);
		}
	}
}
