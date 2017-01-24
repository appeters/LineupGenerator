using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softball.Team;

namespace Softball.Positions
{
    public class Position
    {
        public Position(Player player)
        {
            Name = player.Name;
        }

        public string Name { get; }
    }
}
