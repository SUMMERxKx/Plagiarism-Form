using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgrammingMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdatePBar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step1.txt", "");
            File.WriteAllText("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step2.txt", "");
            File.WriteAllText("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step3.txt", "");
            File.WriteAllText("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step4.txt", "");
            File.WriteAllText("C:\\Users\\acer\\source\\repos\\ProgrammingMethod\\Step5.txt", "");
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FileChecker() == 0)
            {
                DialogResult res = MessageBox.Show("There are no Forms", "Error", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                {
                    return;
                }

            }
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int FileChecker()
        {
            string[] filePaths = {
        @"C:\Users\acer\source\repos\ProgrammingMethod\Step1.txt",
        @"C:\Users\acer\source\repos\ProgrammingMethod\Step2.txt",
        @"C:\Users\acer\source\repos\ProgrammingMethod\Step3.txt",
        @"C:\Users\acer\source\repos\ProgrammingMethod\Step4.txt",
        @"C:\Users\acer\source\repos\ProgrammingMethod\Step5.txt"
    };

            return filePaths.Count(filePath => new FileInfo(filePath).Length > 0);
        }


        public void UpdatePBar()
        {
            int i = FileChecker();
            int load = (i * 100) / 5;
            progressBar1.Value = load;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        void search()
        {
            var pyExecutable = @"C:\Users\acer\AppData\Local\Programs\Python\Python310\python.exe";
            var srcPath = @"C:\Users\acer\source\repos\ProgrammingMethod\script.py";
            var step1 = @"C:\Users\acer\source\repos\ProgrammingMethod\Step1.txt";
            var step2 = @"C:\Users\acer\source\repos\ProgrammingMethod\Step2.txt";
            var step3 = @"C:\Users\acer\source\repos\ProgrammingMethod\Step3.txt";
            var step4 = @"C:\Users\acer\source\repos\ProgrammingMethod\Step4.txt";
            var step5 = @"C:\Users\acer\source\repos\ProgrammingMethod\Step5.txt";
            var searchTerm = textBox1.Text;

            var startInfo = new ProcessStartInfo();
            startInfo.FileName = pyExecutable;
            startInfo.Arguments = $"\"{srcPath}\" \"{step1}\" \"{step2}\" \"{step3}\" \"{step4}\" \"{step5}\" \"{searchTerm}\"";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            using (var process = Process.Start(startInfo))
            {
                using (var reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    textBox2.Text = result;
                    textBox2.Enabled = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
