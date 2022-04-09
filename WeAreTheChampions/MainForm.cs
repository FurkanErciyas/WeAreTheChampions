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
    public partial class MainForm : Form
    {
        WATCDbContext db = new WATCDbContext();
        public MainForm()
        {
            InitializeComponent();
            LoadingTeams();
            LoadingPlayers();
        }

        private void LoadingPlayers()
        {
            dgvPlayers.DataSource = db.Players.ToList();
        }

        private void LoadingTeams()
        {
            dgvTeams.DataSource = db.Teams.ToList();

            cboTeams.Items.Clear();
            cboTeams.Items.Add("All Players");
            cboTeams.Items.Add("Non-Contracted Players");
            foreach (Team team in db.Teams)
            {
                cboTeams.Items.Add(team);
            }
            cboTeams.SelectedIndex = 0;
            //cboTeams.DataSource = db.Teams.ToList();
        }

        private void lblNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTeamForm addTeamForm = new AddTeamForm(db);
            addTeamForm.ShowDialog();
            LoadingTeams();
        }
        private void lblNewPlayer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Team selectedTeam = cboTeams.SelectedItem as Team;
            AddPlayerForm addPlayerForm = new AddPlayerForm(db, selectedTeam);
            addPlayerForm.ShowDialog();
            LoadingTeams();
            LoadingPlayers();
        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTeams.SelectedIndex == 0)
            {
                dgvPlayers.DataSource = db.Players.ToList();
            }
            else if (cboTeams.SelectedIndex == 1)
            {
                dgvPlayers.DataSource = db.Players.Where(x => x.TeamId == null).ToList();
            }
            else
            {
                Team selectedTeam = (Team)cboTeams.SelectedItem;
                dgvPlayers.DataSource = selectedTeam.Players.ToList();
            }

        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tpPlayers)
            {
                Player selectedPlayer = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;
                db.Players.Remove(selectedPlayer);
            }
            else if (tabControl.SelectedTab == tpTeams)
            {
                Team selectedTeam = (Team)dgvTeams.SelectedRows[0].DataBoundItem;
                db.Teams.Remove(selectedTeam);
            }
            else
            {
                return;
            }

            db.SaveChanges();
            LoadingPlayers();
            LoadingTeams();
        }

        private void dgvPlayers_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count > 0 && e.Button == MouseButtons.Right)
            {
                cms.Show((DataGridView)sender, new Point(e.X, e.Y));
            }
        }

        private void dgvTeams_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvTeams.SelectedRows.Count > 0 && e.Button == MouseButtons.Right)
            {
                cms.Show((DataGridView)sender, new Point(e.X, e.Y));
            }
        }
    }
}
