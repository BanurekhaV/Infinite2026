using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaskPrj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("DataFile.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        
        private async void button1_Click(object sender, EventArgs e)
        {
            //working asynchronously

            label1.Text = textBox1.Text;
            label1.Visible = true;
            Task<int> mytask = new Task<int>(CountCharacters);
            mytask.Start();
            label1.Text = "Processing File Count Job... Please Wait";
            textBox1.Text = "Waiting for the job to be done";
            int z = await mytask;  // await waits for the task to complete and return the value if there is any
            label1.Text = z.ToString() + " " + "Characters Found in the File";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1. Work with synchronous programming
            label1.Text = textBox1.Text;
            label1.Visible = true;
            int z = CountCharacters();  //calling the function
            label1.Text = "Processing File Count Job... Please Wait";
            textBox1.Text = "Waiting for the job to be done";
            label1.Text = z.ToString();

        }
    }
}
