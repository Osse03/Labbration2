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
    public partial class FordonStationsHantering : Form
    {
        private LogicLayer _logicLayer;
        public FordonStationsHantering(LogicLayer logicLayer)
        {
            InitializeComponent();
            _logicLayer = logicLayer;  // Tilldela den mottagna LogicLayer-instansen
        }
        private void LäggTillFordon_Load(object sender, EventArgs e)
        {
            listStationer.Columns.Add("StationID", 100);
            listStationer.Columns.Add("Adress", 100);
            listStationer.Columns.Add("AntalFordon", 100);

            listFordon.Columns.Add("FordonID", 100);
            listFordon.Columns.Add("Typ", 100);
            listFordon.Columns.Add("BatteriNivå", 100);
            listFordon.Columns.Add("Status", 100);

            // Hämta stationerna från databasen
            var stationer = _logicLayer.HämtaStationer();

            // Rensa listan för att förhindra duplicering
            listStationer.Items.Clear();

            // Loopar igenom varje station
            foreach (var station in stationer)
            {
                // Skapar en ny ListViewItem för varje station
                ListViewItem item = new ListViewItem(station.StationID.ToString());
                item.SubItems.Add(station.Adress);
                item.SubItems.Add(station.BefintligaFordon.Count.ToString()); // Lägg till antal fordon
                listStationer.Items.Add(item);
            }

        }
        private void listFordon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listFordon.SelectedItems.Count > 0)
            {
                // Hämta det valda fordonet från ListView
                int selectedFordonID = int.Parse(listFordon.SelectedItems[0].SubItems[0].Text);

                // Hämta vald station
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);
                var stationer = _logicLayer.HämtaStationer();
                var valdStation = stationer.FirstOrDefault(station => station.StationID == selectedStationID);

                if (valdStation != null)
                {
                    // Hitta det valda fordonet baserat på ID
                    var valtFordon = valdStation.BefintligaFordon.FirstOrDefault(fordon => fordon.FordonID == selectedFordonID);

                    if (valtFordon != null)
                    {
                        // Fyll i textfälten med fordonets data
                        txtFordonID.Text = valtFordon.FordonID.ToString();
                        txtTyp.Text = valtFordon.Typ;
                        txtBatteriNivå.Text = valtFordon.BatteriNivå.ToString();
                        txtStatus.Text = valtFordon.Status;
                    }
                }
            }

        }
        private void listStationer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kontrollera att en station har valts
            if (listStationer.SelectedItems.Count > 0)
            {
                // Hämta den valda stationens ID
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);

                var stationer = _logicLayer.HämtaStationer();

                // Hitta den valda stationen baserat på StationID
                var valdStation = stationer.FirstOrDefault(station => station.StationID == selectedStationID);

                // Om en station hittas, visa dess fordon
                if (valdStation != null)
                {
                    // Rensa fordonlistan
                    listFordon.Items.Clear();

                    // Loopa igenom varje fordon i den valda stationen
                    foreach (var fordon in valdStation.BefintligaFordon)
                    {
                        // Skapa ett ListViewItem för varje fordon
                        ListViewItem fordonItem = new ListViewItem(fordon.FordonID.ToString());
                        fordonItem.SubItems.Add(fordon.Typ);
                        fordonItem.SubItems.Add(fordon.BatteriNivå.ToString());
                        fordonItem.SubItems.Add(fordon.Status);
                        listFordon.Items.Add(fordonItem);
                    }

                    // Uppdatera antalet fordon för den valda stationen i listStationer
                    listStationer.SelectedItems[0].SubItems[2].Text = valdStation.BefintligaFordon.Count.ToString();
                }
            }


        }

        private void Uppdatera_Click(object sender, EventArgs e)
        {
            if (listFordon.SelectedItems.Count > 0 && listStationer.SelectedItems.Count > 0)
            {
                // Hämta valt station och fordonsID
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);
                int selectedFordonID = int.Parse(listFordon.SelectedItems[0].SubItems[0].Text);

                // Hämta stationerna från databasen
                var stationer = _logicLayer.HämtaStationer();
                var valdStation = stationer.FirstOrDefault(station => station.StationID == selectedStationID);

                if (valdStation != null)
                {
                    // Hitta fordonet med rätt ID
                    var valtFordon = valdStation.BefintligaFordon.FirstOrDefault(fordon => fordon.FordonID == selectedFordonID);
                    if (valtFordon != null)
                    {
                        // Uppdatera fordonets egenskaper baserat på användarens inmatning
                        valtFordon.Typ = txtTyp.Text;  // Ny typ som användaren har matat in
                        valtFordon.BatteriNivå = int.Parse(txtBatteriNivå.Text);  // Ny batterinivå som användaren har matat in
                        valtFordon.Status = txtStatus.Text;  // Ny status som användaren har matat in

                        // Uppdatera listan med fordon
                        UppdateraFordonLista(valdStation);

                        // Spara ändringar under körning
                        SparaÄndringar(valdStation);


                        txtFordonID.Clear();
                        txtTyp.Clear();
                        txtBatteriNivå.Clear();
                        txtStatus.Clear();

                        MessageBox.Show("Uppdatering är genomförd");
                    }
                }
            }
            else
            {
                MessageBox.Show("Välj ett fordon att uppdatera.");
            }

        }

        private void LäggTillFordn_Click(object sender, EventArgs e)
        {
            if (listStationer.SelectedItems.Count > 0)
            {
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);
                var stationer = _logicLayer.HämtaStationer();
                var valdStation = stationer.FirstOrDefault(station => station.StationID == selectedStationID);

                if (valdStation != null)
                {
                    if (int.TryParse(txtFordonID.Text, out int fordonsID) && !string.IsNullOrWhiteSpace(txtTyp.Text) && int.TryParse(txtBatteriNivå.Text, out int batteriNivå))
                    {
                        var nyttFordon = new Fordon
                        {
                            FordonID = fordonsID,
                            Typ = txtTyp.Text,
                            BatteriNivå = batteriNivå,
                            Status = txtStatus.Text
                        };

                        valdStation.BefintligaFordon.Add(nyttFordon);
                        UppdateraFordonLista(valdStation);
                        SparaÄndringar(valdStation);

                        // Rensa textfälten
                        txtFordonID.Clear();
                        txtTyp.Clear();
                        txtBatteriNivå.Clear();
                        txtStatus.Clear();

                        MessageBox.Show("Fordon är tillagd");
                    }
                    else
                    {
                        MessageBox.Show("Fyll i alla fält korrekt.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Välj en station innan du lägger till ett fordon.");
            }
        }

        private void TabortFordon_Click(object sender, EventArgs e)
        {
            if (listFordon.SelectedItems.Count > 0 && listStationer.SelectedItems.Count > 0)
            {
                // Hämta valt station och fordons-ID
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);
                int selectedFordonID = int.Parse(listFordon.SelectedItems[0].SubItems[0].Text);


                var stationer = _logicLayer.HämtaStationer();
                var valdStation = stationer.FirstOrDefault(station => station.StationID == selectedStationID);

                if (valdStation != null)
                {
                    // Hitta fordonet och ta bort det från stationens lista
                    var valtFordon = valdStation.BefintligaFordon.FirstOrDefault(fordon => fordon.FordonID == selectedFordonID);
                    if (valtFordon != null)
                    {
                        valdStation.BefintligaFordon.Remove(valtFordon);  // Ta bort fordonet
                        UppdateraFordonLista(valdStation);  // Uppdatera ListView
                        SparaÄndringar(valdStation);  // Spara ändringar
                    }
                    MessageBox.Show("Fordon är borttagen");
                }
            }
            else
            {
                MessageBox.Show("Välj ett fordon att ta bort.");
            }

        }

        private void UppdateraFordonLista(Station valdStation)
        {
            listFordon.Items.Clear();

            foreach (var fordon in valdStation.BefintligaFordon)
            {
                ListViewItem item = new ListViewItem(fordon.FordonID.ToString());
                item.SubItems.Add(fordon.Typ);
                item.SubItems.Add(fordon.BatteriNivå.ToString());
                item.SubItems.Add(fordon.Status);
                listFordon.Items.Add(item);
            }

            // Uppdatera stationens fordonräkning
            listStationer.SelectedItems[0].SubItems[2].Text = valdStation.BefintligaFordon.Count.ToString();
        }

        private void SparaÄndringar(Station valdStation)
        {
            // Uppdatera antal fordon i den valda stationen
            valdStation.AntalFodon = valdStation.BefintligaFordon.Count;

            // Logga en sparningsoperation (kan ersättas med riktig sparlogik)
            Console.WriteLine($"Sparade ändringar för station: {valdStation.Adress}, Antal fordon: {valdStation.AntalFodon}");

            UppdateraFordonLista(valdStation);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
