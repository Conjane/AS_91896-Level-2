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
        AnimalManager am;
        public int ID;

        public AddAnimal(AnimalManager am)
        {
            this.am = am;
            
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            SPCA window = new SPCA(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }


        public void btnAddAnimal_Click(object sender, EventArgs e)
        {
            ID = am.animals.Count() + 1;

            NewAnimal na = new NewAnimal();
            
            na.SetDetails(txtbxName.Text, (int)numAge.Value, (string)cbxSpecies.SelectedItem, (string)rtxNotes.Text, ID);
            na.SetConsumption((int)numDay1.Value, (int)numDay2.Value, (int)numDay3.Value, (int)numDay4.Value,
                            (int)numDay5.Value, (int)numDay6.Value, (int)numDay7.Value);

            am.addAnimal(na);
            
            txtbxName.Text = "";
            numAge.Value = 0;
            cbxSpecies.SelectedItem = default;
            rtxNotes.Text = "";

            MessageBox.Show("Animal Added \n" + "\n"+ na.reciept());
        }
    }
}
