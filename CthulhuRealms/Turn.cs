using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CthulhuRealms
{
    class Turn
    {
        Player player;
        public int Strength { get; }
        public Dictionary<CardColor, List<Card>> PlayedColors { get; }
        public Dictionary<CardType, List<Card>> PlayedTypes { get; }
        public bool Drop { get; }
        public bool Discard { get; }
        List<Card> CardsInPlay { get; }
        List<ITarget> Targets { get; }

        public Turn(Player player, List<Player> players)
        {
            this.player = player;
            CardsInPlay = new List<Card>();
            Targets = new List<ITarget>();

            foreach (var p in players)
            {
                Targets.Add(p);
            }

            PlayedColors = new Dictionary<CardColor, List<Card>>();
            foreach(var color in Enum.GetValues(typeof(CardColor)).Cast<CardColor>())
            {
                PlayedColors[color] = new List<Card>();
            }

            PlayedTypes = new Dictionary<CardType, List<Card>>();
            foreach (var type in Enum.GetValues(typeof(CardType)).Cast<CardType>())
            {
                PlayedTypes[type] = new List<Card>();
            }

            foreach(var location in player.Locations)
            {
                PlayCard(location.Card);
                Targets.Add(location);
            }
        }

        public void PlayCard(Card card)
        {
            CardsInPlay.Add(card);
            PlayedTypes[card.CardType].Add(card);
            PlayedColors[card.CardColor].Add(card);
        }
    }
}
