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
    public partial class Form2 : Baseform
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void resultatButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Hent værdier fra tekstbokse
                double værdi1 = Convert.ToDouble(værdi1TextBox.Text);
                double værdi2 = Convert.ToDouble(værdi2TextBox.Text);

                // Hent operation fra ComboBox
                string operation = operationComboBox.SelectedItem.ToString();

                double resultat = 0;

                // Beregn baseret på operation
                switch (operation)
                {
                    case "+":
                        resultat = værdi1 + værdi2;
                        break;
                    case "-":
                        resultat = værdi1 - værdi2;
                        break;
                    case "*":
                        resultat = værdi1 * værdi2;
                        break;
                    case "/":
                        if (værdi2 == 0)
                        {
                            MessageBox.Show("Kan ikke dividere med 0!");
                            return;
                        }
                        resultat = værdi1 / værdi2;
                        break;
                    default:
                        MessageBox.Show("Vælg en gyldig operation.");
                        return;
                }

                // Vis resultat i resultatLabel
                resultatLabel.Text = "Resultat: " + resultat.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Indtast gyldige tal i tekstboksene.");
            }
        }

        private void værdi1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
