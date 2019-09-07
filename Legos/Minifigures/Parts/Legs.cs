using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class Legs
    {
        public int NumberOfLegs { get; set; }
        public PantLength PantLength { get; set; }
        public bool BareFoot { get; set; }
        public int VerticalLeap { get; set; }

        public virtual void Kick()
        {
            UseLegs("kick");
        }

        public void Dance()
        {
            UseLegs("dance");
        }

        public void Walk()
        {
            UseLegs("walk");
        }

        private void UseLegs(string activity)
        {
            var shoesOrBarefoot = BareFoot ? "without shoes" : "with shoes";

            if (NumberOfLegs <= 0)
            {
                Console.WriteLine($"No legs, can't {activity}");
                return;
            }
            
            Console.WriteLine($"The {NumberOfLegs} legs {activity} {shoesOrBarefoot} while wearing {PantLength}.");
        }
    }

    enum PantLength
    {
        Shorts,
        Pants,
        Capris,
        None,
    }
}
