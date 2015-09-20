using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostCardGameCore
{
    public class Deck<T>
    {
        private List<T> _deck;
        private Random random = new Random();

        public Deck(List<T> deck)
        {
            _deck = deck;
        }

        public T TakeCard()
        {
            int randomNumber = GetRandomNumber();
            var card = _deck[randomNumber];
            _deck.RemoveAt(randomNumber);

            return card;
        }

        private int GetRandomNumber()
        {
            return random.Next(_deck.Count);
        }
    }
}
