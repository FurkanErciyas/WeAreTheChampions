using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Data;

namespace WeAreTheChampions
{
    public partial class AddPlayerForm : Form
    {
        private readonly WATCDbContext _db;
        private readonly Team _selectedTeam;

        public AddPlayerForm(WATCDbContext db, Team selectedTeam)
        {
            InitializeComponent();
            _db = db;
            _selectedTeam = selectedTeam;
            LoadingTeams();
        }

        private void LoadingTeams()
        {
            cboTeams.Items.Clear();
            cboTeams.Items.Add("Non-Contracted Players");
            foreach (Team team in _db.Teams)
            {
                cboTeams.Items.Add(team);
            }
            cboTeams.SelectedIndex = 0;
            //cboTeams.DataSource = _db.Teams.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPlayerName.Text))
            {

                Player newPlayer;
                if (cboTeams.SelectedIndex == 0)
                {
                    newPlayer = new Player()
                    {
                        PlayerName = txtPlayerName.Text,
                    };
                }
                else
                {
                    Team selectedTeam = (Team)cboTeams.SelectedItem;
                    newPlayer = new Player()
                    {
                        PlayerName = txtPlayerName.Text,
                        TeamId = selectedTeam.Id
                    };
                }

                _db.Players.Add(newPlayer);
                _db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("You must specify a player name!", "Warning");
            }
        }
    }
}
