using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softball.Positions;

namespace Softball.Provider
{

    public class FieldProvider
    {

        public Dictionary<FieldPosition, Position> Positions = new Dictionary<FieldPosition, Position>();
        public List<Position> Bench = new List<Position>();

        public FieldProvider()
        {
            foreach (FieldPosition positionName in Enum.GetValues(typeof(FieldPosition)))
            {
                Console.WriteLine(positionName);
                Positions.Add(positionName, new Position(positionName));
            }
        }
       

        
    }


}
