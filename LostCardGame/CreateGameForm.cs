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
    public partial class MainForm : Form
    {
        public Game game;
        public List<Player> Players = new List<Player>();
        public MainForm()
        {
            InitializeComponent();
            game = new Game("C:/Users/andrew.cornforth/Documents/characters.txt", "C:/Users/andrew.cornforth/Documents/events.txt");
        }

        private void btnAddPlayerToGame_Click(object sender, EventArgs e)
        {
            if (!txtPlayerName.Text.Equals(string.Empty))
            {
                Player player = new Player()
                {
                    Name = txtPlayerName.Text,
                    Hand = new Hand()
                };
                game.AddPlayer(player);
                lstPlayers.Items.Add(txtPlayerName.Text);
                txtPlayerName.Text = string.Empty;
                Players.Add(player);
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (lstPlayers.Items.Count < 2)
            {
                DialogResult = DialogResult.None;
            }
        }
    }
}
