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
    public partial class Form4 : Baseform
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tilføjButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(opgaveTextBox.Text))
            {
                opgaverListBox.Items.Add(opgaveTextBox.Text);
                opgaveTextBox.Clear(); // Tøm tekstfeltet efter tilføjelse
            }
            else
            {
                MessageBox.Show("Indtast en gyldig opgave.");
            }
        }

        private void fjernButton_Click(object sender, EventArgs e)
        {
            if (opgaverListBox.SelectedItem != null) //bruger select så jeg kan klikke
            {
                opgaverListBox.Items.Remove(opgaverListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vælg en opgave, der skal fjernes.");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void opgaverListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
