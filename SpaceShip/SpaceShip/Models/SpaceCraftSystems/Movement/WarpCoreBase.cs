using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems.Movement
{
    public class WarpCoreBase : IModule
    {
        public int Id { get; set; }

        public string GetModuleInfo()
        {
            return $"";
        }
    }
}
