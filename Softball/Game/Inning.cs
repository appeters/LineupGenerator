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

            var sortedPlayers = players.OrderBy(x => x.sitOrCaughtCount).ToList();

            foreach (var player in sortedPlayers)
            {
                var sortedPositions = player.PositionRanks.Where(x => x.Rank != 0).OrderBy(x => x.Rank);
                foreach (var position in sortedPositions)
                {
                    if (field.Positions.Find(x => x.FieldPosition == position.Position.FieldPosition).PlayerName() ==
                        null)
                    {
                        field.Positions.Find(x => x.FieldPosition == position.Position.FieldPosition).SetPlayer(player);
                        break;
                    }
                    field.Bench.Add(player);
                }

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
