namespace SpaceShip.Models.SpaceCraftSystems.Power.Entity
{
    public class SmallBattery : BatteryBase
    {
        public SmallBattery(uint v) : base(v)
        {
            MaxV = 500;
        }
    }
}