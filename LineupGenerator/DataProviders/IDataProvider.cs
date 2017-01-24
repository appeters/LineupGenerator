using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softball.Team;

namespace LineupGenerator.DataProviders
{
    interface IDataProvider
    {
        List<Player> GetPlayers();

    }
}
