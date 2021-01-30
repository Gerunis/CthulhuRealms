using System;
using System.Collections.Generic;
using System.Text;

namespace CthulhuRealms
{
    class Location : ITarget
    {
        public Card Card { get; }
        public int HP { get; private set; }

        public Location(Card card)
        {
            Card = card;
            HP = card.LocationHP;
        }

        public void UpdateHP()
        {
            HP = Card.LocationHP;
        }

        public void TakeDamage(int count)
        {
            HP -= count;
        }
    }
}
