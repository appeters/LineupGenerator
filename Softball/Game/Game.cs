using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softball.Team;

namespace Softball.Game
{
    public class Game
    {
        List<Inning> innings = new List<Inning>(); 
        public Game(List<Player> players)
        {
            for (int i = 0; i < 14; i++)
            {
                innings.Add(new Inning(players));
               // innings[i].PrintInning();
            }

            innings[0].PrintInningHeader();
            foreach (var inning in innings)
            {
                inning.PrintInning();
            }

        }

    }
}
