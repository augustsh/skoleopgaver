namespace løsningsforslag_winforms_opgaver
{
    partial class Form1 : Baseform
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
            trykButton = new Button();
            SkrivHejLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // trykButton
            // 
            trykButton.Location = new Point(17, 345);
            trykButton.Margin = new Padding(8, 6, 8, 6);
            trykButton.Name = "trykButton";
            trykButton.Size = new Size(400, 95);
            trykButton.TabIndex = 0;
            trykButton.Text = "TRYK FOR RESPONS";
            trykButton.UseVisualStyleBackColor = true;
            trykButton.Click += trykButton_Click;
            // 
            // SkrivHejLabel
            // 
            SkrivHejLabel.AutoSize = true;
            SkrivHejLabel.Location = new Point(17, 9);
            SkrivHejLabel.Margin = new Padding(8, 0, 8, 0);
            SkrivHejLabel.Name = "SkrivHejLabel";
            SkrivHejLabel.Size = new Size(0, 37);
            SkrivHejLabel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.magic;
            pictureBox1.Location = new Point(387, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 174);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(21F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 455);
            Controls.Add(pictureBox1);
            Controls.Add(SkrivHejLabel);
            Controls.Add(trykButton);
            Margin = new Padding(8, 6, 8, 6);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button trykButton;
        private Label SkrivHejLabel;
        private PictureBox pictureBox1;
    }
}
