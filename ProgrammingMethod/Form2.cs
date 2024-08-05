using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingMethod
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Step1 step1 = new Step1();
            step1.Show();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Step2 step2 = new Step2();
            step2.Show();
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Step3 step3 = new Step3();
            step3.Show();
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Step4 step4 = new Step4();
            step4.Show();
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Step5 step5 = new Step5();
            step5.Show();
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show("Saved", "Thanks", buttons);
            
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
