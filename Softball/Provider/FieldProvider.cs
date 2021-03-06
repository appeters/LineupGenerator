﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softball.Positions;
using Softball.Team;

namespace Softball.Provider
{

    public class FieldProvider
    {

        public List<Position> Positions = new List<Position>();
        public List<Player> Bench = new List<Player>();

        public FieldProvider()
        {
            foreach (FieldPosition positionName in Enum.GetValues(typeof(FieldPosition)))
            {
                Positions.Add(new Position(positionName));
            }
        }

        public Position GetPosition(FieldPosition position)
        {
           return Positions.Find(x => x.FieldPosition == position);
        }


    }


}
