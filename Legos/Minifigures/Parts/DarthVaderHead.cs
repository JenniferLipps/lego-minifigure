using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class DarthVaderHead : Head
    {
        public override void Think()
        {
            Console.WriteLine("Am I your father?");
        }

        public override void Talk()
        {
            Console.WriteLine("KHOOOH PUUUHRRR");
            base.Talk();
            Console.WriteLine("KHOOOH PUUUHRRR");
        }
    }
}
