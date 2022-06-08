using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Student Name: Mary Maher
 * Student ID: 14499808
 * Date:13/11/2020
 * Assignment: 2
 * Assignment: Create a well-designed application for Mild Atlantic Bus Tours 
 * that will generate prices and process bookings
 */

namespace MaryMaher_Assignment2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
    
        }

        const decimal CLIFFS_PRICE = 55M, KYLEMORE_PRICE = 50M, BUNRATTY_PRICE = 75M,
            BURREN_PRICE = 45M, CONNEMARA_PRICE = 75M, BELMULLET_PRICE = 99M,
            LUNCH_PRICE = 11.50M,
            FIVESTAR_PRICE = 100M, FOURSTAR_PRICE = 75M, THREESTAR_PRICE = 55M, NOHOTEL_PRICE = 0M,
            MAINDISCOUNT = 7.5M,
            DISCOUNT7AM = 20M, DISCOUNT8AM = 10M, DISCOUNT9AM = 15M, DISCOUNT10AM = 0M,
            DISCOUNT11AM = 0M, DISCOUNT1300 = 25M;

        decimal TotalTripFees, AvgRevenuePerBooking, ValueofHotelStays, ValueofLunch, OverallCost,
                TripCost, HotelCost, LunchCost;
        int     TotalNoOfTransactions, NoOfGuests;
        string  DepartureTime = " ", HotelChosen = " ", Location =" ";

        /*This Display button event handler is the main feature of the application. 
        It stores input values, performs calculations and displays the returned output values for user to see*/
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            decimal LocationCost = 0m, DepartureTimeDiscount = 0m, DiscountedAmount,
                    HotelPrice, CostBeforeDiscount;
            int     LocationIndex, DepartureTimeIndex;
            string  CLIFFS = "Cliffs of Moher", KYLEMORE = "Kylemore Abbey", BUNRATTY = "Bunratty Castle",
            BURREN = "The Burren", CONNEMARA = "Connemara", BELMULLET = "Belmullet",
            DEPTIME7 = "07:00", DEPTIME8 = "08:00",
            DEPTIME9 = "09:00", DEPTIME10 = "10:00", DEPTIME11 = "11:00", DEPTIME1300 = "13:00",
            FIVESTAR = "5 Star Hotel", FOURSTAR = "4 Star Hotel",
            THREESTAR = "3 Star Hotel", NOHOTEL = "No Hotel";


            //grouped the compulsory decisions together in if, else if statements and switch statements
            /*if there are 3 or more guests the label displaying the discount information will appear 
             * to prompt salesperson/user to encourage customer to opt for an overnight stay and lunch*/
            
            try
            { 
                LocationIndex = LocationListBox.SelectedIndex;

                if (LocationListBox.SelectedIndex != -1)
                {
                    switch (LocationIndex)
                    {
                        case 0: Location = CLIFFS; LocationCost = CLIFFS_PRICE; break;
                        case 1: Location = KYLEMORE; LocationCost = KYLEMORE_PRICE; break;
                        case 2: Location = BUNRATTY; LocationCost = BUNRATTY_PRICE; break;
                        case 3: Location = BURREN; LocationCost = BURREN_PRICE; break;
                        case 4: Location = CONNEMARA; LocationCost = CONNEMARA_PRICE; break;
                        case 5: Location = BELMULLET; LocationCost = BELMULLET_PRICE; break;
                    }
                    DepartureTimeIndex = DepartureTimesListBox.SelectedIndex;

                    if (DepartureTimesListBox.SelectedIndex != -1)
                    {
                        switch (DepartureTimeIndex)
                        {
                            case 0: DepartureTime = DEPTIME7; DepartureTimeDiscount = DISCOUNT7AM; break;
                            case 1: DepartureTime = DEPTIME8; DepartureTimeDiscount = DISCOUNT8AM; break;
                            case 2: DepartureTime = DEPTIME9; DepartureTimeDiscount = DISCOUNT9AM; break;
                            case 3: DepartureTime = DEPTIME10; DepartureTimeDiscount = DISCOUNT10AM; break;
                            case 4: DepartureTime = DEPTIME11; DepartureTimeDiscount = DISCOUNT11AM; break;
                            case 5: DepartureTime = DEPTIME1300; DepartureTimeDiscount = DISCOUNT1300; break;

                        }
                        if (int.TryParse(NoOfGuestsTextBox.Text, out NoOfGuests))
                        {

                            if (NoOfGuests >= 3)
                            {
                                InformDiscountLabel.Visible = true;
                            }

                            NoOfGuestsLabel.Text = NoOfGuests.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Valid Number of Guests", "Error", MessageBoxButtons.OK,
                                                     MessageBoxIcon.Error);
                            NoOfGuestsTextBox.Focus();
                            NoOfGuestsTextBox.SelectAll();

                        }

                        DepartureTimeLabel.Text = DepartureTime;
                        DepartureTimesHeaderLabel.Text = DepartureTime;
                    }
                    else
                    {

                        MessageBox.Show("Please Select A Departure Time", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        DepartureTimesListBox.Focus();
                    }


                    TripCost = (LocationCost - (LocationCost / 100) * DepartureTimeDiscount) * NoOfGuests;
                    LocationLabel.Text = Location;
                    LocationHeaderLabel.Text = Location;
                    TripCostLabel.Text = TripCost.ToString("c");

                }
                else

                {
                    MessageBox.Show("Please Select A Location", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    LocationListBox.Focus();
                }

                /*grouped the optional decisions together with if, else if statements. 
                 * Calculations processed depending on options chosen
                   Displaying only information on options chosen*/
                if (_5StarRadioButton.Checked)
                {
                    HotelChosen = FIVESTAR; HotelPrice = FIVESTAR_PRICE;
                }
                else if (_4StarRadioButton.Checked)
                {
                    HotelChosen = FOURSTAR; HotelPrice = FOURSTAR_PRICE;
                }
                else if (_3StarRadioButton.Checked)
                {
                    HotelChosen = THREESTAR; HotelPrice = THREESTAR_PRICE;
                }
                else
                {
                    HotelChosen = NOHOTEL; HotelPrice = NOHOTEL_PRICE;
                    OutputHotelCostLabel.Visible = false;
                    HotelCostLabel.Visible = false;
                }
                HotelCost = HotelPrice * NoOfGuests;
                ChosenHotelLabel.Text = HotelChosen;
                HotelCostLabel.Text = HotelCost.ToString("c");

                if (LunchCheckBox.Checked)

                {
                    LunchCost = LUNCH_PRICE * NoOfGuests;
                    IncludeLunchLabel.Text = "Yes";
                    LunchCostLabel.Text = LunchCost.ToString("c");
                    OutputLunchCostLabel.Visible = true;
                    LunchCostLabel.Visible = true;


                    if ((NoOfGuests >= 3) && (_5StarRadioButton.Checked || _4StarRadioButton.Checked
                           || _3StarRadioButton.Checked) && (LunchCheckBox.Checked))
                    {
                        CostBeforeDiscount = TripCost + HotelCost + LunchCost;
                        CostBeforeDiscountLabel.Text = CostBeforeDiscount.ToString("c");

                        DiscountedAmount = ((CostBeforeDiscount / 100) * MAINDISCOUNT);

                        OverallCost = CostBeforeDiscount - DiscountedAmount;
                        DiscountLabel.Text = DiscountedAmount.ToString("c");

                        OverallCostLabel.Text = OverallCost.ToString("c");


                        InformDiscountLabel.Visible = true;
                        DiscountOutputLabel.Visible = true;
                        DiscountLabel.Visible = true;
                        CostBeforeDiscountLabel.Visible = true;
                        CostBeforeDiscountOutputLabel.Visible = true;
                    }
                    else
                    {
                        OverallCost = TripCost + HotelCost + LunchCost;
                        OverallCostLabel.Text = OverallCost.ToString("c");

                        InformDiscountLabel.Visible = false;
                        DiscountOutputLabel.Visible = false;
                        DiscountLabel.Visible = false;
                        CostBeforeDiscountLabel.Visible = false;
                        CostBeforeDiscountOutputLabel.Visible = false;
                    }

                }
                else
                {
                    OverallCost = TripCost + HotelCost;
                    OverallCostLabel.Text = OverallCost.ToString("c");
                    IncludeLunchLabel.Text = "No";
                    OutputLunchCostLabel.Visible = false;
                    LunchCostLabel.Visible = false;

                }

                /*Toggle visibility and enable/disable controls - 
                To avoid possility of input error, and have a better flow to the application*/
                DisplayGroupBox.Visible = true;
                NoHotelRadioButton.Visible = true;
                BookButton.Enabled = true;
                SummaryButton.Enabled = false;


            }
            catch
            {
                MessageBox.Show("Please Select From Booking Options", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                

            }
        }



        /*Once the BookButton is pressed the event handler displays a confirmation message box.
        *The user can select yes to confirm booking and add values of the tranaction
         *or select no and have the opportunity to change choices made from the booking options*/
        private void BookButton_Click(object sender, EventArgs e)
        {
            
            DisplayButton.Enabled = false;

            this.Text = "Your Confirmed Booking";

            var Confirmed = MessageBox.Show("\n" + "Number of Guests: " + NoOfGuests.ToString() + "\n"
                  + "\n" + "Excursion Location: " + Location + "\n"
                  + "\n" + "Departure Time: " + DepartureTime + "\n"
                  + "\n" + "Hotel: " + HotelChosen + "\n"
                  + "\n" + "Total Cost: " + OverallCost.ToString("c2") + "\n", "Confirm Booking",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (Confirmed == DialogResult.Yes)
            {//performing calculations and storing values - to be displayed in summary
                TotalNoOfTransactions++;
                TotalTripFees = TotalNoOfTransactions * TripCost;
                ValueofHotelStays = HotelCost * TotalNoOfTransactions;
                ValueofLunch = LunchCost * TotalNoOfTransactions;
                AvgRevenuePerBooking = OverallCost / TotalNoOfTransactions;

                //Booking complete, want form to be cleared for next booking/user
                LocationLabel.Text = "";
                DepartureTimeLabel.Text = "";
                NoOfGuestsLabel.Text = "";
                ChosenHotelLabel.Text = "";
                IncludeLunchLabel.Text = "";
                DiscountLabel.Text = "";
                CostBeforeDiscountLabel.Text = "";
                TripCostLabel.Text = "";
                HotelCostLabel.Text = "";
                LunchCostLabel.Text = "";
                OverallCostLabel.Text = "";

                LocationListBox.SelectedIndex = -1;
                LocationHeaderLabel.Text = "Location / Price (€) pp";
                DepartureTimesListBox.SelectedIndex = -1;
                DepartureTimesHeaderLabel.Text = "Departure Time / Discount";
                NoOfGuestsTextBox.Text = "";

                LunchCheckBox.Checked = false;
                _5StarRadioButton.Checked = true;
                InformDiscountLabel.Visible = false;
                NoHotelRadioButton.Visible = false;
                SummaryGroupBox.Visible = false;
                DisplayGroupBox.Visible = true;
                DisplayButton.Visible = true;
                DiscountLabel.Visible = true;
                DiscountOutputLabel.Visible = true;
                CostBeforeDiscountLabel.Visible = true;
                CostBeforeDiscountOutputLabel.Visible = true;
                HotelCostLabel.Visible = true;
                OutputHotelCostLabel.Visible = true;
                LunchCostLabel.Visible = true;
                OutputLunchCostLabel.Visible = true;
                DisplayButton.Enabled = true;
                SummaryButton.Enabled = true;


                this.Text = "Mild Atlantic Bus Tours";

            }
            else
            {//allows for changes to be made to current booking without clearing whole form - doesnt add in to transactions
                DisplayButton.Enabled = true;

            }


        }
        //When SummaryButton is clicked a summary groupbox appears with details of all transactions processed.
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            TotalTransactionsLabel.Text = TotalNoOfTransactions.ToString();
            TotalTripFeesLabel.Text = TotalTripFees.ToString("c2");
            ValueofHotelOptionsLabel.Text = ValueofHotelStays.ToString("c2");
            ValueofLunchesLabel.Text = ValueofLunch.ToString("c2");
            AvgRevenueLabel.Text = AvgRevenuePerBooking.ToString("c2");

            DisplayGroupBox.Visible = false;
            SummaryGroupBox.Visible = true;
            BookButton.Enabled = false;

            this.Text = "Summary of All Transactions";

        }

        //When ClearButton is clicked it resets form for next user or next booking.
        private void ClearButton_Click(object sender, EventArgs e)
        {
            LocationLabel.Text = "";
            DepartureTimeLabel.Text = "";
            NoOfGuestsLabel.Text = "";
            ChosenHotelLabel.Text = "";
            IncludeLunchLabel.Text = "";
            DiscountLabel.Text = "";
            CostBeforeDiscountLabel.Text = "";
            TripCostLabel.Text = "";
            HotelCostLabel.Text = "";
            LunchCostLabel.Text = "";
            OverallCostLabel.Text = "";

            LocationListBox.SelectedIndex = -1;
            LocationHeaderLabel.Text = "Location / Price (€) pp";
            DepartureTimesListBox.SelectedIndex = -1;
            DepartureTimesHeaderLabel.Text = "Departure Time / Discount";
            NoOfGuestsTextBox.Text = "";

            LunchCheckBox.Checked = false;
            _5StarRadioButton.Checked = true;
            InformDiscountLabel.Visible = false;
            NoHotelRadioButton.Visible = false;
            SummaryGroupBox.Visible = false;
            DisplayGroupBox.Visible = true;
            DisplayButton.Visible = true;
            DiscountLabel.Visible = true;
            DiscountOutputLabel.Visible = true;
            CostBeforeDiscountLabel.Visible = true;
            CostBeforeDiscountOutputLabel.Visible = true;
            HotelCostLabel.Visible = true;
            OutputHotelCostLabel.Visible = true;
            LunchCostLabel.Visible = true;
            OutputLunchCostLabel.Visible = true;
            DisplayButton.Enabled = true;
            SummaryButton.Enabled = true;

            this.Text = "Mild Atlantic Bus Tours";


        }
        //ExitButton allows user to exit the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }

       





    }




