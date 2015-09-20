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
    public partial class SwapCardForm : Form
    {
        public object CardToBeRemoved;
        private ListBox _characterBox;
        public SwapCardForm(object newCard, object cardList, CardType cardType)
        {
            InitializeComponent();
            CreateList(newCard, cardList, cardType);
        }

        public ListBox Cards
        {
            get
            {
                return lstPlayerCards;
            }
        }

        private void CreateList(object newCard, object cardList, CardType cardType)
        {
            if (cardType == CardType.CHARACTER)
            {
                var cards = (List<CharacterCard>)cardList;
                cards.Add((CharacterCard)newCard);
                lstPlayerCards.DataSource = cards;
            }
            else
            {
                var cards = (List<EventCard>)cardList;
                cards.Add((EventCard)newCard);
                lstPlayerCards.DataSource = cards;
                _characterBox = new ListBox();
                Width = Width + 110;
                _characterBox.Location = new Point(280, 12);
                _characterBox.Height = lstPlayerCards.Height;
                _characterBox.Width = 100;
                this.Controls.Add(_characterBox);
                _characterBox.DataSource = ((EventCard)lstPlayerCards.SelectedItem).Characters;
                _characterBox.ClearSelected();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            CardToBeRemoved = lstPlayerCards.SelectedItem;
        }

        private void lstPlayerCards_SelectIndexChanged(object sender, EventArgs e)
        {
            if (_characterBox != null)
            {
                _characterBox.DataSource = ((EventCard)lstPlayerCards.SelectedItem).Characters;
                _characterBox.ClearSelected();
            }
        }
    }
}
