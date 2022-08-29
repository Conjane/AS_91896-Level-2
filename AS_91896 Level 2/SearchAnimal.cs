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
        
        //Returns the user to home screen
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            SPCA window = new SPCA(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        //Will filter and display animals onto a List Box dependant on what is inputted / Will clear the list box when new values are inputted
        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            lstBoxAnimals.Items.Clear();
            am.names.Clear();

            if (!cbxSpecies.Text.Equals(""))
            {
                lstBoxAnimals.Items.Clear();

                foreach (string name in am.SearchAnimal(txtbxName.Text, (int)numAge.Value, cbxSpecies.Text, (int)numID.Value, cbxSelectSearch.Text))
                {
                    lstBoxAnimals.Items.Add(name);

                }
                cbxSpecies.Text = "";
            }
            else if (!numAge.Value.Equals(-1))
            {
                lstBoxAnimals.Items.Clear();

                foreach (string name in am.SearchAnimal(txtbxName.Text, (int)numAge.Value, cbxSpecies.Text, (int)numID.Value, cbxSelectSearch.Text))
                { 
                    lstBoxAnimals.Items.Add(name);
    
                }

                numAge.Value = 0;
            }
            else if (!txtbxName.Text.Equals(""))
            {
                lstBoxAnimals.Items.Clear();

                foreach (string name in am.SearchAnimal(txtbxName.Text, (int)numAge.Value, cbxSpecies.Text, (int)numID.Value, cbxSelectSearch.Text))
                {
                    lstBoxAnimals.Items.Add(name);
                }

                txtbxName.Text = "";
            }
            else if (!numID.Value.Equals(0))
            {
                lstBoxAnimals.Items.Clear();

                foreach (string name in am.SearchAnimal(txtbxName.Text, (int)numAge.Value, cbxSpecies.Text, (int)numID.Value, cbxSelectSearch.Text))
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

        //Display an animals details when selected
        private void lstBoxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxAnimals.SelectedIndex != -1)
            {
                MessageBox.Show(am.SearchReciept(lstBoxAnimals.SelectedItem.ToString()));
            }
            else
            {
                MessageBox.Show("Please Select an Animal");
            }
        }

        //Allows user to select what critria they'd like to search by
        private void cbxSelectSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxSelectSearch.Text.Equals("Species"))
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
            else if (cbxSelectSearch.Text.Equals("Age"))
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
            else if (cbxSelectSearch.Text.Equals("Name"))
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
            else if (cbxSelectSearch.Text.Equals("ID Number"))
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
    }
}
