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
        private List<Human> Personal = new List<Human>();
        private List<Сabin> Cabins = new List<Сabin>();
        private List<O2Gen> O2Gens = new List<O2Gen>();
        private List<ClimateControl> ClimateControls = new List<ClimateControl>();
        private List<RocketEngine> RocketEngines = new List<RocketEngine>();
        private List<WarpCore> WarpCores = new List<WarpCore>();
        private LiquidSypplySystem LiquidSypplySystem = new LiquidSypplySystem();

        public Task Idle(int Ticks)
        {

        }

        public Task Move(int Ticks)
        {
            
        }

        public Task WarpJump(int Power)
        {
            
        }

        private void Tick()
        {
            ReactorsGenTick();
        }

        private void ReactorsGenTick()
        {

            foreach(var reactor in Reactors)
            {
                if (LiquidSypplySystem.PipeLiquidFromTanks(LiquidType.Oil, reactor.OilRec))
                {
                    var battary = Battaries.
                }
            }
        }
    }
}
