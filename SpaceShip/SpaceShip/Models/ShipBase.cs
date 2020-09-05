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
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace SpaceShip.Models
{
    public class ShipBase : IShip
    {
        #region State

        public uint X { get; set; }

        #endregion

        #region Systems

        public PowerSupplySystem PowerSupplySystem { get; set; } // TODO incapsulate
        public LiquidSupplySystem LiquidSupplySystem { get; set; } // TODO incapsulate

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
                if(PowerSupplySystem.CheckBatteries(engine.VToThrust) && LiquidSupplySystem.CheckTanks(engine.FuelType, engine.HToThrust))
                {
                    if(PowerSupplySystem.UnchargeBatteries(engine.ThrustPower) && LiquidSupplySystem.PipeLuquidFromTanks(engine.FuelType, engine.HToThrust))
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
                if (LiquidSupplySystem.PipeLuquidFromTanks(LiquidType.Oil, reactor.OilRec))
                {
                    PowerSupplySystem.ChargeBatteries(reactor.PowerOut);
                }
            }
        }
    }
}
