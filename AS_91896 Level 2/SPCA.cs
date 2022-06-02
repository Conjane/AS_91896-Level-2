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
        //Global Variables
        public Random rd = new Random();
        public Dictionary<int, string> SPCAIndex = new Dictionary<int, string>();
        public List<int> codeList = new List<int>();

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

            int petCode = rd.Next(1000, 9999);

            na.getDetails(txtBxName.Text, (string)cboBxSpecies.SelectedItem, petCode);

            SPCAIndex.Add(petCode, na.recieptGen());

            codeList.Add(petCode);

            rtxOutput.Text = na.recieptGen();

            txtBxName.Clear();
            numFood.Value = 0;
            cboBxSpecies.SelectedItem = "";

            lstBxPetCatalouge.Items.Clear();

            for (int i = 0; i < codeList.Count; i++)
            {
                lstBxPetCatalouge.Items.Add(codeList[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                rtxOutput.Text = SPCAIndex[(int)lstBxPetCatalouge.SelectedItem];
            }
            catch (Exception)
            {
                rtxOutput.Text = "Please select a valid item";
            }
        }
    }
}
