using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_91896_Level_2
{
    public partial class Summary : Form
    {
        AnimalManager am;

        public Summary(AnimalManager am)
        {
            this.am = am;
            
            InitializeComponent();

            rtxOutput.Text = am.FoodSummary(cbxSelectSearch.Text, cbxSpecies.Text, (int)numAge.Value);
        }

        //Returns the user to home screen
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            SPCA window = new SPCA(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
        
        // Will filter and display animals consumptions onto a Rich Textbox dependant on what is inputted +
        // Will clear the Rich Textbox when new values are inputted
        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            rtxOutput.Text = "";
            rtxOutput.Text = am.FoodSummary(cbxSelectSearch.Text, cbxSpecies.Text, (int)numAge.Value);

        }
        
        //Allows user to select what critria they'd like to search by
        private void cbxSelectSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSelectSearch.Text.Equals("Species"))
            {
                lblSpecies.Visible = true;
                cbxSpecies.Visible = true;
                lblAge.Visible = false;
                numAge.Visible = false;

            }
            else if (cbxSelectSearch.Text.Equals("Age"))
            {
                lblSpecies.Visible = false;
                cbxSpecies.Visible = false;
                lblAge.Visible = true;
                numAge.Visible = true;
            }
            else
            {
                lblSpecies.Visible = false;
                cbxSpecies.Visible = false;
                lblAge.Visible = false;
                numAge.Visible = false;
            }
        }
    }
}
