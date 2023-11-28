using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewer : Form
    {
        private TournamentModel tournamentModel;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();
        public TournamentViewer(TournamentModel model)
        {
            InitializeComponent();
            tournamentModel = model;

            tournamentModel.OnTournamentComplete += Tournament_OnTournamentComplete;

            WireUpRoundLists();

            WireUpMatchupLists();

            LoadFormData();

            LoadRounds();

        }

        private void Tournament_OnTournamentComplete(object sender, DateTime e)
        {
            this.Close();
        }

        public void LoadFormData()
        {
            TournamentNameLbl.Text = tournamentModel.TournamentName;
        }
        //public void WireUpList()
        //{
        //    RoundDropdown.DataSource = null;
        //    RoundDropdown.DataSource = rounds;
        //}

        public void WireUpRoundLists()
        {
            RoundDropdown.DataSource = rounds;
        }

        public void WireUpMatchupLists()
        {
            MatchupListBox.DataSource = selectedMatchups;
            MatchupListBox.DisplayMember = "DisplayName";
        }
        public void LoadRounds()
        {
            int curround = 1;
            rounds.Clear();
            rounds.Add(curround);
            foreach (List<MatchupModel> matchups in tournamentModel.Rounds)
            {
                if (matchups.First().MatchUpRound > curround)
                {
                    curround = matchups.First().MatchUpRound;
                    rounds.Add(curround);
                }
            }
            LoadMatchups(1);
        }
        public void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournamentModel.Rounds)
            {
                if (matchups.First().MatchUpRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !UnplayedChckBox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }
                    }
                    //break;
                }
            }
            if(selectedMatchups.Count > 0)
            {
                LoadMatchUp(selectedMatchups.First());
            }
            DisplayMatchUpInfo();
        }
        public void DisplayMatchUpInfo()
        {
            bool invisible = (selectedMatchups.Count > 0);
            Team1Lbl.Visible = invisible;
            Team1txtbox.Visible = invisible;
            Team2Lbl.Visible = invisible;
            Team2txtbox.Visible = invisible;
            button2.Visible = invisible;
            label5.Visible = invisible;
            label2.Visible = invisible;
            label3.Visible = invisible;
        }
        public void LoadMatchUp(MatchupModel m)
        {
            if (m == null)
            {
                return;
            }
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        Team1Lbl.Text = m.Entries[0].TeamCompeting.TeamName;
                        Team1txtbox.Text = m.Entries[0].Score.ToString();

                        Team2Lbl.Text = "<bye>";
                        Team2txtbox.Text = "0";
                    }
                    else
                    {
                        Team1Lbl.Text = "Not yet set";
                        Team1txtbox.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        Team2Lbl.Text = m.Entries[1].TeamCompeting.TeamName;
                        Team2txtbox.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        Team2Lbl.Text = "Not yet set";
                        Team2txtbox.Text = "";
                    }
                }

            }
        }

        private void MatchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchUp((MatchupModel)MatchupListBox.SelectedItem);
        }

        private void RoundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropdown.SelectedItem);
        }

        private void UnplayedChckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropdown.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateTournamentResults(tournamentModel);
        }
        public  void UpdateTournamentResults(TournamentModel model)
        {
            int startRound = TournamentLogic.CheckCurrRound(model);
            MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;
            double TeamOneScore = 0;
            double TeamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0] != null)
                    {
                        if (double.TryParse(Team1txtbox.Text, out TeamOneScore))
                        {
                            m.Entries[0].Score = TeamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid score for team 1");
                            return;
                        }
                    }

                }
                if (i == 1)
                {
                    if (m.Entries[1] != null)
                    {
                        double ScoreValid = 0;
                        if (double.TryParse(Team2txtbox.Text, out TeamTwoScore))
                        {
                            m.Entries[1].Score = TeamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid score for team 2");
                            return;
                        }
                    }

                }

            }
            if (TeamOneScore > TeamTwoScore)
            {
                m.Winner = m.Entries[0].TeamCompeting;
            }
            else if (TeamTwoScore > TeamOneScore)
            {
                m.Winner = m.Entries[1].TeamCompeting;
            }
            else
            {
                MessageBox.Show("I do not handle tie games");
                return;
            }

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    foreach (MatchupEntryModel me in rm.Entries)
                    {
                        if (me.ParentMatchup != null)
                        {
                            if (me.ParentMatchup.Id == m.Id)
                            {
                                me.TeamCompeting = m.Winner;
                                GlobalConfig.Connections.UpdateMatchup(rm);
                            }
                        }
                    }
                }
            }
            LoadMatchups((int)RoundDropdown.SelectedItem);
            GlobalConfig.Connections.UpdateMatchup(m);
            int endingRound = TournamentLogic.CheckCurrRound(model);

            if (endingRound > startRound)
            {
                TournamentLogic.AlertUsersToNewRound(model);
            }
        }
    }
}