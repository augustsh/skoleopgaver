namespace løsningsforslag_winforms_opgaver
{
    partial class Form5
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
            menuStrip1 = new MenuStrip();
            vælgEnOpgaveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            todoListAppToolStripMenuItem4 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { vælgEnOpgaveToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(16, 4, 0, 4);
            menuStrip1.Size = new Size(350, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // vælgEnOpgaveToolStripMenuItem
            // 
            vælgEnOpgaveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, todoListAppToolStripMenuItem4 });
            vælgEnOpgaveToolStripMenuItem.Name = "vælgEnOpgaveToolStripMenuItem";
            vælgEnOpgaveToolStripMenuItem.Size = new Size(130, 24);
            vælgEnOpgaveToolStripMenuItem.Text = "Vælg en opgave";
            vælgEnOpgaveToolStripMenuItem.Click += vælgEnOpgaveToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(224, 26);
            toolStripMenuItem1.Text = "1) Hello World app";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(224, 26);
            toolStripMenuItem2.Text = "2) Simple calculator";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(224, 26);
            toolStripMenuItem3.Text = "3) Login form";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // todoListAppToolStripMenuItem4
            // 
            todoListAppToolStripMenuItem4.Name = "todoListAppToolStripMenuItem4";
            todoListAppToolStripMenuItem4.Size = new Size(224, 26);
            todoListAppToolStripMenuItem4.Text = "4) To-do list app";
            toolStripMenuItem3.Click += toolStripMenuItem4_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(21F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 246);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(18, 9, 18, 9);
            Name = "Form5";
            Text = "Form5";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem vælgEnOpgaveToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem todoListAppToolStripMenuItem4;
    }
}