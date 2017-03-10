using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAGE
{
    class class_stagiaire
    {
        public string Nums;
        public string Noms;
        public string Prenom;
        public string Sexe;
        public DateTime Dns;
        public string Dips;
        public class_stagiaire() { }

        public class_stagiaire(string nums, string noms, string prenom, string sexe, DateTime dns, string dips)
        {
            Nums = nums;
            Noms = noms;
            Prenom = prenom;
            Sexe = sexe;
            Dns = dns;
            Dips = dips;
        }
        public static List<class_stagiaire> list_stagiaire = new List<class_stagiaire>();
    }
}
