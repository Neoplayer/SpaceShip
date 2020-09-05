using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShip.Models.SpaceCraftSystems.Power.Entity
{
    class SmallReactor : ReactorBase
    {
        public SmallReactor()
        {
            OilRec = 10;
            PowerOut = 10;
        }
    }
}
