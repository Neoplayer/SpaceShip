using System;
using System.Collections.Generic;
using System.Text;
using SpaceShip.Models.SpaceCraftSystems.LiquidSupply;

namespace SpaceShip.Models.SpaceCraftSystems
{
    public class TankBase<T> : IModule
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public T Type { get; set; }
        public uint MaxVolume { get; set; }

        public uint CurrentVolume { get; set; }

        public TankBase(T type, uint volume)
        {
            Type = type;
            CurrentVolume = volume;
        }
        
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

        public string GetModuleInfo()
        {
            return $"Type: {Type.ToString()}\nCurrentVolume: {CurrentVolume}\nMaxVolume: {MaxVolume}";
        }
    }
}
