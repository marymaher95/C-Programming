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

namespace Maher_Mary_Assignment4_MS806
{
    public partial class ManagementReport : Form
    {
        public ManagementReport()
        {
            InitializeComponent();
        }

        
        public void DisplayManagementReport(string TransID, string TransDate, string AllSelectedItems, string AllSelectedSizes, string AllItemPrices, string NoOfItems, string TotalPrice)
        {
            StreamReader InputFile;
            InputFile = File.OpenText("ManagementReport-" + System.DateTime.Today.ToString("yyyy-MM-dd") + ".txt");


            while (!InputFile.EndOfStream)
            {
                TransID = InputFile.ReadLine();
                TransDate = InputFile.ReadLine();
                AllSelectedItems = InputFile.ReadLine();
                AllSelectedSizes = InputFile.ReadLine();
                AllItemPrices = InputFile.ReadLine();
                NoOfItems = InputFile.ReadLine();
                TotalPrice = InputFile.ReadLine();
                


                    ManagementReportListBox.Items.Add("Transaction ID:" + " " + TransID);
                    ManagementReportListBox.Items.Add("Date of Purchase:" + TransDate);
                    ManagementReportListBox.Items.Add("Selected Items:" + " " + AllSelectedItems);
                    ManagementReportListBox.Items.Add("Selected Size:" + " " + AllSelectedSizes);
                    ManagementReportListBox.Items.Add("Price of Item:" + " " + AllItemPrices);
                    ManagementReportListBox.Items.Add("Number of Items Selected:" + " " + NoOfItems);
                    ManagementReportListBox.Items.Add("Total Price:" + " " + TotalPrice);
                
            }
            InputFile.Close();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
