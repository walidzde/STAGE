using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAGE
{
    class stage
    {
        public string Nomstage { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public string Cds { get; set; }
        public stage() { }
        public stage(string nomstage,DateTime datedebut,DateTime datefin,string cds)
        {
            Nomstage = nomstage;
            Datedebut = datedebut;
            Datefin = datefin;
            Cds = cds;
        }

        public static List<stage> liststage = new List<stage>();

         
    }
    

}
