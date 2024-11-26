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
    public partial class Baseform : Form
    {
        public Baseform()
        {
            InitializeComponent();
            SetControlSizes(); // Kald metoden for at sætte størrelsen på kontroller
        }

        // Metode til at ændre størrelsen på knapper, labels og tekstbokse i formularen
        protected void SetControlSizes()
        {
            foreach (Control control in this.Controls)
            {
                // Hvis kontrollen er en Button, ændr dens størrelse
                if (control is Button button)
                {
                    button.Size = new Size(200, 50); // Sæt knapstørrelsen til ønsket størrelse
                }

                // Hvis kontrollen er en Label, ændr dens størrelse
                if (control is Label label)
                {
                    label.Size = new Size(200, 50); // Sæt labelstørrelsen til ønsket størrelse
                }

                // Hvis kontrollen er en TextBox, ændr dens størrelse
                if (control is TextBox textBox)
                {
                    textBox.Size = new Size(200, 50); // Sæt tekstboksstørrelsen til ønsket størrelse
                }
            }
        }

    }
}
