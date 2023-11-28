using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, ITeamRequester, IPrizeRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connections.GetTeamAll();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireupLists();
        }

        public void WireupLists()
        {
            SelectTeamComboBox.DataSource = null;
            SelectTeamComboBox.DataSource = availableTeams;
            SelectTeamComboBox.DisplayMember = "TeamName";

            SelectedTeamListbox.DataSource = null;
            SelectedTeamListbox.DataSource = selectedTeams;
            SelectedTeamListbox.DisplayMember = "TeamName";

            PrizesList.DataSource = null;
            PrizesList.DataSource = selectedPrizes;
            PrizesList.DisplayMember = "PlaceName";

        }

        private void AddTeamBtn_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)SelectTeamComboBox.SelectedItem;
            if (p != null)
            {
                availableTeams.Remove(p);
                selectedTeams.Add(p);
                WireupLists();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)SelectedTeamListbox.SelectedItem;
            if (p != null)
            {
                selectedTeams.Remove(p);
                availableTeams.Add(p);
                WireupLists();
            }
        }

        private void DeletePrizeBtn_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizesList.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireupLists();
            }
        }

        private void CreateNewLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new CreateTeam(this);
            frm.Show();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireupLists();
        }

        private void CreatePrizeBtn_Click(object sender, EventArgs e)
        {
            Form frm = new CreatePrize(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireupLists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal fee = 0;
            if(!(decimal.TryParse(EntryFeeTxtBox.Text, out fee)))
            {
                MessageBox.Show("Enter valid information!");
                return;
            }
            TournamentModel tm = new TournamentModel();
            tm.TournamentName = TournamentNameTxtBox.Text;
            tm.EntryFee = fee;
            tm.EnteredTeams = selectedTeams;
            tm.Prizes = selectedPrizes;

            TournamentLogic.CreateRounds(tm);

            GlobalConfig.Connections.CreateTournament(tm);
            TournamentLogic.AlertUsersToNewRound(tm);

            TournamentViewer frm = new TournamentViewer(tm);
            frm.Show();
            this.Close();

        }
    }
}
