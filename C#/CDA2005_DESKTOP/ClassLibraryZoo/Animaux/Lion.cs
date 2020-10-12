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
        private bool estNeeAuZoo;

        public Lion()
        {
        }

        public Lion(DateTime dateDeNaissance, bool estNeeAuZoo):base(dateDeNaissance, estNeeAuZoo)
        {
            this.dateDeNaissance = dateDeNaissance;
            this.estNeeAuZoo = true;
        }

        public void Manger()
        {
            throw new System.NotImplementedException();
        }


        public override bool SeDeplacer()
        {
            Console.WriteLine("Je marche lentimmment");
            return true;
        }
    }
}
