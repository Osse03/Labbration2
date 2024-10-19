using Entiteter;
using InMemoryDatabase;

namespace PrestationsLager
{
    public partial class LogIn : Form
    {
        private LogicLayer logicLayer;
        private Användare inloggadAnvändare;
        public LogIn(LogicLayer logicLayer)
        {
            InitializeComponent();
            this.logicLayer = logicLayer;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            var användareLista = logicLayer.HämtaAllaAnvändare();
            var inloggadAnvändare = användareLista
                .FirstOrDefault(a => a.FullNamn == textNamn.Text && a.Lösenord == textLösenord.Text);

            if (inloggadAnvändare != null)
            {
                // Visa uthyrningsformuläret och skicka användaren
                FordonUthyrning uthyrningsForm = new FordonUthyrning(logicLayer, inloggadAnvändare);
                uthyrningsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord. Försök igen.");
                textNamn.Clear();
                textLösenord.Clear();
                textNamn.Focus();
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {
            new SkapaKonto(logicLayer).Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RänsaFält_Click(object sender, EventArgs e)
        {
            textNamn.Clear();
            textLösenord.Clear();
            textNamn.Focus();
        }

        private void VisaLösenord_CheckedChanged(object sender, EventArgs e)
        {
            if (textVisaLösenord.Checked)
            {
                textLösenord.PasswordChar = '\0';
            }
            else
            {
                textLösenord.PasswordChar = '*';
            }
        }



    }
}
