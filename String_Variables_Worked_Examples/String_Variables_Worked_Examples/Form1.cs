using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Variables_Worked_Examples
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string FullName;

            FullName = FirstNameTextBox.Text + " " + LastNameTextBox.Text;

            OutputLabel.Text = FullName;


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
