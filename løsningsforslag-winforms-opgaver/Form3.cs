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
    public partial class Form3 : Baseform
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            // Hent input fra tekstbokse
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Simpel validering
            if (string.IsNullOrWhiteSpace(username))
            {
                validationLabel.Text = "Brugernavn må ikke være tomt.";
                validationLabel.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                validationLabel.Text = "Adgangskode må ikke være tom.";
                validationLabel.ForeColor = Color.Red;
                return;
            }

            // Eksempel: Simuler korrekt brugernavn/adgangskode
            if (username == "admin" && password == "1234")
            {
                validationLabel.Text = "Validering succesfuld!";
                validationLabel.ForeColor = Color.Green;
            }
            else
            {
                validationLabel.Text = "Forkert brugernavn eller adgangskode.";
                validationLabel.ForeColor = Color.Red;
            }
        }

    }
}
