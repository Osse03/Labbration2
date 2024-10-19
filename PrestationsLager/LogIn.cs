using Entiteter;
using InMemoryDatabase;

namespace PrestationsLager
{
    public partial class LogIn : Form
    {
        private LogicLayer logicLayer;
        private Anv�ndare inloggadAnv�ndare;
        public LogIn(LogicLayer logicLayer)
        {
            InitializeComponent();
            this.logicLayer = logicLayer;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            var anv�ndareLista = logicLayer.H�mtaAllaAnv�ndare();
            var inloggadAnv�ndare = anv�ndareLista
                .FirstOrDefault(a => a.FullNamn == textNamn.Text && a.L�senord == textL�senord.Text);

            if (inloggadAnv�ndare != null)
            {
                // Visa uthyrningsformul�ret och skicka anv�ndaren
                FordonUthyrning uthyrningsForm = new FordonUthyrning(logicLayer, inloggadAnv�ndare);
                uthyrningsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fel anv�ndarnamn eller l�senord. F�rs�k igen.");
                textNamn.Clear();
                textL�senord.Clear();
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

        private void R�nsaF�lt_Click(object sender, EventArgs e)
        {
            textNamn.Clear();
            textL�senord.Clear();
            textNamn.Focus();
        }

        private void VisaL�senord_CheckedChanged(object sender, EventArgs e)
        {
            if (textVisaL�senord.Checked)
            {
                textL�senord.PasswordChar = '\0';
            }
            else
            {
                textL�senord.PasswordChar = '*';
            }
        }



    }
}
