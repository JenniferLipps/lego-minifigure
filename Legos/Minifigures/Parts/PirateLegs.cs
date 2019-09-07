using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class PirateLegs : Legs
    {
        public PirateLegs()
        {
            NumberOfLegs = 1;
            PantLength = PantLength.Capris;
            VerticalLeap = 2;
        }

    }

    class ZombieLegs : Legs
    {
        public ZombieLegs()
        {
            NumberOfLegs = 0;
            PantLength = PantLength.None;
            BareFoot = true;
            VerticalLeap = 0;
        }
    }

    class CentaurLegs : Legs
    {
        public CentaurLegs()
        {
            NumberOfLegs = 4;
            PantLength = PantLength.None;
            BareFoot = true;
            VerticalLeap = 100;
        }
    }
}
