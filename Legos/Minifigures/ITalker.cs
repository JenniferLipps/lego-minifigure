using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures
{
    interface ITalker
    {
        void Talk();
        /*void Shout(int numberOfDecibels);*/
    }

    interface IShouter : ITalker
    {
        void Shout(int numberOfDecibels);
    }
}
