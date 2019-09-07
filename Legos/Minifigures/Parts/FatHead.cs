using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class FatHead : Head
    {
        public FatHead()
        {
            Size = HeadSize.Fat;
        }

        public override void Talk()
        {
            Console.WriteLine("I'm a fat talking head.");
        }

        public override void Think()
        {
            Console.WriteLine("I wish I was smarter,");
        }
    }
}
