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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(CommonButtonClickHandler);
            button2.Click += new EventHandler(CommonButtonClickHandler);
        }

        private void CommonButtonClickHandler(object sender, EventArgs e)
        {
            Button clickedbutton = (Button)sender;  //sender as Button
            if(clickedbutton != null )
            {
                MessageBox.Show($"Button {clickedbutton.Name} was clicked");

            }
        }
    }
}
