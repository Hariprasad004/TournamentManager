using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;
using TrackerLibrary;
using System.DirectoryServices.ActiveDirectory;

namespace TrackerUI
{
    public partial class CreateTeam : Form
    {
        public List<PersonModel> AvailableMembers = GlobalConfig.Connections.GetPersonAll();
        public List<PersonModel> SelectedMemebrs = new List<PersonModel>();
        ITeamRequester callingForm;
        public CreateTeam(ITeamRequester callingForm)
        {
            InitializeComponent();
            //createSampleData();
            WireUpLists();
            this.callingForm = callingForm;
        }

        public void createSampleData()
        {
            var a = GlobalConfig.Connections.GetPersonAll();
            AvailableMembers.Add(new PersonModel { FirstName = "Dhanush", LastName = "Suvarna" });
            AvailableMembers.Add(new PersonModel { FirstName = "Jeevan", LastName = "A" });
            SelectedMemebrs.Add(new PersonModel { FirstName = "Hariprasad", LastName = "Poojary" });
            SelectedMemebrs.Add(new PersonModel { FirstName = "Sanketh" });
        }

        public void WireUpLists()
        {
            SelectMemberComboBox.DataSource = null;
            SelectMemberComboBox.DataSource = AvailableMembers;
            SelectMemberComboBox.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;
            TeamMembersListBox.DataSource = SelectedMemebrs;
            TeamMembersListBox.DisplayMember = "FullName";
        }
        private void CreateMemberBtn_Click(object sender, EventArgs e)
        {
            if (ValidateTeamMember() == true)
            {
                PersonModel model = new PersonModel(
                   FirstnameTxtBox.Text,
                   LastNameTxtBox.Text,
                   EmailTxtBox.Text,
                   PhoneNoTxtBox.Text);

                PersonModel p = GlobalConfig.Connections.CreateTeamMember(model);
                AvailableMembers.Add(p);

                WireUpLists();
                FirstnameTxtBox.Text = "";
                LastNameTxtBox.Text = "";
                EmailTxtBox.Text = "";
                PhoneNoTxtBox.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid informations Present!");
            }
        }
        private bool ValidateTeamMember()
        {
            bool output = true;
            if (FirstnameTxtBox.Text == "") { return false; }
            if (LastNameTxtBox.Text == "") { return false; }
            if (EmailTxtBox.Text == "") { return false; }
            if (PhoneNoTxtBox.Text == "") { return false; }
            return output;
        }

        private void AddTeamBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectMemberComboBox.SelectedItem;
            if (p != null)
            {
                AvailableMembers.Remove(p);
                SelectedMemebrs.Add(p);
                WireUpLists();
            }
        }

        private void DeleteSelectedBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersListBox.SelectedItem;
            if (p != null)
            {
                SelectedMemebrs.Remove(p);
                AvailableMembers.Add(p);
                WireUpLists();
            }
        }

        private void CreateTeamBtn_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = TeamNameTxtBox.Text;
            t.TeamMembers = SelectedMemebrs;
            GlobalConfig.Connections.CreateTeam(t);
            callingForm.TeamComplete(t);
            this.Close();
        }
    }
}
