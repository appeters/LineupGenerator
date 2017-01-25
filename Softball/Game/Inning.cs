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

            players = players.OrderByDescending(x => x.sitOrCaughtCount).ToList();

            foreach (var player in players)
            {
                var sortedPositions = player.PositionRanks.Where(x => x.Rank != 0).OrderBy(x => x.Rank);
                bool playerPlaced = false;
                foreach (var position in sortedPositions)
                {
                    if (field.Positions.Find(x => x.FieldPosition == position.Position.FieldPosition).PlayerName() ==
                        null)
                    {
                        field.Positions.Find(x => x.FieldPosition == position.Position.FieldPosition).SetPlayer(player);
                        playerPlaced = true;
                        break;
                    }
                    
                }
                if (!playerPlaced)
                {
                    if (field.Positions.Find(x => x.FieldPosition == FieldPosition.Catcher).PlayerName() ==
                        null)
                    {
                        field.Positions.Find(x => x.FieldPosition == FieldPosition.Catcher).SetPlayer(player);
                    }
                    else
                    {
                        field.Bench.Add(player);
                    }
                    player.sitOrCaughtCount++;
                }
            }

          


        }

        public void PrintInningHeader()
        {
            foreach (var position in field.Positions)
            {
                Console.Write(string.Format("|{0}|", position.FieldPosition));

            }
            Console.WriteLine();
        }


        public void PrintInning()
        {
            foreach (var position in field.Positions)
            {
                int length = position.FieldPosition.ToString().Length;
                int buffer = length - position.PlayerName().Length;
                string a = new string(' ', buffer);
                Console.Write(string.Format("|{0}{1}|", position.PlayerName(), a));
            }
            Console.WriteLine();
        }


    }
}
