using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public class Lapin : AnimalDuZoo
    {
        int lgOreilleEnCm;
        private DateTime dateDeNaissance;
        private bool estNeeAuZoo;

        public Lapin()
        {
        }

        public Lapin(DateTime dateDeNaissance, bool estNeeAuZoo): base(dateDeNaissance, estNeeAuZoo)
        {
            this.dateDeNaissance = dateDeNaissance;
            this.estNeeAuZoo = true;
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
            Console.WriteLine("Je saute");
            return true;
        }
    }
}
