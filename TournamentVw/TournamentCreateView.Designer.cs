namespace TrackerUI
{
    partial class TournamentCreateView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            teamDropDown = new ComboBox();
            entryFee = new TextBox();
            tournamentName = new TextBox();
            linkLabel1 = new LinkLabel();
            scoreButton = new Button();
            tournamentPlayersListBox = new ListBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            prizeListBox = new ListBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(384, 20);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(430, 65);
            label1.TabIndex = 15;
            label1.Text = "Create Tournament";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 109);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(419, 65);
            label2.TabIndex = 16;
            label2.Text = "Tournament Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 277);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(221, 65);
            label3.TabIndex = 17;
            label3.Text = "Entry Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 369);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(277, 65);
            label4.TabIndex = 18;
            label4.Text = "Select Team";
            // 
            // teamDropDown
            // 
            teamDropDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamDropDown.FormattingEnabled = true;
            teamDropDown.Location = new Point(487, 369);
            teamDropDown.Margin = new Padding(0);
            teamDropDown.Name = "teamDropDown";
            teamDropDown.Size = new Size(620, 70);
            teamDropDown.TabIndex = 19;
            // 
            // entryFee
            // 
            entryFee.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            entryFee.Location = new Point(487, 274);
            entryFee.Margin = new Padding(0);
            entryFee.Name = "entryFee";
            entryFee.Size = new Size(288, 71);
            entryFee.TabIndex = 23;
            // 
            // tournamentName
            // 
            tournamentName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.Location = new Point(30, 179);
            tournamentName.Margin = new Padding(0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(1077, 71);
            tournamentName.TabIndex = 24;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(935, 328);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(172, 41);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create New";
            // 
            // scoreButton
            // 
            scoreButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
            scoreButton.Location = new Point(814, 452);
            scoreButton.Margin = new Padding(0);
            scoreButton.Name = "scoreButton";
            scoreButton.Padding = new Padding(12, 14, 12, 14);
            scoreButton.Size = new Size(293, 70);
            scoreButton.TabIndex = 28;
            scoreButton.Text = "Add Team";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 62;
            tournamentPlayersListBox.Location = new Point(487, 548);
            tournamentPlayersListBox.Margin = new Padding(0);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(620, 374);
            tournamentPlayersListBox.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 457);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(351, 65);
            label5.TabIndex = 31;
            label5.Text = "Teams / Players";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(814, 941);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 14, 12, 14);
            button1.Size = new Size(293, 70);
            button1.TabIndex = 32;
            button1.Text = "Delete Team";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(814, 1413);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(12, 14, 12, 14);
            button2.Size = new Size(293, 70);
            button2.TabIndex = 35;
            button2.Text = "Delete Prize";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 941);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(351, 65);
            label6.TabIndex = 34;
            label6.Text = "Teams / Players";
            // 
            // prizeListBox
            // 
            prizeListBox.BorderStyle = BorderStyle.FixedSingle;
            prizeListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeListBox.FormattingEnabled = true;
            prizeListBox.ItemHeight = 62;
            prizeListBox.Location = new Point(487, 1027);
            prizeListBox.Margin = new Padding(0);
            prizeListBox.Name = "prizeListBox";
            prizeListBox.Size = new Size(620, 374);
            prizeListBox.TabIndex = 33;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(487, 1413);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Padding = new Padding(12, 14, 12, 14);
            button3.Size = new Size(293, 70);
            button3.TabIndex = 36;
            button3.Text = "New Prize";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(424, 1520);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Padding = new Padding(12, 14, 12, 14);
            button4.Size = new Size(293, 93);
            button4.TabIndex = 37;
            button4.Text = "New Prize";
            button4.UseVisualStyleBackColor = true;
            // 
            // TournamentCreateView
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 1622);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(prizeListBox);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(scoreButton);
            Controls.Add(linkLabel1);
            Controls.Add(tournamentName);
            Controls.Add(entryFee);
            Controls.Add(teamDropDown);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TournamentCreateView";
            Text = "TournamentCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox teamDropDown;
        private TextBox entryFee;
        private TextBox tournamentName;
        private LinkLabel linkLabel1;
        private Button scoreButton;
        private ListBox tournamentPlayersListBox;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label6;
        private ListBox prizeListBox;
        private Button button3;
        private Button button4;
    }
}