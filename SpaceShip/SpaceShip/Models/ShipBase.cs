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

namespace SpaceShip.Models
{
    class ShipBase : IShip
    {
        #region State

        public uint X { get; set; }

        #endregion

        #region Systems

        protected PowerSupplySystem PowerSupplySystem;
        protected LiquidSypplySystem LiquidSypplySystem;

        protected List<HumanBase> Personal;
        protected List<СabinBase> Cabins;
        protected List<O2GenBase> O2Gens;
        protected List<ClimateControlBase> ClimateControls;
        protected List<RocketEngineBase> RocketEngines;
        protected List<WarpCoreBase> WarpCores;

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
