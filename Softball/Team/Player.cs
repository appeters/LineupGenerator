using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softball.Team
{
    public class Player
    {
        public string Name { get; set; }
        public int Pitcher { get; set; }
        public int Catcher { get; set; }
        public int FirstBase { get; set; }
        public int SecondBase { get; set; }
        public int ThirdBase { get; set; }
        public int ShortStop { get; set; }
        public int RightField { get; set; }
        public int RightCenterField { get; set; }
        public int LeftCenterField { get; set; }
        public int LeftField { get; set; }
    }
}
