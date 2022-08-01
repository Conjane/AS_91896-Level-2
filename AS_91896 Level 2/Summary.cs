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

            rtxOutput.Text = am.FoodSummary(cbxSearchForSearch.Text, cbxSpecies.Text, (int)numAge.Value);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            SPCA window = new SPCA(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();

            am.Day1Food.Clear();
            am.Day2Food.Clear();
            am.Day3Food.Clear();
            am.Day4Food.Clear();
            am.Day5Food.Clear();
            am.Day6Food.Clear();
            am.Day7Food.Clear();
        }



        private void cbxSearchForSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearchForSearch.Text.Equals("Species"))
            {
                lblSpecies.Visible = true;
                cbxSpecies.Visible = true;
                lblAge.Visible = false;
                numAge.Visible = false;
                
            }
            else if (cbxSearchForSearch.Text.Equals("Age"))
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxOutput.Text = "";
        }

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            if (!numAge.Value.Equals(-1))
            {
                am.Day1Food.Clear();
                am.Day2Food.Clear();
                am.Day3Food.Clear();
                am.Day4Food.Clear();
                am.Day5Food.Clear();
                am.Day6Food.Clear();
                am.Day7Food.Clear();

                rtxOutput.Text = am.FoodSummary(cbxSearchForSearch.Text, cbxSpecies.Text, (int)numAge.Value);

            }
            else if (!cbxSpecies.Text.Equals(""))
            {
                am.Day1Food.Clear();
                am.Day2Food.Clear();
                am.Day3Food.Clear();
                am.Day4Food.Clear();
                am.Day5Food.Clear();
                am.Day6Food.Clear();
                am.Day7Food.Clear();

                rtxOutput.Text = am.FoodSummary(cbxSearchForSearch.Text, cbxSpecies.Text, (int)numAge.Value);

            }
        }
    }
}
