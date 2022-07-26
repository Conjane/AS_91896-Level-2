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
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            SPCA window = new SPCA(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
