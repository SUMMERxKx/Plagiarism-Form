using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProgrammingMethod
{
    public partial class Step2 : Form
    {
        public Step2()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step2.txt");
            var info = new FileInfo("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step2.txt");

            if (info.Length != 0)
            {
                textBox1.Text = streamReader.ReadLine();
                textBox1.Enabled = false;
                textBox2.Text = streamReader.ReadLine();
                textBox2.Enabled = false;
                textBox3.Text = streamReader.ReadLine();
                textBox3.Enabled = false;
                textBox4.Text = streamReader.ReadLine();
                textBox4.Enabled = false;
                checkBox1.Checked = true;
                checkBox1.Enabled = false;
            }
            streamReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step2.txt");
            String S_name = textBox1.Text;
            streamWriter.WriteLine(S_name);

            String sign = textBox3.Text;
            streamWriter.WriteLine(sign);

            String email = textBox2.Text;
            streamWriter.WriteLine(email);

            String date3 = textBox4.Text;
            streamWriter.WriteLine(date3);

            

            streamWriter.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckBox1_Checker(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }


            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void CheckBox2_checker(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }
    }
}
