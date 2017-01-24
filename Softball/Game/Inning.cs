using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softball.Positions;
using Softball.Provider;
using Softball.Team;

namespace Softball.Game
{
    public class Inning
    {
        private FieldProvider field = new FieldProvider();

        public Inning(List<Player> players)
        {
            Random a = new Random();
            int start = a.Next(players.Count);

            field.Pitcher = new Position(players[0 + start % players.Count]);


        }


        public void PrintInning()
        {
            Console.WriteLine("Pitcher: " + field.Pitcher.Name);
        }


    }
}
