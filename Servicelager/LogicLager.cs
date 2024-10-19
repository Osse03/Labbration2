using System;
using System.Collections.Generic;
using System.Linq;
using Entiteter;
using InMemoryDatabase;

namespace InMemoryDatabase
{
    public class LogicLayer
    {
        private Database _database;
        public LogicLayer(Database database)
        {
            _database = database;
        }

        // Användare-relaterade metoder
        public List<Användare> HämtaAllaAnvändare()
        {
            return _database.HämtaAnvändare();
        }
        public Användare HittaAnvändare(string epost, string lösenord)
        {
            return _database.Användares.FirstOrDefault(a => a.Epost == epost && a.Lösenord == lösenord);
        }

        public void LäggTillNyAnvändare(Användare användare)
        {
            _database.LäggTillAnvändare(användare);
        }

        public List<SystemAdmin> InitieraSystemAdmins()
        {
            return _database.InitieraSystemAdmin();
        }

        // Fordon-relaterade metoder
        public List<Fordon> HämtaFordonPåStation(int stationId)
        {
            var station = _database.Stations.FirstOrDefault(s => s.StationID == stationId);
            return station?.BefintligaFordon ?? new List<Fordon>();
        }

        public void LäggTillFordonTillStation(int stationId, Fordon fordon)
        {
            var station = _database.Stations.FirstOrDefault(s => s.StationID == stationId);
            if (station != null)
            {
                station.BefintligaFordon.Add(fordon);
            }
        }

        public void TaBortFordonFrånStation(int stationId, Fordon fordon)
        {
            var station = _database.Stations.FirstOrDefault(s => s.StationID == stationId);
            if (station != null)
            {
                station.BefintligaFordon.Remove(fordon);
            }
        }

        // Station-relaterade metoder
        public List<Station> HämtaStationer()
        {
            return _database.HämtaStation();
        }

        // Hyra-relaterade metoder
        public void LäggTillHyra(Hyra hyra, Användare användare)
        {
            användare.HyresHistorik.Add(hyra);
        }

        public int GenereraNyHyraID()
        {
            return Database.GenereraNyHyraID();
        }

    }
}
