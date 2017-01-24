using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Softball.Positions;

namespace Softball.Team
{
    public class Player
    {
        public List<PositionRank> PositionRanks = new List<PositionRank>();
        public int sitOrCaughtCount = 0;
        public Player()
        {
            foreach (FieldPosition positionName in Enum.GetValues(typeof(FieldPosition)))
            {
                PositionRanks.Add(new PositionRank(new Position(positionName)));
            }
        }

        public string Name { get; set; }
        public int Pitcher {
            get
            {
                return getPosition(FieldPosition.Pitcher).Rank;
            }
            set
            {
                getPosition(FieldPosition.Pitcher).Rank = value;
            }
        }
        public int Catcher
        {
            get
            {
                return getPosition(FieldPosition.Catcher).Rank;
            }
            set
            {
                getPosition(FieldPosition.Catcher).Rank = value;
            }
        }
        public int FirstBase
        {
            get
            {
                return getPosition(FieldPosition.FirstBase).Rank;
            }
            set
            {
                getPosition(FieldPosition.FirstBase).Rank = value;
            }
        }
        public int SecondBase
        {
            get
            {
                return getPosition(FieldPosition.SecondBase).Rank;
            }
            set
            {
                getPosition(FieldPosition.SecondBase).Rank = value;
            }
        }
        public int ThirdBase
        {
            get
            {
                return getPosition(FieldPosition.ThirdBase).Rank;
            }
            set
            {
                getPosition(FieldPosition.ThirdBase).Rank = value;
            }
        }
        public int ShortStop
        {
            get
            {
                return getPosition(FieldPosition.ShortStop).Rank;
            }
            set
            {
                getPosition(FieldPosition.ShortStop).Rank = value;
            }
        }
        public int RightField
        {
            get
            {
                return getPosition(FieldPosition.RightField).Rank;
            }
            set
            {
                getPosition(FieldPosition.RightField).Rank = value;
            }
        }
        public int RightCenterField
        {
            get
            {
                return getPosition(FieldPosition.RightCenterField).Rank;
            }
            set
            {
                getPosition(FieldPosition.RightCenterField).Rank = value;
            }
        }
        public int LeftCenterField
        {
            get
            {
                return getPosition(FieldPosition.LeftCenterField).Rank;
            }
            set
            {
                getPosition(FieldPosition.LeftCenterField).Rank = value;
            }
        }
        public int LeftField
        {
            get
            {
                return getPosition(FieldPosition.LeftField).Rank;
            }
            set
            {
                getPosition(FieldPosition.LeftField).Rank = value;
            }
        }

        private PositionRank getPosition(FieldPosition position)
        {
            return PositionRanks.Find(x => x.Position.FieldPosition == position);
        }

    }
}
