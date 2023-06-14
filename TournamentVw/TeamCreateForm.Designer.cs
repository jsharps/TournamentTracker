namespace TrackerUI
{
	partial class TeamCreateForm
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
			tournamentName = new TextBox();
			label2 = new Label();
			label1 = new Label();
			addMemberButton = new Button();
			teamDropDown = new ComboBox();
			label4 = new Label();
			groupBox1 = new GroupBox();
			firstNameTextBox = new TextBox();
			label3 = new Label();
			label5 = new Label();
			textBox2 = new TextBox();
			label6 = new Label();
			lastNameTextBox = new TextBox();
			emailTextBox = new TextBox();
			label7 = new Label();
			createMemberButton = new Button();
			phoneTextBox = new TextBox();
			memberListBox = new ListBox();
			deleteMemberButton = new Button();
			createTeamButtom = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// tournamentName
			// 
			tournamentName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			tournamentName.Location = new Point(184, 63);
			tournamentName.Margin = new Padding(0);
			tournamentName.Name = "tournamentName";
			tournamentName.Size = new Size(373, 39);
			tournamentName.TabIndex = 27;
			tournamentName.TextChanged += tournamentName_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(17, 63);
			label2.Margin = new Padding(0);
			label2.Name = "label2";
			label2.Size = new Size(142, 32);
			label2.TabIndex = 26;
			label2.Text = "Team Name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(410, 9);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(147, 32);
			label1.TabIndex = 25;
			label1.Text = "Create Team";
			// 
			// addMemberButton
			// 
			addMemberButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			addMemberButton.Location = new Point(419, 173);
			addMemberButton.Margin = new Padding(0);
			addMemberButton.Name = "addMemberButton";
			addMemberButton.Padding = new Padding(6, 7, 6, 7);
			addMemberButton.Size = new Size(138, 47);
			addMemberButton.TabIndex = 34;
			addMemberButton.Text = "Add Member";
			addMemberButton.UseVisualStyleBackColor = true;
			// 
			// teamDropDown
			// 
			teamDropDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			teamDropDown.FormattingEnabled = true;
			teamDropDown.Location = new Point(184, 122);
			teamDropDown.Margin = new Padding(0);
			teamDropDown.Name = "teamDropDown";
			teamDropDown.Size = new Size(373, 40);
			teamDropDown.TabIndex = 33;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(17, 122);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(142, 32);
			label4.TabIndex = 32;
			label4.Text = "Select Team";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(phoneTextBox);
			groupBox1.Controls.Add(createMemberButton);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(emailTextBox);
			groupBox1.Controls.Add(lastNameTextBox);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(firstNameTextBox);
			groupBox1.Location = new Point(26, 235);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(558, 333);
			groupBox1.TabIndex = 35;
			groupBox1.TabStop = false;
			groupBox1.Text = "Add New Member";
			// 
			// firstNameTextBox
			// 
			firstNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameTextBox.Location = new Point(158, 48);
			firstNameTextBox.Margin = new Padding(0);
			firstNameTextBox.Name = "firstNameTextBox";
			firstNameTextBox.Size = new Size(373, 39);
			firstNameTextBox.TabIndex = 29;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(36, 283);
			label3.Margin = new Padding(0);
			label3.Name = "label3";
			label3.Size = new Size(129, 32);
			label3.TabIndex = 28;
			label3.Text = "First Name";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(62, 161);
			label5.Margin = new Padding(0);
			label5.Name = "label5";
			label5.Size = new Size(71, 32);
			label5.TabIndex = 30;
			label5.Text = "Email";
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox2.Location = new Point(154, -40);
			textBox2.Margin = new Padding(0);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(373, 39);
			textBox2.TabIndex = 31;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(10, 103);
			label6.Margin = new Padding(0);
			label6.Name = "label6";
			label6.Size = new Size(126, 32);
			label6.TabIndex = 36;
			label6.Text = "Last Name";
			// 
			// lastNameTextBox
			// 
			lastNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameTextBox.Location = new Point(158, 100);
			lastNameTextBox.Margin = new Padding(0);
			lastNameTextBox.Name = "lastNameTextBox";
			lastNameTextBox.Size = new Size(373, 39);
			lastNameTextBox.TabIndex = 37;
			// 
			// emailTextBox
			// 
			emailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			emailTextBox.Location = new Point(158, 158);
			emailTextBox.Margin = new Padding(0);
			emailTextBox.Name = "emailTextBox";
			emailTextBox.Size = new Size(373, 39);
			emailTextBox.TabIndex = 38;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(51, 218);
			label7.Margin = new Padding(0);
			label7.Name = "label7";
			label7.Size = new Size(82, 32);
			label7.TabIndex = 39;
			label7.Text = "Phone";
			// 
			// createMemberButton
			// 
			createMemberButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			createMemberButton.Location = new Point(393, 265);
			createMemberButton.Margin = new Padding(0);
			createMemberButton.Name = "createMemberButton";
			createMemberButton.Padding = new Padding(6, 7, 6, 7);
			createMemberButton.Size = new Size(138, 47);
			createMemberButton.TabIndex = 36;
			createMemberButton.Text = "Create Member";
			createMemberButton.UseVisualStyleBackColor = true;
			// 
			// phoneTextBox
			// 
			phoneTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			phoneTextBox.Location = new Point(158, 215);
			phoneTextBox.Margin = new Padding(0);
			phoneTextBox.Name = "phoneTextBox";
			phoneTextBox.Size = new Size(373, 39);
			phoneTextBox.TabIndex = 40;
			// 
			// memberListBox
			// 
			memberListBox.BorderStyle = BorderStyle.FixedSingle;
			memberListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			memberListBox.FormattingEnabled = true;
			memberListBox.ItemHeight = 32;
			memberListBox.Location = new Point(611, 63);
			memberListBox.Margin = new Padding(0);
			memberListBox.Name = "memberListBox";
			memberListBox.Size = new Size(293, 418);
			memberListBox.TabIndex = 36;
			// 
			// deleteMemberButton
			// 
			deleteMemberButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			deleteMemberButton.Location = new Point(780, 500);
			deleteMemberButton.Margin = new Padding(0);
			deleteMemberButton.Name = "deleteMemberButton";
			deleteMemberButton.Padding = new Padding(6, 7, 6, 7);
			deleteMemberButton.Size = new Size(124, 47);
			deleteMemberButton.TabIndex = 41;
			deleteMemberButton.Text = "Delete Member";
			deleteMemberButton.UseVisualStyleBackColor = true;
			// 
			// createTeamButtom
			// 
			createTeamButtom.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			createTeamButtom.Location = new Point(611, 500);
			createTeamButtom.Margin = new Padding(0);
			createTeamButtom.Name = "createTeamButtom";
			createTeamButtom.Padding = new Padding(6, 7, 6, 7);
			createTeamButtom.Size = new Size(138, 47);
			createTeamButtom.TabIndex = 41;
			createTeamButtom.Text = "Create Team";
			createTeamButtom.UseVisualStyleBackColor = true;
			// 
			// TeamCreateForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(930, 574);
			Controls.Add(createTeamButtom);
			Controls.Add(deleteMemberButton);
			Controls.Add(memberListBox);
			Controls.Add(label3);
			Controls.Add(groupBox1);
			Controls.Add(addMemberButton);
			Controls.Add(teamDropDown);
			Controls.Add(label4);
			Controls.Add(tournamentName);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "TeamCreateForm";
			Text = "TeamCreateForm";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tournamentName;
		private Label label2;
		private Label label1;
		private Button addMemberButton;
		private ComboBox teamDropDown;
		private Label label4;
		private GroupBox groupBox1;
		private TextBox firstNameTextBox;
		private Label label3;
		private TextBox phoneTextBox;
		private Button createMemberButton;
		private Label label7;
		private TextBox emailTextBox;
		private TextBox lastNameTextBox;
		private Label label6;
		private Label label5;
		private TextBox textBox2;
		private ListBox memberListBox;
		private Button deleteMemberButton;
		private Button createTeamButtom;
	}
}