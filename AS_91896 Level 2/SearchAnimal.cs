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
    public partial class SearchAnimal : Form
    {
        AnimalManager am;

        public SearchAnimal(AnimalManager am)
        {
            this.am = am;    
            InitializeComponent();

            numID.Maximum = am.animals.Count();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            SPCA window = new SPCA(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            lstBoxAnimals.Items.Clear();

            if (!cbxSpecies.Text.Equals(""))
            {
                lstBoxAnimals.Items.Clear();

                foreach (string name in am.SearchAnimal(txtbxName.Text, (int)numAge.Value, cbxSpecies.Text, (int)numID.Value, cbxSearchForSearch.Text))
                {
                    lstBoxAnimals.Items.Add(name);

                }
                cbxSpecies.Text = "";
            }
            else if (!numAge.Value.Equals(-1))
            {
                lstBoxAnimals.Items.Clear();

                foreach (string name in am.SearchAnimal(txtbxName.Text, (int)numAge.Value, cbxSpecies.Text, (int)numID.Value, cbxSearchForSearch.Text))
                { 
                    lstBoxAnimals.Items.Add(name);
    
                }

                numAge.Value = 0;
            }
            else if (!txtbxName.Text.Equals(""))
            {
                lstBoxAnimals.Items.Clear();

                foreach (string name in am.SearchAnimal(txtbxName.Text, (int)numAge.Value, cbxSpecies.Text, (int)numID.Value, cbxSearchForSearch.Text))
                {
                    lstBoxAnimals.Items.Add(name);
                }

                txtbxName.Text = "";
            }
            else if (!numID.Value.Equals(0))
            {
                lstBoxAnimals.Items.Clear();

                foreach (string name in am.SearchAnimal(txtbxName.Text, (int)numAge.Value, cbxSpecies.Text, (int)numID.Value, cbxSearchForSearch.Text))
                {
                    lstBoxAnimals.Items.Add(name);
                }

                numID.Value = 1;
            }
            else
            {
                MessageBox.Show("Enter Something");
            }

            
        }

        private void cbxSearchForSeearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearchForSearch.Text.Equals("Species"))
            {
                lblSpecies.Visible = true;
                cbxSpecies.Visible = true;
                lblAge.Visible = false;
                numAge.Visible = false;
                lblName.Visible = false;
                txtbxName.Visible = false;
                lblID.Visible = false;
                numID.Visible = false;
            }
            else if (cbxSearchForSearch.Text.Equals("Age"))
            {
                lblSpecies.Visible = false;
                cbxSpecies.Visible = false;
                lblAge.Visible = true;
                numAge.Visible = true;
                lblName.Visible = false;
                txtbxName.Visible = false;
                lblID.Visible = false;
                numID.Visible = false;
            }
            else if (cbxSearchForSearch.Text.Equals("Name"))
            {
                lblSpecies.Visible = false;
                cbxSpecies.Visible = false;
                lblAge.Visible = false;
                numAge.Visible = false;
                lblName.Visible = true;
                txtbxName.Visible = true;
                lblID.Visible = false;
                numID.Visible = false;
            }
            else if (cbxSearchForSearch.Text.Equals("ID Number"))
            {
                lblSpecies.Visible = false;
                cbxSpecies.Visible = false;
                lblAge.Visible = false;
                numAge.Visible = false;
                lblName.Visible = false;
                txtbxName.Visible = false;
                lblID.Visible = true;
                numID.Visible = true;
            }

        }

        //This breaks when you click on the lstBx but aren't selecting anything while having a selectable option; so fix it whenever
        private void lstBoxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
                MessageBox.Show(am.SearchReciept(lstBoxAnimals.SelectedItem.ToString()));
             
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBoxAnimals.Items.Clear();
            am.names.Clear();
        }
    }
}
