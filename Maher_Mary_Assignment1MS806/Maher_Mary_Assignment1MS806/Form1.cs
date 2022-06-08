/*THIS HAS BEEN UPDATED TO INCLUDE CORRECTIONS FROM FEEDBACK
* Student Name: Mary Maher
 * Student ID: 14499808
 * Date:22/10/2020
 * Assignment: 1
 * Assignment: Create a well designed application that allows "Sult Bar & Restaurant" staff 
 * to take table orders from bar customers
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

namespace Maher_Mary_Assignment1MS806
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Field Variables - declared as integers and decimals  needed for summation
        int TotalNumberOfPizzasPerTable;
        decimal TotalTableReceipts;
        int TotalCompanyTransactions;
        int TotalNumberOfPizzasSummary;
       
        //Constant fields - prices and service charge to remain constant
        const decimal MARGHERITAPIZZAPRICE= 9.00m;
        const decimal PEPPERONIPIZZAPRICE = 11.50m;
        const decimal HAMPINEAPPLEPIZZAPRICE= 12.79m;
        const decimal SERVICE_CHARGE = 2.49m;

        /*StartButton Event Handler - When Start button is pressed by user it brings user to 
        Order Screen in which they can input pizza order - it causes the server name + table 
        number inputted by user to be displayed in forms text property */
        
        private void StartButton_Click(object sender, EventArgs e)
        {
            //Bring in user input + display as text property of form - Toggle visability
            this.Text = ServerNameTextBox.Text + " " + "@ Table Number "  + TableNumberTextBox.Text;
            StartPanel.Visible = false;
            PizzaGroupBox.Visible = true;
            ButtonPanel.Visible = true;
            SultPictureBox.Visible = true;

            //Set default values of textboxes to 0 - Set focus to textbox
            MargheritaPizzaTextBox.Text = "0";
            PepperoniPizzaTextBox.Text = "0";
            HamPineapplePizzaTextBox.Text = "0";
            MargheritaPizzaTextBox.Focus();
            MargheritaPizzaTextBox.SelectAll();

        }
        /*OrderButton Event Handler - performs pizza order per table calculations and displays them 
        and the servers name in the relevant output labels in the Table Order Summary Data GroupBox */
       
        private void OrderButton_Click(object sender, EventArgs e)
        {
            try
            {//Local variables
                int NumberOfMargheritaPizzas;
                int NumberOfPepperoniPizzas;
                int NumberOfHampineapplePizzas;
                //Convert string input to integer
                NumberOfMargheritaPizzas = int.Parse(MargheritaPizzaTextBox.Text);

                try
                {//Convert string input to integer
                    
                    NumberOfPepperoniPizzas = int.Parse(PepperoniPizzaTextBox.Text);

                    try
                    {//Convert string input to integer
                        
                        NumberOfHampineapplePizzas = int.Parse(HamPineapplePizzaTextBox.Text);

                        //Calculate number of pizzas per table - Display in output label
                        TotalNumberOfPizzasPerTable = NumberOfMargheritaPizzas + 
                            NumberOfPepperoniPizzas + NumberOfHampineapplePizzas;
                       
                        TotalPizzasLabel.Text = TotalNumberOfPizzasPerTable.ToString();

                        //Calculate total table receipts + service charge - Display in output label as €
                        TotalTableReceipts = (NumberOfMargheritaPizzas * MARGHERITAPIZZAPRICE)
                           + (NumberOfPepperoniPizzas * PEPPERONIPIZZAPRICE)
                           + (NumberOfHampineapplePizzas * HAMPINEAPPLEPIZZAPRICE) + SERVICE_CHARGE;

                        TotalTableReceiptsLabel.Text = TotalTableReceipts.ToString("c");

                        //Calculate total number of transactions - Display in output label
                        TotalCompanyTransactions += 1;
                        TotalCompanyTransactionsLabel.Text = TotalCompanyTransactions.ToString();

                        //Toggle control visability
                        StartPanel.Visible = false;
                        PizzaGroupBox.Visible = true;
                        ButtonPanel.Visible = true;
                        SultPictureBox.Visible = true;
                        TableOrderGroupBox.Visible = true;
                        CompanySummaryGroupBox.Visible = false;

                        //Disable groupbox and order button so user cannot press order again before clearing
                        PizzaGroupBox.Enabled = false;
                        OrderButton.Enabled = false;
                        SummaryButton.Enabled = true;

                        

                        //Display servers name as text proerty
                        ServerNameLabel.Text = ServerNameTextBox.Text;
                    }
                    catch
                    { //Exception handler message shown if user input is invalid (not an integer)
                        MessageBox.Show("Sorry Whole Number Expected For Ham Pineapple Pizza Order",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        HamPineapplePizzaTextBox.Focus();
                        HamPineapplePizzaTextBox.SelectAll();
                    }

                }
                catch
                { //Exception handler message shown if user input is invalid (not an integer)
                    MessageBox.Show("Sorry Whole Number Expected For Pepperoni Pizza Order",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PepperoniPizzaTextBox.Focus();
                    PepperoniPizzaTextBox.SelectAll();
                }
            }
             catch
            {  //Exception handler message shown if user input is invalid (not an integer)
                MessageBox.Show("Sorry Whole Number Expected For Margherita Pizza Order", 
                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MargheritaPizzaTextBox.Focus();
                MargheritaPizzaTextBox.SelectAll();
            }
 
        }
        /*SummaryButton Event Handler - performs total pizza order and transaction calculations and 
        displays them in the relevant output labels in the Company Summary Data GroupBox */
         private void SummaryButton_Click(object sender, EventArgs e)
        {
            //Local variables 
            decimal TotalCompanyReceipts;
            decimal AvgTransactionValue;

            //Calculations to be displayed in Company Summary Data GroupBox 

            //Calculate total company transaction - Display in output label
            TotalNumberOfPizzasSummary += TotalNumberOfPizzasPerTable;
            TotalNumberPizzaSummaryLabel.Text = TotalNumberOfPizzasSummary.ToString("n0");

            //Calculate total number of receipts - Display in output label
            TotalCompanyReceipts = TotalTableReceipts * TotalCompanyTransactions;
            TotalCompanyReceiptsLabel.Text = TotalCompanyReceipts.ToString("c");

            //Calculate avg tranactions - Display in output label
            AvgTransactionValue = TotalCompanyReceipts / TotalCompanyTransactions;
            AvgTransactionValueLabel.Text = AvgTransactionValue.ToString("c");

            //toggle visability
            StartPanel.Visible = false;
            PizzaGroupBox.Visible = false;
            ButtonPanel.Visible = true;
            SultPictureBox.Visible = true;
            TableOrderGroupBox.Visible = false;
            CompanySummaryGroupBox.Visible = true;
            OrderButton.Enabled = false;
            SummaryButton.Enabled = true;

           
            //Change form text property to suit company summary data display
            Text = "Sult Company Summary Data";

        }
        /*ClearButton Event Handler - Resets form for next user - brings user back to start screen 
        - Allows for another user to input an order*/
          private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear textboxes for next users input
            ServerNameTextBox.Text = " ";
            TableNumberTextBox.Text = " ";

            //Toggle Visability 
            StartPanel.Visible = true;
            PizzaGroupBox.Visible = false;
            ButtonPanel.Visible = false;
            SultPictureBox.Visible = false;
            TableOrderGroupBox.Visible = false;
            CompanySummaryGroupBox.Visible = false;

            //set focus
            
            ServerNameTextBox.Focus();
            ServerNameTextBox.SelectAll();

            //Change form text property to suit start screen
            Text = "Welcome to Sult";

            //Enable PizzaGroupBox and Order button for next user
            PizzaGroupBox.Enabled = true;
            OrderButton.Enabled = true;
        }
        //ExitButton Event Handler - Allows user to exit application - the form closes
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
