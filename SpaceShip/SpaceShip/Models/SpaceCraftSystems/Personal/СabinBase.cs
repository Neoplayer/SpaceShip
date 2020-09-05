using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems.Personal
{
    public class СabinBase : IModule
    {
        public int Id { get; set; }

        public string GetModuleInfo()
        {
            return "";
        }
    }
}
