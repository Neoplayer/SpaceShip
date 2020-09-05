using SpaceShip.Models.SpaceCraftSystems.LiquidSupply;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems.Movement
{
    class RocketEngineBase
    {
        public int Id { get; set; }

        public LiquidType FuelType { get; set; }
        public uint ThrustPower { get; set; }
        public uint HToThrust { get; set; }
        public uint VToThrust { get; set; }
    }
}
