using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryToolsVerification
{
    public static class ClassVerifications
    {

        // ---------------  Verification du Nom -----------------
        public static bool Name(string name)
        {
            Regex nomRegex = new Regex(@"^[a-zA-Z]{2,30}$");
            if (nomRegex.IsMatch(name))
                return true;
            else
                return false;
        }


        // ---------------  Verification de la date -----------------
        public static bool VerifDate(string _date)
        {
            Regex dateRegex = new Regex(@"^(\d{2})/(\d{2})/(\d{4})$");
            if (dateRegex.IsMatch(_date))
                return true;
            else
                return false;
        }


        // ---------------  Verification du montant -----------------
        public static bool Montant(string _montant)
        {
            Regex montantRegex = new Regex(@"^\d+\,(\d{2})$");
            if (montantRegex.IsMatch(_montant))
                return true;
            else
                return false;
        }


        // ---------------  Verification du code postal -----------------
        public static bool CodePostal(string _code)
        {
            Regex codePostalRegex = new Regex(@"^\d{5}$");
            if (codePostalRegex.IsMatch(_code))
                return true;
            else
                return false;
        }
    }
}
