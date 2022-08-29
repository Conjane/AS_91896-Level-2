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
    public partial class AddAnimal : Form
    {
        //Variables
        AnimalManager am;
        public int ID;

        public AddAnimal(AnimalManager am)
        {
            this.am = am;
            
            InitializeComponent();
        }

        //Returns the user to home screen
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            SPCA window = new SPCA(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        //Button that will add an animals details to a list which can be used whenever needed
        public void btnAddAnimal_Click(object sender, EventArgs e)
        {
            ID = am.animals.Count() + 1;

            NewAnimal na = new NewAnimal();
            
            na.SetDetails(txtbxName.Text, (int)numAge.Value, (string)cbxSpecies.SelectedItem, (string)rtxNotes.Text, ID);

            List<int> consumption = new List<int>()
            {
                (int)numDay1.Value, (int)numDay2.Value, (int)numDay3.Value, (int)numDay4.Value,
                (int)numDay5.Value, (int)numDay6.Value, (int)numDay7.Value
            };

            na.SetConsumption(consumption);

            am.addAnimal(na);
            
            txtbxName.Text = "";
            numAge.Value = 0;
            cbxSpecies.SelectedItem = default;
            rtxNotes.Text = "";
            numDay1.Value = 0;

            MessageBox.Show("Animal Added \n" + "\n"+ na.receipt());
        }
    }
}
