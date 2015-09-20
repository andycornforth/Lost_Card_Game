using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostCardGameCore
{
    public class Hand
    {
        private IList<CharacterCard> _characterCards;
        private IList<EventCard> _pivotalEventCards;
        private List<EventCard> _standardEventCards;
  
        public Hand()
        {
            _characterCards = new List<CharacterCard>();
            _pivotalEventCards = new List<EventCard>();
            _standardEventCards = new List<EventCard>();
        }

        public IList<CharacterCard> GetCharacterCards()
        {
            return _characterCards;
        }

        public IList<EventCard> GetPivotalEventCards()
        {
            return _pivotalEventCards;
        }

        public EventCard[] GetStandardEventCards()
        {
            return _standardEventCards.ToArray<EventCard>();
        }

        public bool AddCharacterCard(CharacterCard card)
        {
            var numberOfCardsInHand = _characterCards.Count();
            if (numberOfCardsInHand < 6)
            {
                _characterCards.Add(card);
                return true;
            }
            return false;
        }

        public void AddCharacterCard(CharacterCard cardToAdd, CharacterCard cardToRemove)
        {
            for (int i = 0; i < 6; i++)
            {
                if (_characterCards[i].Name.Equals(cardToRemove.Name))
                {
                    _characterCards.RemoveAt(i);
                    _characterCards.Add(cardToAdd);
                }
            }
        }

        public bool AddPivotalEventCard(EventCard card)
        {
            var numberOfCardsInHand = _pivotalEventCards.Count();
            if (numberOfCardsInHand < 6)
            {
                _pivotalEventCards.Add(card);
                return true;
            }
            return false;
        }

        public void AddPivotalEventCard(EventCard cardToAdd, EventCard cardToRemove)
        {
            for (int i = 0; i < 6; i++)
            {
                if (_pivotalEventCards[i].Name.Equals(cardToRemove.Name))
                {
                    _pivotalEventCards.RemoveAt(i);
                    _pivotalEventCards.Add(cardToAdd);
                }
            }
        }

        public bool AddStandardEventCard(EventCard card)
        {
            _standardEventCards.Add(card);
            return true;
        }
    }
}
