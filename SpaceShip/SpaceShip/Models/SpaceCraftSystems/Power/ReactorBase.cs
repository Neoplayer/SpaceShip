using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems.Power
{
    public class ReactorBase : IModule
    {
        public int Id { get; set; }
        public uint PowerOut { get; set; }
        public uint OilRec { get; set; }

        public string GetModuleInfo()
        {
            return $"Power Out: {PowerOut}\nOil Rec: {OilRec}";
        }
    }
}
