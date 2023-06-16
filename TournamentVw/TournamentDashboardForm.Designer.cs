namespace TrackerUI
{
	partial class TournamentDashboardForm
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
			loadTournamentButton = new Button();
			existingTournamentDropDown = new ComboBox();
			label4 = new Label();
			label1 = new Label();
			createTournamentButton = new Button();
			SuspendLayout();
			// 
			// loadTournamentButton
			// 
			loadTournamentButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			loadTournamentButton.Location = new Point(46, 162);
			loadTournamentButton.Margin = new Padding(0);
			loadTournamentButton.Name = "loadTournamentButton";
			loadTournamentButton.Padding = new Padding(6, 7, 6, 7);
			loadTournamentButton.Size = new Size(169, 60);
			loadTournamentButton.TabIndex = 40;
			loadTournamentButton.Text = "Load Tournament";
			loadTournamentButton.UseVisualStyleBackColor = true;
			// 
			// existingTournamentDropDown
			// 
			existingTournamentDropDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			existingTournamentDropDown.FormattingEnabled = true;
			existingTournamentDropDown.Location = new Point(46, 106);
			existingTournamentDropDown.Margin = new Padding(0);
			existingTournamentDropDown.Name = "existingTournamentDropDown";
			existingTournamentDropDown.Size = new Size(338, 40);
			existingTournamentDropDown.TabIndex = 36;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(60, 57);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(289, 32);
			label4.TabIndex = 35;
			label4.Text = "Load Existing Tournament";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(73, 9);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(265, 32);
			label1.TabIndex = 32;
			label1.Text = "Tournament Dashboard";
			// 
			// createTournamentButton
			// 
			createTournamentButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			createTournamentButton.Location = new Point(215, 162);
			createTournamentButton.Margin = new Padding(0);
			createTournamentButton.Name = "createTournamentButton";
			createTournamentButton.Padding = new Padding(6, 7, 6, 7);
			createTournamentButton.Size = new Size(169, 60);
			createTournamentButton.TabIndex = 41;
			createTournamentButton.Text = "Create Tournament";
			createTournamentButton.UseVisualStyleBackColor = true;
			// 
			// TournamentDashboardForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(430, 247);
			Controls.Add(createTournamentButton);
			Controls.Add(loadTournamentButton);
			Controls.Add(existingTournamentDropDown);
			Controls.Add(label4);
			Controls.Add(label1);
			Name = "TournamentDashboardForm";
			Text = "TournamentDashboardForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label5;
		private ListBox tournamentPlayersListBox;
		private Button loadTournamentButton;
		private LinkLabel linkLabel1;
		private TextBox entryFee;
		private ComboBox existingTournamentDropDown;
		private Label label4;
		private Label label3;
		private Label label1;
		private Button createTournamentButton;
	}
}