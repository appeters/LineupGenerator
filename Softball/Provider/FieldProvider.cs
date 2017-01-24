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
        public Position Pitcher;
        public Position Catcher;
        public Position FirstBase;
        public Position SecondBase;
        public Position ThirdBase;
        public Position ShortStop;
        public Position RightField;
        public Position RightCenterField;
        public Position LeftCenterField;
        public Position LeftField;

        public List<Position> Bench = new List<Position>();
    }
}
