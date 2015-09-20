using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostCardGameCore
{
    public class DiscardCard
    {
        public object Card;
        public CardType CardType;

        public DiscardCard(object card, CardType cardType)
        {
            Card = card;
            CardType = cardType;
        }

        public override string ToString()
        {
            return CardType == CardType.CHARACTER ? ((CharacterCard)Card).ToString() : ((EventCard)Card).ToString();
        }
    }

    public class DiscardPile
    {
        public List<DiscardCard> Pile = new List<DiscardCard>();

        public void DiscardCard(object card, CardType cardType)
        {
           var newCard = new DiscardCard(card, cardType);
           Pile.Add(newCard);
        }

        public DiscardCard GetCard()
        {
            if (Pile.Count > 0)
            {
                var card = Pile[Pile.Count - 1];
                Pile.Remove(card);
                return card;
            }
            return null;
        }
    }
}
