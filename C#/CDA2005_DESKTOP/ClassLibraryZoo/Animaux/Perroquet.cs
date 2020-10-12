using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public class Perroquet : AnimalDuZoo,IParler
    {
        private DateTime dateDeNaissance;
        private bool estNeeAuZoo;

        public Perroquet()
        {
        }

        public Perroquet(DateTime dateDeNaissance, bool estNeeAuZoo): base(dateDeNaissance, estNeeAuZoo) 
        {
            this.dateDeNaissance = dateDeNaissance;
            this.estNeeAuZoo = true;
        }
        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public bool Parler()
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
