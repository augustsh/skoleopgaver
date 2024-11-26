namespace løsningsforslag_winforms_opgaver
{
    partial class Form4
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
            opgaveTextBox = new TextBox();
            tilføjButton = new Button();
            opgaverListBox = new ListBox();
            fjernButton = new Button();
            skrivopgaveLabel = new Label();
            SuspendLayout();
            // 
            // opgaveTextBox
            // 
            opgaveTextBox.Location = new Point(417, 320);
            opgaveTextBox.Margin = new Padding(8, 6, 8, 6);
            opgaveTextBox.Name = "opgaveTextBox";
            opgaveTextBox.Size = new Size(251, 45);
            opgaveTextBox.TabIndex = 0;
            // 
            // tilføjButton
            // 
            tilføjButton.Location = new Point(418, 34);
            tilføjButton.Margin = new Padding(8, 6, 8, 6);
            tilføjButton.Name = "tilføjButton";
            tilføjButton.Size = new Size(260, 83);
            tilføjButton.TabIndex = 1;
            tilføjButton.Text = "Tilføj opgave";
            tilføjButton.UseVisualStyleBackColor = true;
            tilføjButton.Click += tilføjButton_Click;
            // 
            // opgaverListBox
            // 
            opgaverListBox.FormattingEnabled = true;
            opgaverListBox.ItemHeight = 37;
            opgaverListBox.Location = new Point(17, 34);
            opgaverListBox.Margin = new Padding(8, 6, 8, 6);
            opgaverListBox.Name = "opgaverListBox";
            opgaverListBox.Size = new Size(384, 337);
            opgaverListBox.TabIndex = 2;
            opgaverListBox.SelectedIndexChanged += opgaverListBox_SelectedIndexChanged;
            // 
            // fjernButton
            // 
            fjernButton.Location = new Point(417, 139);
            fjernButton.Margin = new Padding(8, 6, 8, 6);
            fjernButton.Name = "fjernButton";
            fjernButton.Size = new Size(261, 85);
            fjernButton.TabIndex = 3;
            fjernButton.Text = "fjern opgave";
            fjernButton.UseVisualStyleBackColor = true;
            fjernButton.Click += fjernButton_Click;
            // 
            // skrivopgaveLabel
            // 
            skrivopgaveLabel.AutoSize = true;
            skrivopgaveLabel.Location = new Point(417, 277);
            skrivopgaveLabel.Name = "skrivopgaveLabel";
            skrivopgaveLabel.Size = new Size(251, 37);
            skrivopgaveLabel.TabIndex = 4;
            skrivopgaveLabel.Text = "Skriv opgave:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(21F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 455);
            Controls.Add(skrivopgaveLabel);
            Controls.Add(fjernButton);
            Controls.Add(opgaverListBox);
            Controls.Add(tilføjButton);
            Controls.Add(opgaveTextBox);
            Margin = new Padding(18, 9, 18, 9);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox opgaveTextBox;
        private Button tilføjButton;
        private ListBox opgaverListBox;
        private Button fjernButton;
        private Label skrivopgaveLabel;
    }
}