using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Challenges
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        frnHighLow fr1 = new frnHighLow();
        frnNameGenerator generator = new frnNameGenerator();

        private void btn3_Click(object sender, EventArgs e)
        {
            fr1.Show();
        }

        private void btnNameGenerator_Click(object sender, EventArgs e) {
            generator.Show();
        }
    }
}
