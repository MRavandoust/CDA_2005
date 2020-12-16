using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_PAPYRUS;

namespace BL_PAPYRUS
{
    public class BL_Frm_Connexion: DataAccess
    {
        public string Code;
        public string Nom;
        public string Adresse;
        public int CP;
        public string Ville;
        public string Contact;
        public int Satisfaction;


        public BL_Frm_Connexion(string confstring):base(confstring)
        { 
            //inistialiser autres attributs
        }
    }
}
