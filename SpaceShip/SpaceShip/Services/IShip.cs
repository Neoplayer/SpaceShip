using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip.Services
{
    interface IShip
    {
        Task Move(int Ticks);
        Task Idle(int Ticks);
        Task WarpJump(int Power);
    }
}
