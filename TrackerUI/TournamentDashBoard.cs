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
    public partial class TournamentDashBoard : Form
    {
        List<TournamentModel> tournamentModels = GlobalConfig.Connections.GetTournamentAll();
        public TournamentDashBoard()
        {
            InitializeComponent();
            WireUpList();
        }

        private void WireUpList()
        {
            LoadExTournamentComboBox.DataSource = tournamentModels;
            LoadExTournamentComboBox.DisplayMember = "TournamentName";
        }
        private void CreateTournamentBtn_Click(object sender, EventArgs e)
        {
            CreateTournamentForm CT = new CreateTournamentForm();
            CT.Show();
        }

        private void LoadTournamentBtn_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)LoadExTournamentComboBox.SelectedItem;
            TournamentViewer viewer = new TournamentViewer(tm);
            viewer.Show();
        }
    }
}
