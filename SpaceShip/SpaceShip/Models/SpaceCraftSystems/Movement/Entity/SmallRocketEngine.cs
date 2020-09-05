using SpaceShip.Models.SpaceCraftSystems.LiquidSupply;

namespace SpaceShip.Models.SpaceCraftSystems.Movement.Entity
{
    public class SmallRocketEngine : RocketEngineBase
    {
        public SmallRocketEngine()
        {
            FuelType = LiquidType.Hydrogenium;
            ThrustPower = 1;
            HToThrust = 10;
            VToThrust = 5;
        }
    }
}