using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public class Perroquet : AnimalDuZoo
    {
        private DateTime dateDeNaissance;

        public Perroquet()
        {
        }

        public Perroquet(DateTime dateDeNaissance)
        {
            this.dateDeNaissance = dateDeNaissance;
        }
        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public override bool PeutParler()
        {
            Console.WriteLine("Je parle");
            return true;
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je vole!");
            return true;
        }
    }
}
