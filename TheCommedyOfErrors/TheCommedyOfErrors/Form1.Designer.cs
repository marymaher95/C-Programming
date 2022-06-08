namespace TheCommedyOfErrors
{
    partial class JokeAndPunchline
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
            this.SetUpButton = new System.Windows.Forms.Button();
            this.PunchlineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetUpButton
            // 
            this.SetUpButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SetUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetUpButton.Location = new System.Drawing.Point(210, 196);
            this.SetUpButton.Name = "SetUpButton";
            this.SetUpButton.Size = new System.Drawing.Size(161, 62);
            this.SetUpButton.TabIndex = 0;
            this.SetUpButton.Text = "Set Up";
            this.SetUpButton.UseVisualStyleBackColor = false;
            this.SetUpButton.Click += new System.EventHandler(this.SetUpButton_Click);
            // 
            // PunchlineButton
            // 
            this.PunchlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunchlineButton.Location = new System.Drawing.Point(451, 196);
            this.PunchlineButton.Name = "PunchlineButton";
            this.PunchlineButton.Size = new System.Drawing.Size(161, 62);
            this.PunchlineButton.TabIndex = 1;
            this.PunchlineButton.Text = "Punch Line";
            this.PunchlineButton.UseVisualStyleBackColor = true;
            this.PunchlineButton.Click += new System.EventHandler(this.PunchlineButton_Click);
            // 
            // JokeAndPunchline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PunchlineButton);
            this.Controls.Add(this.SetUpButton);
            this.Name = "JokeAndPunchline";
            this.Text = "Joke and Punchline";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetUpButton;
        private System.Windows.Forms.Button PunchlineButton;
    }
}

