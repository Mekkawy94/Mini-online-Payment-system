using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bridge
{
    public partial class alex : Form
    {
        public alex()
        {
            InitializeComponent();
        }

        private void button_alex_Click(object sender, EventArgs e)
        {
            if (radioButton1_alex.Checked == true)
            {
                AlexBank product = new AlexBank();
                product.payprocess(textBox1_alex.Text, textBox2_alex.Text);
                payment order_1 = new Paybal();
                order_1.pay("Alex");
                MessageBox.Show("Sucessfully added");
                return;

            }
            else if (radioButton2_alex.Checked == true)
            {
                AlexBank product = new AlexBank();
                product.payprocess(textBox1_alex.Text, textBox2_alex.Text);
                payment order_1 = new Misa();
                order_1.pay("Alex");
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
