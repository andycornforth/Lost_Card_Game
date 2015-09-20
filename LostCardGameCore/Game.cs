using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostCardGameCore
{
    public class Game
    {
        private IList<Player> _players;
        private int _currentPlayerIndex = 0;
        private Deck<CharacterCard> _characterCardDeck;
        private Deck<EventCard> _eventCardDeck;
        private DiscardPile _discardPile;

        public Game(string characterCardFile, string eventCardFile)
        {
            _players = new List<Player>();
            Initialise(characterCardFile, eventCardFile);
        }

        public int AddPlayer(Player player)
        {
            _players.Add(player);
            return _players.Count - 1;
        }

        public IList<CharacterCard> GetPlayersCharacterCards(int playerId)
        {
            return _players[playerId].Hand.GetCharacterCards().ToList().Where(x => x != null).ToList();
        }

        public IList<EventCard> GetPlayersPivotalEventCards(int playerId)
        {
            return _players[playerId].Hand.GetPivotalEventCards().ToList().Where(x => x != null).ToList();
        }

        public IList<EventCard> GetPlayersStandardEventCards(int playerId)
        {
            return _players[playerId].Hand.GetStandardEventCards().ToList().Where(x => x != null).ToList();
        }

        public object TakeCardFromDeck(int playerId, CardType cardType)
        {
            if (!IsCurrentPlayer(playerId))
            {
                return null;
            }
            return GetCardFromDeck(cardType);
        }

        public DiscardCard TakeCardFromDiscardPile()
        {
            return _discardPile.GetCard();
        }

        public bool AddCardToHand(int playerId, CardType cardType, object card)
        {
            if (AddCardToPlayerHand(playerId, cardType, card))
            {
                ChangeCurrentPlayerIndex();
                return true;
            }
            return false;
        }

        public void AddCardToHand(int playerId, CardType cardType, object cardToAdd, object cardToRemove)
        {
            if (cardType == CardType.CHARACTER)
            {
                _players[playerId].Hand.AddCharacterCard((CharacterCard)cardToAdd, (CharacterCard)cardToRemove);
            }
            else
            {
                _players[playerId].Hand.AddPivotalEventCard((EventCard)cardToAdd, (EventCard)cardToRemove);
            }
            _discardPile.DiscardCard(cardToRemove, cardType);
            ChangeCurrentPlayerIndex();
        }

        public string GetPlayerName(int playerId)
        {
            return _players[playerId].Name;
        }

        public List<DiscardCard> GetDiscardPile()
        {
            return _discardPile.Pile;
        }

        private void Initialise(string characterCardFile, string eventCardFile)
        {
            _characterCardDeck = new Deck<CharacterCard>(ReadCharactersFromTxtFile(characterCardFile));
            _eventCardDeck = new Deck<EventCard>(ReadEventsFromTxtFile(eventCardFile));
            _discardPile = new DiscardPile();
        }

        private List<EventCard> ReadEventsFromTxtFile(string eventCardFile)
        {
            var eventLines = File.ReadAllLines(eventCardFile);
            var eventCardList = new List<EventCard>();
            foreach (var line in eventLines)
            {
                var cardStringList = line.Split(new char[] { ':' });
                var name = cardStringList[0];
                var season = cardStringList[1];
                var type = cardStringList[2];

                var eventCard = new EventCard()
                {
                    Name = name,
                    Season = Convert.ToInt32(season),
                    EventCardType = type == "P" ? EventCardType.PIVOTAL : EventCardType.STANDARD
                };

                if (eventCard.EventCardType == EventCardType.PIVOTAL)
                {
                    eventCard.Characters = new List<string>();
                    for (int i = 3; i < cardStringList.Count(); i++)
                    {
                        eventCard.Characters.Add(cardStringList[i]);
                    }
                }
                eventCardList.Add(eventCard);
            }
            return eventCardList;
        }

        private List<CharacterCard> ReadCharactersFromTxtFile(string characterCardFile)
        {
            var characterLines = File.ReadAllLines(characterCardFile);
            var characterCardList = new List<CharacterCard>();
            foreach (var line in characterLines)
            {
                characterCardList.Add(new CharacterCard() { Name = line });
            }
            return characterCardList;
        }

        private bool AddCardToPlayerHand(int playerId, CardType cardType, object card)
        {
            if (cardType == CardType.CHARACTER)
            {
                return _players[playerId].Hand.AddCharacterCard((CharacterCard)card);
            }
            var eventCard = (EventCard)card;
            if (eventCard.EventCardType == EventCardType.PIVOTAL)
            {
                return _players[playerId].Hand.AddPivotalEventCard(eventCard);
            }
            return _players[playerId].Hand.AddStandardEventCard(eventCard);
        }

        private object GetCardFromDeck(CardType cardType)
        {
            if (cardType == CardType.CHARACTER)
            {
                return _characterCardDeck.TakeCard();
            }
            return _eventCardDeck.TakeCard();
        }

        private bool IsCurrentPlayer(int playerId)
        {
            return playerId == _currentPlayerIndex;
        }

        private void ChangeCurrentPlayerIndex()
        {
            _currentPlayerIndex = _currentPlayerIndex == _players.Count - 1 ? 0 : _currentPlayerIndex+1;
        }
    }
}
