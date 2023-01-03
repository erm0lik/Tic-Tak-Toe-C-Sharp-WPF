using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Game1
{
    internal class DefoltGame : Games
    {
        public override double rating { get; } = new Random().NextDouble();
    }
}
