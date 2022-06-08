using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCommedyOfErrors
{
    public partial class JokeAndPunchline : Form
    {
        public JokeAndPunchline()
        {
            InitializeComponent();
        }

        private void SetUpButton_Click(object sender, EventArgs e)
        {
            Label.Show("What do you call a Sheep and a Kangaroo together?");

        }

        private void PunchlineButton_Click(object sender, EventArgs e)
        {
            Label.Show("A Wooly Jumper!");

        }
    }
}
