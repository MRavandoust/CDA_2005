using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public class Lion : AnimalDuZoo
    {
        private DateTime dateDeNaissance;

        public Lion()
        {
        }

        public Lion(DateTime dateDeNaissance)
        {
            this.dateDeNaissance = dateDeNaissance;
        }

        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public override bool PeutParler()
        {
            Console.WriteLine("Je ne parle pas");
            return false;
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je marche lentimmment");
            return true;
        }
    }
}
