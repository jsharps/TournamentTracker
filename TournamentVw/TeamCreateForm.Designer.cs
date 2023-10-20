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
            teamName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            addMemberButton = new Button();
            teamDropDown = new ComboBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            phoneTextBox = new TextBox();
            createMemberButton = new Button();
            label7 = new Label();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            firstNameTextBox = new TextBox();
            label3 = new Label();
            memberListBox = new ListBox();
            deleteMemberButton = new Button();
            createTeamButtom = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // teamName
            // 
            teamName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamName.Location = new Point(391, 129);
            teamName.Margin = new Padding(0);
            teamName.Name = "teamName";
            teamName.Size = new Size(788, 71);
            teamName.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 129);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(277, 65);
            label2.TabIndex = 26;
            label2.Text = "Team Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(871, 18);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(288, 65);
            label1.TabIndex = 25;
            label1.Text = "Create Team";
            // 
            // addMemberButton
            // 
            addMemberButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
            addMemberButton.Location = new Point(890, 355);
            addMemberButton.Margin = new Padding(0);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Padding = new Padding(13, 14, 13, 14);
            addMemberButton.Size = new Size(293, 96);
            addMemberButton.TabIndex = 34;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamDropDown
            // 
            teamDropDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamDropDown.FormattingEnabled = true;
            teamDropDown.Location = new Point(391, 250);
            teamDropDown.Margin = new Padding(0);
            teamDropDown.Name = "teamDropDown";
            teamDropDown.Size = new Size(788, 70);
            teamDropDown.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 250);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(277, 65);
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
            groupBox1.Location = new Point(55, 482);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(1186, 683);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTextBox.Location = new Point(336, 441);
            phoneTextBox.Margin = new Padding(0);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(788, 71);
            phoneTextBox.TabIndex = 40;
            // 
            // createMemberButton
            // 
            createMemberButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
            createMemberButton.Location = new Point(835, 543);
            createMemberButton.Margin = new Padding(0);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Padding = new Padding(13, 14, 13, 14);
            createMemberButton.Size = new Size(293, 96);
            createMemberButton.TabIndex = 36;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(108, 447);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(162, 65);
            label7.TabIndex = 39;
            label7.Text = "Phone";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(336, 324);
            emailTextBox.Margin = new Padding(0);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(788, 71);
            emailTextBox.TabIndex = 38;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(336, 205);
            lastNameTextBox.Margin = new Padding(0);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(788, 71);
            lastNameTextBox.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 211);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(250, 65);
            label6.TabIndex = 36;
            label6.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(132, 330);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(141, 65);
            label5.TabIndex = 30;
            label5.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(327, -82);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(788, 71);
            textBox2.TabIndex = 31;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(336, 98);
            firstNameTextBox.Margin = new Padding(0);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(788, 71);
            firstNameTextBox.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(76, 580);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(255, 65);
            label3.TabIndex = 28;
            label3.Text = "First Name";
            // 
            // memberListBox
            // 
            memberListBox.BorderStyle = BorderStyle.FixedSingle;
            memberListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            memberListBox.FormattingEnabled = true;
            memberListBox.ItemHeight = 62;
            memberListBox.Location = new Point(1298, 129);
            memberListBox.Margin = new Padding(0);
            memberListBox.Name = "memberListBox";
            memberListBox.Size = new Size(620, 808);
            memberListBox.TabIndex = 36;
            // 
            // deleteMemberButton
            // 
            deleteMemberButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
            deleteMemberButton.Location = new Point(1658, 1025);
            deleteMemberButton.Margin = new Padding(0);
            deleteMemberButton.Name = "deleteMemberButton";
            deleteMemberButton.Padding = new Padding(13, 14, 13, 14);
            deleteMemberButton.Size = new Size(264, 96);
            deleteMemberButton.TabIndex = 41;
            deleteMemberButton.Text = "Delete Member";
            deleteMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButtom
            // 
            createTeamButtom.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamButtom.Location = new Point(1298, 1025);
            createTeamButtom.Margin = new Padding(0);
            createTeamButtom.Name = "createTeamButtom";
            createTeamButtom.Padding = new Padding(13, 14, 13, 14);
            createTeamButtom.Size = new Size(293, 96);
            createTeamButtom.TabIndex = 41;
            createTeamButtom.Text = "Create Team";
            createTeamButtom.UseVisualStyleBackColor = true;
            // 
            // TeamCreateForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1976, 1177);
            Controls.Add(createTeamButtom);
            Controls.Add(deleteMemberButton);
            Controls.Add(memberListBox);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(addMemberButton);
            Controls.Add(teamDropDown);
            Controls.Add(label4);
            Controls.Add(teamName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "TeamCreateForm";
            Text = "TeamCreateForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamName;
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