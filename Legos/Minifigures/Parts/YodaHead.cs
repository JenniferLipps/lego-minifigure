using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class YodaHead : Head, ITalker
    {
        /*public bool HasEars => true;*/
        public bool HasEars { get; private set; }
        public YodaHead()
        {
            Size = HeadSize.Small;
            HasEars = true;
        }

       /* public override void Talk()
        {
            Console.WriteLine("Talking head I am.");
        }*/

        public void Shout(int numberOfDecibels)
        {

        }

        public void Battle()
        {
            HasEars = false;
        }

        
        public override void Think()
        {
            Console.WriteLine("I'm talking Yoda.");
        }
    }
}
