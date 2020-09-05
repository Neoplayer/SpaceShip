using SpaceShip.Models.SpaceCraftSystems.LiquidSupply;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems
{
    public class ShipStatusInfo
    {
        public (uint current, uint max) EnergyInfo { get; set; }
        public Dictionary<LiquidType, (uint current, uint max)> LiquidInfo { get; set; }

    }
}
