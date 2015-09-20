using LostCardGameCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostCardGame
{
    public partial class GameForm : Form
    {
        private Game _game;
        private int _playerId = 0;
        private List<Player> _players;
        private List<OtherPlayerCards> _otherUserCards = new List<OtherPlayerCards>();
        public GameForm()
        {
            SetPlayers();
            InitializeComponent();
            SetPlayerScreen();
            SetNonPlayerTurnListBoxes();
            SetImages();
        }

        private void SetImages()
        {
            Image image = Image.FromFile("C:/Users/andrew.cornforth/Documents/visual studio 2013/Projects/LostCardGame/LostCardGame/Images/main-image.jpg");
            pictureMain.Image = image;
        }

        private void SetPlayers()
        {
            var createGameForm = new MainForm();
            createGameForm.ShowDialog();
            _game = createGameForm.game;
            _players = createGameForm.Players;
        }

        private void ChangePlayer()
        {
            _playerId = _playerId == _players.Count - 1 ? 0 : _playerId + 1;
            MessageBox.Show("Your turn is over. Pass the mouse to " + _game.GetPlayerName(_playerId) + ".");
            SetPlayerScreen();
        }

        private void SetPlayerScreen()
        {
            lblPlayer.Text = _game.GetPlayerName(_playerId);
            List<CharacterCard> characterCards = _game.GetPlayersCharacterCards(_playerId).ToList();
            lstCharacters.DataSource = characterCards;
            lstCharacters.DisplayMember = "Name";
            lstCharacters.ClearSelected();
            lstPivotalEventCharacters.DataSource = null;
            lstPivotalEvents.DataSource = _game.GetPlayersPivotalEventCards(_playerId);
            lstPivotalEvents.DisplayMember = "Name";
            lstStandardEvents.DataSource = _game.GetPlayersStandardEventCards(_playerId);
            lstStandardEvents.DisplayMember = "Name";
            lstStandardEvents.ClearSelected();
            SetDiscardPile();
            UpdateNonPlayerTurnListBoxes();
        }

        private void btnPickCharacter_Click(object sender, EventArgs e)
        {
            var card = (CharacterCard)_game.TakeCardFromDeck(_playerId, CardType.CHARACTER);
            var cardDisplay = new CharacterCardForm(card);
            cardDisplay.ShowDialog();

            AddCharacterCardToHand(card);
            ChangePlayer();
        }

        private void AddCharacterCardToHand(CharacterCard card)
        {
            if (!_game.AddCardToHand(_playerId, CardType.CHARACTER, card))
            {
                var swapCards = new SwapCardForm(card, _game.GetPlayersCharacterCards(_playerId), CardType.CHARACTER);
                swapCards.ShowDialog();
                if (swapCards.DialogResult == DialogResult.OK)
                {
                    var discardedCard = (CharacterCard)swapCards.CardToBeRemoved;
                    _game.AddCardToHand(_playerId, CardType.CHARACTER, card, discardedCard);
                }
            }
            SetPlayerScreen();
        }

        private void btnPickEvent_Click(object sender, EventArgs e)
        {
            var card = (EventCard)_game.TakeCardFromDeck(_playerId, CardType.EVENT);
            var cardDisplay = new EventCardForm(card);
            cardDisplay.ShowDialog();

            AddEventCardToHand(card);
            ChangePlayer();
        }

        private void AddEventCardToHand(EventCard card)
        {
            if (!_game.AddCardToHand(_playerId, CardType.EVENT, card))
            {
                var swapCards = new SwapCardForm(card, _game.GetPlayersPivotalEventCards(_playerId), CardType.EVENT);
                swapCards.ShowDialog();
                if (swapCards.DialogResult == DialogResult.OK)
                {
                    var discardedCard = (EventCard)swapCards.CardToBeRemoved;
                    _game.AddCardToHand(_playerId, CardType.EVENT, card, discardedCard);
                }
            }
            SetPlayerScreen();
        }

        private void lstPivotalEvents_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            lstPivotalEventCharacters.DataSource = ((EventCard)lstPivotalEvents.SelectedItem).Characters;
            lstPivotalEventCharacters.ClearSelected();
        }

        private void SetDiscardPile()
        {
            lstDiscardPile.DataSource = null;
            var pile = _game.GetDiscardPile();
            lstDiscardPile.DataSource = pile;
            lstDiscardPile.SelectedIndex = pile.Count() - 1;
            btnDiscardCard.Enabled = lstDiscardPile.Items.Count == 0 ? false : true;
        }

        private void lstDiscardPile_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lstDiscardPile.DataSource != null)
            {
                lstDiscardPile.SelectedIndex = _game.GetDiscardPile().Count() - 1;
            }
        }

        private void btnDiscardCard_Click(object sender, EventArgs e)
        {
            var card = _game.TakeCardFromDiscardPile();
            if (card.CardType == CardType.CHARACTER)
            {
                AddCharacterCardToHand((CharacterCard)card.Card);
            }
            else
            {
                AddEventCardToHand((EventCard)card.Card);
            }
            ChangePlayer();
        }

        private void SetNonPlayerTurnListBoxes()
        {
            var location = 430;
            foreach (var player in _players)
            {
                if (!player.Name.Equals(_game.GetPlayerName(_playerId)))
                {
                    var userControl = new OtherPlayerCards(player.Name, player.Hand.GetCharacterCards().ToList(), player.Hand.GetPivotalEventCards().ToList(), player.Hand.GetStandardEventCards().ToList());
                    Height = Height + 150;
                    userControl.Location = new Point(0, location);
                    location += 150;
                    this.Controls.Add(userControl);
                    _otherUserCards.Add(userControl);
                }
            }
        }

        private void UpdateNonPlayerTurnListBoxes()
        {
            var index = 0;
            foreach (var player in _players)
            {
                if (!player.Name.Equals(_game.GetPlayerName(_playerId)))
                {
                    if (_otherUserCards.Count > index)
                    {
                        var userControl = _otherUserCards[index];
                        userControl.Update(player.Name, player.Hand.GetCharacterCards().ToList(), player.Hand.GetPivotalEventCards().ToList(), player.Hand.GetStandardEventCards().ToList());
                        index++;
                    }
                }
            }
        }
    }
}
