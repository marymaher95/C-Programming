namespace Maher_Mary_Assignment1MS806
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
            this.StartPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.TableNumberTextBox = new System.Windows.Forms.TextBox();
            this.OutputTableNumberLabel = new System.Windows.Forms.Label();
            this.ServerNameTextBox = new System.Windows.Forms.TextBox();
            this.OutputServerNameLabel = new System.Windows.Forms.Label();
            this.PizzaGroupBox = new System.Windows.Forms.GroupBox();
            this.HamPineapplePriceLabel = new System.Windows.Forms.Label();
            this.PepperoniPizzaPriceLabel = new System.Windows.Forms.Label();
            this.MargheritaPizzaPriceLabel = new System.Windows.Forms.Label();
            this.HamPineapplePizzaTextBox = new System.Windows.Forms.TextBox();
            this.PepperoniPizzaTextBox = new System.Windows.Forms.TextBox();
            this.MargheritaPizzaTextBox = new System.Windows.Forms.TextBox();
            this.OutputHamPineappleLabel = new System.Windows.Forms.Label();
            this.OutputPepperoniPizzaLabel = new System.Windows.Forms.Label();
            this.OutputMargheritaPizzaLabel = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.SultPictureBox = new System.Windows.Forms.PictureBox();
            this.TableOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalTableReceiptsLabel = new System.Windows.Forms.Label();
            this.TotalPizzasLabel = new System.Windows.Forms.Label();
            this.ServerNameLabel = new System.Windows.Forms.Label();
            this.OutputTableReceiptsLabel = new System.Windows.Forms.Label();
            this.OutputTotalPizzasLabel = new System.Windows.Forms.Label();
            this.OutputServersNameLabel = new System.Windows.Forms.Label();
            this.CompanySummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.AvgTransactionValueLabel = new System.Windows.Forms.Label();
            this.OutputAvgTransactionValueLabel = new System.Windows.Forms.Label();
            this.TotalCompanyReceiptsLabel = new System.Windows.Forms.Label();
            this.TotalNumberPizzaSummaryLabel = new System.Windows.Forms.Label();
            this.TotalCompanyTransactionsLabel = new System.Windows.Forms.Label();
            this.OutputCompanyReceiptLabel = new System.Windows.Forms.Label();
            this.OutputTotalPizzaSummaryLabel = new System.Windows.Forms.Label();
            this.OutputCompanyTransactionsLabel = new System.Windows.Forms.Label();
            this.OrderButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SummaryButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExitButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StartPanel.SuspendLayout();
            this.PizzaGroupBox.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SultPictureBox)).BeginInit();
            this.TableOrderGroupBox.SuspendLayout();
            this.CompanySummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartPanel.Controls.Add(this.StartButton);
            this.StartPanel.Controls.Add(this.TableNumberTextBox);
            this.StartPanel.Controls.Add(this.OutputTableNumberLabel);
            this.StartPanel.Controls.Add(this.ServerNameTextBox);
            this.StartPanel.Controls.Add(this.OutputServerNameLabel);
            this.StartPanel.Location = new System.Drawing.Point(19, 32);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(560, 59);
            this.StartPanel.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(433, 19);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 24);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TableNumberTextBox
            // 
            this.TableNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumberTextBox.Location = new System.Drawing.Point(332, 19);
            this.TableNumberTextBox.Name = "TableNumberTextBox";
            this.TableNumberTextBox.Size = new System.Drawing.Size(44, 22);
            this.TableNumberTextBox.TabIndex = 1;
            this.TableNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputTableNumberLabel
            // 
            this.OutputTableNumberLabel.AutoSize = true;
            this.OutputTableNumberLabel.Location = new System.Drawing.Point(256, 24);
            this.OutputTableNumberLabel.Name = "OutputTableNumberLabel";
            this.OutputTableNumberLabel.Size = new System.Drawing.Size(70, 17);
            this.OutputTableNumberLabel.TabIndex = 2;
            this.OutputTableNumberLabel.Text = "Table No:";
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerNameTextBox.Location = new System.Drawing.Point(116, 19);
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.Size = new System.Drawing.Size(110, 22);
            this.ServerNameTextBox.TabIndex = 0;
            this.ServerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputServerNameLabel
            // 
            this.OutputServerNameLabel.AutoSize = true;
            this.OutputServerNameLabel.Location = new System.Drawing.Point(15, 22);
            this.OutputServerNameLabel.Name = "OutputServerNameLabel";
            this.OutputServerNameLabel.Size = new System.Drawing.Size(95, 17);
            this.OutputServerNameLabel.TabIndex = 0;
            this.OutputServerNameLabel.Text = "Server Name:";
            // 
            // PizzaGroupBox
            // 
            this.PizzaGroupBox.Controls.Add(this.HamPineapplePriceLabel);
            this.PizzaGroupBox.Controls.Add(this.PepperoniPizzaPriceLabel);
            this.PizzaGroupBox.Controls.Add(this.MargheritaPizzaPriceLabel);
            this.PizzaGroupBox.Controls.Add(this.HamPineapplePizzaTextBox);
            this.PizzaGroupBox.Controls.Add(this.PepperoniPizzaTextBox);
            this.PizzaGroupBox.Controls.Add(this.MargheritaPizzaTextBox);
            this.PizzaGroupBox.Controls.Add(this.OutputHamPineappleLabel);
            this.PizzaGroupBox.Controls.Add(this.OutputPepperoniPizzaLabel);
            this.PizzaGroupBox.Controls.Add(this.OutputMargheritaPizzaLabel);
            this.PizzaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaGroupBox.Location = new System.Drawing.Point(18, 21);
            this.PizzaGroupBox.Name = "PizzaGroupBox";
            this.PizzaGroupBox.Size = new System.Drawing.Size(560, 169);
            this.PizzaGroupBox.TabIndex = 1;
            this.PizzaGroupBox.TabStop = false;
            this.PizzaGroupBox.Text = "Pizza Menu";
            this.PizzaGroupBox.Visible = false;
            // 
            // HamPineapplePriceLabel
            // 
            this.HamPineapplePriceLabel.AutoSize = true;
            this.HamPineapplePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HamPineapplePriceLabel.Location = new System.Drawing.Point(369, 109);
            this.HamPineapplePriceLabel.Name = "HamPineapplePriceLabel";
            this.HamPineapplePriceLabel.Size = new System.Drawing.Size(80, 20);
            this.HamPineapplePriceLabel.TabIndex = 8;
            this.HamPineapplePriceLabel.Text = "@ €12.79";
            // 
            // PepperoniPizzaPriceLabel
            // 
            this.PepperoniPizzaPriceLabel.AutoSize = true;
            this.PepperoniPizzaPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PepperoniPizzaPriceLabel.Location = new System.Drawing.Point(369, 70);
            this.PepperoniPizzaPriceLabel.Name = "PepperoniPizzaPriceLabel";
            this.PepperoniPizzaPriceLabel.Size = new System.Drawing.Size(80, 20);
            this.PepperoniPizzaPriceLabel.TabIndex = 7;
            this.PepperoniPizzaPriceLabel.Text = "@ €11.50";
            // 
            // MargheritaPizzaPriceLabel
            // 
            this.MargheritaPizzaPriceLabel.AutoSize = true;
            this.MargheritaPizzaPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MargheritaPizzaPriceLabel.Location = new System.Drawing.Point(369, 36);
            this.MargheritaPizzaPriceLabel.Name = "MargheritaPizzaPriceLabel";
            this.MargheritaPizzaPriceLabel.Size = new System.Drawing.Size(49, 20);
            this.MargheritaPizzaPriceLabel.TabIndex = 6;
            this.MargheritaPizzaPriceLabel.Text = "@ €9";
            // 
            // HamPineapplePizzaTextBox
            // 
            this.HamPineapplePizzaTextBox.Location = new System.Drawing.Point(255, 109);
            this.HamPineapplePizzaTextBox.Name = "HamPineapplePizzaTextBox";
            this.HamPineapplePizzaTextBox.Size = new System.Drawing.Size(55, 22);
            this.HamPineapplePizzaTextBox.TabIndex = 5;
            this.HamPineapplePizzaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PepperoniPizzaTextBox
            // 
            this.PepperoniPizzaTextBox.Location = new System.Drawing.Point(255, 70);
            this.PepperoniPizzaTextBox.Name = "PepperoniPizzaTextBox";
            this.PepperoniPizzaTextBox.Size = new System.Drawing.Size(55, 22);
            this.PepperoniPizzaTextBox.TabIndex = 4;
            this.PepperoniPizzaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MargheritaPizzaTextBox
            // 
            this.MargheritaPizzaTextBox.Location = new System.Drawing.Point(255, 36);
            this.MargheritaPizzaTextBox.Name = "MargheritaPizzaTextBox";
            this.MargheritaPizzaTextBox.Size = new System.Drawing.Size(55, 22);
            this.MargheritaPizzaTextBox.TabIndex = 3;
            this.MargheritaPizzaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputHamPineappleLabel
            // 
            this.OutputHamPineappleLabel.AutoSize = true;
            this.OutputHamPineappleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputHamPineappleLabel.Location = new System.Drawing.Point(80, 109);
            this.OutputHamPineappleLabel.Name = "OutputHamPineappleLabel";
            this.OutputHamPineappleLabel.Size = new System.Drawing.Size(128, 20);
            this.OutputHamPineappleLabel.TabIndex = 2;
            this.OutputHamPineappleLabel.Text = "Ham Pineapple ";
            // 
            // OutputPepperoniPizzaLabel
            // 
            this.OutputPepperoniPizzaLabel.AutoSize = true;
            this.OutputPepperoniPizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputPepperoniPizzaLabel.Location = new System.Drawing.Point(80, 70);
            this.OutputPepperoniPizzaLabel.Name = "OutputPepperoniPizzaLabel";
            this.OutputPepperoniPizzaLabel.Size = new System.Drawing.Size(131, 20);
            this.OutputPepperoniPizzaLabel.TabIndex = 1;
            this.OutputPepperoniPizzaLabel.Text = "Pepperoni Pizza";
            // 
            // OutputMargheritaPizzaLabel
            // 
            this.OutputMargheritaPizzaLabel.AutoSize = true;
            this.OutputMargheritaPizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputMargheritaPizzaLabel.Location = new System.Drawing.Point(80, 31);
            this.OutputMargheritaPizzaLabel.Name = "OutputMargheritaPizzaLabel";
            this.OutputMargheritaPizzaLabel.Size = new System.Drawing.Size(136, 20);
            this.OutputMargheritaPizzaLabel.TabIndex = 0;
            this.OutputMargheritaPizzaLabel.Text = "Margherita Pizza";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.ExitButton);
            this.ButtonPanel.Controls.Add(this.SummaryButton);
            this.ButtonPanel.Controls.Add(this.ClearButton);
            this.ButtonPanel.Controls.Add(this.OrderButton);
            this.ButtonPanel.Location = new System.Drawing.Point(19, 219);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(557, 53);
            this.ButtonPanel.TabIndex = 2;
            this.ButtonPanel.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitButton.Location = new System.Drawing.Point(410, 16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 27);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "&Exit";
            this.ExitButtonToolTip.SetToolTip(this.ExitButton, "Press to Exit Application");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SummaryButton.Enabled = false;
            this.SummaryButton.Location = new System.Drawing.Point(289, 16);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(94, 27);
            this.SummaryButton.TabIndex = 2;
            this.SummaryButton.Text = "&Summary";
            this.SummaryButtonToolTip.SetToolTip(this.SummaryButton, "Press for Company Summary Data");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClearButton.Location = new System.Drawing.Point(169, 16);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 27);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "&Clear";
            this.ClearButtonToolTip.SetToolTip(this.ClearButton, "Press to clear form for next user");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OrderButton.Location = new System.Drawing.Point(44, 16);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(94, 27);
            this.OrderButton.TabIndex = 0;
            this.OrderButton.Text = "&Order";
            this.OrderButtonToolTip.SetToolTip(this.OrderButton, "Press to submit order");
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // SultPictureBox
            // 
            this.SultPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SultPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SultPictureBox.Image")));
            this.SultPictureBox.Location = new System.Drawing.Point(190, 552);
            this.SultPictureBox.Name = "SultPictureBox";
            this.SultPictureBox.Size = new System.Drawing.Size(206, 79);
            this.SultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SultPictureBox.TabIndex = 3;
            this.SultPictureBox.TabStop = false;
            this.SultPictureBox.Visible = false;
            // 
            // TableOrderGroupBox
            // 
            this.TableOrderGroupBox.Controls.Add(this.TotalTableReceiptsLabel);
            this.TableOrderGroupBox.Controls.Add(this.TotalPizzasLabel);
            this.TableOrderGroupBox.Controls.Add(this.ServerNameLabel);
            this.TableOrderGroupBox.Controls.Add(this.OutputTableReceiptsLabel);
            this.TableOrderGroupBox.Controls.Add(this.OutputTotalPizzasLabel);
            this.TableOrderGroupBox.Controls.Add(this.OutputServersNameLabel);
            this.TableOrderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableOrderGroupBox.Location = new System.Drawing.Point(18, 293);
            this.TableOrderGroupBox.Name = "TableOrderGroupBox";
            this.TableOrderGroupBox.Size = new System.Drawing.Size(557, 231);
            this.TableOrderGroupBox.TabIndex = 4;
            this.TableOrderGroupBox.TabStop = false;
            this.TableOrderGroupBox.Text = "Table Order Summary Data";
            this.TableOrderGroupBox.Visible = false;
            // 
            // TotalTableReceiptsLabel
            // 
            this.TotalTableReceiptsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTableReceiptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTableReceiptsLabel.Location = new System.Drawing.Point(343, 141);
            this.TotalTableReceiptsLabel.Name = "TotalTableReceiptsLabel";
            this.TotalTableReceiptsLabel.Size = new System.Drawing.Size(157, 37);
            this.TotalTableReceiptsLabel.TabIndex = 5;
            this.TotalTableReceiptsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPizzasLabel
            // 
            this.TotalPizzasLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPizzasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPizzasLabel.Location = new System.Drawing.Point(343, 90);
            this.TotalPizzasLabel.Name = "TotalPizzasLabel";
            this.TotalPizzasLabel.Size = new System.Drawing.Size(157, 37);
            this.TotalPizzasLabel.TabIndex = 4;
            this.TotalPizzasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerNameLabel
            // 
            this.ServerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerNameLabel.Location = new System.Drawing.Point(344, 37);
            this.ServerNameLabel.Name = "ServerNameLabel";
            this.ServerNameLabel.Size = new System.Drawing.Size(157, 37);
            this.ServerNameLabel.TabIndex = 3;
            this.ServerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputTableReceiptsLabel
            // 
            this.OutputTableReceiptsLabel.AutoSize = true;
            this.OutputTableReceiptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTableReceiptsLabel.Location = new System.Drawing.Point(72, 154);
            this.OutputTableReceiptsLabel.Name = "OutputTableReceiptsLabel";
            this.OutputTableReceiptsLabel.Size = new System.Drawing.Size(163, 20);
            this.OutputTableReceiptsLabel.TabIndex = 2;
            this.OutputTableReceiptsLabel.Text = "Total Table Receipts";
            // 
            // OutputTotalPizzasLabel
            // 
            this.OutputTotalPizzasLabel.AutoSize = true;
            this.OutputTotalPizzasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTotalPizzasLabel.Location = new System.Drawing.Point(72, 99);
            this.OutputTotalPizzasLabel.Name = "OutputTotalPizzasLabel";
            this.OutputTotalPizzasLabel.Size = new System.Drawing.Size(170, 20);
            this.OutputTotalPizzasLabel.TabIndex = 1;
            this.OutputTotalPizzasLabel.Text = "Total Number Pizza\'s";
            // 
            // OutputServersNameLabel
            // 
            this.OutputServersNameLabel.AutoSize = true;
            this.OutputServersNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputServersNameLabel.Location = new System.Drawing.Point(72, 46);
            this.OutputServersNameLabel.Name = "OutputServersNameLabel";
            this.OutputServersNameLabel.Size = new System.Drawing.Size(116, 20);
            this.OutputServersNameLabel.TabIndex = 0;
            this.OutputServersNameLabel.Text = "Servers Name";
            // 
            // CompanySummaryGroupBox
            // 
            this.CompanySummaryGroupBox.Controls.Add(this.AvgTransactionValueLabel);
            this.CompanySummaryGroupBox.Controls.Add(this.OutputAvgTransactionValueLabel);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalCompanyReceiptsLabel);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalNumberPizzaSummaryLabel);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalCompanyTransactionsLabel);
            this.CompanySummaryGroupBox.Controls.Add(this.OutputCompanyReceiptLabel);
            this.CompanySummaryGroupBox.Controls.Add(this.OutputTotalPizzaSummaryLabel);
            this.CompanySummaryGroupBox.Controls.Add(this.OutputCompanyTransactionsLabel);
            this.CompanySummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanySummaryGroupBox.Location = new System.Drawing.Point(17, 293);
            this.CompanySummaryGroupBox.Name = "CompanySummaryGroupBox";
            this.CompanySummaryGroupBox.Size = new System.Drawing.Size(561, 223);
            this.CompanySummaryGroupBox.TabIndex = 5;
            this.CompanySummaryGroupBox.TabStop = false;
            this.CompanySummaryGroupBox.Text = "Company Summary Data";
            this.CompanySummaryGroupBox.Visible = false;
            // 
            // AvgTransactionValueLabel
            // 
            this.AvgTransactionValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvgTransactionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgTransactionValueLabel.Location = new System.Drawing.Point(346, 172);
            this.AvgTransactionValueLabel.Name = "AvgTransactionValueLabel";
            this.AvgTransactionValueLabel.Size = new System.Drawing.Size(157, 38);
            this.AvgTransactionValueLabel.TabIndex = 7;
            this.AvgTransactionValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputAvgTransactionValueLabel
            // 
            this.OutputAvgTransactionValueLabel.AutoSize = true;
            this.OutputAvgTransactionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputAvgTransactionValueLabel.Location = new System.Drawing.Point(83, 180);
            this.OutputAvgTransactionValueLabel.Name = "OutputAvgTransactionValueLabel";
            this.OutputAvgTransactionValueLabel.Size = new System.Drawing.Size(177, 20);
            this.OutputAvgTransactionValueLabel.TabIndex = 6;
            this.OutputAvgTransactionValueLabel.Text = "Avg Transaction Value";
            this.OutputAvgTransactionValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCompanyReceiptsLabel
            // 
            this.TotalCompanyReceiptsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCompanyReceiptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCompanyReceiptsLabel.Location = new System.Drawing.Point(346, 116);
            this.TotalCompanyReceiptsLabel.Name = "TotalCompanyReceiptsLabel";
            this.TotalCompanyReceiptsLabel.Size = new System.Drawing.Size(157, 37);
            this.TotalCompanyReceiptsLabel.TabIndex = 5;
            this.TotalCompanyReceiptsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalNumberPizzaSummaryLabel
            // 
            this.TotalNumberPizzaSummaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalNumberPizzaSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNumberPizzaSummaryLabel.Location = new System.Drawing.Point(346, 66);
            this.TotalNumberPizzaSummaryLabel.Name = "TotalNumberPizzaSummaryLabel";
            this.TotalNumberPizzaSummaryLabel.Size = new System.Drawing.Size(157, 37);
            this.TotalNumberPizzaSummaryLabel.TabIndex = 4;
            this.TotalNumberPizzaSummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCompanyTransactionsLabel
            // 
            this.TotalCompanyTransactionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCompanyTransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCompanyTransactionsLabel.Location = new System.Drawing.Point(346, 17);
            this.TotalCompanyTransactionsLabel.Name = "TotalCompanyTransactionsLabel";
            this.TotalCompanyTransactionsLabel.Size = new System.Drawing.Size(157, 37);
            this.TotalCompanyTransactionsLabel.TabIndex = 3;
            this.TotalCompanyTransactionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputCompanyReceiptLabel
            // 
            this.OutputCompanyReceiptLabel.AutoSize = true;
            this.OutputCompanyReceiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputCompanyReceiptLabel.Location = new System.Drawing.Point(81, 133);
            this.OutputCompanyReceiptLabel.Name = "OutputCompanyReceiptLabel";
            this.OutputCompanyReceiptLabel.Size = new System.Drawing.Size(192, 20);
            this.OutputCompanyReceiptLabel.TabIndex = 2;
            this.OutputCompanyReceiptLabel.Text = "Total Company Receipts";
            // 
            // OutputTotalPizzaSummaryLabel
            // 
            this.OutputTotalPizzaSummaryLabel.AutoSize = true;
            this.OutputTotalPizzaSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTotalPizzaSummaryLabel.Location = new System.Drawing.Point(83, 78);
            this.OutputTotalPizzaSummaryLabel.Name = "OutputTotalPizzaSummaryLabel";
            this.OutputTotalPizzaSummaryLabel.Size = new System.Drawing.Size(170, 20);
            this.OutputTotalPizzaSummaryLabel.TabIndex = 1;
            this.OutputTotalPizzaSummaryLabel.Text = "Total Number Pizza\'s";
            // 
            // OutputCompanyTransactionsLabel
            // 
            this.OutputCompanyTransactionsLabel.AutoSize = true;
            this.OutputCompanyTransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputCompanyTransactionsLabel.Location = new System.Drawing.Point(81, 25);
            this.OutputCompanyTransactionsLabel.Name = "OutputCompanyTransactionsLabel";
            this.OutputCompanyTransactionsLabel.Size = new System.Drawing.Size(223, 20);
            this.OutputCompanyTransactionsLabel.TabIndex = 0;
            this.OutputCompanyTransactionsLabel.Text = "Total Company Transactions";
            // 
            // OrderButtonToolTip
            // 
            this.OrderButtonToolTip.IsBalloon = true;
            this.OrderButtonToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ClearButtonToolTip
            // 
            this.ClearButtonToolTip.IsBalloon = true;
            this.ClearButtonToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // SummaryButtonToolTip
            // 
            this.SummaryButtonToolTip.IsBalloon = true;
            this.SummaryButtonToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ExitButtonToolTip
            // 
            this.ExitButtonToolTip.IsBalloon = true;
            this.ExitButtonToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 643);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.SultPictureBox);
            this.Controls.Add(this.PizzaGroupBox);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.TableOrderGroupBox);
            this.Controls.Add(this.CompanySummaryGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Welcome to Sult";
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.PizzaGroupBox.ResumeLayout(false);
            this.PizzaGroupBox.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SultPictureBox)).EndInit();
            this.TableOrderGroupBox.ResumeLayout(false);
            this.TableOrderGroupBox.PerformLayout();
            this.CompanySummaryGroupBox.ResumeLayout(false);
            this.CompanySummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox TableNumberTextBox;
        private System.Windows.Forms.Label OutputTableNumberLabel;
        private System.Windows.Forms.TextBox ServerNameTextBox;
        private System.Windows.Forms.Label OutputServerNameLabel;
        private System.Windows.Forms.GroupBox PizzaGroupBox;
        private System.Windows.Forms.Label OutputHamPineappleLabel;
        private System.Windows.Forms.Label OutputPepperoniPizzaLabel;
        private System.Windows.Forms.Label OutputMargheritaPizzaLabel;
        private System.Windows.Forms.Label HamPineapplePriceLabel;
        private System.Windows.Forms.Label PepperoniPizzaPriceLabel;
        private System.Windows.Forms.Label MargheritaPizzaPriceLabel;
        private System.Windows.Forms.TextBox HamPineapplePizzaTextBox;
        private System.Windows.Forms.TextBox PepperoniPizzaTextBox;
        private System.Windows.Forms.TextBox MargheritaPizzaTextBox;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.PictureBox SultPictureBox;
        private System.Windows.Forms.GroupBox TableOrderGroupBox;
        private System.Windows.Forms.Label TotalTableReceiptsLabel;
        private System.Windows.Forms.Label TotalPizzasLabel;
        private System.Windows.Forms.Label ServerNameLabel;
        private System.Windows.Forms.Label OutputTableReceiptsLabel;
        private System.Windows.Forms.Label OutputTotalPizzasLabel;
        private System.Windows.Forms.Label OutputServersNameLabel;
        private System.Windows.Forms.GroupBox CompanySummaryGroupBox;
        private System.Windows.Forms.Label AvgTransactionValueLabel;
        private System.Windows.Forms.Label OutputAvgTransactionValueLabel;
        private System.Windows.Forms.Label TotalCompanyReceiptsLabel;
        private System.Windows.Forms.Label TotalNumberPizzaSummaryLabel;
        private System.Windows.Forms.Label TotalCompanyTransactionsLabel;
        private System.Windows.Forms.Label OutputCompanyReceiptLabel;
        private System.Windows.Forms.Label OutputTotalPizzaSummaryLabel;
        private System.Windows.Forms.Label OutputCompanyTransactionsLabel;
        private System.Windows.Forms.ToolTip OrderButtonToolTip;
        private System.Windows.Forms.ToolTip ClearButtonToolTip;
        private System.Windows.Forms.ToolTip SummaryButtonToolTip;
        private System.Windows.Forms.ToolTip ExitButtonToolTip;
    }
}

