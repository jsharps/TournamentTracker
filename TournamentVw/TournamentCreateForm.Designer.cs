namespace TrackerUI
{
	partial class TournamentCreateForm
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
			label1.Location = new Point(181, 10);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(219, 32);
			label1.TabIndex = 15;
			label1.Text = "Create Tournament";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(14, 53);
			label2.Margin = new Padding(0);
			label2.Name = "label2";
			label2.Size = new Size(214, 32);
			label2.TabIndex = 16;
			label2.Text = "Tournament Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(14, 135);
			label3.Margin = new Padding(0);
			label3.Name = "label3";
			label3.Size = new Size(113, 32);
			label3.TabIndex = 17;
			label3.Text = "Entry Fee";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(14, 180);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(142, 32);
			label4.TabIndex = 18;
			label4.Text = "Select Team";
			// 
			// teamDropDown
			// 
			teamDropDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			teamDropDown.FormattingEnabled = true;
			teamDropDown.Location = new Point(229, 180);
			teamDropDown.Margin = new Padding(0);
			teamDropDown.Name = "teamDropDown";
			teamDropDown.Size = new Size(294, 40);
			teamDropDown.TabIndex = 19;
			// 
			// entryFee
			// 
			entryFee.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			entryFee.Location = new Point(229, 134);
			entryFee.Margin = new Padding(0);
			entryFee.Name = "entryFee";
			entryFee.Size = new Size(138, 39);
			entryFee.TabIndex = 23;
			// 
			// tournamentName
			// 
			tournamentName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			tournamentName.Location = new Point(14, 87);
			tournamentName.Margin = new Padding(0);
			tournamentName.Name = "tournamentName";
			tournamentName.Size = new Size(509, 39);
			tournamentName.TabIndex = 24;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(440, 160);
			linkLabel1.Margin = new Padding(1, 0, 1, 0);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(86, 20);
			linkLabel1.TabIndex = 25;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Create New";
			// 
			// scoreButton
			// 
			scoreButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			scoreButton.Location = new Point(383, 230);
			scoreButton.Margin = new Padding(0);
			scoreButton.Name = "scoreButton";
			scoreButton.Padding = new Padding(6, 7, 6, 7);
			scoreButton.Size = new Size(138, 47);
			scoreButton.TabIndex = 28;
			scoreButton.Text = "Add Team";
			scoreButton.UseVisualStyleBackColor = true;
			// 
			// tournamentPlayersListBox
			// 
			tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
			tournamentPlayersListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			tournamentPlayersListBox.FormattingEnabled = true;
			tournamentPlayersListBox.ItemHeight = 32;
			tournamentPlayersListBox.Location = new Point(228, 288);
			tournamentPlayersListBox.Margin = new Padding(0);
			tournamentPlayersListBox.Name = "tournamentPlayersListBox";
			tournamentPlayersListBox.Size = new Size(293, 162);
			tournamentPlayersListBox.TabIndex = 30;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(14, 223);
			label5.Margin = new Padding(0);
			label5.Name = "label5";
			label5.Size = new Size(178, 32);
			label5.TabIndex = 31;
			label5.Text = "Teams / Players";
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(383, 459);
			button1.Margin = new Padding(0);
			button1.Name = "button1";
			button1.Padding = new Padding(6, 7, 6, 7);
			button1.Size = new Size(138, 42);
			button1.TabIndex = 32;
			button1.Text = "Delete Team";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			button2.Location = new Point(383, 681);
			button2.Margin = new Padding(0);
			button2.Name = "button2";
			button2.Padding = new Padding(6, 7, 6, 7);
			button2.Size = new Size(138, 42);
			button2.TabIndex = 35;
			button2.Text = "Delete Prize";
			button2.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(14, 459);
			label6.Margin = new Padding(0);
			label6.Name = "label6";
			label6.Size = new Size(178, 32);
			label6.TabIndex = 34;
			label6.Text = "Teams / Players";
			// 
			// prizeListBox
			// 
			prizeListBox.BorderStyle = BorderStyle.FixedSingle;
			prizeListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			prizeListBox.FormattingEnabled = true;
			prizeListBox.ItemHeight = 32;
			prizeListBox.Location = new Point(228, 510);
			prizeListBox.Margin = new Padding(0);
			prizeListBox.Name = "prizeListBox";
			prizeListBox.Size = new Size(293, 162);
			prizeListBox.TabIndex = 33;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			button3.Location = new Point(229, 681);
			button3.Margin = new Padding(0);
			button3.Name = "button3";
			button3.Padding = new Padding(6, 7, 6, 7);
			button3.Size = new Size(138, 42);
			button3.TabIndex = 36;
			button3.Text = "New Prize";
			button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			button4.Location = new Point(9, 681);
			button4.Margin = new Padding(0);
			button4.Name = "button4";
			button4.Padding = new Padding(6, 7, 6, 7);
			button4.Size = new Size(219, 42);
			button4.TabIndex = 37;
			button4.Text = "Create Tournament";
			button4.UseVisualStyleBackColor = true;
			// 
			// TournamentCreateView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(541, 739);
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
			Margin = new Padding(1, 1, 1, 1);
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