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
            var inloggadAnvändare = användareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.Lösenord == textLösenord.Text);

            var systemAdminLista = logicLayer.InitieraSystemAdmins();

            var Nyanvändare = användareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.Lösenord == textLösenord.Text);
            var systemAdmin = systemAdminLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.Lösenord == textLösenord.Text);

            if (Nyanvändare != null)
            {
                new FordonUthyrning(logicLayer, inloggadAnvändare).Show();  // Skickar LogicLayer och inloggad användare
                this.Hide();
            }
            else if (systemAdmin != null)
            {
                new FordonStationsHantering(logicLayer).Show();  // Skickar LogicLayer
                this.Hide();
                MessageBox.Show("1. Vid Uppdatering måste du fylla i alla fält och klicka på FordonID." +
                                "\n 2. För att ta bort måste du klicka på FordonID och fylla i FordonID-fältet.");
            }
            else
            {
                MessageBox.Show("Ditt fulla namn eller lösenord är fel, försök igen");
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
