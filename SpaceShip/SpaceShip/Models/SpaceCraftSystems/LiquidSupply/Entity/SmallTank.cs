namespace SpaceShip.Models.SpaceCraftSystems.LiquidSupply.Entity
{
    public class SmallTank : TankBase<LiquidType>
    {
        public SmallTank(LiquidType type, uint volume) : base(type, volume)
        {
            MaxVolume = 1000;
        }
    }
}