using System;
using System.Collections.Generic;
using System.Text;

namespace CthulhuRealms
{
    class Card
    {
        public string Name { get; }
        public int Cost { get; }
        public CardColor CardColor { get; }
        public CardType CardType { get; }
        public LocationType LocationType { get; }
        public int LocationHP { get; }
        public List<Attribute> Attributes { get; }

    }

    enum CardColor
    {
        Purple,
        Green,
        Yelow,
        Black
    }

    enum CardType
    {
        Location,
        Person,
        Artifact
    }

    enum LocationType
    {
        None,
        Simple,
        Vault,
        Gate
    }
}
