namespace Maher_Mary_Assignment4_MS806
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.SizeListBox = new System.Windows.Forms.ListBox();
            this.TransactionGroupBox = new System.Windows.Forms.GroupBox();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Date_TimeLabel = new System.Windows.Forms.Label();
            this.Date_TimeDisplayLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TransIDLabel = new System.Windows.Forms.Label();
            this.TransIDDisplayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentOrderLabel = new System.Windows.Forms.Label();
            this.SelectSizeLabel = new System.Windows.Forms.Label();
            this.SelectItemsLabel = new System.Windows.Forms.Label();
            this.TransactionDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.NoOfItemsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberOfItemsLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.OrderListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmSaleButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AvailableStockLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DailySalesButton = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ManagementReportButton = new System.Windows.Forms.Button();
            this.SearchTransactionButton = new System.Windows.Forms.Button();
            this.SearchTransactionGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TransactionListBox = new System.Windows.Forms.ListBox();
            this.EnterTransIDLabel = new System.Windows.Forms.Label();
            this.EnterTransDateTextBox = new System.Windows.Forms.TextBox();
            this.ClearTransIDButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EnterTransIDTextBox = new System.Windows.Forms.TextBox();
            this.DailySalesGroupBox = new System.Windows.Forms.GroupBox();
            this.SalesReportListBox = new System.Windows.Forms.ListBox();
            this.AddtoOrderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.TransactionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.TransactionDisplayGroupBox.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SearchTransactionGroupBox.SuspendLayout();
            this.DailySalesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 16;
            this.ItemListBox.Items.AddRange(new object[] {
            "T-Shirt\t\tWhite\t\t€15",
            "T-Shirt\t\tBlack\t\t€15",
            "T-Shirt\t\tGrey\t\t€15",
            "Hoody\t\tRed\t\t€30",
            "Hoody\t\tBlack\t\t€30",
            "Hoody\t\tGrey\t\t€30",
            "Fleece\t\tRed\t\t€30",
            "Fleece\t\tBlack\t\t€30",
            "Fleece\t\tGrey\t\t€30",
            "Leggings\t\tGrey\t\t€25",
            "Leggings\t\tBlack\t\t€25",
            "Shorts\t\tNavy\t\t€20",
            "Shorts\t\tBlack\t\t€20"});
            this.ItemListBox.Location = new System.Drawing.Point(9, 55);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(336, 164);
            this.ItemListBox.TabIndex = 0;
            // 
            // SizeListBox
            // 
            this.SizeListBox.FormattingEnabled = true;
            this.SizeListBox.ItemHeight = 16;
            this.SizeListBox.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL"});
            this.SizeListBox.Location = new System.Drawing.Point(385, 55);
            this.SizeListBox.Name = "SizeListBox";
            this.SizeListBox.Size = new System.Drawing.Size(120, 84);
            this.SizeListBox.TabIndex = 1;
            // 
            // TransactionGroupBox
            // 
            this.TransactionGroupBox.Controls.Add(this.AddToOrderButton);
            this.TransactionGroupBox.Controls.Add(this.label8);
            this.TransactionGroupBox.Controls.Add(this.label7);
            this.TransactionGroupBox.Controls.Add(this.QuantityNumericUpDown);
            this.TransactionGroupBox.Controls.Add(this.Date_TimeLabel);
            this.TransactionGroupBox.Controls.Add(this.Date_TimeDisplayLabel);
            this.TransactionGroupBox.Controls.Add(this.label3);
            this.TransactionGroupBox.Controls.Add(this.TransIDLabel);
            this.TransactionGroupBox.Controls.Add(this.ItemListBox);
            this.TransactionGroupBox.Controls.Add(this.TransIDDisplayLabel);
            this.TransactionGroupBox.Controls.Add(this.label1);
            this.TransactionGroupBox.Controls.Add(this.SizeListBox);
            this.TransactionGroupBox.Controls.Add(this.CurrentOrderLabel);
            this.TransactionGroupBox.Controls.Add(this.SelectSizeLabel);
            this.TransactionGroupBox.Controls.Add(this.SelectItemsLabel);
            this.TransactionGroupBox.Controls.Add(this.TransactionDisplayGroupBox);
            this.TransactionGroupBox.Location = new System.Drawing.Point(12, 13);
            this.TransactionGroupBox.Name = "TransactionGroupBox";
            this.TransactionGroupBox.Size = new System.Drawing.Size(1117, 287);
            this.TransactionGroupBox.TabIndex = 3;
            this.TransactionGroupBox.TabStop = false;
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.Enabled = false;
            this.AddToOrderButton.Location = new System.Drawing.Point(428, 168);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(124, 34);
            this.AddToOrderButton.TabIndex = 21;
            this.AddToOrderButton.Text = "&Add to Order";
            this.AddtoOrderToolTip.SetToolTip(this.AddToOrderButton, "Press to Add items");
            this.AddToOrderButton.UseVisualStyleBackColor = true;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Add Quantity:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(529, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Quantity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(532, 56);
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(53, 22);
            this.QuantityNumericUpDown.TabIndex = 18;
            this.QuantityNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
            // 
            // Date_TimeLabel
            // 
            this.Date_TimeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date_TimeLabel.Location = new System.Drawing.Point(764, 249);
            this.Date_TimeLabel.Name = "Date_TimeLabel";
            this.Date_TimeLabel.Size = new System.Drawing.Size(101, 28);
            this.Date_TimeLabel.TabIndex = 9;
            this.Date_TimeLabel.Visible = false;
            // 
            // Date_TimeDisplayLabel
            // 
            this.Date_TimeDisplayLabel.AutoSize = true;
            this.Date_TimeDisplayLabel.Location = new System.Drawing.Point(772, 222);
            this.Date_TimeDisplayLabel.Name = "Date_TimeDisplayLabel";
            this.Date_TimeDisplayLabel.Size = new System.Drawing.Size(90, 17);
            this.Date_TimeDisplayLabel.TabIndex = 8;
            this.Date_TimeDisplayLabel.Text = "Date && Time ";
            this.Date_TimeDisplayLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Choose a Size:";
            // 
            // TransIDLabel
            // 
            this.TransIDLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TransIDLabel.Location = new System.Drawing.Point(609, 249);
            this.TransIDLabel.Name = "TransIDLabel";
            this.TransIDLabel.Size = new System.Drawing.Size(101, 28);
            this.TransIDLabel.TabIndex = 7;
            this.TransIDLabel.Visible = false;
            // 
            // TransIDDisplayLabel
            // 
            this.TransIDDisplayLabel.AutoSize = true;
            this.TransIDDisplayLabel.Location = new System.Drawing.Point(606, 222);
            this.TransIDDisplayLabel.Name = "TransIDDisplayLabel";
            this.TransIDDisplayLabel.Size = new System.Drawing.Size(104, 17);
            this.TransIDDisplayLabel.TabIndex = 6;
            this.TransIDDisplayLabel.Text = "Transaction ID:";
            this.TransIDDisplayLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose an Item:";
            // 
            // CurrentOrderLabel
            // 
            this.CurrentOrderLabel.AutoSize = true;
            this.CurrentOrderLabel.Location = new System.Drawing.Point(736, 15);
            this.CurrentOrderLabel.Name = "CurrentOrderLabel";
            this.CurrentOrderLabel.Size = new System.Drawing.Size(96, 17);
            this.CurrentOrderLabel.TabIndex = 5;
            this.CurrentOrderLabel.Text = "Current Order";
            // 
            // SelectSizeLabel
            // 
            this.SelectSizeLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SelectSizeLabel.Location = new System.Drawing.Point(385, 26);
            this.SelectSizeLabel.Name = "SelectSizeLabel";
            this.SelectSizeLabel.Size = new System.Drawing.Size(120, 26);
            this.SelectSizeLabel.TabIndex = 4;
            this.SelectSizeLabel.Text = "Size";
            this.SelectSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectItemsLabel
            // 
            this.SelectItemsLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SelectItemsLabel.Location = new System.Drawing.Point(6, 26);
            this.SelectItemsLabel.Name = "SelectItemsLabel";
            this.SelectItemsLabel.Size = new System.Drawing.Size(337, 26);
            this.SelectItemsLabel.TabIndex = 3;
            this.SelectItemsLabel.Text = "Item                         Colour                 Starting Price";
            this.SelectItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TransactionDisplayGroupBox
            // 
            this.TransactionDisplayGroupBox.Controls.Add(this.TotalPriceLabel);
            this.TransactionDisplayGroupBox.Controls.Add(this.NoOfItemsLabel);
            this.TransactionDisplayGroupBox.Controls.Add(this.label6);
            this.TransactionDisplayGroupBox.Controls.Add(this.NumberOfItemsLabel);
            this.TransactionDisplayGroupBox.Controls.Add(this.PriceLabel);
            this.TransactionDisplayGroupBox.Controls.Add(this.OrderListBox);
            this.TransactionDisplayGroupBox.Controls.Add(this.label5);
            this.TransactionDisplayGroupBox.Controls.Add(this.ConfirmSaleButton);
            this.TransactionDisplayGroupBox.Controls.Add(this.ClearButton);
            this.TransactionDisplayGroupBox.Controls.Add(this.AvailableStockLabel);
            this.TransactionDisplayGroupBox.Controls.Add(this.label2);
            this.TransactionDisplayGroupBox.Location = new System.Drawing.Point(609, 9);
            this.TransactionDisplayGroupBox.Name = "TransactionDisplayGroupBox";
            this.TransactionDisplayGroupBox.Size = new System.Drawing.Size(486, 204);
            this.TransactionDisplayGroupBox.TabIndex = 12;
            this.TransactionDisplayGroupBox.TabStop = false;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalPriceLabel.Location = new System.Drawing.Point(379, 162);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(101, 28);
            this.TotalPriceLabel.TabIndex = 22;
            // 
            // NoOfItemsLabel
            // 
            this.NoOfItemsLabel.AutoSize = true;
            this.NoOfItemsLabel.Location = new System.Drawing.Point(254, 75);
            this.NoOfItemsLabel.Name = "NoOfItemsLabel";
            this.NoOfItemsLabel.Size = new System.Drawing.Size(115, 17);
            this.NoOfItemsLabel.TabIndex = 14;
            this.NoOfItemsLabel.Text = "Number of Items:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total Price:";
            // 
            // NumberOfItemsLabel
            // 
            this.NumberOfItemsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumberOfItemsLabel.Location = new System.Drawing.Point(379, 72);
            this.NumberOfItemsLabel.Name = "NumberOfItemsLabel";
            this.NumberOfItemsLabel.Size = new System.Drawing.Size(101, 28);
            this.NumberOfItemsLabel.TabIndex = 14;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriceLabel.Location = new System.Drawing.Point(379, 117);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(101, 28);
            this.PriceLabel.TabIndex = 20;
            // 
            // OrderListBox
            // 
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.ItemHeight = 16;
            this.OrderListBox.Location = new System.Drawing.Point(6, 27);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(244, 116);
            this.OrderListBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Current Item Price:";
            // 
            // ConfirmSaleButton
            // 
            this.ConfirmSaleButton.Enabled = false;
            this.ConfirmSaleButton.Location = new System.Drawing.Point(30, 149);
            this.ConfirmSaleButton.Name = "ConfirmSaleButton";
            this.ConfirmSaleButton.Size = new System.Drawing.Size(93, 44);
            this.ConfirmSaleButton.TabIndex = 0;
            this.ConfirmSaleButton.Text = "Confirm Sale";
            this.toolTip1.SetToolTip(this.ConfirmSaleButton, "Press to confirm sale");
            this.ConfirmSaleButton.UseVisualStyleBackColor = true;
            this.ConfirmSaleButton.Click += new System.EventHandler(this.ConfirmSaleButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(145, 149);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(93, 44);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "&Clear";
            this.toolTip2.SetToolTip(this.ClearButton, "Press to Clear Order");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AvailableStockLabel
            // 
            this.AvailableStockLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AvailableStockLabel.Location = new System.Drawing.Point(379, 27);
            this.AvailableStockLabel.Name = "AvailableStockLabel";
            this.AvailableStockLabel.Size = new System.Drawing.Size(101, 28);
            this.AvailableStockLabel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Remaining Stock:";
            // 
            // DailySalesButton
            // 
            this.DailySalesButton.Location = new System.Drawing.Point(172, 3);
            this.DailySalesButton.Name = "DailySalesButton";
            this.DailySalesButton.Size = new System.Drawing.Size(125, 51);
            this.DailySalesButton.TabIndex = 6;
            this.DailySalesButton.Text = "Daily Sales";
            this.toolTip5.SetToolTip(this.DailySalesButton, "Press to view Today\'s Transactions");
            this.DailySalesButton.UseVisualStyleBackColor = true;
            this.DailySalesButton.Click += new System.EventHandler(this.DailySalesButton_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ButtonPanel.Controls.Add(this.DailySalesButton);
            this.ButtonPanel.Controls.Add(this.ExitButton);
            this.ButtonPanel.Controls.Add(this.ManagementReportButton);
            this.ButtonPanel.Controls.Add(this.SearchTransactionButton);
            this.ButtonPanel.Location = new System.Drawing.Point(191, 306);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(618, 61);
            this.ButtonPanel.TabIndex = 4;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(462, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(105, 51);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "&Exit";
            this.toolTip3.SetToolTip(this.ExitButton, "Press to Exit Application");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // ManagementReportButton
            // 
            this.ManagementReportButton.Location = new System.Drawing.Point(317, 3);
            this.ManagementReportButton.Name = "ManagementReportButton";
            this.ManagementReportButton.Size = new System.Drawing.Size(125, 51);
            this.ManagementReportButton.TabIndex = 1;
            this.ManagementReportButton.Text = "Management Report";
            this.toolTip4.SetToolTip(this.ManagementReportButton, "Press to view management report");
            this.ManagementReportButton.UseVisualStyleBackColor = true;
            this.ManagementReportButton.Click += new System.EventHandler(this.ManagementReportButton_Click);
            // 
            // SearchTransactionButton
            // 
            this.SearchTransactionButton.Location = new System.Drawing.Point(22, 3);
            this.SearchTransactionButton.Name = "SearchTransactionButton";
            this.SearchTransactionButton.Size = new System.Drawing.Size(130, 51);
            this.SearchTransactionButton.TabIndex = 0;
            this.SearchTransactionButton.Text = "Search Transaction";
            this.toolTip6.SetToolTip(this.SearchTransactionButton, "Search Previous Transactions");
            this.SearchTransactionButton.UseVisualStyleBackColor = true;
            this.SearchTransactionButton.Click += new System.EventHandler(this.SearchTransactionButton_Click);
            // 
            // SearchTransactionGroupBox
            // 
            this.SearchTransactionGroupBox.Controls.Add(this.label4);
            this.SearchTransactionGroupBox.Controls.Add(this.TransactionListBox);
            this.SearchTransactionGroupBox.Controls.Add(this.EnterTransIDLabel);
            this.SearchTransactionGroupBox.Controls.Add(this.EnterTransDateTextBox);
            this.SearchTransactionGroupBox.Controls.Add(this.ClearTransIDButton);
            this.SearchTransactionGroupBox.Controls.Add(this.SearchButton);
            this.SearchTransactionGroupBox.Controls.Add(this.EnterTransIDTextBox);
            this.SearchTransactionGroupBox.Location = new System.Drawing.Point(124, 387);
            this.SearchTransactionGroupBox.Name = "SearchTransactionGroupBox";
            this.SearchTransactionGroupBox.Size = new System.Drawing.Size(732, 198);
            this.SearchTransactionGroupBox.TabIndex = 6;
            this.SearchTransactionGroupBox.TabStop = false;
            this.SearchTransactionGroupBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Transaction Date:";
            // 
            // TransactionListBox
            // 
            this.TransactionListBox.FormattingEnabled = true;
            this.TransactionListBox.ItemHeight = 16;
            this.TransactionListBox.Location = new System.Drawing.Point(352, 18);
            this.TransactionListBox.Name = "TransactionListBox";
            this.TransactionListBox.Size = new System.Drawing.Size(351, 116);
            this.TransactionListBox.TabIndex = 4;
            this.TransactionListBox.Visible = false;
            // 
            // EnterTransIDLabel
            // 
            this.EnterTransIDLabel.AutoSize = true;
            this.EnterTransIDLabel.Location = new System.Drawing.Point(52, 28);
            this.EnterTransIDLabel.Name = "EnterTransIDLabel";
            this.EnterTransIDLabel.Size = new System.Drawing.Size(142, 17);
            this.EnterTransIDLabel.TabIndex = 3;
            this.EnterTransIDLabel.Text = "Enter Transaction ID:";
            // 
            // EnterTransDateTextBox
            // 
            this.EnterTransDateTextBox.Location = new System.Drawing.Point(216, 53);
            this.EnterTransDateTextBox.Name = "EnterTransDateTextBox";
            this.EnterTransDateTextBox.Size = new System.Drawing.Size(117, 22);
            this.EnterTransDateTextBox.TabIndex = 8;
            // 
            // ClearTransIDButton
            // 
            this.ClearTransIDButton.Location = new System.Drawing.Point(172, 108);
            this.ClearTransIDButton.Name = "ClearTransIDButton";
            this.ClearTransIDButton.Size = new System.Drawing.Size(75, 23);
            this.ClearTransIDButton.TabIndex = 2;
            this.ClearTransIDButton.Text = "Clear";
            this.ClearTransIDButton.UseVisualStyleBackColor = true;
            this.ClearTransIDButton.Click += new System.EventHandler(this.ClearTransIDButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(172, 78);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "&Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EnterTransIDTextBox
            // 
            this.EnterTransIDTextBox.Location = new System.Drawing.Point(216, 25);
            this.EnterTransIDTextBox.Name = "EnterTransIDTextBox";
            this.EnterTransIDTextBox.Size = new System.Drawing.Size(117, 22);
            this.EnterTransIDTextBox.TabIndex = 0;
            // 
            // DailySalesGroupBox
            // 
            this.DailySalesGroupBox.Controls.Add(this.SalesReportListBox);
            this.DailySalesGroupBox.Location = new System.Drawing.Point(139, 368);
            this.DailySalesGroupBox.Name = "DailySalesGroupBox";
            this.DailySalesGroupBox.Size = new System.Drawing.Size(732, 138);
            this.DailySalesGroupBox.TabIndex = 7;
            this.DailySalesGroupBox.TabStop = false;
            this.DailySalesGroupBox.Visible = false;
            // 
            // SalesReportListBox
            // 
            this.SalesReportListBox.FormattingEnabled = true;
            this.SalesReportListBox.ItemHeight = 16;
            this.SalesReportListBox.Location = new System.Drawing.Point(151, 21);
            this.SalesReportListBox.Name = "SalesReportListBox";
            this.SalesReportListBox.Size = new System.Drawing.Size(434, 100);
            this.SalesReportListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 382);
            this.Controls.Add(this.SearchTransactionGroupBox);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TransactionGroupBox);
            this.Controls.Add(this.DailySalesGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Welcome to EcoSports - Sustainable Sportswear";
            this.TransactionGroupBox.ResumeLayout(false);
            this.TransactionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.TransactionDisplayGroupBox.ResumeLayout(false);
            this.TransactionDisplayGroupBox.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.SearchTransactionGroupBox.ResumeLayout(false);
            this.SearchTransactionGroupBox.PerformLayout();
            this.DailySalesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.ListBox SizeListBox;
        private System.Windows.Forms.GroupBox TransactionGroupBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ConfirmSaleButton;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ManagementReportButton;
        private System.Windows.Forms.Button SearchTransactionButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox SearchTransactionGroupBox;
        private System.Windows.Forms.Label EnterTransIDLabel;
        private System.Windows.Forms.Button ClearTransIDButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox EnterTransIDTextBox;
        private System.Windows.Forms.ListBox TransactionListBox;
        private System.Windows.Forms.GroupBox DailySalesGroupBox;
        private System.Windows.Forms.ListBox SalesReportListBox;
        private System.Windows.Forms.Label CurrentOrderLabel;
        private System.Windows.Forms.Label SelectSizeLabel;
        private System.Windows.Forms.Label SelectItemsLabel;
        private System.Windows.Forms.Label TransIDLabel;
        private System.Windows.Forms.Label TransIDDisplayLabel;
        private System.Windows.Forms.Label Date_TimeLabel;
        private System.Windows.Forms.Label Date_TimeDisplayLabel;
        private System.Windows.Forms.GroupBox TransactionDisplayGroupBox;
        private System.Windows.Forms.ListBox OrderListBox;
        private System.Windows.Forms.Label NoOfItemsLabel;
        private System.Windows.Forms.Label NumberOfItemsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AvailableStockLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EnterTransDateTextBox;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DailySalesButton;
        private System.Windows.Forms.ToolTip AddtoOrderToolTip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}

