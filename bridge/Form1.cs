using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bridge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void masr_1_Click(object sender, EventArgs e)
        {
            masr showform = new masr();
            showform.ShowDialog();
        }

        private void alex_1_Click(object sender, EventArgs e)
        {
            alex showform = new alex();
            showform.ShowDialog();
        }

        private void ahly_1_Click(object sender, EventArgs e)
        {
            ahly showform = new ahly();
            showform.ShowDialog();
        }
    }
}
