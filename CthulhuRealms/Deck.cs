using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CthulhuRealms
{
    class Deck
    {
        List<Card> cards;
        public Card TopCard { get => cards[cards.Count - 1]; }
        public int Size { get => cards.Count; }

        public Deck(List<Card> cards)
        {
            this.cards = cards;
            Shuffle();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public Card GetCard()
        {
            if (cards.Count == 0) return null;
            var card = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return card;
        }

        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                var value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
    }

    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(
                unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

}
