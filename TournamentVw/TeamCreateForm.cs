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
    public partial class TeamCreateForm : Form
    {

        private List<PlayerModel> availableTeamMembers = GlobalConfig.Connection.GetPlayers_All();
        private List<PlayerModel> selectedTeamMembers = new List<PlayerModel>();
        public TeamCreateForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PlayerModel { FirstName = "Jeff", LastName = "Manrique" });
            availableTeamMembers.Add(new PlayerModel { FirstName = "Belle", LastName = "Manrique" });

            selectedTeamMembers.Add(new PlayerModel { FirstName = "Inigo", LastName = "Manrique" });
            selectedTeamMembers.Add(new PlayerModel { FirstName = "Izza", LastName = "Manrique" });


        }

        private void WireUpLists()
        {
            teamDropDown.DataSource = null;

            teamDropDown.DataSource = availableTeamMembers;
            teamDropDown.DisplayMember = "FullName";

            memberListBox.DataSource = null;

            memberListBox.DataSource = selectedTeamMembers;
            memberListBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PlayerModel p = new PlayerModel()
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    EmailAddress = emailTextBox.Text,
                    CellphoneNumber = phoneTextBox.Text
                };

                availableTeamMembers.Add(p);

                WireUpLists();

                p = GlobalConfig.Connection.CreatePlayer(p);

                firstNameTextBox.Text = string.Empty;
                lastNameTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;
                phoneTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("You need to fill in all fields");
            }
        }

        private bool ValidateForm()
        {
            // TODO - Add validation to the form
            if (firstNameTextBox.TextLength *
                lastNameTextBox.TextLength *
                emailTextBox.TextLength *
                phoneTextBox.TextLength == 0)
                return false;

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PlayerModel p = (PlayerModel)teamDropDown.SelectedItem;

            if(p != null)

    {
                availableTeamMembers.Remove(p);

                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }

        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            PlayerModel p = (PlayerModel)memberListBox.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Add(p);

                selectedTeamMembers.Remove(p);

                WireUpLists();  
            }
        }
    }
}
