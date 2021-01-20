using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMetier
{
    public class DemandeurDEmploi
    {
        private long numeroSecuriteSocial;
        private Dictionary<DateTime,EnumDiplomes> diplomes;
        private DateTime dateDInscription;
        private string nom;
        private string prenom;

        public Dictionary<DateTime, EnumDiplomes> Diplom { get; set; }

        public DemandeurDEmploi(long numeroSecuriteSocial, DateTime dateDInscription, string nom, string prenom)
        {
            this.numeroSecuriteSocial = numeroSecuriteSocial;
            this.dateDInscription = dateDInscription;
            this.nom = nom;
            this.prenom = prenom;

            this.diplomes = new Dictionary<DateTime, EnumDiplomes>();
        }

        public DemandeurDEmploi():this(100000000000000,DateTime.Now,"","")
        {
        }

        public bool AddDiplome(DateTime dateDObtentionDuDiplome,EnumDiplomes diplome)
        {
            //implementer la methode
            diplomes.Add(dateDObtentionDuDiplome, diplome);
            //throw new NotImplementedException();
            //diplomes.Add(dateDObtentionDuDiplome, diplome);
            return true;
        }

 


    }
}
