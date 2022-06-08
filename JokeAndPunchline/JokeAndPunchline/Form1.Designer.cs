namespace JokeAndPunchline
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
            this.LabelSetUpJoke = new System.Windows.Forms.Label();
            this.LabelPunchLine = new System.Windows.Forms.Label();
            this.ShowSetupbutton = new System.Windows.Forms.Button();
            this.ShowPunchlineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelSetUpJoke
            // 
            this.LabelSetUpJoke.AutoSize = true;
            this.LabelSetUpJoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetUpJoke.Location = new System.Drawing.Point(122, 76);
            this.LabelSetUpJoke.Name = "LabelSetUpJoke";
            this.LabelSetUpJoke.Size = new System.Drawing.Size(468, 25);
            this.LabelSetUpJoke.TabIndex = 0;
            this.LabelSetUpJoke.Text = "What do you call a Sheep and a Kangaroo together?";
            this.LabelSetUpJoke.Visible = false;
            // 
            // LabelPunchLine
            // 
            this.LabelPunchLine.AutoSize = true;
            this.LabelPunchLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPunchLine.Location = new System.Drawing.Point(263, 114);
            this.LabelPunchLine.Name = "LabelPunchLine";
            this.LabelPunchLine.Size = new System.Drawing.Size(179, 25);
            this.LabelPunchLine.TabIndex = 1;
            this.LabelPunchLine.Text = "A Wooly Jumper!";
            this.LabelPunchLine.Visible = false;
            // 
            // ShowSetupbutton
            // 
            this.ShowSetupbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSetupbutton.Location = new System.Drawing.Point(115, 176);
            this.ShowSetupbutton.Name = "ShowSetupbutton";
            this.ShowSetupbutton.Size = new System.Drawing.Size(150, 57);
            this.ShowSetupbutton.TabIndex = 2;
            this.ShowSetupbutton.Text = "Set Up";
            this.ShowSetupbutton.UseVisualStyleBackColor = true;
            this.ShowSetupbutton.Click += new System.EventHandler(this.ShowSetupbutton_Click);
            // 
            // ShowPunchlineButton
            // 
            this.ShowPunchlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPunchlineButton.Location = new System.Drawing.Point(412, 176);
            this.ShowPunchlineButton.Name = "ShowPunchlineButton";
            this.ShowPunchlineButton.Size = new System.Drawing.Size(152, 57);
            this.ShowPunchlineButton.TabIndex = 3;
            this.ShowPunchlineButton.Text = "Punch Line";
            this.ShowPunchlineButton.UseVisualStyleBackColor = true;
            this.ShowPunchlineButton.Click += new System.EventHandler(this.ShowPunchlineButton_Click);
            // 
            // JokeAndPunchline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 362);
            this.Controls.Add(this.ShowPunchlineButton);
            this.Controls.Add(this.ShowSetupbutton);
            this.Controls.Add(this.LabelPunchLine);
            this.Controls.Add(this.LabelSetUpJoke);
            this.Name = "JokeAndPunchline";
            this.Text = "Joke And Punchline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSetUpJoke;
        private System.Windows.Forms.Label LabelPunchLine;
        private System.Windows.Forms.Button ShowSetupbutton;
        private System.Windows.Forms.Button ShowPunchlineButton;
    }
}

