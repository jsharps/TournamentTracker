namespace TrackerUI
{
    partial class TournamentView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            label2 = new Label();
            teamOneScoreText = new TextBox();
            teamTwoScoreText = new TextBox();
            label3 = new Label();
            teamTwoName = new Label();
            label4 = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 35);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.Location = new Point(152, 35);
            tournamentName.Margin = new Padding(0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(62, 20);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.Location = new Point(71, 74);
            roundLabel.Margin = new Padding(0);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(52, 20);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(161, 71);
            roundDropDown.Margin = new Padding(0);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(121, 28);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckBox.Location = new Point(162, 110);
            unplayedOnlyCheckBox.Margin = new Padding(0);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(91, 24);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 20;
            matchupListBox.Location = new Point(17, 138);
            matchupListBox.Margin = new Padding(0);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(265, 202);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.Location = new Point(301, 138);
            teamOneName.Margin = new Padding(0);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(92, 20);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(346, 175);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Score";
            // 
            // teamOneScoreText
            // 
            teamOneScoreText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreText.Location = new Point(425, 172);
            teamOneScoreText.Margin = new Padding(0);
            teamOneScoreText.Name = "teamOneScoreText";
            teamOneScoreText.Size = new Size(100, 27);
            teamOneScoreText.TabIndex = 8;
            // 
            // teamTwoScoreText
            // 
            teamTwoScoreText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreText.Location = new Point(425, 286);
            teamTwoScoreText.Margin = new Padding(0);
            teamTwoScoreText.Name = "teamTwoScoreText";
            teamTwoScoreText.Size = new Size(100, 27);
            teamTwoScoreText.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(346, 289);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 10;
            label3.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoName.Location = new Point(301, 252);
            teamTwoName.Margin = new Padding(0);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(92, 20);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<team two>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(450, 231);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 12;
            label4.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            scoreButton.Location = new Point(535, 226);
            scoreButton.Margin = new Padding(0);
            scoreButton.Name = "scoreButton";
            scoreButton.Padding = new Padding(5);
            scoreButton.Size = new Size(84, 34);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(810, 381);
            Controls.Add(scoreButton);
            Controls.Add(label4);
            Controls.Add(teamTwoScoreText);
            Controls.Add(label3);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreText);
            Controls.Add(label2);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            MinimumSize = new Size(720, 420);
            Name = "TournamentView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tournament Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label label2;
        private TextBox teamOneScoreText;
        private TextBox teamTwoScoreText;
        private Label label3;
        private Label teamTwoName;
        private Label label4;
        private Button scoreButton;
    }
}