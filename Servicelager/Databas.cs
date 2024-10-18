using Entiteter;
using static System.Collections.Specialized.BitVector32;
using System;


namespace InMemoryDatabase
{
    public class Database
    {

        internal List<Fordon> Fordons = new List<Fordon>();
        public List<Station> Stations = new List<Station>();
        internal List<Hyra> Hyras = new List<Hyra>();
        internal List<Användare> Användares = new List<Användare>();
        internal List<SystemAdmin> SystemAdmins = new List<SystemAdmin>();
        internal List<Person> Persons = new List<Person>();

        private static int nästaHyraID = 2;  // Startar från 2 och ökar för varje ny hyra

        // Andra delar av din databas-klass

        public static int GenereraNyHyraID()
        {
            return nästaHyraID++;
        }

        public List<Användare> HämtaAnvändare()
        {
            return Användares;
        }

        public void LäggTillAnvändare(Användare användare)
        {
            Användares.Add(användare);
        }

        public void InitieraAnvändare()
        {
            if (Användares.Count == 0)
            {
                Användares.Add(new Användare
                {
                    AnvändareID = "A123",
                    FullNamn = "Ali Chorba",
                    Lösenord = "12345",
                    Epost = "AliChorba@icloud.com",
                    BetalningsMetod = "Klarna",
                    HyresHistorik = new List<Hyra>
                    {
                         new Hyra
                         {
                             HyraID = 1,
                             Kostnad = 55.95,
                              StartTid = DateTime.Now.AddMonths(-1),
                              SlutTid = DateTime.Now
                    }
                          }

                });

                Användares.Add(new Användare
                {
                    AnvändareID = "D123",
                    FullNamn = "Alex Nilsson",
                    Lösenord = "123456",
                    Epost = "AlexNilsson@icloud.com",
                    BetalningsMetod = "MasterCard",
                    HyresHistorik = new List<Hyra>
                    {
                         new Hyra
                         {
                               HyraID = 1,
                               Kostnad = 200.10,
                               StartTid = DateTime.Now.AddMonths(-2),
                                SlutTid = DateTime.Now
                         }
                    }
                });
            }


        }

        public List<SystemAdmin> InitieraSystemAdmin()
        {

            List<SystemAdmin> systemAdmins = new List<SystemAdmin>()
            {

                new SystemAdmin
                {
                    SystemAdminID = "O123",
                    FullNamn = "Osama Alhussain",
                    Lösenord = "1234567",
                    Epost = "osamaalhussain@icloud.com",

                },

                new SystemAdmin
                {
                    SystemAdminID = "V123",
                    FullNamn = "Varto Kaka",
                    Lösenord = "123456",
                    Epost = "vartokaka@icloud.com",
                }



            };

            return systemAdmins;

        }

        // för att skapa station en gång!!
        public Database()
        {
            // Initiera stationer EN GÅNG
            Stations = new List<Station>
            {
             #region Göteborg Station

                new Station
                {
                    StationID = 1,
                    Adress = "Göteborg",
                    AntalFodon = 3,
                    BefintligaFordon = new List<Fordon>
                    {
                       new Fordon
                       {

                           FordonID = 1,
                          Typ ="El Scooter",
                           BatteriNivå = 80,
                            Status = "Laddar"

                       },

                      new Fordon
                      {
                         FordonID = 2,
                         Typ ="El Scooter",
                         BatteriNivå = 100,
                         Status = "Tillgänglig"

                      },



                    }
                },

                #endregion
                #region Borås Station
                new Station
                {
                    StationID = 2,
                    Adress = "Borås",
                    AntalFodon = 3,
                    BefintligaFordon = new List<Fordon>
                    {
                         new Fordon
                         {
                            FordonID = 1,
                            Typ ="El Scooter",
                            BatteriNivå = 80,
                            Status = "Laddar"

                         },
                         new Fordon
                         {
                            FordonID = 2,
                            Typ ="El Scooter",
                            BatteriNivå = 0,
                            Status = "Underhåll"

                         },
                          new Fordon
                         {
                            FordonID = 2,
                            Typ ="El Scooter",
                            BatteriNivå = 100,
                            Status = "Tillgänglig"

                         },

                    }
                },

                #endregion
                #region Uppsala Station
                new Station
                {
                    StationID = 3,
                    Adress = "Uppsala",
                    AntalFodon = 3,
                    BefintligaFordon = new List<Fordon>
                    {
                       new Fordon
                       {
                           FordonID = 1,
                          Typ ="El Scooter",
                           BatteriNivå = 80,
                            Status = "Tillgänglig"

                       },

                      new Fordon
                      {
                         FordonID = 2,
                          Typ ="El Cykel",
                          BatteriNivå = 95,
                         Status = "Tillgänglig"

                      },
                    }
                },

                #endregion
                #region Jokkmokk Station
                new Station
                {
                    StationID = 4,
                    Adress = "Jokkmokk",
                    AntalFodon = 3,
                    BefintligaFordon = new List<Fordon>
                    {
                         new Fordon
                         {
                            FordonID = 1,
                            Typ ="El Scooter",
                            BatteriNivå = 80,
                            Status = "Tillgänglig"

                         },

                         new Fordon
                         {
                            FordonID = 2,
                            Typ ="El Cykel",
                            BatteriNivå = 95,
                            Status = "Tillgänglig"

                         },
                         new Fordon
                         {
                            FordonID = 3,
                            Typ ="El Scooter",
                            BatteriNivå = 80,
                            Status = "Laddar"

                         },
                         new Fordon
                         {
                          FordonID = 4,
                          Typ ="El Cykel",
                          BatteriNivå = 95,
                          Status = "Tillgänglig"

                         },
                    }
                }


                #endregion


            };
        }

        public List<Station> HämtaStation()
        {
            return Stations; // Returnera samma stationer
        }


    }





}
