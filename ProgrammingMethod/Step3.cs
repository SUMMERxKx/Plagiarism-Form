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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgrammingMethod
{
    public partial class Step3 : Form
    {
        public Step3()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step3.txt");
            var info = new FileInfo("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step3.txt");

            if (info.Length != 0)
            {
                textBox1.Text = streamReader.ReadLine();
                textBox1.Enabled = false;
                textBox2.Text = streamReader.ReadLine();
                textBox2.Enabled = false;
                textBox3.Text = streamReader.ReadLine();
                textBox3.Enabled = false;
                
            }
            streamReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step3.txt");
            String F_sign1 = textBox1.Text;
            streamWriter.WriteLine(F_sign1);

            String F_name = textBox3.Text;
            streamWriter.WriteLine(F_name);

            String date4 = textBox2.Text;
            streamWriter.WriteLine(date4);


            streamWriter.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
