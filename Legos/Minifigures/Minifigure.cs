using Legos.Minifigures.Parts;

namespace Legos.Minifigures
{
    class Minifigure
    {
        readonly ITalker _head; /*Using this instad of Head, this can be any class as long as it has Talk functionality*/
        readonly Torso _torso;
        readonly Legs _legs;

        public Minifigure(ITalker head, Torso torso, Legs legs)
        {
            _head = head;
            _torso = torso;
            _legs = legs;
        }

        public void Battle()
        {
            _legs.Walk();
            _head.Talk();
            _torso.Flex();
            _torso.Fight();
            _legs.Kick();
        }

    }
}
