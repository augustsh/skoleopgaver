using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace løsningsforslag_winforms_opgaver
{
    public partial class Form5 : Baseform
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void vælgEnOpgaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Åbn Form1, som indeholder Opgave 1
            form1.Show();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Åbn Form2, som indeholder Opgave 2
            form2.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Åbn Form3, som indeholder Opgave 3
            form3.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // Åbn Form4, som indeholder Opgave 4
            form4.Show();
        }

    }
}
        


