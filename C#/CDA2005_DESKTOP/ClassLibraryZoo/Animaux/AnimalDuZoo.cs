using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public abstract class AnimalDuZoo:IDeplacable, IParler, IComparable<DateTime>
    {
        private DateTime dateDeNaissance;
        bool estNeeAuZoo;

        protected AnimalDuZoo():this(DateTime.Today,false)
        {
        }

        protected AnimalDuZoo(DateTime dateDeNaissance, bool v)
        {
            this.dateDeNaissance = dateDeNaissance;
            //this.estNeeAuZoo = estNeeAuZoo;
        }


        public abstract bool SeDeplacer();

        public abstract bool PeutParler();

        

        public int CompareTo(DateTime other)
        {
            return this.dateDeNaissance.CompareTo(other);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
