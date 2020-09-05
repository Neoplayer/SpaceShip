using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems.Power
{
    class PowerSupplySystem
    {
        public List<ReactorBase> Reactors = new List<ReactorBase>();
        public List<BatteryBase> Batteries = new List<BatteryBase>();


        public bool CheckBatteries(uint V)
        {
            var onBoard = Batteries.Sum(x => x.CurrentV);

            return onBoard >= V;
        }

        public bool UnchargeBatteries(uint V)
        {
            if (!CheckBatteries(V))
                return false;

            var requiredQuantity = V;

            foreach (var battery in Batteries)
            {
                if (requiredQuantity == 0)
                    break;

                var inBattery = battery.CurrentV;

                if (inBattery >= requiredQuantity)
                {
                    battery.Uncharge(requiredQuantity);
                }
                else
                {
                    battery.Uncharge(inBattery);
                    requiredQuantity -= inBattery;
                }
            }

            return requiredQuantity == 0;
        }
        public bool ChargeBatteries(uint V)
        {
            var VToCharge = V;

            while(VToCharge != 0 && UnchargedBarreriesOnBoard())
            {
                foreach (var battery in Batteries)
                {
                    if (VToCharge == 0)
                        break;

                    var inBattery = battery.CurrentV;
                    var canCharge = battery.MaxV - inBattery;

                    if (canCharge >= VToCharge)
                    {
                        battery.Charge(VToCharge);
                        VToCharge = 0;
                    }
                    else
                    {
                        battery.Charge(canCharge);
                        VToCharge -= canCharge;
                    }
                }
            }

            return false; // TODO implement
        }

        private bool UnchargedBarreriesOnBoard()
        {
            return Batteries.Exists(x => x.CurrentV < x.MaxV);
        }

    }
}
