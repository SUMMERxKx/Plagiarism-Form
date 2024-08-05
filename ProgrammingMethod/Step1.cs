using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgrammingMethod
{
    public partial class Step1 : Form
    {
        public Step1()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step1.txt");
            var info = new FileInfo("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step1.txt");
             
            if (info.Length != 0 ) {
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
                textBox6.Text = streamReader.ReadLine();
                textBox6.Enabled = false;
                textBox7.Text = streamReader.ReadLine();
                textBox7.Enabled = false;
                textBox8.Text = streamReader.ReadLine();
                textBox8.Enabled = false;
                textBox9.Text = streamReader.ReadLine();
                textBox9.Enabled = false;
                textBox10.Text = streamReader.ReadLine();
                textBox10.Enabled = false;
                textBox11.Text = streamReader.ReadLine();
                textBox11.Enabled = false;
                textBox12.Text = streamReader.ReadLine();
                textBox12.Enabled = false;
                textBox13.Text = streamReader.ReadLine();
                textBox13.Enabled = false;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            streamReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step1.txt");
            String name = textBox1.Text;
            streamWriter.WriteLine(name);

            String id = textBox2.Text;
            streamWriter.WriteLine(id);

            String email = textBox3.Text;
            streamWriter.WriteLine(email);

            String f_name = textBox4.Text;
            streamWriter.WriteLine(f_name);

            String date = textBox5.Text;
            streamWriter.WriteLine(date);

            String course = textBox6.Text;
            streamWriter.WriteLine(course);

            String assignment = textBox7.Text;
            streamWriter.WriteLine(assignment);
                
            String department  = textBox8.Text;
            streamWriter.WriteLine(department);

            String term = textBox9.Text;
            streamWriter.WriteLine(term);

            String description = textBox10.Text;
            streamWriter.WriteLine(description);

            String f_sign = textBox12.Text;
            streamWriter.WriteLine(f_sign);

            String f_name1 = textBox13.Text;
            streamWriter.WriteLine(f_name1);

            String date2 = textBox11.Text;
            streamWriter.WriteLine(date2);

            streamWriter.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckBox1_checker(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled=false;
            }
        }

        private void Checkbox2_checker(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
