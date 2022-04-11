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
    public partial class AddMatchForm : Form
    {
        private readonly WATCDbContext _db;

        public AddMatchForm(WATCDbContext db)
        {
            InitializeComponent();
            _db = db;
            LoadingTeams();
            LoadingScore();
        }

        private void LoadingScore()
        {
            cboHomeScore.Items.Clear();
            cboAwayScore.Items.Clear();

            cboHomeScore.Items.Add("?");
            cboAwayScore.Items.Add("?");

            for (int i = 0; i < 20; i++)
            {
                cboHomeScore.Items.Add(i);
                cboAwayScore.Items.Add(i);
            }

            cboHomeScore.SelectedIndex = 0;
            cboAwayScore.SelectedIndex = 0;
        }

        private void LoadingTeams()
        {
            cboHomeTeam.DataSource = _db.Teams.ToList();
            cboAwayTeam.DataSource = _db.Teams.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Match newMatch = new Match()
            {
                Team1 = (Team)cboHomeTeam.SelectedItem,
                Team2 = (Team)cboAwayTeam.SelectedItem,
                Score1 = (string)cboHomeScore.SelectedItem.ToString(),
                Score2 = (string)cboAwayScore.SelectedItem.ToString(),
                MatchTime = dtpMatchTime.Value
            };

            if(newMatch.Score1 == "?" && newMatch.Score2 != "?" || newMatch.Score1 != "?" && newMatch.Score2 == "?")
            {
                MessageBox.Show("It must be the result of both teams or not both teams. Please try again.", "Warning!");
                return;
            }

            if (newMatch.Team1.TeamName == newMatch.Team2.TeamName)
            {
                MessageBox.Show("It can't be same for both teams. Please try again.", "Warning!");
                return;
            }

            if (newMatch.Score1 == "?" && newMatch.Score2 == "?")
            {
                newMatch.Result = Result.NotResult;
            }
            else
            {
                int homeScore = Convert.ToInt32(newMatch.Score1);
                int awayScore = Convert.ToInt32(newMatch.Score2);

                if (homeScore > awayScore)
                {
                    newMatch.Result = Result.Team1Won;
                }
                else if (homeScore < awayScore)
                {
                    newMatch.Result = Result.Team2Won;
                }
                else
                {
                    newMatch.Result = Result.Draw;
                }
            }

            _db.Matches.Add(newMatch);
            _db.SaveChanges();
            Close();

        }
    }
}
