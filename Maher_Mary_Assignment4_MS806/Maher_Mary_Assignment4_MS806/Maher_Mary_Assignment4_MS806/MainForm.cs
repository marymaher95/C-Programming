/* Student Name: Mary Maher
 * Student ID: 14499808
 * Date:18/01/2021
 * Assignment: 4
 */

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
    public partial class MainForm : Form
    {
       
        //Array for clothing items 
        readonly static string[] Items = { "T-Shirt White","T-Shirt Black", "T-Shirt Grey", "Hoody Red", "Hoody Black", "Hoody Grey",
            "Fleece Red","Fleece Black","Fleece Grey", "Leggings Grey","Leggings Black", "Shorts Grey", "Shorts Black" };
        //Array for clothing sizes
        readonly static string[] Sizes = { "XS", "S", "M", "L", "XL" };

        //2D array for Price of items - different prices per items and size
        readonly static decimal[,] ItemCost =   {{ 15m, 15m, 20m, 20m, 25m},
                                                 { 15m, 15m, 20m, 20m, 25m},
                                                 { 15m, 15m, 20m, 20m, 25m},

                                                 { 30m, 30m, 35m, 35m, 40m},
                                                 { 30m, 30m, 35m, 35m, 40m},
                                                 { 30m, 30m, 35m, 35m, 40m},

                                                 { 30m, 30m, 35m, 35m, 40m},
                                                 { 30m, 30m, 35m, 35m, 40m},
                                                 { 30m, 30m, 35m, 35m, 40m},

                                                 { 25m, 25m, 30m, 30m, 35m},
                                                 { 25m, 25m, 30m, 30m, 35m},

                                                 { 20m, 20m, 25m, 25m, 30m},
                                                 { 20m, 20m, 25m, 25m, 30m}};
        //2D Array for available stock - different stock values of different sized clothing items
             readonly static int[,] StockAvailable = {{ 2, 2, 2, 2, 2},
                                                      { 2, 2, 2, 2, 2},
                                                      { 2, 2, 2, 2, 2},
                                                      { 3, 3, 3, 3, 3},
                                                      { 3, 3, 3, 3, 3},
                                                      { 3, 3, 3, 3, 3},
                                                      { 3, 3, 3, 3, 3},
                                                      { 3, 3, 3, 3, 3},
                                                      { 3, 3, 3, 3, 3},
                                                      { 2, 2, 2, 2, 2},
                                                      { 2, 2, 2, 2, 2},
                                                      { 1, 1, 1, 1, 1},
                                                      { 1, 1, 1, 1, 1}};
        //2D Array - a replica of the stock available array - created so that it can be edited throughout the process of transaction without affecting the set stock available array
                static  int[,] TempStock = {{ 2, 2, 2, 2, 2},
                                                     { 2, 2, 2, 2, 2},
                                                     { 2, 2, 2, 2, 2},
                                                     { 3, 3, 3, 3, 3},
                                                     { 3, 3, 3, 3, 3},
                                                     { 3, 3, 3, 3, 3},
                                                     { 3, 3, 3, 3, 3},
                                                     { 3, 3, 3, 3, 3},
                                                     { 3, 3, 3, 3, 3},
                                                     { 2, 2, 2, 2, 2},
                                                     { 2, 2, 2, 2, 2},
                                                     { 1, 1, 1, 1, 1},
                                                     { 1, 1, 1, 1, 1}};

        //used for loops with arrays
        const int SizeOfRow = 13, SizeOfColumn = 5;
     

        //storing different data variables
        int NumberOfItems, FullStock, UpdatedStock;
        decimal ItemPrice, TotalPriceOfOrder, TotalPriceOfAllOrders, NumberofTransactions, NumberOfItemsSold, ItemsPrice;
        string TotalNumberOfItemsSold, TotalSales;
        string SelectedItem, SelectedSize,
            TransID, TransDate, AllSelectedItems, AllSelectedSizes, AllItemPrices, TotalPrice, NoOfItems, EveryItemTypeSold, EveryItemSizeSold;
        
        //for form sizing so that it can be adjusted when searching transactions
        const int INCREMENT = 2, FORMWIDTH = 890, FORMSTARTHEIGHT = 430, FORMEXPANDHEIGHT = 530; 

        StreamReader InputFile;
        

        public MainForm()
        {
            InitializeComponent();
        }
        
        
        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            AddToOrderButton.Enabled = true;
        }

        //Addind selected items and sizes to the order - selected items and details will appear in a listbox as a quotation. 
        //labels showing prices, number of items ordered, items remaining in stock - to display such info for the user
        private void AddToOrderButton_Click(object sender, EventArgs e)
        {   int ItemIndex = ItemListBox.SelectedIndex;
            int SizeIndex = SizeListBox.SelectedIndex;
            int Quantity = Convert.ToInt32(QuantityNumericUpDown.Value);

            //making sure items and sizes are selected
            if (ItemIndex != -1 && SizeIndex != -1)
            {
                SelectedItem = Items[ItemListBox.SelectedIndex];
                SelectedSize = Sizes[SizeListBox.SelectedIndex];
                ItemPrice = ItemCost[ItemIndex, SizeIndex];
                FullStock = StockAvailable[ItemIndex, SizeIndex];
                UpdatedStock = TempStock[ItemIndex, SizeIndex] - Quantity;
                //making sure there is enough stock first before proceeding with order
                if (UpdatedStock >=0 && UpdatedStock <= FullStock) {

                    for (int row = 0; row < SizeOfRow; row++)
                    {
                        for (int col = 0; col < SizeOfColumn; col++)
                        {
                             TempStock[ItemIndex, SizeIndex] = UpdatedStock;
                            AvailableStockLabel.Text = UpdatedStock.ToString();
                         }
                    }

                    OrderListBox.Items.Add(SelectedItem + " " + SelectedSize + " " +
                         " " +  " " + ItemPrice.ToString("c2") + " " + "x" + Quantity);

                    AllSelectedItems += SelectedItem + " ";
                    AllSelectedSizes += SelectedSize + " ";
                    AllItemPrices += ItemPrice.ToString("C2") + " ";
                    ItemsPrice = ItemPrice * Quantity;
                    TotalPriceOfOrder += ItemsPrice;
                    NumberOfItems += Quantity;
                    NoOfItems = NumberOfItems.ToString();

                    NumberOfItemsLabel.Text = NoOfItems.ToString();
                    PriceLabel.Text = ItemPrice.ToString("C2");
                    TotalPrice = TotalPriceOfOrder.ToString("C2");
                    TotalPriceLabel.Text = TotalPrice;
                  }
                //message box informing there is not enough stock for requested amount 
                //- allows user to go back to selecting other items or different quantities
                else
                { MessageBox.Show("Can not purchase " + Quantity + " " + "\n" + "Only" + " " + FullStock + " " + "in stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

                ItemListBox.SelectedIndex = -1;
                SizeListBox.SelectedIndex = -1;
               

            }
            else
            {
                MessageBox.Show("Please select an item and/or size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            QuantityNumericUpDown.Value = 0;
            ConfirmSaleButton.Enabled = true;
            
        }
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
 
        private void ConfirmSaleButton_Click(object sender, EventArgs e)
        {//assigning a tranaction number and date to each processed transaction
            Random TransactionID = new Random();
            TransID = TransactionID.Next(0, 999999).ToString();
            TransIDLabel.Text = TransID;
            
            DateTime TransactionDate_Time = DateTime.Now;
            TransDate = TransactionDate_Time.ToShortDateString();
            Date_TimeLabel.Text = TransDate;

            //message box looking for confirmation of order - user can cancel and form is clear to use again

            MessageBox.Show("\n Items Selected:  " + AllSelectedItems
             + "\n" + "Total cost is " + TotalPriceOfOrder.ToString("C2") + 
             "\n\n Do you wish to proceed with the order ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //transaction id and date are displayed on the form and given on the form as labels for user to see
            TransIDDisplayLabel.Visible = true;
            TransIDLabel.Visible = true;
            Date_TimeDisplayLabel.Visible = true;
            Date_TimeLabel.Visible = true;
            //a message box for once order is confirmed
            var result = MessageBox.Show("Order Confirmed" + "\n" + " Transaction ID:" + ""
                 + TransID + "" + "\n"
                 + TransDate + "" + "\n"
                 , "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //when order is confirmed the transaction details are saved to a txt files, 1 for transactions, 1 for management report and another one for daily sales details
            if (result == DialogResult.OK)
            {
                NumberofTransactions++;

                StreamWriter OutputFile;
                OutputFile = File.AppendText("SearchTransactionFile-" + System.DateTime.Today.ToString("yyyy-MM-dd") + ".txt");
                OutputFile.WriteLine(TransID);
                OutputFile.WriteLine(TransDate);
                OutputFile.WriteLine(AllSelectedItems);
                OutputFile.WriteLine(AllSelectedSizes);
                OutputFile.WriteLine(AllItemPrices);
                OutputFile.WriteLine(NoOfItems);
                OutputFile.WriteLine(TotalPrice);

                 OutputFile.Close();

                
                StreamWriter OutputFile1;
                OutputFile1 = File.AppendText("ManagementReport-" + System.DateTime.Today.ToString("yyyy-MM-dd") + ".txt");

                OutputFile1.WriteLine(TransID);
                OutputFile1.WriteLine(TransDate);
                OutputFile1.WriteLine(AllSelectedItems);
                OutputFile1.WriteLine(AllSelectedSizes);
                OutputFile1.WriteLine(AllItemPrices);
                OutputFile1.WriteLine(NoOfItems);
                OutputFile1.WriteLine(TotalPrice);

                OutputFile1.Close();

                //a string for how I want the file to be saved to aid in identifying a particular file
                string SalesFile = "DailySales-" + System.DateTime.Today.ToString("yyyy-MM-dd") + ".txt";
                StreamWriter OutputFile2;

                OutputFile2 = File.CreateText(SalesFile);
                string SalesReport = "Date:" + DateTime.Today.ToString("yyyy-MM-dd") + "          " +
                "Time:" + DateTime.Now.ToString("HH:mm:ss");

                TotalPriceOfAllOrders = TotalPriceOfOrder++;
                TotalSales = TotalPriceOfAllOrders.ToString("c2");
                NumberOfItemsSold = NumberOfItems++;
                TotalNumberOfItemsSold = NumberOfItemsSold.ToString();
                EveryItemTypeSold = AllSelectedItems;
                EveryItemSizeSold = AllSelectedSizes;

                OutputFile2.WriteLine(TotalSales);
                OutputFile2.WriteLine(TotalNumberOfItemsSold);
                OutputFile2.WriteLine(EveryItemTypeSold);
                OutputFile2.WriteLine(EveryItemSizeSold);
                
                OutputFile2.Close();
                


                Clear();
            }
            else
            {
                Clear();

            }
            
        }
        private void SearchTransactionButton_Click(object sender, EventArgs e)
        {
            SearchTransactionGroupBox.Visible = true;
            DailySalesGroupBox.Visible = false;
            for (int i = FORMSTARTHEIGHT; i < FORMEXPANDHEIGHT; i += INCREMENT)
            {
                this.Size = new Size(FORMWIDTH, i);
                this.Update();
                System.Threading.Thread.Sleep(1);
            }
        }
        //can search previous transactions by transaction ID or date transaction was made - details will be read in from file and displayed in a listbox
        private void SearchButton_Click(object sender, EventArgs e)
        {
            TransactionListBox.Visible = true;
           
            string SearchTransID = EnterTransIDTextBox.Text;
            string SearchTransDate = EnterTransDateTextBox.Text;

            InputFile = File.OpenText("SearchTransactionFile-" + System.DateTime.Today.ToString("yyyy-MM-dd") + ".txt");
            
            while (!InputFile.EndOfStream)
            {
                TransID = InputFile.ReadLine();
                TransDate = InputFile.ReadLine();
                AllSelectedItems = InputFile.ReadLine();
                AllSelectedSizes = InputFile.ReadLine();
                AllItemPrices = InputFile.ReadLine();
                NoOfItems = InputFile.ReadLine();
                TotalPrice = InputFile.ReadLine();


                if ((SearchTransID == TransID) || (SearchTransDate == TransDate))
                {
                    TransactionListBox.Items.Clear();


                    TransactionListBox.Items.Add("Transaction ID:" + " " + TransID);
                    TransactionListBox.Items.Add("Date of Purchase:" + TransDate);
                    TransactionListBox.Items.Add("Selected Items:" + " " + AllSelectedItems);
                    TransactionListBox.Items.Add("Selected Size:" + " " + AllSelectedSizes);
                    TransactionListBox.Items.Add("Price of Item:" + " " + AllItemPrices);
                    TransactionListBox.Items.Add("Number of Items Selected:" + " " + NoOfItems);
                    TransactionListBox.Items.Add("Total Price:" + " " + TotalPrice);

                }
                
            }
            InputFile.Close();

            EnterTransIDTextBox.Clear();
            EnterTransIDTextBox.Focus();
            EnterTransDateTextBox.Clear();

        }
        //daily sales information is read in from file and displayed in a listbox once user presses the Daily Sales Button
        private void DailySalesButton_Click(object sender, EventArgs e)
        {

            StreamReader InputFile1;
            InputFile1 = File.OpenText("DailySales-" + System.DateTime.Today.ToString("yyyy-MM-dd") + ".txt");

            while (!InputFile1.EndOfStream)
            {
                TotalSales = InputFile1.ReadLine();
                TotalNumberOfItemsSold = InputFile1.ReadLine();
                EveryItemTypeSold = InputFile1.ReadLine();
                EveryItemSizeSold = InputFile1.ReadLine();


                SalesReportListBox.Items.Clear();

                SalesReportListBox.Items.Add("Total Sales:" + " " + TotalSales);
                SalesReportListBox.Items.Add("Total No Of Items Sold:" + " " + TotalNumberOfItemsSold);
                SalesReportListBox.Items.Add("Types of Items Sold" + " " + EveryItemTypeSold);
                SalesReportListBox.Items.Add( "Sizes of Items Sold" + " " + EveryItemSizeSold);
                
            }
            InputFile1.Close();

            

            SearchTransactionGroupBox.Visible = false;
            SalesReportListBox.Visible = true;
            DailySalesGroupBox.Visible = true;
            for (int i = FORMSTARTHEIGHT; i < FORMEXPANDHEIGHT; i += INCREMENT)
            {
                this.Size = new Size(FORMWIDTH, i);
                this.Update();
                System.Threading.Thread.Sleep(1);
            }
        }
        
        //by pressing the management report button a new form will display with a listbox of the relevant details read in from the management report text file

        private void ManagementReportButton_Click(object sender, EventArgs e)
        {
            //creating class for Management Report Form
            
            ManagementReport Report = new ManagementReport();
   
         Report.DisplayManagementReport(TransID, TransDate, AllSelectedItems, AllSelectedSizes,AllItemPrices, NoOfItems, TotalPrice);
            Report.ShowDialog();


        }

       //Stock is written out to file once the exit button is cleared, as an end of day process - updated stock.
        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            
            //a string for how I want the file to be saved to aid in identifying a particular file
            string StockFile = "StockFile-" + System.DateTime.Today.ToString("yyyy-MM-dd") + ".txt";
            StreamWriter OutputFile;

            OutputFile = File.CreateText(StockFile);
            string StockReport =  "Date:" + DateTime.Today.ToString("yyyy-MM-dd") + "          " +
            "Time:" + DateTime.Now.ToString("HH:mm:ss") + "\r\n" + "Items\t\t Size\tStart Stock\tCurrent Stock\n";
            OutputFile.Write(StockReport);

             foreach ( string i in Items)
            {foreach(string j in Sizes)
                {
                    OutputFile.WriteLine(i + "    " + j + "          " + FullStock + "          " + UpdatedStock);
                    
                    
                }

            }
           

            OutputFile.Close();
            this.Close();
 
        }
        //able to clear so another search can be preformed
        private void ClearTransIDButton_Click(object sender, EventArgs e)
        {
            EnterTransIDTextBox.Clear();
            TransactionListBox.Visible = false;
        }
        //clear method - clearing textboxes, listboxes, labels and toggling visability
          private void Clear()
        {
            TransIDDisplayLabel.Visible = false;
            TransIDLabel.Visible = false;
            TransIDLabel.Text = " ";
            Date_TimeDisplayLabel.Visible = false;
            Date_TimeLabel.Visible = false;
            Date_TimeLabel.Text = " ";
            OrderListBox.Items.Clear();
            ItemListBox.SelectedIndex = -1;
            SizeListBox.SelectedIndex = -1;
            

            AvailableStockLabel.Text = "";
            PriceLabel.Text = "";
            TotalPriceLabel.Text = "";
            NumberOfItemsLabel.Text = "";

            SalesReportListBox.Items.Clear();

            SizeListBox.Focus();
             if (SearchTransactionGroupBox.Visible || DailySalesGroupBox.Visible)
            {
                for (int i = 530; i > 350; i -= INCREMENT)
                {
                    this.Size = new Size(FORMWIDTH, i);
                    this.Update();
                    System.Threading.Thread.Sleep(1);
                }
            }
          }
        
    }
}

