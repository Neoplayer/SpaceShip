using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems.LifeSupport
{
    public class ClimateControlBase : IModule
    {
        public int Id { get; set; }

        public string GetModuleInfo()
        {
            return "";
        }
    }
}
