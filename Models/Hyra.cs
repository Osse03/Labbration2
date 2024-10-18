using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter
{
    public class Hyra
    {
        public int HyraID { get; set; }
        public DateTime StartTid { get; set; }
        public DateTime SlutTid { get; set; }
        public double Kostnad { get; set; }

        public Användare Användare { get; set; }
        public Fordon Fordon { get; set; }


    }

}
