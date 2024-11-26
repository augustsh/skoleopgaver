namespace løsningsforslag_winforms_opgaver
{
    partial class Form3
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
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            validationLabel = new Label();
            validateButton = new Button();
            brugernavnLabel = new Label();
            kodeordLabel = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(387, 208);
            usernameTextBox.Margin = new Padding(8, 6, 8, 6);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(322, 45);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(387, 288);
            passwordTextBox.Margin = new Padding(8, 6, 8, 6);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(322, 45);
            passwordTextBox.TabIndex = 1;
            // 
            // validationLabel
            // 
            validationLabel.AutoSize = true;
            validationLabel.Location = new Point(226, 99);
            validationLabel.Margin = new Padding(8, 0, 8, 0);
            validationLabel.Name = "validationLabel";
            validationLabel.Size = new Size(0, 37);
            validationLabel.TabIndex = 2;
            // 
            // validateButton
            // 
            validateButton.Location = new Point(387, 375);
            validateButton.Margin = new Padding(8, 6, 8, 6);
            validateButton.Name = "validateButton";
            validateButton.Size = new Size(247, 54);
            validateButton.TabIndex = 3;
            validateButton.Text = "Validate";
            validateButton.UseVisualStyleBackColor = true;
            validateButton.Click += validateButton_Click;
            // 
            // brugernavnLabel
            // 
            brugernavnLabel.AutoSize = true;
            brugernavnLabel.Location = new Point(-4, 211);
            brugernavnLabel.Name = "brugernavnLabel";
            brugernavnLabel.Size = new Size(364, 37);
            brugernavnLabel.TabIndex = 4;
            brugernavnLabel.Text = "indtast brugernavn";
            // 
            // kodeordLabel
            // 
            kodeordLabel.AutoSize = true;
            kodeordLabel.Location = new Point(-4, 291);
            kodeordLabel.Name = "kodeordLabel";
            kodeordLabel.Size = new Size(310, 37);
            kodeordLabel.TabIndex = 5;
            kodeordLabel.Text = "indtast kodeord";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(21F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 455);
            Controls.Add(kodeordLabel);
            Controls.Add(brugernavnLabel);
            Controls.Add(validateButton);
            Controls.Add(validationLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Margin = new Padding(18, 9, 18, 9);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label validationLabel;
        private Button validateButton;
        private Label brugernavnLabel;
        private Label kodeordLabel;
    }
}