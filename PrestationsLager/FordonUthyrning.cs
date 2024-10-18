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
    public partial class FordonUthyrning : Form
    {
        private LogicLayer _logicLayer;
        private Användare inloggadAnvändare;
        private Hyra aktuellHyra;
        public FordonUthyrning(LogicLayer logicLayer, Användare användare)
        {
            InitializeComponent();
            _logicLayer = logicLayer;
            this.inloggadAnvändare = användare;
            LaddaStationer();
        }
        private void UthyrningForm_Load(object sender, EventArgs e)
        {
            if (inloggadAnvändare == null)
            {
                MessageBox.Show("Ingen användare är inloggad. Vänligen logga in igen.");
                this.Close();
                return;
            }

            lblFullNamn.Text = $"Namn: {inloggadAnvändare.FullNamn}";
            lblEpost.Text = $"E-post: {inloggadAnvändare.Epost}";

            // Ladda hyreshistorik
            LaddaHyreshistorik();
        }

        private void LaddaStationer()
        {
            listStationer.Columns.Add("StationID", 100);
            listStationer.Columns.Add("Adress", 100);
            listStationer.Columns.Add("AntalFordon", 100);

            listFordon.Columns.Add("FordonID", 100);
            listFordon.Columns.Add("Typ", 100);
            listFordon.Columns.Add("BatteriNivå", 100);
            listFordon.Columns.Add("Status", 100);

            var stationer = _logicLayer.HämtaStationer();
            listStationer.Items.Clear();

            foreach (var station in stationer)
            {
                ListViewItem item = new ListViewItem(station.StationID.ToString());
                item.SubItems.Add(station.Adress);
                item.SubItems.Add(station.BefintligaFordon.Count.ToString());
                listStationer.Items.Add(item);
            }
        }

        private void LaddaHyreshistorik()
        {
            listHyreshistorik.Columns.Add("HyraID", 100);
            listHyreshistorik.Columns.Add("Starttid", 150);
            listHyreshistorik.Columns.Add("Sluttid", 150);
            listHyreshistorik.Columns.Add("Kostnad", 100);

            listHyreshistorik.Items.Clear();
            if (inloggadAnvändare != null && inloggadAnvändare.HyresHistorik != null)
            {
                listHyreshistorik.Items.Clear();
                foreach (var hyra in inloggadAnvändare.HyresHistorik)
                {
                    ListViewItem item = new ListViewItem(hyra.HyraID.ToString());
                    item.SubItems.Add(hyra.StartTid.ToString());
                    item.SubItems.Add(hyra.SlutTid.ToString());
                    item.SubItems.Add(hyra.Kostnad.ToString("F2"));
                    listHyreshistorik.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Ingen hyreshistorik tillgänglig.");
            }
        }

        private void listStationer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStationer.SelectedItems.Count > 0)
            {
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);
                var fordon = _logicLayer.HämtaFordonPåStation(selectedStationID);

                listFordon.Items.Clear();
                foreach (var f in fordon)
                {
                    ListViewItem item = new ListViewItem(f.FordonID.ToString());
                    item.SubItems.Add(f.Typ);
                    item.SubItems.Add(f.BatteriNivå.ToString());
                    item.SubItems.Add(f.Status);
                    listFordon.Items.Add(item);
                }
            }
        }

        private void btnHyra_Click_1(object sender, EventArgs e)
        {
            if (listStationer.SelectedItems.Count > 0 && listFordon.SelectedItems.Count > 0)
            {
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);
                int selectedFordonID = int.Parse(listFordon.SelectedItems[0].SubItems[0].Text);

                var valtFordon = _logicLayer.HämtaFordonPåStation(selectedStationID)
                    .FirstOrDefault(f => f.FordonID == selectedFordonID);

                if (valtFordon != null)
                {
                    aktuellHyra = new Hyra
                    {
                        HyraID = _logicLayer.GenereraNyHyraID(),
                        StartTid = DateTime.Now,
                        Fordon = valtFordon
                    };

                    _logicLayer.TaBortFordonFrånStation(selectedStationID, valtFordon);

                    UppdateraStationer();
                    UppdateraFordon(selectedStationID);

                    MessageBox.Show($"Du har hyrt {valtFordon.Typ}.", "Hyra lyckades");
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj både en station och ett fordon.", "Fel");
            }
        }

        private void btnAvslutaHyra_Click_1(object sender, EventArgs e)
        {
            if (aktuellHyra == null)
            {
                MessageBox.Show("Du har ingen aktiv hyra att avsluta.", "Fel");
                return;
            }

            aktuellHyra.SlutTid = DateTime.Now;
            double timmar = (aktuellHyra.SlutTid - aktuellHyra.StartTid).TotalHours;
            aktuellHyra.Kostnad = timmar * 100;  // Exempel på pris per timme

            inloggadAnvändare.HyresHistorik.Add(aktuellHyra);
            LaddaHyreshistorik();

            var stationLista = _logicLayer.HämtaStationer().Select(s => $"{s.StationID} - {s.Adress}").ToList();
            string stationText = string.Join("\n", stationLista);
            string valdStationID = Microsoft.VisualBasic.Interaction.InputBox($"Välj station att lämna fordonet:\n{stationText}", "Lämna Fordon", "1");

            if (int.TryParse(valdStationID, out int stationID))
            {
                var valdStation = _logicLayer.HämtaStationer().FirstOrDefault(s => s.StationID == stationID);
                if (valdStation != null)
                {
                    _logicLayer.LäggTillFordonTillStation(stationID, aktuellHyra.Fordon);
                    UppdateraStationer();
                    UppdateraFordon(stationID);

                    MessageBox.Show($"Hyran är avslutad. Kostnad: {aktuellHyra.Kostnad} SEK.", "Hyra avslutad");
                }
            }

            aktuellHyra = null;
        }

        private void UppdateraStationer()
        {
            listStationer.Items.Clear();
            var stationer = _logicLayer.HämtaStationer();
            foreach (var station in stationer)
            {
                ListViewItem item = new ListViewItem(station.StationID.ToString());
                item.SubItems.Add(station.Adress);
                item.SubItems.Add(station.BefintligaFordon.Count.ToString());
                listStationer.Items.Add(item);
            }
        }

        private void UppdateraFordon(int stationID)
        {
            listFordon.Items.Clear();
            var fordon = _logicLayer.HämtaFordonPåStation(stationID);
            foreach (var f in fordon)
            {
                ListViewItem item = new ListViewItem(f.FordonID.ToString());
                item.SubItems.Add(f.Typ);
                item.SubItems.Add(f.BatteriNivå.ToString());
                item.SubItems.Add(f.Status);
                listFordon.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
