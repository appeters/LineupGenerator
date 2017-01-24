﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softball.Team;

namespace Softball.Positions
{
    public class Position
    {
        public Position(FieldPosition position)
        {
            FieldPosition = position;
        }


        public void SetPlayer(Player player)
        {
            _player = player;
        }

        public string PlayerName()
        {
            return _player.Name ?? null;
        }


        public FieldPosition FieldPosition;
        private Player _player=null;
    }
}
