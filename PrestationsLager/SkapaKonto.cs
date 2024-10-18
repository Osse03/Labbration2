using Entiteter;
using InMemoryDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestationsLager
{
    public partial class SkapaKonto : Form
    {
        private LogicLayer _logicLayer;
        public SkapaKonto(LogicLayer logicLayer)// Uppdaterad konstruktor som tar emot LogicLayer
        {
            InitializeComponent();
            _logicLayer = logicLayer;
        }
        private void label8_Click(object sender, EventArgs e)
        {
            new LogIn(_logicLayer).Show();
            this.Hide();
        }

        private void REGISTERA_Click(object sender, EventArgs e)
        {
            // Skapa en ny användare baserat på inmatad data
            var nyAnvändare = new Användare
            {
                FullNamn = textNewUserName.Text,
                Epost = textEpost.Text,
                AnvändareID = textAnvändareID.Text, // Antag att det finns en TextBox för AnvändareID
                BetalningsMetod = textBetalningsMetod.Text, // TextBox för BetalningsMetod
                Lösenord = textNyttLösenord.Text
            };

            // Kalla på LogicLayer för att lägga till den nya användaren
            _logicLayer.LäggTillNyAnvändare(nyAnvändare);

            MessageBox.Show("Ny användare har skapats!");

            // Töm fälten efter registrering
            textNewUserName.Clear();
            textEpost.Clear();
            textBetalningsMetod.Clear();
            textAnvändareID.Clear();
            textNyttLösenord.Clear();
            textRättLösenord.Clear();
            textNewUserName.Focus();
        }


        private void RensaFält_Click(object sender, EventArgs e)
        {
            textNewUserName.Clear();
            textEpost.Clear();
            textBetalningsMetod.Clear();
            textNyttLösenord.Clear();
            textRättLösenord.Clear();

            textNewUserName.Focus();
        }

        private void VissaNyLösenord_CheckedChanged(object sender, EventArgs e)
        {
            if (VissaNyLösenord.Checked)
            {
                textNyttLösenord.PasswordChar = '\0';
                textRättLösenord.PasswordChar = '\0';
            }
            else
            {
                textNyttLösenord.PasswordChar = '*';
                textRättLösenord.PasswordChar = '*';
            }

        }
    }
}
