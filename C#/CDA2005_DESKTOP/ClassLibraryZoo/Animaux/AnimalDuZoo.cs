using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public abstract class AnimalDuZoo : IDeplacable, IParler, IComparable<AnimalDuZoo>
    {
        public DateTime dateDeNaissance;
        public bool estNeeAuZoo;

        protected AnimalDuZoo() : this(DateTime.Today, false)
        {
        }

        protected AnimalDuZoo(DateTime dateDeNaissance, bool estNeeAuZoo)
        {
            this.dateDeNaissance = dateDeNaissance;
            this.estNeeAuZoo = estNeeAuZoo;
        }


        public abstract bool SeDeplacer();

        public abstract bool PeutParler();



        public int CompareTo(AnimalDuZoo other)
        {
            if (this.dateDeNaissance > other.dateDeNaissance)
                return 1;
            return this.dateDeNaissance.CompareTo(other.dateDeNaissance);
        }
    }

}
