using System;
using System.Collections.Generic;
using System.Text;
using SpaceShip.Models;
using SpaceShip.Models.SpaceCraftSystems;
using SpaceShip.Models.SpaceCraftSystems.LiquidSupply;
using SpaceShip.Models.SpaceCraftSystems.LiquidSupply.Entity;
using SpaceShip.Models.SpaceCraftSystems.Movement;
using SpaceShip.Models.SpaceCraftSystems.Movement.Entity;
using SpaceShip.Models.SpaceCraftSystems.Power;
using SpaceShip.Models.SpaceCraftSystems.Power.Entity;

namespace SpaceShip.Services
{
    class SimpleSpaceShip : ShipBase
    {
        public SimpleSpaceShip()
        {
            PowerSupplySystem = new PowerSupplySystem()
            {
                Reactors = new List<ReactorBase> { new SmallReactor()},
                Batteries = new List<BatteryBase> { new SmallBattery(250), new SmallBattery(250)}
            };
            LiquidSypplySystem = new LiquidSypplySystem
            {
                Tanks = new List<TankBase<LiquidType>>
                {
                    new SmallTank(LiquidType.Hydrogenium,500), 
                    new SmallTank(LiquidType.Oil, 500)
                }
            };
            
            RocketEngines = new List<RocketEngineBase> { new SmallRocketEngine(), new SmallRocketEngine()};
        }
    }
}
