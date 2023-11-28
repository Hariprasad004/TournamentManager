using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {
        IPrizeRequester callingForm;
        public CreatePrize(IPrizeRequester callingForm)
        {
            InitializeComponent();
            this.callingForm = callingForm;
        }

        private void CreatePrizeBtn_Click(object sender, EventArgs e)
        {
             if (ValidateForm() == true)
            {
                PrizeModel model = new PrizeModel(
                   PlaceNameTxtBox.Text,
                   PlaceNumTxtBox.Text,
                   PrizeAmountTxtBox.Text,
                   PrizePercentTxtBox.Text);
                    GlobalConfig.Connections.CreatePrize(model);
                callingForm.PrizeComplete(model);
                    PlaceNameTxtBox.Text = "";
                    PlaceNumTxtBox.Text = "";
                    PrizeAmountTxtBox.Text = "0";
                 PrizePercentTxtBox.Text = "0";
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid informations Present!");
            }
        }

        private bool ValidateForm()
        {
            //try
            //{
            int PlaceNum = 0;
            double PrizePercent = 0;
            decimal PrizeAmount = 0;
            if (int.TryParse(PlaceNumTxtBox.Text, out PlaceNum) == false)
            {
                return false;
            }
            if (PlaceNum < 1)
            {
                return false;
            }
            if (PlaceNameTxtBox.Text.Length == 0)
            {
                return false;
            }
            decimal.TryParse(PrizeAmountTxtBox.Text, out PrizeAmount);
            double.TryParse(PrizePercentTxtBox.Text, out PrizePercent);

            if (PrizeAmount <= 0 && PrizePercent <= 0)
            {
                return false;
            }

            if (PrizeAmount < 0 || PrizeAmount > 100)
            {
                return false;
            }
            return true;
            //}
            //catch (Exception ex)
            //{

            //}
        }
    }
}
