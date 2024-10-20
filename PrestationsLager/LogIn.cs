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
            var systemAdminLista = logicLayer.InitieraSystemAdmins();

            var inloggadAnvändare = användareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.Lösenord == textLösenord.Text);

            var systemadmin = systemAdminLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.Lösenord == textLösenord.Text);

            if (inloggadAnvändare != null)
            {
                // Visa uthyrningsformuläret och skicka användaren
                FordonUthyrning uthyrningsForm = new FordonUthyrning(logicLayer, inloggadAnvändare);
                uthyrningsForm.Show();
                this.Hide();
            }
            else if (systemadmin != null)
            {
                new FordonStationsHantering(logicLayer).Show();
                this.Hide();

                MessageBox.Show("1. Vid uppdatering måste du fylla i alla fält och klicka på FordonID " +
                    "\n 2. Att ta bort måste du fylla i FordonID och klicka på FordonID");
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
