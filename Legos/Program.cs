using System;
using System.Collections.Generic;
using Legos.Minifigures;
using Legos.Minifigures.Parts;


namespace Legos
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new YodaHead
            {
                EyeColor = "Brown",
                HairColor = "Blue",
                HasNose = false,
                MouthIsOpen = true,
                NumberOfEyes = 3
            };

           /* var fatHead = new FatHead();

            fatHead.Talk();
          */

          /*  switch (minifigure.Head)
            {
                case YodaHead h:
                    h.Battle();
                    break;
            }*/

            var torso = new YetiTorso();
            /* torso.Fight();
             torso.Flex();*/

            var legs = new ZombieLegs();

            var drillsarge = new DrillSarge();
            var yodaYetiZombie = new Minifigure(drillsarge, torso, legs);
            yodaYetiZombie.Battle();

            var fatHead = new FatHead();
            var pirateTorso = new PirateTorso(HandType.Hook);
            var centaurLegs = new CentaurLegs();

            var fatHeadedCentaurPirate = new Minifigure(fatHead, pirateTorso, centaurLegs);
            fatHeadedCentaurPirate.Battle();

            var talkers = new List<ITalker>()
            {
                drillsarge,fatHead,head
            };

            foreach (var talker in talkers)
            {
                talker.Talk();
            }
            
        }
    }
}
