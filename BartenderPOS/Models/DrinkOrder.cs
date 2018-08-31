using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderPOS.Models
{
    public class DrinkOrder
    {
        public int Honduran { get; set; }
        public int Rum { get; set;  }
        public int LocalBrew { get; set; }
        public int Doublepint { get; set; }
        public int PitcherPour { get; set; }
    }
}
