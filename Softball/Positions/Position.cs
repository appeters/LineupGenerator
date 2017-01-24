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
            if (_player == null)
            {
                return null;
            }
            return _player.Name;
        }


        public FieldPosition FieldPosition;
        private Player _player=null;
    }
}
