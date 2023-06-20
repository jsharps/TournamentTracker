namespace TrackerUI
{
	partial class PrizeCreateForm
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
			textBox1 = new TextBox();
			label3 = new Label();
			textBox2 = new TextBox();
			label4 = new Label();
			textBox3 = new TextBox();
			label5 = new Label();
			label6 = new Label();
			createPrizeButton = new Button();
			SuspendLayout();
			// 
			// tournamentName
			// 
			tournamentName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			tournamentName.Location = new Point(265, 77);
			tournamentName.Margin = new Padding(0);
			tournamentName.Name = "tournamentName";
			tournamentName.Size = new Size(373, 39);
			tournamentName.TabIndex = 30;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(56, 77);
			label2.Margin = new Padding(0);
			label2.Name = "label2";
			label2.Size = new Size(164, 32);
			label2.TabIndex = 29;
			label2.Text = "Place Number";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(286, 22);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(141, 32);
			label1.TabIndex = 28;
			label1.Text = "Create Prize";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(265, 129);
			textBox1.Margin = new Padding(0);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(373, 39);
			textBox1.TabIndex = 32;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(56, 129);
			label3.Margin = new Padding(0);
			label3.Name = "label3";
			label3.Size = new Size(140, 32);
			label3.TabIndex = 31;
			label3.Text = "Place Name";
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox2.Location = new Point(265, 178);
			textBox2.Margin = new Padding(0);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(373, 39);
			textBox2.TabIndex = 34;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(56, 178);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(158, 32);
			label4.TabIndex = 33;
			label4.Text = "Prize Amount";
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox3.Location = new Point(265, 265);
			textBox3.Margin = new Padding(0);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(373, 39);
			textBox3.TabIndex = 36;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(56, 268);
			label5.Margin = new Padding(0);
			label5.Name = "label5";
			label5.Size = new Size(190, 32);
			label5.TabIndex = 35;
			label5.Text = "Prize Percentage";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(227, 224);
			label6.Margin = new Padding(0);
			label6.Name = "label6";
			label6.Size = new Size(36, 32);
			label6.TabIndex = 37;
			label6.Text = "or";
			// 
			// createPrizeButton
			// 
			createPrizeButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
			createPrizeButton.Location = new Point(500, 319);
			createPrizeButton.Margin = new Padding(0);
			createPrizeButton.Name = "createPrizeButton";
			createPrizeButton.Padding = new Padding(6, 7, 6, 7);
			createPrizeButton.Size = new Size(138, 47);
			createPrizeButton.TabIndex = 38;
			createPrizeButton.Text = "Create Prize";
			createPrizeButton.UseVisualStyleBackColor = true;
			createPrizeButton.Click += createPrizeButton_Click;
			// 
			// PrizeCreateForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(682, 398);
			Controls.Add(createPrizeButton);
			Controls.Add(label6);
			Controls.Add(textBox3);
			Controls.Add(label5);
			Controls.Add(textBox2);
			Controls.Add(label4);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(tournamentName);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "PrizeCreateForm";
			Text = "CreatePrizeForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tournamentName;
		private Label label2;
		private Label label1;
		private TextBox textBox1;
		private Label label3;
		private TextBox textBox2;
		private Label label4;
		private TextBox textBox3;
		private Label label5;
		private Label label6;
		private Button createPrizeButton;
	}
}