using System;
using System.Collections.Generic;

namespace CthulhuRealms
{
    class Player : ITarget
    {
        public string Name { get;}
        public int HP { get; }
        public List<Card> Hand { get; }
        public List<Location> Locations { get; }
        public Deck Deck { get; }
        public List<Card> Drop { get; }

        public void TakeDamage(int count)
        {
            throw new NotImplementedException();
        }
    }
}
