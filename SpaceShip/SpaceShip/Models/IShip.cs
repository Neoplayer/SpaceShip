using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip.Models
{
    interface IShip
    {
        void Move(int Ticks);
        void Idle(int Ticks);
        void WarpJump(int Power);
    }
}
