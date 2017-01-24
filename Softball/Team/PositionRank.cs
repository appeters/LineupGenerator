using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softball.Positions;

namespace Softball.Team
{
    public class PositionRank
    {
        public Position Position { get; set; }
        public int Rank { get; set; }

        public PositionRank(Position position)
        {
            this.Position = position;
        }
    }
}
