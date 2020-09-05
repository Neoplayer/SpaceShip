using SpaceShip.Models.SpaceCraftSystems;
using SpaceShip.Models.SpaceCraftSystems.LifeSupport;
using SpaceShip.Models.SpaceCraftSystems.LiquidSupply;
using SpaceShip.Models.SpaceCraftSystems.Movement;
using SpaceShip.Models.SpaceCraftSystems.Personal;
using SpaceShip.Models.SpaceCraftSystems.Power;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip.Services
{
    class ShipBase : IShip
    {
        #region State

        public uint X { get; set; }

        #endregion

        #region Systems

        private PowerSupplySystem PowerSupplySystem = new PowerSupplySystem();
        private LiquidSypplySystem LiquidSypplySystem = new LiquidSypplySystem();

        private List<HumanBase> Personal = new List<HumanBase>();
        private List<СabinBase> Cabins = new List<СabinBase>();
        private List<O2GenBase> O2Gens = new List<O2GenBase>();
        private List<ClimateControlBase> ClimateControls = new List<ClimateControlBase>();
        private List<RocketEngineBase> RocketEngines = new List<RocketEngineBase>();
        private List<WarpCoreBase> WarpCores = new List<WarpCoreBase>();

        #endregion


        public void Idle(int Ticks)
        {
            for (int i = 0; i < Ticks; i++)
            {
                Tick();
            }
        }

        public void Move(int Ticks)
        {
            uint thrustPower = 0;

            foreach (var engine in RocketEngines)
            {
                if(PowerSupplySystem.CheckBatteries(engine.VToThrust) && LiquidSypplySystem.CheckTanks(engine.FuelType, engine.HToThrust))
                {
                    if(PowerSupplySystem.UnchargeBatteries(engine.ThrustPower) && LiquidSypplySystem.PipeLuquidFromTanks(engine.FuelType, engine.HToThrust))
                    {
                        thrustPower += engine.ThrustPower;
                    }
                }
            }

            X += thrustPower;
        }

        public void WarpJump(int Power)
        {
            // TODO implement
        }

        private void Tick()
        {
            ReactorsGenTick();
        }

        private void ReactorsGenTick()
        {
            foreach(var reactor in PowerSupplySystem.Reactors)
            {
                if (LiquidSypplySystem.PipeLuquidFromTanks(LiquidType.Oil, reactor.OilRec))
                {
                    var battary = PowerSupplySystem.ChargeBatteries(reactor.PowerOut);
                }
            }
        }
    }
}
