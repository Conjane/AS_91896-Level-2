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
    public partial class SPCA : Form
    {

        public Dictionary<string, string> SPCAIndex = new Dictionary<string, string>();
        public List<string> nameList = new List<string>();


        NewAnimal na = new NewAnimal();

        public SPCA()
        {
            InitializeComponent();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

            

            if(Convert.ToInt32(cboBxFood.SelectedItem) == 1)
            {
                na.Day1((int)numFood.Value);
            }
            
            else if (Convert.ToInt32(cboBxFood.SelectedItem) == 2)
            {
                na.Day2((int)numFood.Value);
            }
            
            else if (Convert.ToInt32(cboBxFood.SelectedItem) == 3)
            {
                na.Day3((int)numFood.Value);
            }
            
            else if (Convert.ToInt32(cboBxFood.SelectedItem) == 4)
            {
                na.Day4((int)numFood.Value);
            }
            
            else if (Convert.ToInt32(cboBxFood.SelectedItem) == 5)
            {
                na.Day5((int)numFood.Value);
            }
            
            else if (Convert.ToInt32(cboBxFood.SelectedItem) == 6)
            {
                na.Day6((int)numFood.Value);
            }
            
            else
            {
                na.Day7((int)numFood.Value);
            }

            numFood.Value = 0;
        }

        private void cboBxFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            numFood.Value = 0;
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            na.getName(txtBxName.Text);

            na.getSpecies((string)cboBxSpecies.SelectedItem);

            SPCAIndex.Add(txtBxName.Text, na.recieptGen());

            nameList.Add(txtBxName.Text);

            txtBxName.Clear();
            numFood.Value = 0;
            cboBxSpecies.SelectedItem = "";

            lstBxPetCatalouge.Items.Clear();

            for (int i = 0; i < nameList.Count; i++)
            {
                lstBxPetCatalouge.Items.Add(nameList[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxOutput.Text = SPCAIndex[(string)lstBxPetCatalouge.SelectedItem];
        }
    }
}
