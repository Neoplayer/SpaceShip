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
    public class SimpleSpaceShip : ShipBase
    {
        //private static SimpleSpaceShip _ship;

        // #region Singleton
        //
        // public static SimpleSpaceShip Instance()
        // {
        //     if (_ship != null) return _ship;
        //     
        //     _ship = new SimpleSpaceShip();
        //     return _ship;
        // }
        //    
        // #endregion
        
        
        public SimpleSpaceShip()
        {
            PowerSupplySystem = new PowerSupplySystem()
            {
                Reactors = new List<ReactorBase> { new SmallReactor()},
                Batteries = new List<BatteryBase> { new SmallBattery(250), new SmallBattery(250)}
            };
            LiquidSupplySystem = new LiquidSupplySystem
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
