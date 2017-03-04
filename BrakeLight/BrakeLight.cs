using Rage;
using Rage.Native;
using Rage.Attributes;

[assembly: Plugin("BrakeLight", Description = "Brake light", Author = "gp")]
namespace BrakeLight
{
    public static class BrakeLight
    {
        private static readonly float StoppedSpeed = 0.0025f;

        private static void Main()
        {
            while (true)
            {
                Vehicle vehicle = Game.LocalPlayer.Character.CurrentVehicle;

                if (vehicle.Exists())
                {
                    if (vehicle.Speed <= StoppedSpeed)
                    {
                        bool engineOn = vehicle.IsEngineOn || vehicle.IsEngineStarting;
                        bool vehicleStationary = vehicle.AccelerationScale == 0f;
                        NativeFunction.CallByName<uint>("SET_VEHICLE_BRAKE_LIGHTS", vehicle, engineOn && vehicleStationary);
                    }
                }

                GameFiber.Yield();
            }
        }
    }
}
