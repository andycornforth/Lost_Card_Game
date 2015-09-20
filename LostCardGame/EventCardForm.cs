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
    public partial class EventCardForm : Form
    {
        public EventCardForm(EventCard card)
        {
            InitializeComponent();
            lblEventType.Text = card.EventCardType == EventCardType.PIVOTAL ? "Pivotal Event" : "Standard Event";
            lblSeason.Text += card.Season;
            lblName.Text = card.Name;
            if (card.EventCardType == EventCardType.PIVOTAL)
            {
                lstCharacters.DataSource = card.Characters;
            }
            else
            {
                lstCharacters.Hide();
                Height = Height - lstCharacters.Height;
            }
        }
    }
}
