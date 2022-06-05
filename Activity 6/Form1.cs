using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numSeconds = int.Parse(userInput.Text);
            if (numSeconds >= 86400)
            {
                int numDays = numSeconds / 86400;
                conversion.Text = numDays + " days";
            }
            else if (numSeconds >= 3600) {
                int numHours = numSeconds / 3600;
                conversion.Text = numHours + " hour(s)";
            }
            else if (numSeconds >= 60)
            {
                int numMinutes = numSeconds / 60;
                conversion.Text = numMinutes + " minutes";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
