using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems.Power
{
    class ReactorBase
    {
        public int Id { get; set; }
        public uint PowerOut { get; set; }
        public uint OilRec { get; set; }
    }
}
