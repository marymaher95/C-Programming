namespace Maher_Mary_Assignment4_MS806
{
    partial class ManagementReport
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
            this.Exitbutton = new System.Windows.Forms.Button();
            this.ManagementReportListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(666, 303);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(94, 30);
            this.Exitbutton.TabIndex = 0;
            this.Exitbutton.Text = "&Close";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // ManagementReportListBox
            // 
            this.ManagementReportListBox.FormattingEnabled = true;
            this.ManagementReportListBox.ItemHeight = 16;
            this.ManagementReportListBox.Location = new System.Drawing.Point(59, 59);
            this.ManagementReportListBox.Name = "ManagementReportListBox";
            this.ManagementReportListBox.Size = new System.Drawing.Size(701, 180);
            this.ManagementReportListBox.TabIndex = 1;
            // 
            // ManagementReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.ManagementReportListBox);
            this.Controls.Add(this.Exitbutton);
            this.Name = "ManagementReport";
            this.Text = "ManagementReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.ListBox ManagementReportListBox;
    }
}