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
    public partial class CharacterCardForm : Form
    {
        public CharacterCardForm(CharacterCard card)
        {
            InitializeComponent();
            lblCharacterName.Text = card.Name;
        }
    }
}
