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
        AnimalManager am;

        public SPCA(AnimalManager am)
        {
            this.am = am;
            
            InitializeComponent();
        }

        //Takes user to the AddAnimal Form
        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAnimal window = new AddAnimal(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        //Takes user to the SearchAnimal Form
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAnimal window = new SearchAnimal(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        //Takes user to the Summary Form
        private void btnSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            Summary window = new Summary(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
