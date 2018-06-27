namespace BeechwoodClassic
{
    partial class TeamGenerator
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
            this.TwoManScramble = new System.Windows.Forms.RadioButton();
            this.FourManScramble = new System.Windows.Forms.RadioButton();
            this.Team1 = new System.Windows.Forms.RichTextBox();
            this.Team2 = new System.Windows.Forms.RichTextBox();
            this.Team3 = new System.Windows.Forms.RichTextBox();
            this.Team4 = new System.Windows.Forms.RichTextBox();
            this.Team5 = new System.Windows.Forms.RichTextBox();
            this.Team6 = new System.Windows.Forms.RichTextBox();
            this.Team7 = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.vsLabel = new System.Windows.Forms.Label();
            this.usaLabel = new System.Windows.Forms.Label();
            this.europeLabel = new System.Windows.Forms.Label();
            this.Team8 = new System.Windows.Forms.RichTextBox();
            this.Team9 = new System.Windows.Forms.RichTextBox();
            this.Team10 = new System.Windows.Forms.RichTextBox();
            this.Team11 = new System.Windows.Forms.RichTextBox();
            this.Team12 = new System.Windows.Forms.RichTextBox();
            this.Team13 = new System.Windows.Forms.RichTextBox();
            this.Team14 = new System.Windows.Forms.RichTextBox();
            this.Team1Sum = new System.Windows.Forms.Label();
            this.Team2Sum = new System.Windows.Forms.Label();
            this.Team3Sum = new System.Windows.Forms.Label();
            this.Team4Sum = new System.Windows.Forms.Label();
            this.Team5Sum = new System.Windows.Forms.Label();
            this.Team6Sum = new System.Windows.Forms.Label();
            this.Team7Sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TwoManScramble
            // 
            this.TwoManScramble.AutoSize = true;
            this.TwoManScramble.Location = new System.Drawing.Point(333, 12);
            this.TwoManScramble.Name = "TwoManScramble";
            this.TwoManScramble.Size = new System.Drawing.Size(102, 17);
            this.TwoManScramble.TabIndex = 0;
            this.TwoManScramble.Text = "2-Man Scramble";
            this.TwoManScramble.UseVisualStyleBackColor = true;
            this.TwoManScramble.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FourManScramble
            // 
            this.FourManScramble.AutoSize = true;
            this.FourManScramble.Checked = true;
            this.FourManScramble.Location = new System.Drawing.Point(331, 35);
            this.FourManScramble.Name = "FourManScramble";
            this.FourManScramble.Size = new System.Drawing.Size(102, 17);
            this.FourManScramble.TabIndex = 1;
            this.FourManScramble.TabStop = true;
            this.FourManScramble.Text = "4-Man Scramble";
            this.FourManScramble.UseVisualStyleBackColor = true;
            // 
            // Team1
            // 
            this.Team1.Location = new System.Drawing.Point(13, 110);
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(100, 96);
            this.Team1.TabIndex = 2;
            this.Team1.Text = "";
            // 
            // Team2
            // 
            this.Team2.Location = new System.Drawing.Point(120, 110);
            this.Team2.Name = "Team2";
            this.Team2.Size = new System.Drawing.Size(100, 96);
            this.Team2.TabIndex = 3;
            this.Team2.Text = "";
            // 
            // Team3
            // 
            this.Team3.Location = new System.Drawing.Point(226, 110);
            this.Team3.Name = "Team3";
            this.Team3.Size = new System.Drawing.Size(100, 96);
            this.Team3.TabIndex = 4;
            this.Team3.Text = "";
            // 
            // Team4
            // 
            this.Team4.Location = new System.Drawing.Point(333, 110);
            this.Team4.Name = "Team4";
            this.Team4.Size = new System.Drawing.Size(100, 96);
            this.Team4.TabIndex = 5;
            this.Team4.Text = "";
            // 
            // Team5
            // 
            this.Team5.Location = new System.Drawing.Point(440, 110);
            this.Team5.Name = "Team5";
            this.Team5.Size = new System.Drawing.Size(100, 96);
            this.Team5.TabIndex = 6;
            this.Team5.Text = "";
            // 
            // Team6
            // 
            this.Team6.Location = new System.Drawing.Point(547, 110);
            this.Team6.Name = "Team6";
            this.Team6.Size = new System.Drawing.Size(100, 96);
            this.Team6.TabIndex = 7;
            this.Team6.Text = "";
            // 
            // Team7
            // 
            this.Team7.Location = new System.Drawing.Point(654, 110);
            this.Team7.Name = "Team7";
            this.Team7.Size = new System.Drawing.Size(100, 96);
            this.Team7.TabIndex = 8;
            this.Team7.Text = "";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(333, 450);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 9;
            this.GenerateButton.Text = "Generate!";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Location = new System.Drawing.Point(372, 239);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(21, 13);
            this.vsLabel.TabIndex = 10;
            this.vsLabel.Text = "VS";
            this.vsLabel.Visible = false;
            // 
            // usaLabel
            // 
            this.usaLabel.AutoSize = true;
            this.usaLabel.ForeColor = System.Drawing.Color.Red;
            this.usaLabel.Location = new System.Drawing.Point(364, 91);
            this.usaLabel.Name = "usaLabel";
            this.usaLabel.Size = new System.Drawing.Size(29, 13);
            this.usaLabel.TabIndex = 11;
            this.usaLabel.Text = "USA";
            this.usaLabel.Visible = false;
            // 
            // europeLabel
            // 
            this.europeLabel.AutoSize = true;
            this.europeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.europeLabel.Location = new System.Drawing.Point(367, 277);
            this.europeLabel.Name = "europeLabel";
            this.europeLabel.Size = new System.Drawing.Size(41, 13);
            this.europeLabel.TabIndex = 12;
            this.europeLabel.Text = "Europe";
            this.europeLabel.Visible = false;
            // 
            // Team8
            // 
            this.Team8.Location = new System.Drawing.Point(13, 315);
            this.Team8.Name = "Team8";
            this.Team8.Size = new System.Drawing.Size(100, 96);
            this.Team8.TabIndex = 13;
            this.Team8.Text = "";
            this.Team8.Visible = false;
            // 
            // Team9
            // 
            this.Team9.Location = new System.Drawing.Point(120, 315);
            this.Team9.Name = "Team9";
            this.Team9.Size = new System.Drawing.Size(100, 96);
            this.Team9.TabIndex = 14;
            this.Team9.Text = "";
            this.Team9.Visible = false;
            // 
            // Team10
            // 
            this.Team10.Location = new System.Drawing.Point(226, 315);
            this.Team10.Name = "Team10";
            this.Team10.Size = new System.Drawing.Size(100, 96);
            this.Team10.TabIndex = 15;
            this.Team10.Text = "";
            this.Team10.Visible = false;
            // 
            // Team11
            // 
            this.Team11.Location = new System.Drawing.Point(333, 315);
            this.Team11.Name = "Team11";
            this.Team11.Size = new System.Drawing.Size(100, 96);
            this.Team11.TabIndex = 16;
            this.Team11.Text = "";
            this.Team11.Visible = false;
            // 
            // Team12
            // 
            this.Team12.Location = new System.Drawing.Point(440, 315);
            this.Team12.Name = "Team12";
            this.Team12.Size = new System.Drawing.Size(100, 96);
            this.Team12.TabIndex = 17;
            this.Team12.Text = "";
            this.Team12.Visible = false;
            // 
            // Team13
            // 
            this.Team13.Location = new System.Drawing.Point(547, 315);
            this.Team13.Name = "Team13";
            this.Team13.Size = new System.Drawing.Size(100, 96);
            this.Team13.TabIndex = 18;
            this.Team13.Text = "";
            this.Team13.Visible = false;
            // 
            // Team14
            // 
            this.Team14.Location = new System.Drawing.Point(654, 315);
            this.Team14.Name = "Team14";
            this.Team14.Size = new System.Drawing.Size(100, 96);
            this.Team14.TabIndex = 19;
            this.Team14.Text = "";
            this.Team14.Visible = false;
            // 
            // Team1Sum
            // 
            this.Team1Sum.AutoSize = true;
            this.Team1Sum.Location = new System.Drawing.Point(63, 213);
            this.Team1Sum.Name = "Team1Sum";
            this.Team1Sum.Size = new System.Drawing.Size(0, 13);
            this.Team1Sum.TabIndex = 20;
            // 
            // Team2Sum
            // 
            this.Team2Sum.AutoSize = true;
            this.Team2Sum.Location = new System.Drawing.Point(162, 213);
            this.Team2Sum.Name = "Team2Sum";
            this.Team2Sum.Size = new System.Drawing.Size(0, 13);
            this.Team2Sum.TabIndex = 21;
            // 
            // Team3Sum
            // 
            this.Team3Sum.AutoSize = true;
            this.Team3Sum.Location = new System.Drawing.Point(270, 213);
            this.Team3Sum.Name = "Team3Sum";
            this.Team3Sum.Size = new System.Drawing.Size(0, 13);
            this.Team3Sum.TabIndex = 22;
            // 
            // Team4Sum
            // 
            this.Team4Sum.AutoSize = true;
            this.Team4Sum.Location = new System.Drawing.Point(357, 214);
            this.Team4Sum.Name = "Team4Sum";
            this.Team4Sum.Size = new System.Drawing.Size(0, 13);
            this.Team4Sum.TabIndex = 23;
            // 
            // Team5Sum
            // 
            this.Team5Sum.AutoSize = true;
            this.Team5Sum.Location = new System.Drawing.Point(488, 213);
            this.Team5Sum.Name = "Team5Sum";
            this.Team5Sum.Size = new System.Drawing.Size(0, 13);
            this.Team5Sum.TabIndex = 24;
            // 
            // Team6Sum
            // 
            this.Team6Sum.AutoSize = true;
            this.Team6Sum.Location = new System.Drawing.Point(591, 213);
            this.Team6Sum.Name = "Team6Sum";
            this.Team6Sum.Size = new System.Drawing.Size(0, 13);
            this.Team6Sum.TabIndex = 25;
            // 
            // Team7Sum
            // 
            this.Team7Sum.AutoSize = true;
            this.Team7Sum.Location = new System.Drawing.Point(700, 213);
            this.Team7Sum.Name = "Team7Sum";
            this.Team7Sum.Size = new System.Drawing.Size(0, 13);
            this.Team7Sum.TabIndex = 26;
            // 
            // TeamGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 485);
            this.Controls.Add(this.Team7Sum);
            this.Controls.Add(this.Team6Sum);
            this.Controls.Add(this.Team5Sum);
            this.Controls.Add(this.Team4Sum);
            this.Controls.Add(this.Team3Sum);
            this.Controls.Add(this.Team2Sum);
            this.Controls.Add(this.Team1Sum);
            this.Controls.Add(this.Team14);
            this.Controls.Add(this.Team13);
            this.Controls.Add(this.Team12);
            this.Controls.Add(this.Team11);
            this.Controls.Add(this.Team10);
            this.Controls.Add(this.Team9);
            this.Controls.Add(this.Team8);
            this.Controls.Add(this.europeLabel);
            this.Controls.Add(this.usaLabel);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.Team7);
            this.Controls.Add(this.Team6);
            this.Controls.Add(this.Team5);
            this.Controls.Add(this.Team4);
            this.Controls.Add(this.Team3);
            this.Controls.Add(this.Team2);
            this.Controls.Add(this.Team1);
            this.Controls.Add(this.FourManScramble);
            this.Controls.Add(this.TwoManScramble);
            this.Name = "TeamGenerator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton TwoManScramble;
        public System.Windows.Forms.RadioButton FourManScramble;
        private System.Windows.Forms.RichTextBox Team1;
        private System.Windows.Forms.RichTextBox Team2;
        private System.Windows.Forms.RichTextBox Team3;
        private System.Windows.Forms.RichTextBox Team4;
        private System.Windows.Forms.RichTextBox Team5;
        private System.Windows.Forms.RichTextBox Team6;
        private System.Windows.Forms.RichTextBox Team7;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Label usaLabel;
        private System.Windows.Forms.Label europeLabel;
        private System.Windows.Forms.RichTextBox Team8;
        private System.Windows.Forms.RichTextBox Team9;
        private System.Windows.Forms.RichTextBox Team10;
        private System.Windows.Forms.RichTextBox Team11;
        private System.Windows.Forms.RichTextBox Team12;
        private System.Windows.Forms.RichTextBox Team13;
        private System.Windows.Forms.RichTextBox Team14;
        private System.Windows.Forms.Label Team1Sum;
        private System.Windows.Forms.Label Team2Sum;
        private System.Windows.Forms.Label Team3Sum;
        private System.Windows.Forms.Label Team4Sum;
        private System.Windows.Forms.Label Team5Sum;
        private System.Windows.Forms.Label Team6Sum;
        private System.Windows.Forms.Label Team7Sum;
    }
}

