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

            var positionCount = field.Positions.Count;
            for(int i =0; i < positionCount; i++)
            {
                field.Positions[i].SetPlayer(players[(i +start) % players.Count]);
            }
            


        }

        public void PrintInningHeader()
        {
            foreach (var position in field.Positions)
            {
                Console.Write(string.Format("|  {0}   |", position.FieldPosition));

            }
            Console.WriteLine();
        }


        public void PrintInning()
        {
            foreach (var position in field.Positions)
            {
                Console.Write(string.Format("|  {0}   |", position.PlayerName()));

            }
            Console.WriteLine();
        }


    }
}
