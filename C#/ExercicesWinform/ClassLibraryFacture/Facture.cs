using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacture
{
    public class Facture
    {
        private string name;
        private DateTime date;
        private double montant;
        private int codePostale;

        public Facture(string name, DateTime _date, double _montant, int _codePostale)
        {
            this.name = name;
            this.date = _date;
            this.montant = _montant;
            this.codePostale = _codePostale;
        }

        public bool DateIsValid()
        {
            if (DateTime.Compare(DateTime.Now, this.date) < 1)
                return true;
            else
                return false;
        }


    }
}
