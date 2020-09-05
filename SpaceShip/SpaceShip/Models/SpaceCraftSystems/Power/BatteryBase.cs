using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems.Power
{
    public class BatteryBase
    {
        public int Id { get; set; }
        public uint MaxV { get; set; }

        public uint CurrentV { get; set; }

        public BatteryBase(uint v)
        {
            CurrentV = v;
        }
        
        public bool Uncharge(uint V)
        {
            if (CurrentV >= V)
            {
                CurrentV -= V;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Charge(uint V)
        {
            if (CurrentV + V <= MaxV)
            {
                CurrentV += V;
            }
            else
            {
                CurrentV = MaxV;
            }
        }
    }
}
