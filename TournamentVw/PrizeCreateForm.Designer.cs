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
            placeNumberValue = new TextBox();
            label2 = new Label();
            label1 = new Label();
            placeNameValue = new TextBox();
            label3 = new Label();
            prizeAmountValue = new TextBox();
            label4 = new Label();
            prizePercantageValue = new TextBox();
            label5 = new Label();
            label6 = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // placeNumberValue
            // 
            placeNumberValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberValue.Location = new Point(563, 158);
            placeNumberValue.Margin = new Padding(0);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(788, 71);
            placeNumberValue.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(119, 158);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(325, 65);
            label2.TabIndex = 29;
            label2.Text = "Place Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(608, 45);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(281, 65);
            label1.TabIndex = 28;
            label1.Text = "Create Prize";
            // 
            // placeNameValue
            // 
            placeNameValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameValue.Location = new Point(563, 264);
            placeNameValue.Margin = new Padding(0);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(788, 71);
            placeNameValue.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(119, 264);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(277, 65);
            label3.TabIndex = 31;
            label3.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountValue.Location = new Point(563, 365);
            prizeAmountValue.Margin = new Padding(0);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(788, 71);
            prizeAmountValue.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(119, 365);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(314, 65);
            label4.TabIndex = 33;
            label4.Text = "Prize Amount";
            // 
            // prizePercantageValue
            // 
            prizePercantageValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercantageValue.Location = new Point(563, 543);
            prizePercantageValue.Margin = new Padding(0);
            prizePercantageValue.Name = "prizePercantageValue";
            prizePercantageValue.Size = new Size(788, 71);
            prizePercantageValue.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(119, 549);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(378, 65);
            label5.TabIndex = 35;
            label5.Text = "Prize Percentage";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(482, 459);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(73, 65);
            label6.TabIndex = 37;
            label6.Text = "or";
            // 
            // createPrizeButton
            // 
            createPrizeButton.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeButton.Location = new Point(1062, 654);
            createPrizeButton.Margin = new Padding(0);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Padding = new Padding(13, 14, 13, 14);
            createPrizeButton.Size = new Size(293, 96);
            createPrizeButton.TabIndex = 38;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // PrizeCreateForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 816);
            Controls.Add(createPrizeButton);
            Controls.Add(label6);
            Controls.Add(prizePercantageValue);
            Controls.Add(label5);
            Controls.Add(prizeAmountValue);
            Controls.Add(label4);
            Controls.Add(placeNameValue);
            Controls.Add(label3);
            Controls.Add(placeNumberValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "PrizeCreateForm";
            Text = "CreatePrizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox placeNumberValue;
        private Label label2;
        private Label label1;
        private TextBox placeNameValue;
        private Label label3;
        private TextBox prizeAmountValue;
        private Label label4;
        private TextBox prizePercantageValue;
        private Label label5;
        private Label label6;
        private Button createPrizeButton;
    }
}