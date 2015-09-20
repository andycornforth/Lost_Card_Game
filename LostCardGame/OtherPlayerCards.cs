using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LostCardGameCore;

namespace LostCardGame
{
    public partial class OtherPlayerCards : UserControl
    {
        public OtherPlayerCards(string playerName, List<CharacterCard> characters, List<EventCard> pivotalEvents, List<EventCard> standardEvents)
        {
            InitializeComponent();
            SetUserControl(playerName, characters, pivotalEvents, standardEvents);
        }

        private void SetUserControl(string playerName, List<CharacterCard> characters, List<EventCard> pivotalEvents, List<EventCard> standardEvents)
        {
            lblName.Text = playerName;
            lstCharacters.DataSource = characters;
            lstCharacters.ClearSelected();
            lstStandard.DataSource = standardEvents;
            lstStandard.ClearSelected();

            SetLabelsForEvent(lblPivotal1, lblPivChar1, pivotalEvents, 0);
            SetLabelsForEvent(lblPivotal2, lblPivChar2, pivotalEvents, 1);
            SetLabelsForEvent(lblPivotal3, lblPivChar3, pivotalEvents, 2);
            SetLabelsForEvent(lblPivotal4, lblPivChar4, pivotalEvents, 3);
            SetLabelsForEvent(lblPivotal5, lblPivChar5, pivotalEvents, 4);
            SetLabelsForEvent(lblPivotal6, lblPivChar6, pivotalEvents, 5);
        }

        private void SetLabelsForEvent(Label EventLabel, Label characterLabel, List<EventCard> events, int index)
        {
            if (index < events.Count)
            {
                EventLabel.Text = index < events.Count ? events[index].ToString() : string.Empty;
                characterLabel.Text = GetCharactersForPivotalEvent(events[index]);
            }
        }

        private string GetCharactersForPivotalEvent(EventCard card)
        {
            var str = "->  ";
            var characters = card.Characters;
            foreach (var character in characters)
            {
                str += character + ". ";
            }
            return str;
        }

        public void Update(string playerName, List<CharacterCard> characters, List<EventCard> pivotalEvents, List<EventCard> standardEvents)
        {
            lblName.Text = playerName;
            lstCharacters.DataSource = null;
            lstStandard.DataSource = null;
            lblPivotal1.Text = string.Empty;
            lblPivotal2.Text = string.Empty;
            lblPivotal3.Text = string.Empty;
            lblPivotal4.Text = string.Empty;
            lblPivotal5.Text = string.Empty;
            lblPivotal6.Text = string.Empty;
            lblPivChar1.Text = string.Empty;
            lblPivChar2.Text = string.Empty;
            lblPivChar3.Text = string.Empty;
            lblPivChar4.Text = string.Empty;
            lblPivChar5.Text = string.Empty;
            lblPivChar6.Text = string.Empty;
            SetUserControl(playerName, characters, pivotalEvents, standardEvents);
        }
    }
}
