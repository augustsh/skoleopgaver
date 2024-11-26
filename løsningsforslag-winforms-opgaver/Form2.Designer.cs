namespace løsningsforslag_winforms_opgaver
{
    partial class Form2
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
            resultatButton = new Button();
            værdi1TextBox = new TextBox();
            værdi2TextBox = new TextBox();
            operationComboBox = new ComboBox();
            resultatLabel = new Label();
            tal1Label = new Label();
            tal2Label = new Label();
            operatorLabel = new Label();
            SuspendLayout();
            // 
            // resultatButton
            // 
            resultatButton.Location = new Point(13, 385);
            resultatButton.Margin = new Padding(4, 3, 4, 3);
            resultatButton.Name = "resultatButton";
            resultatButton.Size = new Size(323, 58);
            resultatButton.TabIndex = 0;
            resultatButton.Text = "Se resultat!";
            resultatButton.UseVisualStyleBackColor = true;
            resultatButton.Click += resultatButton_Click;
            // 
            // værdi1TextBox
            // 
            værdi1TextBox.Location = new Point(18, 322);
            værdi1TextBox.Margin = new Padding(4, 3, 4, 3);
            værdi1TextBox.Name = "værdi1TextBox";
            værdi1TextBox.Size = new Size(153, 45);
            værdi1TextBox.TabIndex = 1;
            værdi1TextBox.TextChanged += værdi1TextBox_TextChanged;
            // 
            // værdi2TextBox
            // 
            værdi2TextBox.Location = new Point(427, 322);
            værdi2TextBox.Margin = new Padding(4, 3, 4, 3);
            værdi2TextBox.Name = "værdi2TextBox";
            værdi2TextBox.Size = new Size(153, 45);
            værdi2TextBox.TabIndex = 2;
            // 
            // operationComboBox
            // 
            operationComboBox.FormattingEnabled = true;
            operationComboBox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            operationComboBox.Location = new Point(208, 322);
            operationComboBox.Margin = new Padding(4, 3, 4, 3);
            operationComboBox.Name = "operationComboBox";
            operationComboBox.Size = new Size(186, 45);
            operationComboBox.TabIndex = 3;
            // 
            // resultatLabel
            // 
            resultatLabel.AutoSize = true;
            resultatLabel.Location = new Point(13, 9);
            resultatLabel.Margin = new Padding(4, 0, 4, 0);
            resultatLabel.Name = "resultatLabel";
            resultatLabel.Size = new Size(0, 37);
            resultatLabel.TabIndex = 4;
            // 
            // tal1Label
            // 
            tal1Label.AutoSize = true;
            tal1Label.Location = new Point(30, 249);
            tal1Label.Name = "tal1Label";
            tal1Label.Size = new Size(93, 37);
            tal1Label.TabIndex = 5;
            tal1Label.Text = "tal 1";
            // 
            // tal2Label
            // 
            tal2Label.AutoSize = true;
            tal2Label.Location = new Point(444, 249);
            tal2Label.Name = "tal2Label";
            tal2Label.Size = new Size(95, 37);
            tal2Label.TabIndex = 6;
            tal2Label.Text = "tal 2";
            tal2Label.Click += label2_Click;
            // 
            // operatorLabel
            // 
            operatorLabel.AutoSize = true;
            operatorLabel.Location = new Point(211, 249);
            operatorLabel.Name = "operatorLabel";
            operatorLabel.Size = new Size(183, 37);
            operatorLabel.TabIndex = 7;
            operatorLabel.Text = "operator";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(21F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 455);
            Controls.Add(operatorLabel);
            Controls.Add(tal2Label);
            Controls.Add(tal1Label);
            Controls.Add(resultatLabel);
            Controls.Add(operationComboBox);
            Controls.Add(værdi2TextBox);
            Controls.Add(værdi1TextBox);
            Controls.Add(resultatButton);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resultatButton;
        private TextBox værdi1TextBox;
        private TextBox værdi2TextBox;
        private ComboBox operationComboBox;
        private Label resultatLabel;
        private Label tal1Label;
        private Label tal2Label;
        private Label operatorLabel;
    }
}