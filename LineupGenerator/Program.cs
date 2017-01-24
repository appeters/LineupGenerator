using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineupGenerator.DataProviders;
using Softball.Game;
using Softball.Provider;

namespace LineupGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelDataReader a = new ExcelDataReader(@".\Data\DummyData.xlsx");

            Game b = new Game(a.GetPlayers());
            

        }
    }
}
