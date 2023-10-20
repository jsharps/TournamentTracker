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
        public TeamCreateForm()
        {
            InitializeComponent();
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

                GlobalConfig.Connection.CreatePlayer(p);
                
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
    }
}
