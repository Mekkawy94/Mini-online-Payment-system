using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bridge
{
    public partial class masr : Form
    {
        public masr()
        {
            InitializeComponent();
        }

        private void button_masr_Click(object sender, EventArgs e)
        {
            if (radioButton1_masr.Checked == true)
            {
                MasrBank product = new MasrBank();
                product.payprocess(textBox1_masr.Text, textBox2_masr.Text);
                payment order_1 = new Paybal();
                order_1.pay("Masr");
                MessageBox.Show("Sucessfully added");
                return;

            }
            else if (radioButton2_masr.Checked == true)
            {
                MasrBank product = new MasrBank();
                product.payprocess(textBox1_masr.Text, textBox2_masr.Text);
                payment order_1 = new Misa();
                order_1.pay("Masr");
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
