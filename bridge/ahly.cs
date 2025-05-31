using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace bridge
{
    public partial class ahly : Form
    {
        public ahly()
        {
            InitializeComponent();
        }

        private void button_ahly_Click(object sender, EventArgs e)
        {
            if (radioButton1_ahly.Checked == true)
            {
                Ahly product = new Ahly();
                product.payprocess(textBox1_ahly.Text, textBox2_ahly.Text);
                payment order_1 = new Paybal();
                order_1.pay("AL Ahly");
                MessageBox.Show("Sucessfully added");
                return;

            }
            else if (radioButton2_ahly.Checked == true)
            {
                Ahly product = new Ahly();
                product.payprocess(textBox1_ahly.Text, textBox2_ahly.Text);
                payment order_1 = new Misa();
                order_1.pay("AL Ahly");
                MessageBox.Show("Sucessfully added");
                return;
            }
            else
            {
                MessageBox.Show("You are selected none !! ");
                return;
            }
        
        }
    }
}
