using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello All ! Welcome to Windows programming..");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            txtData.Text = "I am a Text Box..";
            //to travel to another form
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + " lives in "  + txtCity.Text;
        }

      
    }
}
