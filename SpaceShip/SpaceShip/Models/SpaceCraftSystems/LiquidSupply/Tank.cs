using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems
{
    class Tank<T>
    {
        public int Id { get; set; }
        public T Type { get; set; }
        public uint MaxVolume { get; set; }

        public uint CurrentVolume { get; set; }
        public bool PipeLiquidOut(uint vol)
        {
            if(CurrentVolume >= vol)
            {
                CurrentVolume -= vol;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
