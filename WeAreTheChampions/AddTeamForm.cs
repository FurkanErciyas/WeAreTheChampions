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
using Color = System.Drawing.Color;

namespace WeAreTheChampions
{
    public partial class AddTeamForm : Form
    {
        private readonly WATCDbContext _db;
        private readonly Team _team;

        public AddTeamForm(WATCDbContext db)
        {
            InitializeComponent();
            _db = db;
            LoadingPlayers();
            LoadingColors();
        }

        public AddTeamForm(WATCDbContext db, Team team)
        {
            InitializeComponent();
            _db = db;
            _team = team;
            menuStrip1.Hide();
            btnAdd.Text = "Edit";
            Text = "Edit Team";
            txtTeamName.Text = _team.TeamName;
            clbPlayers.DataSource = _db.Players.Where(x => x.TeamId == _team.Id || x.TeamId == null).ToList();
            clbColors.DataSource = _db.Colors.ToList();
        }

        private void LoadingColors()
        {
            clbColors.DataSource = _db.Colors.ToList();
            tscbColors.Items.Clear();
            foreach (Data.Color color in _db.Colors)
            {
                tscbColors.Items.Add(color);
            }
        }

        private void LoadingPlayers()
        {
            clbPlayers.DataSource = _db.Players.Where(x => x.TeamId == null).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                Team newTeam = new Team()
                {
                    TeamName = txtTeamName.Text,
                    Colors = clbColors.CheckedItems.Cast<Data.Color>().ToList(),
                    Players = clbPlayers.CheckedItems.Cast<Player>().ToList(),
                };
                _db.Teams.Add(newTeam);
            }
            else
            {
                _team.TeamName = txtTeamName.Text;
                _team.Colors = clbColors.CheckedItems.Cast<Data.Color>().ToList();
                _team.Players = clbPlayers.CheckedItems.Cast<Player>().ToList();
            }
            _db.SaveChanges();
            Close();
        }

        private void tsmiAddColor_Click(object sender, EventArgs e)
        {
            AddColorForm addColorForm = new AddColorForm(_db);
            addColorForm.ShowDialog();
            LoadingColors();
        }

        private void tscbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.Color selectedColor = (Data.Color)tscbColors.SelectedItem;
            Color backColor = Color.FromArgb((int)selectedColor.Red, (int)selectedColor.Green, (int)selectedColor.Blue);
            tstbColor.BackColor = backColor;
        }

        private void tscbColors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && tscbColors.Items.Count > 0)
            {
                Data.Color selectedColor = (Data.Color)tscbColors.SelectedItem;
                _db.Colors.Remove(selectedColor);
                _db.SaveChanges();
                LoadingColors();
            }
        }
    }
}
