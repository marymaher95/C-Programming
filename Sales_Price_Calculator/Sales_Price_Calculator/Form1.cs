using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Price_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal OriginalPrice, DiscountPercentage, DiscountAmount, SalePrice;
            OriginalPrice = decimal.Parse(PriceTextBox.Text);
            DiscountPercentage = decimal.Parse(DiscountTextBox.Text);
            DiscountPercentage = DiscountPercentage / 100;
            DiscountAmount = OriginalPrice * DiscountPercentage;
            SalePrice = OriginalPrice - DiscountAmount;
            OutputLabel.Text = SalePrice.ToString("c2");

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
