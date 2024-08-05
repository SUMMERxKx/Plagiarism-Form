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
    public partial class Step4 : Form
    {
        public Step4()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step4.txt");
            var info = new FileInfo("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step4.txt");

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
                textBox5.Text = streamReader.ReadLine(); 
                textBox5.Enabled = false;
                if(streamReader.ReadLine() == "True")
                {
                    checkBox1.Checked = true;

                }
                else
                {
                    checkBox2.Checked = true;
                }
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;

            }
            streamReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step4.txt");
            String ifChecked = textBox1.Text;
            streamWriter.WriteLine(ifChecked);

            String comments = textBox3.Text;
            streamWriter.WriteLine(comments);

            String d_Sign = textBox2.Text;
            streamWriter.WriteLine(d_Sign);

            String d_Name = textBox4.Text;
            streamWriter.WriteLine(d_Name);

            String date3 = textBox5.Text;
            streamWriter.WriteLine(date3);




            streamWriter.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckBox1_Checker(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                textBox1.Enabled = false;
            }
        }

        private void CheckBox2_Checker(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                textBox1.Enabled = true;
            }
        }
    }
}
